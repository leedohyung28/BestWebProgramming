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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.metroContextMenu1.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userid,
            this.title,
            this.date,
            this.views});

            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(23, 90);
            this.metroGrid1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidth = 51;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 27;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(553, 369);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroGrid1.TabIndex = 0;
            // userid
            this.userid.DataPropertyName = "userid";
            this.userid.HeaderText = "userid";
            this.userid.MinimumWidth = 6;
            this.userid.Name = "userid";
            this.userid.ReadOnly = true;
            // title

            this.title.DataPropertyName = "title";
            this.title.HeaderText = "title";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // date
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // views
            this.views.DataPropertyName = "views";
            this.views.HeaderText = "views";
            this.views.MinimumWidth = 6;
            this.views.Name = "views";
            this.views.ReadOnly = true;
            // metroTextBox1
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(-447, 2);
            this.metroTextBox1.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(445, 445);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(613, 78);
            this.metroTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(1, 450);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTextBox1.TabIndex = 1;
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // htmlLabel1

            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(61, 35);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.htmlLabel1.Font = new System.Drawing.Font("굴림", 15F);
            this.htmlLabel1.Location = new System.Drawing.Point(659, 90);
            this.htmlLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(374, 42);
            this.htmlLabel1.TabIndex = 3;
            this.htmlLabel1.Text = "제목";
            // htmlLabel2
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(106, 25);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.htmlLabel2.Location = new System.Drawing.Point(659, 139);
            this.htmlLabel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(374, 36);
            this.htmlLabel2.TabIndex = 4;
            this.htmlLabel2.Text = "글쓴이 | 시간";
            // ModifyTextButton

            this.ModifyTextButton.Location = new System.Drawing.Point(659, 476);
            this.ModifyTextButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModifyTextButton.Name = "ModifyTextButton";
            this.ModifyTextButton.Size = new System.Drawing.Size(99, 22);
            this.ModifyTextButton.TabIndex = 5;
            this.ModifyTextButton.Text = "글 수정";
            this.ModifyTextButton.UseSelectable = true;
            this.ModifyTextButton.Visible = false;
            this.ModifyTextButton.Click += new System.EventHandler(this.ModifyTextButton_Click);
            // metroTextBox2
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(98, 2);
            this.metroTextBox2.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(273, 273);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Enabled = false;
            this.metroTextBox2.Lines = new string[] {"글 내용"};
            this.metroTextBox2.Location = new System.Drawing.Point(659, 182);
            this.metroTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(374, 278);
            this.metroTextBox2.TabIndex = 6;
            this.metroTextBox2.Text = "글 내용";
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // MakeElementButton
            this.MakeElementButton.Location = new System.Drawing.Point(23, 476);
            this.MakeElementButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MakeElementButton.Name = "MakeElementButton";
            this.MakeElementButton.Size = new System.Drawing.Size(69, 22);
            this.MakeElementButton.TabIndex = 7;
            this.MakeElementButton.Text = "글 쓰기";
            this.MakeElementButton.UseSelectable = true;
            this.MakeElementButton.Click += new System.EventHandler(this.MakeElementButton_Click);
            // SearchStringTextBox
            this.SearchStringTextBox.CustomButton.Image = null;
            this.SearchStringTextBox.CustomButton.Location = new System.Drawing.Point(135, 2);
            this.SearchStringTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchStringTextBox.CustomButton.Name = "";
            this.SearchStringTextBox.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.SearchStringTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SearchStringTextBox.CustomButton.TabIndex = 1;
            this.SearchStringTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SearchStringTextBox.CustomButton.UseSelectable = true;
            this.SearchStringTextBox.CustomButton.Visible = false;
            this.SearchStringTextBox.Lines = new string[0];
            this.SearchStringTextBox.Location = new System.Drawing.Point(349, 476);
            this.SearchStringTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchStringTextBox.MaxLength = 32767;
            this.SearchStringTextBox.Name = "SearchStringTextBox";
            this.SearchStringTextBox.PasswordChar = '\0';
            this.SearchStringTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchStringTextBox.SelectedText = "";
            this.SearchStringTextBox.SelectionLength = 0;
            this.SearchStringTextBox.SelectionStart = 0;
            this.SearchStringTextBox.ShortcutsEnabled = true;
            this.SearchStringTextBox.Size = new System.Drawing.Size(155, 22);
            this.SearchStringTextBox.TabIndex = 8;
            this.SearchStringTextBox.UseSelectable = true;
            this.SearchStringTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchStringTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // SearchElementButton
            this.SearchElementButton.Location = new System.Drawing.Point(511, 476);
            this.SearchElementButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchElementButton.Name = "SearchElementButton";
            this.SearchElementButton.Size = new System.Drawing.Size(65, 22);
            this.SearchElementButton.TabIndex = 9;
            this.SearchElementButton.Text = "찾기";
            this.SearchElementButton.UseSelectable = true;
            this.SearchElementButton.Click += new System.EventHandler(this.SearchElementButton_Click);
            // DeleteElementButton
            this.DeleteElementButton.Location = new System.Drawing.Point(763, 476);
            this.DeleteElementButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteElementButton.Name = "DeleteElementButton";
            this.DeleteElementButton.Size = new System.Drawing.Size(99, 22);
            this.DeleteElementButton.TabIndex = 10;
            this.DeleteElementButton.Text = "글 삭제";
            this.DeleteElementButton.UseSelectable = true;
            this.DeleteElementButton.Visible = false;
            this.DeleteElementButton.Click += new System.EventHandler(this.DeleteElementButton_Click);
            // menuButton
            this.menuButton.Location = new System.Drawing.Point(119, 34);
            this.menuButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(161, 24);
            this.menuButton.TabIndex = 11;
            this.menuButton.Text = "메뉴";
            this.menuButton.UseSelectable = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // metroContextMenu1
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
            this.metroContextMenu1.Size = new System.Drawing.Size(154, 118);
            // 시간표ToolStripMenuItem
            this.시간표ToolStripMenuItem.Name = "시간표ToolStripMenuItem";
            this.시간표ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.시간표ToolStripMenuItem.Text = "시간표";
            this.시간표ToolStripMenuItem.Click += new System.EventHandler(this.시간표ToolStripMenuItem_Click);
            // toolStripSeparator1
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(150, 6);
            // 학점계산기ToolStripMenuItem
            this.학점계산기ToolStripMenuItem.Name = "학점계산기ToolStripMenuItem";
            this.학점계산기ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.학점계산기ToolStripMenuItem.Text = "학점계산기";
            this.학점계산기ToolStripMenuItem.Click += new System.EventHandler(this.학점계산기ToolStripMenuItem_Click);
            // toolStripSeparator2
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(150, 6);
            
            // 로그아웃ToolStripMenuItem
            this.로그아웃ToolStripMenuItem.Name = "로그아웃ToolStripMenuItem";
            this.로그아웃ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.로그아웃ToolStripMenuItem.Text = "로그아웃";
            this.로그아웃ToolStripMenuItem.Click += new System.EventHandler(this.로그아웃ToolStripMenuItem_Click);
            
            // toolStripSeparator3
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(150, 6);

            // 종료ToolStripMenuItem
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 551);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "board";
            this.Padding = new System.Windows.Forms.Padding(21, 75, 21, 20);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "게시판";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.metroContextMenu1.ResumeLayout(false);
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
    }
}

