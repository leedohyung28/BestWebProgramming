using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace tedt
{
    public partial class loginForm : MetroFramework.Forms.MetroForm
    {
        private static string connectionString = "server=webp.flykorea.kr;user=bestwebp;database=bestwebpDB;port=13306;password=webp!@#012345;";
        private MySqlConnection connection = new MySqlConnection(connectionString);

        public loginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand command = connection.CreateCommand();
            connection.Open();

            try
            {
                string id = loginTextBox.Text.ToString();
                string pass = pwTextBox.Text.ToString();

                if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(pass))
                {
                    throw new Exception("값을 입력해주세요.");
                }

                command.CommandText = "SELECT uid, upwd, uname, umajor, ugrade FROM USER WHERE uid=@id AND upwd=@password";
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@password", pass);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string name = reader["uname"].ToString();

                    Form3 form3 = new Form3(id, name);
                    form3.ShowDialog();
                }
                else
                {
                    throw new Exception("아이디 또는 비밀번호가 틀렸습니다.");
                }

            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message, "오류"); 
            }
            finally { connection.Close(); }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            registerForm form2 = new registerForm();
            form2.ShowDialog();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
