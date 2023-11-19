using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace tedt
{
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        private static string connectionString = "server=webp.flykorea.kr;user=bestwebp;database=bestwebpDB;port=13306;password=webp!@#012345;";
        private MySqlConnection connection = new MySqlConnection(connectionString);

        private User user = new User();
        Dictionary<string, int> student19 = new Dictionary<string, int>
        {   
            {"HRD필수", 6},
            {"HRD선택", 4},
            {"MSC", 30}, //MSC선수, MSC필수 통합
            {"교양", 29}, //교선, 교필 통합
            {"자유선택", 5}, //자선 변경
            {"전공선택", 29}, //전선, 학부선 통합
            {"전공필수", 47}, //전필, 학부필 통합
        };
        Dictionary<string, int> student23 = new Dictionary<string, int>
        {
            {"교양", 25 },
            {"MSC", 30 },
            {"전공필수", 49 },
            {"전공선택", 27 },
            {"HRD필수", 10 },
            {"HRD선택", 4 },
            {"자유선택", 5}
        };
        public Form3(string id, string name, string grade, string major)
        {
            InitializeComponent();
            CreateProgressBars(id);
            user.Id = id;
            user.Name = name;
            user.StudentID = ConvertToYear(id);
            user.Major = major;

            User_ID.Text = user.Id; //레이블 -> 사용자 계정
            StudentIDLabel.Text = user.StudentID;
        }


        public string ConvertToYear(string id)
        {
            string studentId = null;
            try
            {
                connection.Open();

                string sql = "SELECT ustudentNumber FROM USER WHERE uid = @id";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", id); // id 파라미터 값을 설정합니다.

                studentId = (string)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "오류");
            }
            finally
            {
                // 예외가 발생하든, 발생하지 않든 항상 연결을 닫습니다.
                connection.Close();
            }

            if (string.IsNullOrEmpty(studentId) || studentId.Length < 10) // 연도를 추출하기 위해선 최소 4자리가 필요합니다.
            {
                throw new ArgumentException("Invalid student ID.");
            }

            string yearString = studentId.Substring(2, 2);
            return yearString;
        }


        private void CreateProgressBars(string id)
        {
            try
            {
                connection.Open();
                string formatsql = "UPDATE APPLICATION SET course = CASE WHEN course = 'MSC선수' OR course = 'MSC필수' THEN 'MSC'  WHEN course = '교선' OR course = '교필' THEN '교양' WHEN course = '자선' THEN '자유선택' WHEN course = '전선' OR course = '학부선' THEN '전공선택' WHEN course = '전필' OR course = '학부필' THEN '전공필수' END WHERE course IN('MSC선수', 'MSC필수', '교선', '교필', '자선', '전선', '학부선', '전필', '학부필')";
                MySqlCommand cmd = new MySqlCommand(formatsql, connection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "오류");
            }
            finally
            {
                // 예외가 발생하든, 발생하지 않든 항상 연결을 닫습니다.
                connection.Close();
            }

            int yPoint = 180; // 시작 y 위치
            try
            {
                connection.Open();

                foreach (var item in student19)
                {
                    string sql = "SELECT SUM(point) AS TotalPoints FROM APPLICATION WHERE id = @id AND course = @course";
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@id", id); // id 파라미터 값을 설정합니다.
                    cmd.Parameters.AddWithValue("@course", item.Key); // course 파라미터 값을 설정합니다.
                    //Debug.WriteLine($"Query(item) Result: {item.Key}");
                    object result = cmd.ExecuteScalar();
                    int totalPoint = 0;
                    if (result != null && result != DBNull.Value)
                    {
                        totalPoint = Convert.ToInt32(result);
                    }
                    // 라벨 생성 및 설정
                    Label progressLabel = new Label
                    {
                        Text = item.Key, // 라벨 텍스트 설정
                        Location = new Point(30, yPoint), // 위치 설정
                        Width = 100, // 너비 설정
                        TextAlign = ContentAlignment.MiddleRight // 텍스트 오른쪽 정렬
                    };
                    Controls.Add(progressLabel);

                    // 프로그레스바 생성 및 설정
                    ProgressBar progressBar = new ProgressBar
                    {
                        Width = 750,
                        Height = 25,
                        Value = totalPoint, // 이 부분을 실제 진행 상태 값으로 업데이트해야 함
                        Maximum = item.Value, // 최대 값 설정
                        Location = new Point(160, yPoint) // 위치 설정
                    };
                    Controls.Add(progressBar);

                    // 프로그레스바 옆에 현재 값을 표시하는 라벨 생성 및 설정
                    Label valueLabel = new Label
                    {
                        Text = $"{totalPoint} / {progressBar.Maximum}", // 현재 값 / 최대 값
                        Location = new Point(progressBar.Right + 10, yPoint + 7), // 위치 설정
                        AutoSize = true // 크기 자동 조정
                    };
                    Controls.Add(valueLabel);
                    if (totalPoint > progressBar.Maximum)
                        valueLabel.ForeColor = Color.Blue;
                    else if (totalPoint == progressBar.Maximum)
                        valueLabel.ForeColor = Color.Green;
                    else
                        valueLabel.ForeColor = Color.Red;

                    // 다음 컨트롤의 y 위치 업데이트
                    yPoint += progressBar.Height + 10;
                    cmd.Parameters.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "오류");
            }
            finally
            {
                // 예외가 발생하든, 발생하지 않든 항상 연결을 닫습니다.
                connection.Close();
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            metroContextMenu1.Show(menuButton, 0, menuButton.Height);
        }

        private void 학점계산기ToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            this.Visible = false;
            timeTable form = new timeTable(user.Id, user.Name, user.Grade, user.Major);
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
