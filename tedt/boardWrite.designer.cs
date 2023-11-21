namespace tedt
{
    partial class boardWrite
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TitleTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ContentsTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SummitButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 81);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(39, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "제목";
            // 
            // TitleTextBox
            // 
            // 
            // 
            // 
            this.TitleTextBox.CustomButton.Image = null;
            this.TitleTextBox.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.TitleTextBox.CustomButton.Name = "";
            this.TitleTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TitleTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TitleTextBox.CustomButton.TabIndex = 1;
            this.TitleTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TitleTextBox.CustomButton.UseSelectable = true;
            this.TitleTextBox.CustomButton.Visible = false;
            this.TitleTextBox.Lines = new string[0];
            this.TitleTextBox.Location = new System.Drawing.Point(114, 81);
            this.TitleTextBox.MaxLength = 32767;
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.PasswordChar = '\0';
            this.TitleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TitleTextBox.SelectedText = "";
            this.TitleTextBox.SelectionLength = 0;
            this.TitleTextBox.SelectionStart = 0;
            this.TitleTextBox.ShortcutsEnabled = true;
            this.TitleTextBox.Size = new System.Drawing.Size(250, 23);
            this.TitleTextBox.TabIndex = 1;
            this.TitleTextBox.UseSelectable = true;
            this.TitleTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TitleTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TitleTextBox.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // ContentsTextBox
            // 
            // 
            // 
            // 
            this.ContentsTextBox.CustomButton.Image = null;
            this.ContentsTextBox.CustomButton.Location = new System.Drawing.Point(190, 2);
            this.ContentsTextBox.CustomButton.Name = "";
            this.ContentsTextBox.CustomButton.Size = new System.Drawing.Size(225, 225);
            this.ContentsTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ContentsTextBox.CustomButton.TabIndex = 1;
            this.ContentsTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ContentsTextBox.CustomButton.UseSelectable = true;
            this.ContentsTextBox.CustomButton.Visible = false;
            this.ContentsTextBox.Lines = new string[0];
            this.ContentsTextBox.Location = new System.Drawing.Point(114, 110);
            this.ContentsTextBox.MaxLength = 32767;
            this.ContentsTextBox.Name = "ContentsTextBox";
            this.ContentsTextBox.PasswordChar = '\0';
            this.ContentsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ContentsTextBox.SelectedText = "";
            this.ContentsTextBox.SelectionLength = 0;
            this.ContentsTextBox.SelectionStart = 0;
            this.ContentsTextBox.ShortcutsEnabled = true;
            this.ContentsTextBox.Size = new System.Drawing.Size(418, 230);
            this.ContentsTextBox.TabIndex = 3;
            this.ContentsTextBox.UseSelectable = true;
            this.ContentsTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ContentsTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 110);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(58, 20);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "글 내용";
            // 
            // SummitButton
            // 
            this.SummitButton.Location = new System.Drawing.Point(550, 317);
            this.SummitButton.Name = "SummitButton";
            this.SummitButton.Size = new System.Drawing.Size(75, 23);
            this.SummitButton.TabIndex = 4;
            this.SummitButton.Text = "저장";
            this.SummitButton.UseSelectable = true;
            this.SummitButton.Click += new System.EventHandler(this.SummitButton_Click);

            // boardWrite
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 384);
            this.Controls.Add(this.SummitButton);
            this.Controls.Add(this.ContentsTextBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Name = "boardWrite";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "게시글 작성";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TitleTextBox;
        private MetroFramework.Controls.MetroTextBox ContentsTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton SummitButton;
    }
}