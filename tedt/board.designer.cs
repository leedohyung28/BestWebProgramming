namespace tedt
{
    partial class board
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(board));
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.views = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.ModifyTextButton = new MetroFramework.Controls.MetroButton();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.MakeElementButton = new MetroFramework.Controls.MetroButton();
            this.SearchStringTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SearchElementButton = new MetroFramework.Controls.MetroButton();
            this.DeleteElementButton = new MetroFramework.Controls.MetroButton();
            this.menuButton = new MetroFramework.Controls.MetroButton();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.시간표ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.학점계산기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.로그아웃ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.likeButton = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.metroContextMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.likeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userid,
            this.title,
            this.date,
            this.views});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(37, 144);
            this.metroGrid1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidth = 51;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 27;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(899, 590);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroGrid1.TabIndex = 0;
            // 
            // userid
            // 
            this.userid.DataPropertyName = "userid";
            this.userid.HeaderText = "userid";
            this.userid.MinimumWidth = 6;
            this.userid.Name = "userid";
            this.userid.ReadOnly = true;
            // 
            // title
            // 
            this.title.DataPropertyName = "title";
            this.title.HeaderText = "title";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // views
            // 
            this.views.DataPropertyName = "views";
            this.views.HeaderText = "views";
            this.views.MinimumWidth = 6;
            this.views.Name = "views";
            this.views.ReadOnly = true;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(-1330, 4);
            this.metroTextBox1.CustomButton.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(1328, 1430);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(995, 124);
            this.metroTextBox1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(2, 720);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTextBox1.TabIndex = 1;
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(90, 50);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.htmlLabel1.Font = new System.Drawing.Font("Gulim", 15F);
            this.htmlLabel1.Location = new System.Drawing.Point(1072, 144);
            this.htmlLabel1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(607, 68);
            this.htmlLabel1.TabIndex = 3;
            this.htmlLabel1.Text = "제목";
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(158, 34);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.htmlLabel2.Location = new System.Drawing.Point(1072, 222);
            this.htmlLabel2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(607, 58);
            this.htmlLabel2.TabIndex = 4;
            this.htmlLabel2.Text = "글쓴이 | 시간";
            // 
            // ModifyTextButton
            // 
            this.ModifyTextButton.Location = new System.Drawing.Point(1072, 762);
            this.ModifyTextButton.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.ModifyTextButton.Name = "ModifyTextButton";
            this.ModifyTextButton.Size = new System.Drawing.Size(162, 36);
            this.ModifyTextButton.TabIndex = 5;
            this.ModifyTextButton.Text = "글 수정";
            this.ModifyTextButton.UseSelectable = true;
            this.ModifyTextButton.Visible = false;
            this.ModifyTextButton.Click += new System.EventHandler(this.ModifyTextButton_Click);
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(306, 4);
            this.metroTextBox2.CustomButton.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(815, 878);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Enabled = false;
            this.metroTextBox2.Lines = new string[] {
        "글 내용"};
            this.metroTextBox2.Location = new System.Drawing.Point(1072, 292);
            this.metroTextBox2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(607, 444);
            this.metroTextBox2.TabIndex = 6;
            this.metroTextBox2.Text = "글 내용";
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MakeElementButton
            // 
            this.MakeElementButton.Location = new System.Drawing.Point(37, 762);
            this.MakeElementButton.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MakeElementButton.Name = "MakeElementButton";
            this.MakeElementButton.Size = new System.Drawing.Size(111, 36);
            this.MakeElementButton.TabIndex = 7;
            this.MakeElementButton.Text = "글 쓰기";
            this.MakeElementButton.UseSelectable = true;
            this.MakeElementButton.Click += new System.EventHandler(this.MakeElementButton_Click);
            // 
            // SearchStringTextBox
            // 
            // 
            // 
            // 
            this.SearchStringTextBox.CustomButton.Image = null;
            this.SearchStringTextBox.CustomButton.Location = new System.Drawing.Point(407, 4);
            this.SearchStringTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.SearchStringTextBox.CustomButton.Name = "";
            this.SearchStringTextBox.CustomButton.Size = new System.Drawing.Size(58, 62);
            this.SearchStringTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SearchStringTextBox.CustomButton.TabIndex = 1;
            this.SearchStringTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SearchStringTextBox.CustomButton.UseSelectable = true;
            this.SearchStringTextBox.CustomButton.Visible = false;
            this.SearchStringTextBox.Lines = new string[0];
            this.SearchStringTextBox.Location = new System.Drawing.Point(566, 762);
            this.SearchStringTextBox.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.SearchStringTextBox.MaxLength = 32767;
            this.SearchStringTextBox.Name = "SearchStringTextBox";
            this.SearchStringTextBox.PasswordChar = '\0';
            this.SearchStringTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchStringTextBox.SelectedText = "";
            this.SearchStringTextBox.SelectionLength = 0;
            this.SearchStringTextBox.SelectionStart = 0;
            this.SearchStringTextBox.ShortcutsEnabled = true;
            this.SearchStringTextBox.Size = new System.Drawing.Size(253, 36);
            this.SearchStringTextBox.TabIndex = 8;
            this.SearchStringTextBox.UseSelectable = true;
            this.SearchStringTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchStringTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SearchElementButton
            // 
            this.SearchElementButton.Location = new System.Drawing.Point(830, 762);
            this.SearchElementButton.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.SearchElementButton.Name = "SearchElementButton";
            this.SearchElementButton.Size = new System.Drawing.Size(106, 36);
            this.SearchElementButton.TabIndex = 9;
            this.SearchElementButton.Text = "찾기";
            this.SearchElementButton.UseSelectable = true;
            this.SearchElementButton.Click += new System.EventHandler(this.SearchElementButton_Click);
            // 
            // DeleteElementButton
            // 
            this.DeleteElementButton.Location = new System.Drawing.Point(1241, 762);
            this.DeleteElementButton.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.DeleteElementButton.Name = "DeleteElementButton";
            this.DeleteElementButton.Size = new System.Drawing.Size(162, 36);
            this.DeleteElementButton.TabIndex = 10;
            this.DeleteElementButton.Text = "글 삭제";
            this.DeleteElementButton.UseSelectable = true;
            this.DeleteElementButton.Visible = false;
            this.DeleteElementButton.Click += new System.EventHandler(this.DeleteElementButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(449, 29);
            this.menuButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(262, 38);
            this.menuButton.TabIndex = 11;
            this.menuButton.Text = "메뉴";
            this.menuButton.UseSelectable = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.시간표ToolStripMenuItem,
            this.toolStripSeparator1,
            this.학점계산기ToolStripMenuItem,
            this.toolStripSeparator2,
            this.로그아웃ToolStripMenuItem,
            this.toolStripSeparator3,
            this.종료ToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(209, 174);
            // 
            // 시간표ToolStripMenuItem
            // 
            this.시간표ToolStripMenuItem.Name = "시간표ToolStripMenuItem";
            this.시간표ToolStripMenuItem.Size = new System.Drawing.Size(208, 38);
            this.시간표ToolStripMenuItem.Text = "시간표";
            this.시간표ToolStripMenuItem.Click += new System.EventHandler(this.시간표ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(205, 6);
            // 
            // 학점계산기ToolStripMenuItem
            // 
            this.학점계산기ToolStripMenuItem.Name = "학점계산기ToolStripMenuItem";
            this.학점계산기ToolStripMenuItem.Size = new System.Drawing.Size(208, 38);
            this.학점계산기ToolStripMenuItem.Text = "학점계산기";
            this.학점계산기ToolStripMenuItem.Click += new System.EventHandler(this.학점계산기ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(205, 6);
            // 
            // 로그아웃ToolStripMenuItem
            // 
            this.로그아웃ToolStripMenuItem.Name = "로그아웃ToolStripMenuItem";
            this.로그아웃ToolStripMenuItem.Size = new System.Drawing.Size(208, 38);
            this.로그아웃ToolStripMenuItem.Text = "로그아웃";
            this.로그아웃ToolStripMenuItem.Click += new System.EventHandler(this.로그아웃ToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(205, 6);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(208, 38);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // likeButton
            // 
            this.likeButton.Image = ((System.Drawing.Image)(resources.GetObject("likeButton.Image")));
            this.likeButton.Location = new System.Drawing.Point(1632, 762);
            this.likeButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.likeButton.Name = "likeButton";
            this.likeButton.Size = new System.Drawing.Size(46, 52);
            this.likeButton.TabIndex = 12;
            this.likeButton.TabStop = false;
            this.likeButton.Click += new System.EventHandler(this.likeButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(36, 29);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(385, 59);
            this.pictureBox.TabIndex = 13;
            this.pictureBox.TabStop = false;
            // 
            // board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1766, 882);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.likeButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.DeleteElementButton);
            this.Controls.Add(this.SearchElementButton);
            this.Controls.Add(this.SearchStringTextBox);
            this.Controls.Add(this.MakeElementButton);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.ModifyTextButton);
            this.Controls.Add(this.htmlLabel2);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroGrid1);
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "board";
            this.Padding = new System.Windows.Forms.Padding(33, 120, 33, 32);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.metroContextMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.likeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn views;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private MetroFramework.Controls.MetroButton ModifyTextButton;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroButton MakeElementButton;
        private MetroFramework.Controls.MetroTextBox SearchStringTextBox;
        private MetroFramework.Controls.MetroButton SearchElementButton;
        private MetroFramework.Controls.MetroButton DeleteElementButton;
        private MetroFramework.Controls.MetroButton menuButton;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem 시간표ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 학점계산기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 로그아웃ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.PictureBox likeButton;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

