namespace tedt
{
    partial class boardEdit
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
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.InputTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SummitButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(77, 25);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(24, 64);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(76, 23);
            this.htmlLabel1.TabIndex = 0;
            this.htmlLabel1.Text = "수정할 글";
            // 
            // InputTextBox
            // 
            // 
            // 
            // 
            this.InputTextBox.CustomButton.Image = null;
            this.InputTextBox.CustomButton.Location = new System.Drawing.Point(198, 2);
            this.InputTextBox.CustomButton.Name = "";
            this.InputTextBox.CustomButton.Size = new System.Drawing.Size(195, 195);
            this.InputTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.InputTextBox.CustomButton.TabIndex = 1;
            this.InputTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.InputTextBox.CustomButton.UseSelectable = true;
            this.InputTextBox.CustomButton.Visible = false;
            this.InputTextBox.Lines = new string[] {
        "metroTextBox1"};
            this.InputTextBox.Location = new System.Drawing.Point(106, 68);
            this.InputTextBox.MaxLength = 32767;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.PasswordChar = '\0';
            this.InputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.InputTextBox.SelectedText = "";
            this.InputTextBox.SelectionLength = 0;
            this.InputTextBox.SelectionStart = 0;
            this.InputTextBox.ShortcutsEnabled = true;
            this.InputTextBox.Size = new System.Drawing.Size(396, 200);
            this.InputTextBox.TabIndex = 1;
            this.InputTextBox.Text = "metroTextBox1";
            this.InputTextBox.UseSelectable = true;
            this.InputTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.InputTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SummitButton
            // 
            this.SummitButton.Location = new System.Drawing.Point(427, 275);
            this.SummitButton.Name = "SummitButton";
            this.SummitButton.Size = new System.Drawing.Size(75, 23);
            this.SummitButton.TabIndex = 2;
            this.SummitButton.Text = "제출";
            this.SummitButton.UseSelectable = true;
            this.SummitButton.Click += new System.EventHandler(this.SummitButton_Click);
            // 
            // boardEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 328);
            this.Controls.Add(this.SummitButton);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.htmlLabel1);
            this.Movable = false;
            this.Name = "boardEdit";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "게시글 수정";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Controls.MetroTextBox InputTextBox;
        private MetroFramework.Controls.MetroButton SummitButton;
    }
}