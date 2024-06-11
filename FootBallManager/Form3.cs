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
    public partial class Form3 : Form
    {
        private int ballPossessionA;
        private int ballPossessionB;
        private int cornersA;
        private int cornersB;
        private int foulsA;
        private int foulsB;
        public Form3(int ballPossessionA, int ballPossessionB, int cornersA, int cornersB, int foulsA, int foulsB)
        {
            InitializeComponent();
            label2.Text =Form2.goalA.ToString();
            label3.Text = Form2.goalB.ToString();
            this.ballPossessionA = ballPossessionA;
            this.ballPossessionB = ballPossessionB;
            this.cornersA = cornersA;
            this.cornersB = cornersB;
            this.foulsA = foulsA;
            this.foulsB = foulsB;
            this.panel1.Paint += new PaintEventHandler(MatchDetailsForm_Paint);
        }
        private void MatchDetailsForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int panelWidth = panel1.ClientSize.Width;
            int panelHeight = panel1.ClientSize.Height;
            int barHeight = 30;
            int spacing = 60;

            int xOffset = panelWidth / 2;

            DrawBar(g, "Tỉ lệ kiểm soát bóng", ballPossessionA, ballPossessionB, xOffset, spacing, barHeight, panelWidth);
            DrawBar(g, "Phạt góc", cornersA, cornersB, xOffset, spacing * 2, barHeight, panelWidth);
            DrawBar(g, "Phạm lỗi", foulsA, foulsB, xOffset, spacing * 3, barHeight, panelWidth);
            DrawColumnLabels(g, xOffset, barHeight, spacing);
        }
        private void DrawBar(Graphics g, string label, int valueA, int valueB, int xOffset, int yOffset, int barHeight, int panelWidth)
        {
            int maxValue = Math.Max(valueA, valueB);
            float scaleFactor = (panelWidth / 2 - 100) / (float)maxValue;

            // Vẽ nhãn
            g.DrawString(label, new Font("Arial", 12), Brushes.Black, new PointF(xOffset - 150, yOffset + (barHeight / 2) - 10));

            // Vẽ cột cho đội A
            g.FillRectangle(Brushes.Blue, xOffset - (valueA * scaleFactor), yOffset, valueA * scaleFactor, barHeight);
            g.DrawString(valueA.ToString(), new Font("Arial", 10), Brushes.Black, new PointF(xOffset - (valueA * scaleFactor) - 30, yOffset + (barHeight / 2) - 10));

            // Vẽ cột cho đội B
            g.FillRectangle(Brushes.Red, xOffset, yOffset, valueB * scaleFactor, barHeight);
            g.DrawString(valueB.ToString(), new Font("Arial", 10), Brushes.Black, new PointF(xOffset + (valueB * scaleFactor) + 5, yOffset + (barHeight / 2) - 10));
        }
        private void DrawColumnLabels(Graphics g, int panelWidth, int barHeight, int spacing)
        {
            Font labelFont = new Font("Arial", 12);
            Brush labelBrush = Brushes.Black;

            // Vị trí y cho nhãn cột (phía trên cột)
            int labelY = 0;

            // Vị trí x cho các nhãn (giữa hai cột)
            int labelX = panelWidth;

            // Vẽ các nhãn cột
            g.DrawString("Tỉ lệ kiểm soát bóng", labelFont, labelBrush, new PointF(labelX, spacing - 30));
            g.DrawString("Phạt góc", labelFont, labelBrush, new PointF(labelX , spacing * 2 - 30));
            g.DrawString("Phạm lỗi", labelFont, labelBrush, new PointF(labelX , spacing * 3 - 30));
        }



        private void BtnOpenChat_Click(object sender, EventArgs e)
        {
            MessengerForm chatForm = new MessengerForm();
            chatForm.Show();
        }
    }
}
