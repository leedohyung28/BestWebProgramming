namespace tedt
{
    partial class loginForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.pwTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "아이디";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "비밀번호";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(314, 165);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(156, 25);
            this.loginTextBox.TabIndex = 2;
            // 
            // pwTextBox
            // 
            this.pwTextBox.Location = new System.Drawing.Point(314, 234);
            this.pwTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pwTextBox.Name = "pwTextBox";
            this.pwTextBox.Size = new System.Drawing.Size(156, 25);
            this.pwTextBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 161);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 91);
            this.button1.TabIndex = 1;
            this.button1.Text = "로그인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(314, 286);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "회원가입";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.label4_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 481);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pwTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "loginForm";
            this.Padding = new System.Windows.Forms.Padding(20, 75, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "로그인";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox pwTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

