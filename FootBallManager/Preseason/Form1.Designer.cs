namespace FootBallManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            label5 = new Label();
            map1 = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            imgTeam1 = new PictureBox();
            Team1 = new ComboBox();
            panel2 = new Panel();
            button2 = new Button();
            panel4 = new Panel();
            map2 = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            imgTeam2 = new PictureBox();
            Team2 = new ComboBox();
            Start = new Button();
            btnPredict = new Button();
            txtInput = new TextBox();
            btnSend = new Button();
            pictureBox1 = new PictureBox();
            flowLayoutPanelComments = new FlowLayoutPanel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgTeam1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgTeam2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(map1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(imgTeam1);
            panel1.Controls.Add(Team1);
            panel1.Location = new Point(7, 6);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(471, 833);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(342, 65);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(49, 31);
            button1.TabIndex = 7;
            button1.Text = "Info";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnInfo1_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel3.BackColor = Color.FromArgb(10, 18, 45);
            panel3.Location = new Point(7, 105);
            panel3.Name = "panel3";
            panel3.Size = new Size(430, 694);
            panel3.TabIndex = 6;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(7, 802);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 5;
            label5.Text = "HLV Erik Ten hag";
            // 
            // map1
            // 
            map1.FormattingEnabled = true;
            map1.Location = new Point(126, 65);
            map1.Margin = new Padding(3, 4, 3, 4);
            map1.Name = "map1";
            map1.Size = new Size(209, 28);
            map1.TabIndex = 4;
            map1.SelectedIndexChanged += map1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(29, 65);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 3;
            label3.Text = "Chọn sơ đồ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(29, 8);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 2;
            label1.Text = "Chọn đội 1";
            // 
            // imgTeam1
            // 
            imgTeam1.BackgroundImage = (Image)resources.GetObject("imgTeam1.BackgroundImage");
            imgTeam1.BackgroundImageLayout = ImageLayout.Stretch;
            imgTeam1.Location = new Point(342, 4);
            imgTeam1.Margin = new Padding(3, 4, 3, 4);
            imgTeam1.Name = "imgTeam1";
            imgTeam1.Size = new Size(49, 52);
            imgTeam1.TabIndex = 1;
            imgTeam1.TabStop = false;
            // 
            // Team1
            // 
            Team1.FormattingEnabled = true;
            Team1.Location = new Point(126, 4);
            Team1.Margin = new Padding(3, 4, 3, 4);
            Team1.Name = "Team1";
            Team1.Size = new Size(209, 28);
            Team1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(map2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(imgTeam2);
            panel2.Controls.Add(Team2);
            panel2.Location = new Point(571, 6);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(511, 833);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.ForeColor = Color.Black;
            button2.Location = new Point(48, 65);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(49, 31);
            button2.TabIndex = 8;
            button2.Text = "Info";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnInfo2_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel4.BackColor = Color.FromArgb(10, 18, 45);
            panel4.Location = new Point(43, 105);
            panel4.Name = "panel4";
            panel4.Size = new Size(430, 694);
            panel4.TabIndex = 7;
            // 
            // map2
            // 
            map2.FormattingEnabled = true;
            map2.Location = new Point(104, 65);
            map2.Margin = new Padding(3, 4, 3, 4);
            map2.Name = "map2";
            map2.Size = new Size(203, 28);
            map2.TabIndex = 39;
            map2.SelectedIndexChanged += map2_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(14, 802);
            label6.Name = "label6";
            label6.Size = new Size(132, 20);
            label6.TabIndex = 6;
            label6.Text = "HLV Pep Guardiola";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(330, 69);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 4;
            label4.Text = "Chọn sơ đồ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(330, 15);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 3;
            label2.Text = "Chọn đội 2";
            // 
            // imgTeam2
            // 
            imgTeam2.BackgroundImage = (Image)resources.GetObject("imgTeam2.BackgroundImage");
            imgTeam2.BackgroundImageLayout = ImageLayout.Stretch;
            imgTeam2.Location = new Point(48, 4);
            imgTeam2.Margin = new Padding(3, 4, 3, 4);
            imgTeam2.Name = "imgTeam2";
            imgTeam2.Size = new Size(49, 52);
            imgTeam2.TabIndex = 2;
            imgTeam2.TabStop = false;
            // 
            // Team2
            // 
            Team2.FormattingEnabled = true;
            Team2.Location = new Point(104, 4);
            Team2.Margin = new Padding(3, 4, 3, 4);
            Team2.Name = "Team2";
            Team2.Size = new Size(203, 28);
            Team2.TabIndex = 1;
            // 
            // Start
            // 
            Start.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Start.ForeColor = Color.Black;
            Start.Location = new Point(484, 320);
            Start.Margin = new Padding(3, 4, 3, 4);
            Start.Name = "Start";
            Start.Size = new Size(81, 31);
            Start.TabIndex = 2;
            Start.Text = "Đấu";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // btnPredict
            // 
            btnPredict.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnPredict.ForeColor = Color.Black;
            btnPredict.Location = new Point(484, 390);
            btnPredict.Margin = new Padding(3, 4, 3, 4);
            btnPredict.Name = "btnPredict";
            btnPredict.Size = new Size(81, 35);
            btnPredict.TabIndex = 3;
            btnPredict.Text = "Dự đoán";
            btnPredict.UseVisualStyleBackColor = true;
            btnPredict.Click += Predict_Click;
            // 
            // txtInput
            // 
            txtInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtInput.BackColor = SystemColors.InactiveCaption;
            txtInput.Location = new Point(15, 604);
            txtInput.Margin = new Padding(3, 4, 3, 4);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(104, 27);
            txtInput.TabIndex = 4;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSend.BackColor = Color.LightGray;
            btnSend.BackgroundImage = (Image)resources.GetObject("btnSend.BackgroundImage");
            btnSend.BackgroundImageLayout = ImageLayout.Stretch;
            btnSend.ForeColor = Color.Black;
            btnSend.Location = new Point(116, 599);
            btnSend.Margin = new Padding(3, 4, 3, 4);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(37, 37);
            btnSend.TabIndex = 6;
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(15, 71);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 125);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanelComments
            // 
            flowLayoutPanelComments.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            flowLayoutPanelComments.BackColor = SystemColors.ControlLight;
            flowLayoutPanelComments.Location = new Point(15, 294);
            flowLayoutPanelComments.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanelComments.Name = "flowLayoutPanelComments";
            flowLayoutPanelComments.Size = new Size(138, 282);
            flowLayoutPanelComments.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnPredict);
            panel5.Controls.Add(Start);
            panel5.Controls.Add(panel1);
            panel5.Controls.Add(panel2);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1085, 843);
            panel5.TabIndex = 9;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(1085, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(169, 843);
            panel6.TabIndex = 10;
            // 
            // panel7
            // 
            panel7.Controls.Add(flowLayoutPanelComments);
            panel7.Controls.Add(btnSend);
            panel7.Controls.Add(pictureBox1);
            panel7.Controls.Add(txtInput);
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(1260, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(153, 843);
            panel7.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1413, 843);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel7);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgTeam1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgTeam2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox imgTeam1;
        private ComboBox Team1;
        private PictureBox imgTeam2;
        private ComboBox Team2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox map1;
        private Label label6;
        private ComboBox Map2;
        private Button Start;
        private ComboBox map2;
        private Panel panel3;
        private Panel panel4;
        private Button btnPredict;
        private TextBox txtInput;
        private Button btnSend;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanelComments;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
    }
}
