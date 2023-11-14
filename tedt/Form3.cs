using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tedt
{
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        string id_init;
        string name_init;
        string grade_init;
        string major_init;

        Dictionary<string, int> student19 = new Dictionary<string, int>
        {
            {"기초 교양", 6},
            {"교양 필수", 17},
            {"대학 소양", 6},
            {"교양 선택", 3},
            {"MSC", 18},
            {"HRD", 10},
            {"전공 필수 선택", 69},
            {"IPP", 2},
            {"자유 선택", 9}
        };
        public Form3(string id, string name, string grade, string major)
        {
            InitializeComponent();
            id_init = id;
            name_init = name;
            grade_init = grade;
            major_init = major;
            CreateProgressBars();
        }

        private void CreateProgressBars()
        {
            int yPoint = 180; // 시작 y 위치
            foreach (var item in student19)
            {
                // 라벨 생성 및 설정
                Label progressLabel = new Label
                {
                    Text = item.Key, // 라벨 텍스트 설정
                    Location = new Point(30, yPoint), // 위치 설정
                    Width = 100, // 너비 설정
                    TextAlign = ContentAlignment.MiddleRight // 텍스트 오른쪽 정렬
                };
                Controls.Add(progressLabel);

                // 프로그레스바 생성 및 설정
                ProgressBar progressBar = new ProgressBar
                {
                    Width = 750,
                    Height = 25,
                    Value = 1, // 이 부분을 실제 진행 상태 값으로 업데이트해야 함
                    Maximum = item.Value, // 최대 값 설정
                    Location = new Point(160, yPoint) // 위치 설정
                };
                Controls.Add(progressBar);

                // 프로그레스바 옆에 현재 값을 표시하는 라벨 생성 및 설정
                Label valueLabel = new Label
                {
                    Text = $"{progressBar.Value} / {progressBar.Maximum}", // 현재 값 / 최대 값
                    Location = new Point(progressBar.Right + 10, yPoint+7), // 위치 설정
                    AutoSize = true // 크기 자동 조정
                };
                Controls.Add(valueLabel);

                // 다음 컨트롤의 y 위치 업데이트
                yPoint += progressBar.Height + 10;
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            metroContextMenu1.Show(menuButton, 0, menuButton.Height);
        }

        private void 시간표ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            timeTable form = new timeTable(id_init, name_init, grade_init, major_init);
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
    }
}
