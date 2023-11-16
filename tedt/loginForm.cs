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

        public bool test = false;
        TextBox[] txtList;
        const string IdPlaceholder = "아이디 입력";
        const string PwPlaceholder = "비밀번호 입력";

        public loginForm()
        {
            InitializeComponent();

            txtList = new TextBox[] { loginTextBox, pwTextBox };
            foreach (var txt in txtList)
            {
                txt.ForeColor = Color.DarkGray;
                if (txt == loginTextBox) txt.Text = IdPlaceholder;
                else if (txt == pwTextBox) txt.Text = PwPlaceholder;

                txt.GotFocus += RemovePlaceholder;
                txt.LostFocus += SetPlaceholder;
            }
            loginTextBox.KeyDown += loginButton_KeyDown;
            pwTextBox.KeyDown += loginButton_KeyDown;
        }

        private void loginButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // 엔터키를 입력받으면 실행
            {
                this.button1_Click(sender, e);
            }
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
                    string grade = reader["ugrade"].ToString();
                    string major = reader["umajor"].ToString();

                    this.Visible = false;
                    timeTable timeTable = new timeTable(id, name, grade, major);
                    timeTable.Owner = this;
                    timeTable.ShowDialog();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
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

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text == IdPlaceholder | txt.Text == PwPlaceholder)
            {
                txt.ForeColor = Color.Black;
                txt.Text = string.Empty;
                if (txt == pwTextBox) pwTextBox.PasswordChar = '●';
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)(sender);
            if (string.IsNullOrEmpty(txt.Text))
            {
                txt.ForeColor = Color.DarkGray;
                if (txt == loginTextBox) txt.Text = IdPlaceholder;
                else if (txt == pwTextBox)
                {
                    txt.Text = PwPlaceholder;
                    pwTextBox.PasswordChar = default;
                }
            }
        }
    }
}
