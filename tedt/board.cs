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
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static MetroFramework.Drawing.MetroPaint.ForeColor;

namespace tedt
{
    public partial class board : MetroFramework.Forms.MetroForm
    {
        private string connectionString = "server=webp.flykorea.kr;user=bestwebp;database=bestwebpDB;port=13306;password=webp!@#012345;";
        // 사용자 학번(id), 생성자 통해 초기화 가능하고, 테스트를 위해 초기값(aaa)를 임의롤 지정함.
        private string Userid = "aaa";
        private string UN;
        private string UG;
        private string UM;

        public board()
        {
            InitializeComponent();
            metroGrid1.CellDoubleClick += new DataGridViewCellEventHandler(this.metroGrid1_CellDoubleClick);
            // 폼의 생성자 또는 초기화 메서드에서
            SearchStringTextBox.KeyDown += new KeyEventHandler(SearchStringTextBox_KeyDown);
        }

        private Image ResizeImage(Image originalImage, Size newSize)
        {
            Bitmap result = new Bitmap(newSize.Width, newSize.Height);

            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(originalImage, 0, 0, newSize.Width, newSize.Height);
            }

            return result;
        }

        public board(string userid, string username, string usergrade, string usermajor)
        {
            InitializeComponent();
            metroGrid1.CellDoubleClick += new DataGridViewCellEventHandler(this.metroGrid1_CellDoubleClick);
            // 폼의 생성자 또는 초기화 메서드에서
            SearchStringTextBox.KeyDown += new KeyEventHandler(SearchStringTextBox_KeyDown);
            Userid = userid;
            UN = username;
            UG = usergrade;
            UM = usermajor;
        }

