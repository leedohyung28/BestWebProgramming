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
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        private static string connectionString = "server=webp.flykorea.kr;user=w2019136007;database=w2019136007DB;port=13306;password=w2019136007;";
        private MySqlConnection connection = new MySqlConnection(connectionString);

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand command = connection.CreateCommand();
            connection.Open();

            try
            {
                if (textBox2.Text.ToString() != textBox3.Text.ToString()) throw new Exception("비밀번호를 확인해주세요");

                string id = textBox1.Text.ToString();
                MySqlCommand checkIdCommand = new MySqlCommand("SELECT COUNT(*) FROM USER WHERE uid = @id", connection);
                checkIdCommand.Parameters.AddWithValue("@id", id);

                int idCount = Convert.ToInt32(checkIdCommand.ExecuteScalar());
                if (idCount > 0)
                {
                    throw new Exception("아이디가 이미 존재합니다.");
                }

                command.CommandText = "INSERT INTO USER (uid, upwd, uname, umajor, ugrade) VALUES (@id, @password, @name, @major, @grade)";
                command.Parameters.AddWithValue("@id", textBox1.Text.ToString());
                command.Parameters.AddWithValue("@password", textBox2.Text.ToString());
                command.Parameters.AddWithValue("@name", textBox4.Text.ToString());
                command.Parameters.AddWithValue("@major", textBox5.Text.ToString());
                command.Parameters.AddWithValue("@grade", textBox6.Text.ToString());
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
    }
}
