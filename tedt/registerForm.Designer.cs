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
            this.idCheckButton = new System.Windows.Forms.Button();
            this.studentNoCheckButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gradeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(158, 62);
            this.idBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(144, 21);
            this.idBox.TabIndex = 1;
            // 
            // pwBox
            // 
            this.pwBox.Location = new System.Drawing.Point(158, 99);
            this.pwBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pwBox.Name = "pwBox";
            this.pwBox.PasswordChar = '•';
            this.pwBox.Size = new System.Drawing.Size(144, 21);
            this.pwBox.TabIndex = 2;
            // 
            // pwConfirmBox
            // 
            this.pwConfirmBox.Location = new System.Drawing.Point(158, 136);
            this.pwConfirmBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pwConfirmBox.Name = "pwConfirmBox";
            this.pwConfirmBox.PasswordChar = '•';
            this.pwConfirmBox.Size = new System.Drawing.Size(144, 21);
            this.pwConfirmBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(158, 173);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(144, 21);
            this.nameTextBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 142);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 80);
            this.button1.TabIndex = 7;
            this.button1.Text = "회원가입";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idText
            // 
            this.idText.AutoSize = true;
            this.idText.Location = new System.Drawing.Point(111, 64);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(41, 12);
            this.idText.TabIndex = 8;
            this.idText.Text = "아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "비밀번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "비밀번호 확인";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
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
            this.majorComboBox.Location = new System.Drawing.Point(158, 283);
            this.majorComboBox.Name = "majorComboBox";
            this.majorComboBox.Size = new System.Drawing.Size(144, 20);
            this.majorComboBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "학부";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "학과";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // detailMajorComboBox
            // 
            this.detailMajorComboBox.FormattingEnabled = true;
            this.detailMajorComboBox.Location = new System.Drawing.Point(158, 319);
            this.detailMajorComboBox.Name = "detailMajorComboBox";
            this.detailMajorComboBox.Size = new System.Drawing.Size(144, 20);
            this.detailMajorComboBox.TabIndex = 15;
            this.detailMajorComboBox.DropDown += new System.EventHandler(this.detailMajorComboBox_DropDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(123, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "학번";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // studentNoTextBox
            // 
            this.studentNoTextBox.Location = new System.Drawing.Point(158, 210);
            this.studentNoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentNoTextBox.Name = "studentNoTextBox";
            this.studentNoTextBox.Size = new System.Drawing.Size(144, 21);
            this.studentNoTextBox.TabIndex = 18;
            // 
            // idCheckButton
            // 
            this.idCheckButton.Location = new System.Drawing.Point(332, 62);
            this.idCheckButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idCheckButton.Name = "idCheckButton";
            this.idCheckButton.Size = new System.Drawing.Size(93, 21);
            this.idCheckButton.TabIndex = 19;
            this.idCheckButton.Text = "아이디 확인";
            this.idCheckButton.UseVisualStyleBackColor = true;
            this.idCheckButton.Click += new System.EventHandler(this.idCheckButton_Click);
            // 
            // studentNoCheckButton
            // 
            this.studentNoCheckButton.Location = new System.Drawing.Point(332, 211);
            this.studentNoCheckButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentNoCheckButton.Name = "studentNoCheckButton";
            this.studentNoCheckButton.Size = new System.Drawing.Size(93, 21);
            this.studentNoCheckButton.TabIndex = 20;
            this.studentNoCheckButton.Text = "학번 확인";
            this.studentNoCheckButton.UseVisualStyleBackColor = true;
            this.studentNoCheckButton.Click += new System.EventHandler(this.studentNoCheckButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "학년";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradeComboBox
            // 
            this.gradeComboBox.FormattingEnabled = true;
            this.gradeComboBox.Items.AddRange(new object[] {
            "1학년",
            "2학년",
            "3학년",
            "4학년 이상"});
            this.gradeComboBox.Location = new System.Drawing.Point(158, 247);
            this.gradeComboBox.Name = "gradeComboBox";
            this.gradeComboBox.Size = new System.Drawing.Size(144, 20);
            this.gradeComboBox.TabIndex = 21;
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gradeComboBox);
            this.Controls.Add(this.studentNoCheckButton);
            this.Controls.Add(this.idCheckButton);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "registerForm";
            this.Padding = new System.Windows.Forms.Padding(18, 60, 18, 16);
            this.Text = "회원가입";
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
        private System.Windows.Forms.Button idCheckButton;
        private System.Windows.Forms.Button studentNoCheckButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox gradeComboBox;
    }
}