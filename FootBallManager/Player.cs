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
    public partial class Player : UserControl
    {
        public Player()
        {
            InitializeComponent();
            label1.Hide();
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public Image Image
        {
            get { return pictureBox2.Image; }
            set { pictureBox2.Image = value; }
        }
        public float Score
        {
            get
            {
                float result;
                if (float.TryParse(label1.Text, out result))
                    return result;
                else
                    return 0;
            }
            set
            {
                label1.Text = value.ToString();
            }
        }
        // Trong lớp Player
        public void ShowLabel()
        {
            // Đặt thuộc tính Visible của Label thành true
            label1.Visible = true;
        }

        


    }
}
