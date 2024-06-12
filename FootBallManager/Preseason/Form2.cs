using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootBallManager
{
    public partial class Form2 : Form
    {
        public static int goalA;
        public static int goalB;
        public Form2()
        {
            InitializeComponent();
            Random rand = new Random();
            goalA = rand.Next(0, 8);
            label2.Text=goalA.ToString();
            goalB = rand.Next(0, 8);
            label3.Text = goalB.ToString();

            //panel1.Controls.Clear();
            //panel2.Controls.Clear();
            foreach (var playerInfo in Form1.playerInfos1)
            {
                // Tạo ra các Player mới dựa trên thông tin đã lưu
                Player cauThuControl = new Player();
                cauThuControl.Location = playerInfo.Location;
                cauThuControl.Name = playerInfo.Name;

                // Load hình ảnh nếu có đường dẫn
                if (!string.IsNullOrEmpty(playerInfo.ImagePath))
                {
                    cauThuControl.Image = Image.FromFile(playerInfo.ImagePath);
                }
                cauThuControl.ShowLabel();
                if(goalA>goalB)
                {
                    float minValue = 6.0f;
                    float maxValue = 10.0f;
                    cauThuControl.Score = (float)Math.Round((rand.NextDouble() * (maxValue - minValue) + minValue), 1);
                }
                else
                {
                    float minValue = 2.0f;
                    float maxValue = 6.0f;
                    cauThuControl.Score = (float)Math.Round((rand.NextDouble() * (maxValue - minValue) + minValue), 1);
                }
                // Thêm các Player mới vào panel trên form mới
                panel1.Controls.Add(cauThuControl);
            }
            foreach (var playerInfo in Form1.playerInfos2)
            {
                // Tạo ra các Player mới dựa trên thông tin đã lưu
                Player cauThuControl = new Player();
                cauThuControl.Location = playerInfo.Location;
                cauThuControl.Name = playerInfo.Name;

                // Load hình ảnh nếu có đường dẫn
                if (!string.IsNullOrEmpty(playerInfo.ImagePath))
                {
                    cauThuControl.Image = Image.FromFile(playerInfo.ImagePath);
                }
                cauThuControl.ShowLabel();
                if (goalB > goalA)
                {
                    float minValue = 6.0f;
                    float maxValue = 10.0f;
                    cauThuControl.Score = (float)Math.Round((rand.NextDouble() * (maxValue - minValue) + minValue), 1);
                }
                else
                {
                    float minValue = 2.0f;
                    float maxValue = 6.0f;
                    cauThuControl.Score = (float)Math.Round((rand.NextDouble() * (maxValue - minValue) + minValue), 1);
                }
                // Thêm các Player mới vào panel trên form mới
                panel2.Controls.Add(cauThuControl);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int ballPossessionA = rand.Next(30, 71);
            int ballPossessionB = 100 - ballPossessionA;
            int cornersA = rand.Next(1, 11);
            int cornersB = rand.Next(1, 11);
            int foulsA = rand.Next(5, 21);
            int foulsB = rand.Next(5, 21);
            using (Form3 matchDetailsForm = new Form3(ballPossessionA, ballPossessionB, cornersA, cornersB, foulsA, foulsB))
            {
                matchDetailsForm.ShowDialog(); // Show the match details form as a modal dialog
            }
        }
    }
}
