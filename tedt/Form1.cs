﻿using System;
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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private static string connectionString = "server=webp.flykorea.kr;user=w2019136007;database=w2019136007DB;port=13306;password=w2019136007;";
        private MySqlConnection connection = new MySqlConnection(connectionString);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand command = connection.CreateCommand();
            connection.Open();

            try
            {
                string id = textBox1.Text.ToString();
                string pass = textBox2.Text.ToString();

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
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
