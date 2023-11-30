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
using System.Reflection;
using System.Xml.Linq;
using Google.Protobuf.WellKnownTypes;


namespace tedt
{
    public partial class gCal : MetroFramework.Forms.MetroForm
    {
        private static string connectionString = "server=webp.flykorea.kr;user=bestwebp;database=bestwebpDB;port=13306;password=webp!@#012345;";
        private MySqlConnection connection = new MySqlConnection(connectionString);
        private ComboBox comboBoxMajorRequired;
        private Dictionary<string, int> originalProgressValues = new Dictionary<string, int>();
        private User user = new User();

        Dictionary<string, int> studentNum;

        private void FetchAndStoreStudentData(string studentNumber, string major)
        {
            try
            {
                connection.Open();

                // 특정 학번과 전공에 대한 과목과 점수를 가져오는 SQL 쿼리
                string sql = "SELECT sub, point, major FROM GR WHERE stNum = @stNum AND major = @major";
                MySqlCommand cmd = new MySqlCommand(sql, connection);

                // SQL 인젝션 방지를 위해 파라미터 사용
                cmd.Parameters.AddWithValue("@stNum", studentNumber);
                cmd.Parameters.AddWithValue("@major", major);
                
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    // 딕셔너리 초기화
                    studentNum = new Dictionary<string, int>();

                    while (reader.Read())
                    {
                        string subject = reader.GetString("sub");
                        int points = reader.GetInt32("point");
                        //Debug.WriteLine($"쿼리 결과: {subject}");
                        // 과목과 점수를 딕셔너리에 저장
                        studentNum[subject] = points;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "오류 발생");
            }
            finally
            {
                connection.Close();
            }
        }

