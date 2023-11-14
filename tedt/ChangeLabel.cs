using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace tedt
{
    internal class ChangeLabel
    {
        private TableLayoutPanel tableLayoutPanel;
        private List<Label> timeLabel = new List<Label>();


        private enum Day { 월 = 1, 화 = 2, 수 = 3, 목 = 4, 금 = 5 }
        private enum Time { A = 1, B = 2 }

        public void SetTableLayoutPanel(TableLayoutPanel tableLayoutPanel)
        {
            this.tableLayoutPanel = tableLayoutPanel;
        }

        public void PlusLabel(string time, string name, string cls, string professor)
        {
            DoPlusLabel(TimeStringSplit(time), name, cls, professor);
        }

        public void DeleteLabel(string name, string cls)
        {
            List<Label> removeLabel = new List<Label>();

            foreach (Label label in timeLabel)
            {
                string[] s = label.Text.Split(new[] { "\n", "\n\n" }, StringSplitOptions.RemoveEmptyEntries);
                if (s[0] == name && s[1] == cls) removeLabel.Add(label);
            }

            foreach (Label label in removeLabel)
            {
                tableLayoutPanel.Controls.Remove(label);
                timeLabel.Remove(label);
            }
        }

        public void DeleteAllLabel()
        {
            List<Label> removeLabel = new List<Label>();

            foreach (Label label in timeLabel) { removeLabel.Add(label); }

            foreach (Label label in removeLabel)
            {
                tableLayoutPanel.Controls.Remove(label);
                label.Dispose();
                timeLabel.Clear();
            }
        }

        private void DoPlusLabel(List<int> list, string name, string cls, string professor)
        {
            Random random = new Random();
            Color randomColor = Color.FromArgb(random.Next(100, 256), random.Next(100, 256), random.Next(100,256));

            for (int i = 0; i < list.Count() / 3; i++)
            {
                Label label = new Label();
                label.Text = name + "\n" + cls + "\n\n" + professor;
                label.BackColor = randomColor;
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Dock = DockStyle.Fill;
                label.Margin = new Padding(0, 0, 0, 0);
                label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

                int diff = list[i * 3 + 2] - list[i * 3 + 1] + 1;
                tableLayoutPanel.Controls.Add(label, list[i * 3], list[i * 3 + 1]);
                tableLayoutPanel.SetRowSpan(label, diff);

                timeLabel.Add(label);
            }
        }

        public List<int> TimeStringSplit(string t)
        {
            List<int> a = new List<int>();

            if (t.Contains(","))
            {
                string[] splitData = t.Split(',');
                foreach (string data in splitData)
                {
                    char[] s = data.ToCharArray();
                    a.Add((int)Enum.Parse(typeof(ChangeLabel.Day), s[0].ToString()));//월 1
                    int n = (int)Enum.Parse(typeof(ChangeLabel.Time), s[3].ToString());
                    int m = (int)Enum.Parse(typeof(ChangeLabel.Time), s[7].ToString());
                    a.Add(RowCellValue(int.Parse(s[1].ToString()+s[2].ToString()), n));  //01A
                    a.Add(RowCellValue(int.Parse(s[5].ToString()+s[6].ToString()), m));  //02B
                }
            }
            else
            {
                char[] s = t.ToCharArray();
                a.Add((int)Enum.Parse(typeof(ChangeLabel.Day), s[0].ToString()));//월 1
                int n = (int)Enum.Parse(typeof(ChangeLabel.Time), s[3].ToString());
                int m = (int)Enum.Parse(typeof(ChangeLabel.Time), s[7].ToString());
                a.Add(RowCellValue(int.Parse(s[1].ToString()+s[2].ToString()), n));  //01A
                a.Add(RowCellValue(int.Parse(s[5].ToString()+s[6].ToString()), m));  //02B
            }
            return a;
        }

        private int RowCellValue(int x, int y)
        {
            if (y == 1) { return y * x + (x - 1); }
            else { return y * x; }
        }
    }
}