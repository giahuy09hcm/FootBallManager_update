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
    public partial class PieChartForm : Form
    {
        private int teamAPercentage;
        private int teamBPercentage;
        public static int p1;
        public static int p2;
        public PieChartForm(int teamAPercentage)
        {
            InitializeComponent();
            this.teamAPercentage = teamAPercentage;
            this.teamBPercentage = 100 - teamAPercentage;
            
            this.Paint += new PaintEventHandler(PieChartForm_Paint);
            
        }
        private void PieChartForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(10, 10, 200, 200);

            float angleA = 360 * teamAPercentage / 100f;
            float angleB = 360 * teamBPercentage / 100f;

            // Vẽ phần của Đội A
            g.FillPie(Brushes.Blue, rect, 0, angleA);

            // Vẽ phần của Đội B
            g.FillPie(Brushes.Red, rect, angleA, angleB);

            // Vẽ viền của biểu đồ
            g.DrawEllipse(Pens.Black, rect);

            // Vẽ nhãn
            g.DrawString($"Đội 1: {teamAPercentage}%", new Font("Arial", 10), Brushes.Black, new PointF(220, 50));
            g.DrawString($"Đội 2: {teamBPercentage}%", new Font("Arial", 10), Brushes.Black, new PointF(220, 80));
            p1 = teamAPercentage;
            p2 = 100 - teamAPercentage;
        }
    }
}