        // 검색 TextBox에서 엔터 누르면 찾기 버튼 동작하는 함수
        private void SearchStringTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchElementButton_Click(this, new EventArgs());
            }
        }


        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = metroGrid1.Rows[e.RowIndex];
                string gUser = row.Cells["userid"].Value.ToString();
                string gTitle = row.Cells["title"].Value.ToString();
                string gDate = row.Cells["date"].Value.ToString();

                string gContent = GetContentFromDatabase(gUser, gTitle, gDate);
                metroTextBox2.Text = gContent; // 또는 적절한 방법으로 htmlPanel1에 표시
                htmlLabel1.Text = "<b>" + gTitle;
                htmlLabel2.Text = "<b> 사용자 : " + gUser + " | " + gDate;
                if (gUser.Equals(Userid))
                {
                    ModifyTextButton.Visible = true;
                    DeleteElementButton.Visible = true;
                }
                else
                {
                    ModifyTextButton.Visible = false;
                    DeleteElementButton.Visible = false;
                }
                UpdateViews(gUser, gTitle, e.RowIndex);
            }
        }

        private void UpdateViews(string gUser, string gTitle, int rowIndex)
        {
            // DataGridView에서 현재 views 값 읽기
            int currentViews = Convert.ToInt32(metroGrid1.Rows[rowIndex].Cells["views"].Value);
            int currentLikes = Convert.ToInt32(metroGrid1.Rows[rowIndex].Cells["likes"].Value); // 추가: 현재 좋아요 수

            // views 값을 1 증가시키기
            int newViews = currentViews + 1;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "UPDATE `GENERALFORUM` SET g_views = g_views + 1, g_likes = @newLikes WHERE g_user = @userId AND g_title = @title";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@userId", gUser);
                    cmd.Parameters.AddWithValue("@title", gTitle);
                    cmd.Parameters.AddWithValue("@newLikes", currentLikes); // 추가: 현재 좋아요 수 그대로 유지
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("오류 발생: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

            // DataGridView에 업데이트된 views 값 반영
            metroGrid1.Rows[rowIndex].Cells["views"].Value = newViews;
        }


        private string GetContentFromDatabase(string user, string title, string date)
        {
            string content = "";
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                string sql = "SELECT g_content FROM `GENERALFORUM` WHERE g_user = @user AND g_title = @title AND g_date = @date";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@date", date);

                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                    if (rdr.Read())
                    {
                        content = rdr["g_content"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return content;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            getDB();
            string imgFileName = "likeheart.png";
            string imgPath = System.IO.Path.Combine(Application.StartupPath, imgFileName);

            Image originalImage = Image.FromFile(imgPath);
            likeButton.Image = ResizeImage(originalImage, likeButton.Size);

            string iFN = "nameLogo.png";
            string iP = System.IO.Path.Combine(Application.StartupPath, iFN);

            Image oI = Image.FromFile(iP);
            likeButton.Image = ResizeImage(oI, likeButton.Size);

        }

        public void getDB()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string sql = "SELECT g_user, g_title, g_date, g_views, g_likes FROM `GENERALFORUM`";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                    Console.WriteLine(rdr.ToString());
                    // DataTable의 컬럼 구조를 설정합니다.
                    dt.Columns.Add("userid", typeof(string));
                    dt.Columns.Add("title", typeof(string));
                    dt.Columns.Add("date", typeof(string)); // 적절한 데이터 타입으로 변경 가능
                    dt.Columns.Add("views", typeof(int)); // 적절한 데이터 타입으로 변경 가능
                    dt.Columns.Add("likes", typeof(int)); // 추가: 좋아요 카운트

                    while (rdr.Read())
                    {
                        // DataTable에 새 행을 추가합니다.
                        dt.Rows.Add(rdr["g_user"], rdr["g_title"], rdr["g_date"], rdr["g_views"], rdr["g_likes"]);
                    }
                }
                metroGrid1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }



        private void SearchElementButton_Click(object sender, EventArgs e)
        {
            string TextboxData = SearchStringTextBox.Text;
            MySqlConnection conn = new MySqlConnection(connectionString);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string sql = "SELECT g_user, g_title, g_date, g_views FROM GENERALFORUM WHERE g_title LIKE @searchString"; // 검색 쿼리
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@searchString", "%" + TextboxData + "%"); // 검색어 바인딩

                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                    Console.WriteLine(rdr.ToString());
                    // DataTable의 컬럼 구조를 설정합니다.
                    dt.Columns.Add("userid", typeof(string));
                    dt.Columns.Add("title", typeof(string));
                    dt.Columns.Add("date", typeof(string)); // 적절한 데이터 타입으로 변경 가능
                    dt.Columns.Add("views", typeof(int)); // 적절한 데이터 타입으로 변경 가능

                    while (rdr.Read())
                    {
                        // DataTable에 새 행을 추가합니다.
                        dt.Rows.Add(rdr["g_user"], rdr["g_title"], rdr["g_date"], rdr["g_views"]);
                    }
                }

                metroGrid1.DataSource = dt; // 결과를 MetroGrid에 바인딩

            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void MakeElementButton_Click(object sender, EventArgs e)
        {
            using (boardWrite newElementForm = new boardWrite(Userid, connectionString))
            {
                DialogResult result = newElementForm.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    getDB();
                }
            }
        }

        private void ModifyTextButton_Click(object sender, EventArgs e)
        {
            if (metroGrid1.CurrentRow != null)
            {
                DataGridViewRow row = metroGrid1.CurrentRow;
                string gUser = row.Cells["userid"].Value.ToString();
                string gTitle = row.Cells["title"].Value.ToString();
                string gDate = row.Cells["date"].Value.ToString();
                string gContent = GetContentFromDatabase(gUser, gTitle, gDate);

                using (boardEdit modifyForm = new boardEdit(Userid, gTitle, gContent, connectionString))
                {
                    modifyForm.FormClosed += (s, args) =>
                    {
                        getDB();
                        ModifyTextButton.Visible = false;
                        DeleteElementButton.Visible = false;

                        gContent = GetContentFromDatabase(gUser, gTitle, gDate);
                        metroTextBox2.Text = gContent;
                        htmlLabel1.Text = "<b>" + gTitle;
                        htmlLabel2.Text = "<b> 사용자 : " + gUser + " | " + gDate;
                    };

                    DialogResult result = modifyForm.ShowDialog(this);

                    if (result == DialogResult.OK)
                    {
                        getDB();
                        gContent = GetContentFromDatabase(gUser, gTitle, gDate);
                        metroTextBox2.Text = gContent;
                        htmlLabel1.Text = "<b>" + gTitle;
                        htmlLabel2.Text = "<b> 사용자 : " + gUser + " | " + gDate;
                    }
                }
            }
        }


        private void DeleteElementButton_Click(object sender, EventArgs e)
        {
            if (metroGrid1.CurrentRow != null)
            {
                DataGridViewRow row = metroGrid1.CurrentRow;
                MySqlConnection conn = new MySqlConnection(connectionString);
                try
                {
                    conn.Open();

                    string sql = "SELECT g_num FROM GENERALFORUM WHERE g_title = @title AND g_user = @user";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@title", row.Cells["title"].Value.ToString());
                    cmd.Parameters.AddWithValue("@user", row.Cells["userid"].Value.ToString());

                    int postId = Convert.ToInt32(cmd.ExecuteScalar());

                    string sql2 = "DELETE FROM `GENERALFORUM` WHERE g_num = @postId; DELETE FROM UserLikes WHERE PostId = @postId";
                    MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                    cmd2.Parameters.AddWithValue("@postId", postId);

                    cmd2.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("오류 발생: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                    getDB(); // Refresh the grid data after deletion

                    metroTextBox2.Text = "";
                    htmlLabel1.Text = "";
                    htmlLabel2.Text = "";
                    ModifyTextButton.Visible = false;
                    DeleteElementButton.Visible = false;
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            metroContextMenu1.Show(menuButton, 0, menuButton.Height);
        }

        private void 시간표ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            timeTable form = new timeTable(Userid, UN, UG, UM);
            form.Owner = this;
            form.ShowDialog();
            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void 학점계산기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            gCal form = new gCal(Userid, UN, UG, UM);
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

        private void likeButton_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            DataGridViewRow row = metroGrid1.CurrentRow;
            try
            {
                conn.Open();
                string sql = "SELECT g_num FROM GENERALFORUM WHERE g_title = @title AND g_user = @user";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@title", row.Cells["title"].Value.ToString());
                cmd.Parameters.AddWithValue("@user", row.Cells["userid"].Value.ToString());

                int postId = Convert.ToInt32(cmd.ExecuteScalar());


                string exsql = "SELECT COUNT(*) FROM UserLikes WHERE UserId = @userId AND PostId = @postId";
                MySqlCommand excmd = new MySqlCommand(exsql, conn);
                excmd.Parameters.AddWithValue("@postId", postId);
                excmd.Parameters.AddWithValue("@userId", row.Cells["userid"].Value.ToString());

                int cnt = Convert.ToInt32(excmd.ExecuteScalar());
                if (cnt != 0) throw new Exception("이미 좋아요한 게시글입니다.");

                string sql2 = "INSERT INTO UserLikes (UserId, PostId) VALUES (@userId, @postId); UPDATE GENERALFORUM SET g_likes = g_likes + 1 WHERE g_num = @postId;";
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                cmd2.Parameters.AddWithValue("@userId", row.Cells["userid"].Value.ToString());
                cmd2.Parameters.AddWithValue("@postId", postId);
                cmd2.ExecuteNonQuery();

                
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "오류");
            }
            finally { 
                conn.Close();
                getDB();
            }

        }
    }
}