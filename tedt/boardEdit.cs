using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MetroFramework.Drawing.MetroPaint.ForeColor;

namespace tedt
{
    public partial class boardEdit : MetroFramework.Forms.MetroForm
    {
        private string Userid;
        private string gContent;
        private string gTitle;
        private string connectionString;
        public boardEdit(string userid, string title, string content, string connectStr)
        {
            InitializeComponent();
            this.Visible = false;
            Userid = userid;
            gContent = content;
            gTitle = title;
            connectionString = connectStr;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            InputTextBox.Text = gContent;
            htmlLabel1.AutoScroll = false;
        }

        private void SummitButton_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            string newContent = InputTextBox.Text;
            try
            {
                conn.Open();
                string sql = "UPDATE `GENERALFORUM` SET g_content = @newContent, g_date = NOW() WHERE g_user = @user AND g_title = @title";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user", Userid);
                cmd.Parameters.AddWithValue("@title", gTitle);
                cmd.Parameters.AddWithValue("@newContent", newContent);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
            finally
            {
                conn.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

    }
}
