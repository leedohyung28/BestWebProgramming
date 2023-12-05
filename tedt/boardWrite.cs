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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tedt
{
    public partial class boardWrite : MetroFramework.Forms.MetroForm
    {
        private string Userid;
        private string connectionString;

        public boardWrite(string userid, string connectStr)
        {
            InitializeComponent();
            this.Visible = false;
            Userid = userid;
            connectionString = connectStr;
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void SummitButton_Click(object sender, EventArgs e)
        {
            string title = TitleTextBox.Text;
            string contents = ContentsTextBox.Text;
            if (String.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("제목을 설정하세요.");
                return;
            }
            if (String.IsNullOrWhiteSpace(contents))
            {
                MessageBox.Show("글 내용을 작성하세요.");
                return;
            }
            
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO GENERALFORUM (g_user, g_title, g_content) VALUES (@user, @title, @content)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@user", Userid);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@content", contents);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("오류 발생: " + ex.Message);
                }
                this.DialogResult = DialogResult.OK;
                this.Close(); // 폼 닫기
            }
        }
    }
}
