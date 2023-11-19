namespace tedt
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.User_ID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuButton = new MetroFramework.Controls.MetroButton();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.학점계산기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.게시판ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.로그아웃ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StudentIDLabel = new MetroFramework.Controls.MetroLabel();
            this.metroContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "로그인 정보 : ";
            // 
            // User_ID
            // 
            this.User_ID.AutoSize = true;
            this.User_ID.Location = new System.Drawing.Point(108, 62);
            this.User_ID.Name = "User_ID";
            this.User_ID.Size = new System.Drawing.Size(36, 12);
            this.User_ID.TabIndex = 1;
            this.User_ID.Text = "NULL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "학번 졸업요건";
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(183, 28);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(141, 19);
            this.menuButton.TabIndex = 10;
            this.menuButton.Text = "메뉴";
            this.menuButton.UseSelectable = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.학점계산기ToolStripMenuItem,
            this.toolStripSeparator1,
            this.게시판ToolStripMenuItem,
            this.toolStripSeparator2,
            this.로그아웃ToolStripMenuItem,
            this.toolStripSeparator3,
            this.종료ToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(123, 110);
            // 
            // 학점계산기ToolStripMenuItem
            // 
            this.학점계산기ToolStripMenuItem.Name = "학점계산기ToolStripMenuItem";
            this.학점계산기ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.학점계산기ToolStripMenuItem.Text = "시간표";
            this.학점계산기ToolStripMenuItem.Click += new System.EventHandler(this.학점계산기ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // 게시판ToolStripMenuItem
            // 
            this.게시판ToolStripMenuItem.Name = "게시판ToolStripMenuItem";
            this.게시판ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.게시판ToolStripMenuItem.Text = "게시판";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(119, 6);
            // 
            // 로그아웃ToolStripMenuItem
            // 
            this.로그아웃ToolStripMenuItem.Name = "로그아웃ToolStripMenuItem";
            this.로그아웃ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.로그아웃ToolStripMenuItem.Text = "로그아웃";
            this.로그아웃ToolStripMenuItem.Click += new System.EventHandler(this.로그아웃ToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(119, 6);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // StudentIDLabel
            // 
            this.StudentIDLabel.AutoSize = true;
            this.StudentIDLabel.Location = new System.Drawing.Point(55, 88);
            this.StudentIDLabel.Name = "StudentIDLabel";
            this.StudentIDLabel.Size = new System.Drawing.Size(40, 19);
            this.StudentIDLabel.TabIndex = 11;
            this.StudentIDLabel.Text = "NULL";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 676);
            this.Controls.Add(this.StudentIDLabel);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.User_ID);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Padding = new System.Windows.Forms.Padding(18, 60, 18, 16);
            this.Text = "KoreaTechHour";
            this.metroContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label User_ID;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroButton menuButton;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem 학점계산기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 게시판ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 로그아웃ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel StudentIDLabel;
    }
}