namespace tedt
{
    partial class registerForm
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
            this.idBox = new System.Windows.Forms.TextBox();
            this.pwBox = new System.Windows.Forms.TextBox();
            this.pwConfirmBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.idText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.majorComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.detailMajorComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.studentNoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(587, 158);
            this.idBox.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(264, 35);
            this.idBox.TabIndex = 1;
            // 
            // pwBox
            // 
            this.pwBox.Location = new System.Drawing.Point(587, 232);
            this.pwBox.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.pwBox.Name = "pwBox";
            this.pwBox.PasswordChar = '•';
            this.pwBox.Size = new System.Drawing.Size(264, 35);
            this.pwBox.TabIndex = 2;
            // 
            // pwConfirmBox
            // 
            this.pwConfirmBox.Location = new System.Drawing.Point(587, 306);
            this.pwConfirmBox.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.pwConfirmBox.Name = "pwConfirmBox";
            this.pwConfirmBox.PasswordChar = '•';
            this.pwConfirmBox.Size = new System.Drawing.Size(264, 35);
            this.pwConfirmBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(587, 380);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(264, 35);
            this.nameTextBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(899, 542);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 112);
            this.button1.TabIndex = 7;
            this.button1.Text = "회원가입";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idText
            // 
            this.idText.AutoSize = true;
            this.idText.Location = new System.Drawing.Point(500, 168);
            this.idText.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(82, 24);
            this.idText.TabIndex = 8;
            this.idText.Text = "아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 242);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "비밀번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 316);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "비밀번호 확인";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 390);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "이름";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // majorComboBox
            // 
            this.majorComboBox.FormattingEnabled = true;
            this.majorComboBox.Items.AddRange(new object[] {
            "기계공학부",
            "메카트로닉스공학부",
            "전기·전자·통신공학부",
            "컴퓨터공학부",
            "디자인·건축공학부",
            "에너지·신소재·화학공학부",
            "산업경영학부",
            "고용서비스정책학과"});
            this.majorComboBox.Location = new System.Drawing.Point(587, 542);
            this.majorComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.majorComboBox.Name = "majorComboBox";
            this.majorComboBox.Size = new System.Drawing.Size(264, 32);
            this.majorComboBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(522, 550);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "학부";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(522, 622);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "학과";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // detailMajorComboBox
            // 
            this.detailMajorComboBox.FormattingEnabled = true;
            this.detailMajorComboBox.Location = new System.Drawing.Point(587, 614);
            this.detailMajorComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.detailMajorComboBox.Name = "detailMajorComboBox";
            this.detailMajorComboBox.Size = new System.Drawing.Size(264, 32);
            this.detailMajorComboBox.TabIndex = 15;
            this.detailMajorComboBox.DropDown += new System.EventHandler(this.detailMajorComboBox_DropDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(522, 468);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "학번";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // studentNoTextBox
            // 
            this.studentNoTextBox.Location = new System.Drawing.Point(587, 458);
            this.studentNoTextBox.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.studentNoTextBox.Name = "studentNoTextBox";
            this.studentNoTextBox.Size = new System.Drawing.Size(264, 35);
            this.studentNoTextBox.TabIndex = 18;
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 720);
            this.Controls.Add(this.studentNoTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.detailMajorComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.majorComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.pwConfirmBox);
            this.Controls.Add(this.pwBox);
            this.Controls.Add(this.idBox);
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "registerForm";
            this.Padding = new System.Windows.Forms.Padding(33, 120, 33, 32);
            this.Text = "회원가입";
            this.Load += new System.EventHandler(this.registerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox pwBox;
        private System.Windows.Forms.TextBox pwConfirmBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label idText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox majorComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox detailMajorComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox studentNoTextBox;
    }
}