        public gCal(string id, string name, string grade, string major)
        {
            InitializeComponent();
            user.Id = id;
            user.Name = name;
            user.StudentID = ConvertToYear(id);
            user.Major = major;

            User_ID.Text = user.Id; //레이블 -> 사용자 계정
            StudentIDLabel.Text = user.StudentID;
            label3.Text = $"학번            {user.Major} 졸업 요건";

            FetchAndStoreStudentData(user.StudentID, user.Major);
            CreateProgressBars(id, user.StudentID, user.Major);
            SetDefaultComboBoxValue();
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

        private void SetDefaultComboBoxValue()
        {
            // Check if the comboBox has items to prevent exceptions
            if (comboBoxMajorRequired.Items.Count > 0)
            {
                // Set the first item as default
                comboBoxMajorRequired.SelectedIndex = 0;
            }
        }
        private void CreateProgressBars(string id, string studentID, string major)
        {
            Dictionary<string, int> selectedYear;
            selectedYear = studentNum;
            /*
            if (studentID == "18") selectedYear = student18;
            else if (studentID == "19") selectedYear = student19;
            else if(studentID == "20") selectedYear = student20;
            else if (studentID == "21") selectedYear = student21;
            else if (studentID == "22") selectedYear = student22;
            else if (studentID == "23") selectedYear = student23;
            else selectedYear = student23; //기본 값으로 23학번
            */
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

            int yPoint = 150; // 시작 y 위치
            try
            {
                connection.Open();
                foreach (var item in selectedYear)
                {
                    /*
                        ToDo 리스트

                     */
                    string sql = "SELECT SUM(point) AS TotalPoints FROM APPLICATION WHERE id = @id AND course = @course AND major = @major";
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@id", id); // id 파라미터 값을 설정합니다.
                    cmd.Parameters.AddWithValue("@course", item.Key); // course 파라미터 값을 설정합니다.
                    cmd.Parameters.AddWithValue("@major", major); // course 파라미터 값을 설정합니다.
                    object result = cmd.ExecuteScalar();
                    int totalPoint = 0;
                    if (result != null && result != DBNull.Value)
                    {
                        totalPoint = Convert.ToInt32(result);
                    }
                    //Debug.WriteLine($"Query Result: {item.Key}");
                    originalProgressValues[item.Key+"L"] = totalPoint;
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
                        Name = "progressBar" + item.Key,
                        Width = 750,
                        Height = 25,
                        Value = totalPoint, // 이 부분을 실제 진행 상태 값으로 업데이트해야 함
                        Maximum = item.Value, // 최대 값 설정
                        Location = new Point(160, yPoint) // 위치 설정
                    };
                    Controls.Add(progressBar);

                    progressBar = Controls.Find("progressBar" + item.Key, true).FirstOrDefault() as ProgressBar;
                    if (progressBar != null)
                    {
                        originalProgressValues[item.Key] = progressBar.Value;
                    }
                    
                    // 프로그레스바 옆에 현재 값을 표시하는 라벨 생성 및 설정
                    Label valueLabel = new Label
                    {
                        Name = "label" + item.Key,
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

                yPoint += 15;
                Label ippLabel = new Label
                {
                    Text = "IPP",
                    Location = new Point(100, yPoint),
                    Width = 50,
                    TextAlign = ContentAlignment.MiddleLeft
                };
                Controls.Add(ippLabel);

                comboBoxMajorRequired = new ComboBox
                {
                    Location = new Point(160, yPoint),
                    Width = 100,
                    DropDownStyle = ComboBoxStyle.DropDownList,
                    Name = "comboBoxMajorRequired"
                };

                // Add items to the ComboBox
                comboBoxMajorRequired.Items.Add("미정");
                comboBoxMajorRequired.Items.Add("4주");
                comboBoxMajorRequired.Items.Add("8주");
                comboBoxMajorRequired.Items.Add("4개월");
                comboBoxMajorRequired.Items.Add("6개월");
                comboBoxMajorRequired.SelectedIndexChanged += new EventHandler(ComboBoxMajorRequired_SelectedIndexChanged);
                this.Controls.Add(comboBoxMajorRequired);
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

        // ComboBoxMajorRequired_SelectedIndexChanged 메서드 수정
        private void ComboBoxMajorRequired_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            string currentSelection = comboBox.SelectedItem.ToString();

            // 원래 값에 기반하여 새 값을 계산
            if (currentSelection == "4주")
            {
                ResetProgressBarsToOriginal();
                UpdateProgressBar("전공필수", 2);
            }
            else if(currentSelection == "8주")
            {
                ResetProgressBarsToOriginal();
                UpdateProgressBar("전공필수", 2);
                UpdateProgressBar("전공선택", 1);
            }
            else if (currentSelection == "4개월")
            {
                ResetProgressBarsToOriginal();
                UpdateProgressBar("전공필수", 2);
                UpdateProgressBar("전공선택", 2);
                UpdateProgressBar("HRD선택", 2);
            }
            else if(currentSelection == "6개월")
            {
                ResetProgressBarsToOriginal();
                UpdateProgressBar("전공필수", 2);
                UpdateProgressBar("전공선택", 3);
                UpdateProgressBar("HRD선택", 4);
            }
            else if(currentSelection == "미정")
            {
                ResetProgressBarsToOriginal();
            }
        }
        private void ResetProgressBarsToOriginal()
        {
            foreach (var kvp in originalProgressValues)
            {
                string key = kvp.Key;
                int originalValue = kvp.Value;

                ProgressBar progressBar = Controls.Find("progressBar" + key, true).FirstOrDefault() as ProgressBar;
                Label label = Controls.Find("label" + key, true).FirstOrDefault() as Label;

                if (progressBar != null && label != null)
                {
                    progressBar.Value = originalValue;
                    int totalPoint = originalProgressValues[key + "L"];
                    label.Text = $"{totalPoint} / {progressBar.Maximum}";
                    UpdateLabelColor(label, totalPoint, progressBar.Maximum);
                }
            }
        }
        private void UpdateProgressBar(string key, int increment)
        {
            if (originalProgressValues.ContainsKey(key))
            {
                ProgressBar progressBar = Controls.Find("progressBar" + key, true).FirstOrDefault() as ProgressBar;
                Label label = Controls.Find("label" + key, true).FirstOrDefault() as Label;
                if (progressBar != null && label != null)
                {
                    int newValue = Math.Min(originalProgressValues[key] + increment, progressBar.Maximum);
                    progressBar.Value = newValue;
                    int totalPoint = originalProgressValues[key + "L"];
                    label.Text = $"{totalPoint+increment} / {progressBar.Maximum}";
                    UpdateLabelColor(label, totalPoint+increment, progressBar.Maximum);
                }
            }
        }
        private void UpdateLabelColor(Label label, int value, int maximum)
        {
            if (value > maximum)
                label.ForeColor = Color.Blue;
            else if (value == maximum)
                label.ForeColor = Color.Green;
            else
                label.ForeColor = Color.Red;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            comboBoxMajorRequired.SelectedIndex = 0;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            metroContextMenu1.Show(menuButton, 0, menuButton.Height);
        }

        private void 시간표ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void 게시판ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            board form = new board(user.Id, user.Name, user.Grade, user.Major);
            form.Owner = this;
            form.ShowDialog();
            this.DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}
