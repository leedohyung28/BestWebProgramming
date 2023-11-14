using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace tedt
{
    internal class UpdateGrid
    {
        private timeTable tt;
        private MySqlConnection connection;
        private ChangeLabel clabel;

        public static BindingList<Lecture> dataSource = new BindingList<Lecture>();
        public static BindingList<Lecture> dataSource2 = new BindingList<Lecture>();
        public static BindingList<Lecture> timeDataSource = new BindingList<Lecture>();

        public User user = new User();

        public UpdateGrid(ChangeLabel clabel)
        {
            this.clabel = clabel;
        }

        public void SetTimeTable(timeTable tt)
        {
            this.tt = tt;
            connection = tt.GetMySqlConnection();
        }

        //위의 그리드
        //이전 데이터 소스를 클리어함으로써 가비지 컬렉터가 메모리를 회수
        public void ClearDataSource()
        {
            tt.GetMetroGrid1().DataSource = null;
            dataSource = new BindingList<Lecture>();
        }

        //아래 그리드 메모리 회수
        public void ClearDataSource2()
        {
            tt.GetMetroGrid2().DataSource = null;
            dataSource2 = new BindingList<Lecture>();
        }

        //위 그리드 업데이트
        public void UpdateDataGridView1()
        {
            ClearDataSource();

            try
            {
                connection.Open();

                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT 과목코드, 교과목명, 분반, 대표이수구분, 학점, 개설학부, 학년, 담당교수, 강의시간 FROM LECTURE";

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    dataSource.Add(new Lecture()
                    {
                        ClassCode = reader["과목코드"].ToString(),
                        ClassName = reader["교과목명"].ToString(),
                        ClassNumber = reader["분반"].ToString(),
                        Course = reader["대표이수구분"].ToString(),
                        Grades = reader["학점"].ToString(),
                        Department = reader["개설학부"].ToString(),
                        Grade = reader["학년"].ToString(),
                        Professor = reader["담당교수"].ToString(),
                        ClassTime = reader["강의시간"].ToString(),
                    });
                }

                tt.GetMetroGrid1().DataSource = dataSource;
                tt.GetMetroGrid1().Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "오류");
            }
            finally
            {
                connection.Close();
            }
        }

        //아래 그리드 업데이트
        public void UpdateDataGridView2()
        {
            ClearDataSource2();
            timeTable.allgrades = 0;
            try
            {
                connection.Open();

                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM APPLICATION WHERE id=@Id";
                command.Parameters.AddWithValue("@Id", user.Id);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    dataSource2.Add(new Lecture()
                    {
                        ClassCode = reader["code"].ToString(),
                        ClassName = reader["name"].ToString(),
                        ClassNumber = reader["class"].ToString(),
                        Course = reader["course"].ToString(),
                        Grades = reader["point"].ToString(),
                        Department = reader["department"].ToString(),
                        Grade = reader["grade"].ToString(),
                        Professor = reader["professor"].ToString(),
                        ClassTime = reader["time"].ToString(),
                    });
                    timeTable.allgrades += int.Parse(reader["point"].ToString());
                }

                tt.GetMetroGrid2().DataSource = dataSource2;
                tt.GetMetroGrid2().Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "오류");
            }
            finally
            {
                connection.Close();
            }
        }

        public void LabelUpdate()
        {
            try
            {
                connection.Open();

                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM APPLICATION WHERE id=@Id";
                command.Parameters.AddWithValue("@Id", user.Id);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    clabel.PlusLabel(reader["time"].ToString(), reader["name"].ToString(), reader["class"].ToString(), reader["professor"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "오류");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
