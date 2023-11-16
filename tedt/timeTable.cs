using MetroFramework.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tedt
{
    public partial class timeTable : MetroFramework.Forms.MetroForm
    {
        private static string connectionString = "server=webp.flykorea.kr;user=bestwebp;database=bestwebpDB;port=13306;password=webp!@#012345;";
        private MySqlConnection connection = new MySqlConnection(connectionString);

        private string selected = "23_2";
        public static int allgrades = 0;
        private static ChangeLabel changeLabel = new ChangeLabel();
        private UpdateGrid updateGrid = new UpdateGrid(changeLabel);
        private User user = new User();
        string[] items = { "23_2", "23_1", "22_2", "22_1", "21_2", "21_1" };

        public timeTable() { }

        public timeTable(string id, string name, string grade, string major)
        {
            InitializeComponent();
            user.Id = id;
            user.Name = name;
            user.Grade = grade;
            user.Major = major;
            updateGrid.dbname = "23_2";
            metroLabel1.Text = "현재사용자: " + user.Name + "(" + user.Major + ")";
            changeLabel.SetTableLayoutPanel(tableLayoutPanel1);
            updateGrid.SetTimeTable(this);
            updateGrid.user = user;
            updateGrid.UpdateDataGridView1();
            updateGrid.UpdateDataGridView2();
            updateGrid.LabelUpdate();
            setAllGrades();
            metroGrid1.DoubleClick += new EventHandler(dataGridView1_DoubleClick);
            metroGrid2.DoubleClick += new EventHandler(dataGridView2_DoubleClick);

            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.BackColor = Color.White;
            metroTextBox1.KeyDown += TexttextBox1_KeyDown;

            metroComboBox1.Items.AddRange(items);
            metroComboBox1.SelectedIndexChanged += new EventHandler(comboBox_SelectedIndexChanged);
        }

        public MySqlConnection GetMySqlConnection() { return this.connection; }
        public MetroGrid GetMetroGrid1() { return this.metroGrid1;}
        public MetroGrid GetMetroGrid2() { return this.metroGrid2; }
        public void setAllGrades() { metroTextBox2.Text = allgrades.ToString(); }

        private void TexttextBox1_KeyDown(object sender, KeyEventArgs e)   // 텍스트박스 이벤트
        {
            if (e.KeyCode == Keys.Enter) // 엔터키를 입력받으면 실행
            {
                this.metroButton1_Click(sender, e);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string subject = metroTextBox1.Text;

            if (subject == null) updateGrid.UpdateDataGridView1();

            updateGrid.ClearDataSource();
            try
            {
                connection.Open();

                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT 과목코드, 교과목명, 분반, 대표이수구분, 학점, 개설학부, 학년, 담당교수, 강의시간 FROM LECTURE" + selected + " WHERE 교과목명 LIKE @subject";
                command.Parameters.AddWithValue("@subject", subject + "%");

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    UpdateGrid.dataSource.Add(new Lecture()
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
                metroGrid1.DataSource = UpdateGrid.dataSource;
                metroGrid1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "오류");
            }
            finally
            {
                connection.Close();
                metroTextBox1.Text = null;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("정말 초기화하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "DELETE FROM APPLICATION WHERE id=@ID AND year=@year;";
                    command.Parameters.AddWithValue("@Id", user.Id);
                    command.Parameters.AddWithValue("@year", selected);
                    command.ExecuteNonQuery();

                    metroGrid2.Rows.Clear();
                    changeLabel.DeleteAllLabel();

                    allgrades = 0;
                    setAllGrades();
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            bool sta = true;

            if (metroGrid1.CurrentRow == null) return;

            var row = metroGrid1.CurrentRow;
            sta = checkDuplication(row.Cells["ClassTime"].Value.ToString());

            if (sta)
            {
                try
                {
                    //학부 예외처리
                    string depart = row.Cells["Department"].Value.ToString();
                    if (depart != user.Major && depart != "HRD학과" && depart != "교양학부" && depart != "융합학과")
                    {
                        throw new Exception("학부가 일치하지 않습니다.");
                    }

                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO APPLICATION (id, year, code, name, class, course, point, department, grade, professor, time) VALUES (@Id, @year, @Subject_Code, @Subject_Name, " +
                        "@Subject_Class, @Course, @point, @Department, @Grade, @Professor, @Subject_Time)";

                    command.Parameters.AddWithValue("@Id", user.Id);
                    command.Parameters.AddWithValue("@year", selected);
                    command.Parameters.AddWithValue("@Subject_Code", row.Cells["ClassCode"].Value.ToString());
                    command.Parameters.AddWithValue("@Subject_Name", row.Cells["ClassName"].Value.ToString());
                    command.Parameters.AddWithValue("@Subject_Class", row.Cells["ClassNumber"].Value.ToString());
                    command.Parameters.AddWithValue("@Course", row.Cells["Course"].Value.ToString());
                    command.Parameters.AddWithValue("@point", row.Cells["Grades"].Value.ToString());
                    command.Parameters.AddWithValue("@Department", row.Cells["Department"].Value.ToString());
                    command.Parameters.AddWithValue("@Grade", row.Cells["Grade"].Value.ToString());
                    command.Parameters.AddWithValue("@Professor", row.Cells["Professor"].Value.ToString());
                    command.Parameters.AddWithValue("@Subject_Time", row.Cells["ClassTime"].Value.ToString());
                    command.ExecuteNonQuery();

                    connection.Close();

                    updateGrid.UpdateDataGridView2();
                    changeLabel.PlusLabel(row.Cells["ClassTime"].Value.ToString(), row.Cells["ClassName"].Value.ToString(),
                        row.Cells["ClassNumber"].Value.ToString(), row.Cells["Professor"].Value.ToString());

                    setAllGrades();
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

        //넣은 과목 삭제
        public void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            if (metroGrid2.CurrentRow == null)
                return;

            var row = metroGrid2.CurrentRow;

            var subjectName = row.Cells["ClassName"].Value.ToString();
            var cls = row.Cells["ClassNumber"].Value.ToString();
            var grd = row.Cells["Grades"].Value.ToString();

            var confirmResult = MessageBox.Show("해당 과목을 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "DELETE FROM APPLICATION WHERE name=@name AND id=@ID AND class=@class";
                    command.Parameters.AddWithValue("@name", subjectName);
                    command.Parameters.AddWithValue("@Id", user.Id);
                    command.Parameters.AddWithValue("@class", cls);
                    command.ExecuteNonQuery();

                    metroGrid2.Rows.Remove(row);
                    changeLabel.DeleteLabel(subjectName, cls);

                    allgrades -= int.Parse(grd);
                    setAllGrades();
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

        private bool checkDuplication(string time)
        {
            List<int> checkvalue = changeLabel.TimeStringSplit(time);
            List<int> checklist = new List<int>();
            
            bool sta = true;

            try
            {
                connection.Open();

                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT name, time FROM APPLICATION WHERE id=@Id AND year=@year";
                command.Parameters.AddWithValue("@Id", user.Id);
                command.Parameters.AddWithValue("@year", selected);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    checklist = changeLabel.TimeStringSplit(reader["time"].ToString());

                    for (int k = 0; k < (checklist.Count) / 3; k++)
                    {
                        for (int i = 0; i < (checkvalue.Count) / 3; i++)
                        {
                            if (checklist[k * 3] == checkvalue[i * 3])
                            {
                                if ((checklist[k * 3 + 1] <= checkvalue[i * 3 + 1] && checklist[k * 3 + 2] >= checkvalue[i * 3 + 1])
                                    || (checklist[k * 3 + 1] <= checkvalue[i * 3 + 2] && checklist[k * 3 + 2] >= checkvalue[i * 3 + 2])
                                    || (checklist[k * 3 + 1] >= checkvalue[i*3+1] && checklist[k*3 +2] <= checkvalue[i*3+2]))
                                {
                                    sta = false;
                                    throw new Exception(reader["name"].ToString() +" 과목과 시간이 중복됩니다!");
                                }
                            }
                        }
                    }
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
            return sta;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = metroComboBox1.SelectedItem.ToString();
            updateGrid.dbname = selected;

            changeLabel.DeleteAllLabel();
            updateGrid.UpdateDataGridView1();
            updateGrid.UpdateDataGridView2();
            updateGrid.LabelUpdate();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            metroContextMenu1.Show(menuButton, 0, menuButton.Height);
        }

        private void 학점계산기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 form = new Form3(user.Id, user.Name, user.Grade, user.Major);
            form.Owner = this;
            form.ShowDialog();
            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void 로그아웃ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            loginForm form = new loginForm();
            form.Owner = this;
            form.ShowDialog();
            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
