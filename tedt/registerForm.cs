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

namespace tedt
{
    public partial class registerForm : MetroFramework.Forms.MetroForm
    {
        private static string connectionString = "server=webp.flykorea.kr;user=bestwebp;database=bestwebpDB;port=13306;password=webp!@#012345;";
        private MySqlConnection connection = new MySqlConnection(connectionString);

        public registerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand command = connection.CreateCommand();
            connection.Open();

            try
            {
                if (pwBox.Text.ToString() != pwConfirmBox.Text.ToString()) throw new Exception("비밀번호를 확인해주세요");

                command.CommandText = "INSERT INTO USER (uid, upwd, uname, umajor, ugrade) VALUES (@id, @password, @name, @major, @grade)";
                command.Parameters.AddWithValue("@id", idBox.Text.ToString());
                command.Parameters.AddWithValue("@password", pwBox.Text.ToString());
                command.Parameters.AddWithValue("@name", nameTextBox.Text.ToString());
                command.Parameters.AddWithValue("@major", majorComboBox.Text.ToString());
                command.Parameters.AddWithValue("@grade", studentNoTextBox.Text.Substring(0,4).ToString());
                command.ExecuteNonQuery();

                this.Close();

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "오류");
            }
            finally { 
                connection.Close();
            }
        }

        private void detailMajorComboBox_DropDown(object sender, EventArgs e)
        {
            string selectedValue = majorComboBox.Text.ToString();
            string inputText = studentNoTextBox.Text;
            string prefix = inputText.Length == 10 ? inputText.Substring(0, 4) : "";

            if (string.IsNullOrWhiteSpace(selectedValue))
            {
                MessageBox.Show("학부를 선택해주세요.", "오류");
                return;
            }

            int prefixYear;
            if (!int.TryParse(prefix, out prefixYear) || prefixYear < 2010 || prefixYear > 2023)
            {
                MessageBox.Show("올바른 학번을 입력해주세요.", "오류");
                return;
            }

            if (selectedValue == "기계공학부")
            {
                if (prefix == "2021" || prefix == "2022" || prefix == "2023")
                {
                    detailMajorComboBox.Items.Clear();
                    detailMajorComboBox.Items.Add("친환경자동차에너지트랙");
                    detailMajorComboBox.Items.Add("시스템설계제조트랙");
                    detailMajorComboBox.Items.Add("스마일모빌리티트랙");
                }
                else
                {
                    detailMajorComboBox.Items.Clear();
                    detailMajorComboBox.Items.Add("친환경자동차에너지전공");
                    detailMajorComboBox.Items.Add("시스템설계제조전공");
                    detailMajorComboBox.Items.Add("지능형시스템전공");
                }
            }
            else if (selectedValue == "메카트로닉스공학부")
            {
                detailMajorComboBox.Items.Clear();
                detailMajorComboBox.Items.Add("생산시스템전공");
                detailMajorComboBox.Items.Add("제어시스템전공");
                detailMajorComboBox.Items.Add("디지털시스템전공");
            }
            else if (selectedValue == "전기·전자·통신공학부")
            {
                detailMajorComboBox.Items.Clear();
                detailMajorComboBox.Items.Add("전기공학전공");
                detailMajorComboBox.Items.Add("전자공학전공");
                detailMajorComboBox.Items.Add("정보통신공학전공");
            }
            else if (selectedValue == "컴퓨터공학부")
            {
                if (prefix == "2021" || prefix == "2022" || prefix == "2023")
                {
                    detailMajorComboBox.Items.Clear();
                    detailMajorComboBox.Items.Add("스마트IoT트랙");
                    detailMajorComboBox.Items.Add("소프트웨어트랙");
                    detailMajorComboBox.Items.Add("AI트랙");
                }
                else
                {
                    detailMajorComboBox.Items.Clear();
                    detailMajorComboBox.Items.Add("컴퓨터H/W전공");
                    detailMajorComboBox.Items.Add("컴퓨터S/W전공");
                    detailMajorComboBox.Items.Add("스마트 IT전공");
                }
            }
            else if (selectedValue == "디자인·건축공학부")
            {
                detailMajorComboBox.Items.Clear();
                detailMajorComboBox.Items.Add("디자인공학전공");
                detailMajorComboBox.Items.Add("건축공학전공");
            }
            else if (selectedValue == "에너지·신소재·화학공학부")
            {
                detailMajorComboBox.Items.Clear();
                detailMajorComboBox.Items.Add("에너지신소재공학전공");
                detailMajorComboBox.Items.Add("응용화학공학전공");
            }
            else if (selectedValue == "산업경영학부")
            {
                if (prefix == "2021" || prefix == "2022" || prefix == "2023")
                {
                    detailMajorComboBox.Items.Clear();
                    detailMajorComboBox.Items.Add("융합경영전공");
                    detailMajorComboBox.Items.Add("데이터경영전공");
                }
                else
                {
                    detailMajorComboBox.Items.Clear();
                    detailMajorComboBox.Items.Add("산업경영전공");
                    detailMajorComboBox.Items.Add("혁신경영전공");
                }
            }
            else if (selectedValue == "고용서비스정책학과")
            {
                detailMajorComboBox.Items.Clear();
                detailMajorComboBox.Items.Add("고용서비스정책학과");
            }
        }

        private void idCheckButton_Click(object sender, EventArgs e)
        {
            try
            {
                string id = idBox.Text.ToString();
                MySqlCommand checkIdCommand = new MySqlCommand("SELECT COUNT(*) FROM USER WHERE uid = @id", connection);
                checkIdCommand.Parameters.AddWithValue("@id", id);

                connection.Open();

                int idCount = Convert.ToInt32(checkIdCommand.ExecuteScalar());
                if (idCount > 0)
                {
                    MessageBox.Show("아이디가 이미 존재합니다.", "경고");
                }
                else
                {
                    MessageBox.Show("아이디를 사용할 수 있습니다.", "알림");
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

        private void studentNoCheckButton_Click(object sender, EventArgs e)
        {
            try
            {
                string studentNo = studentNoTextBox.Text;
                int prefixYear;

                if (studentNo.Length != 10 || !int.TryParse(studentNo.Substring(0, 4), out prefixYear) || prefixYear < 2000 || prefixYear > 2024)
                {
                    MessageBox.Show("올바른 학번을 입력해주세요.", "경고");
                }
                else
                {
                    MessageBox.Show("학번이 유효합니다.", "알림");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "오류");
            }
        }
    }
}
