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
    public partial class MessengerForm : Form
    {
        public MessengerForm()
        {
            InitializeComponent();
            label2.Text = Form2.goalA.ToString();
            label3.Text = Form2.goalB.ToString();
            string videoPath = @"C:\Users\Gia Huy\Videos\Demo.mp4";
            axWindowsMediaPlayer1.URL = videoPath;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // Lấy bình luận từ TextBox
            string comment = textBoxComment.Text.Trim();
            string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            flowLayoutPanelComments.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelComments.AutoScroll = true;

            if (!string.IsNullOrEmpty(comment))
            {
                // Tạo một CommentControl mới
                CommentControl commentControl = new CommentControl();
                // Đặt thông tin bình luận, ngày tháng và avatar (ở đây bạn cần thay bằng ảnh đại diện thực tế)
                commentControl.SetComment(comment, dateTime);

                // Thêm CommentControl vào FlowLayoutPanel
                flowLayoutPanelComments.Controls.Add(commentControl);

                // Xóa TextBox sau khi gửi bình luận
                textBoxComment.Clear();
            }
            else
            {
                MessageBox.Show("Bạn phải nhập bình luận trước khi gửi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
