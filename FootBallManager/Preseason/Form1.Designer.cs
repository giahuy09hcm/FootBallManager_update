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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgTeam1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgTeam2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel1.Location = new Point(14, 3);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(440, 705);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
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
            panel3.Location = new Point(7, 105);
            panel3.Name = "panel3";
            panel3.Size = new Size(430, 555);
            panel3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 673);
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
            label3.Location = new Point(29, 65);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 3;
            label3.Text = "Chọn sơ đồ";
            // 
            // label1
            // 
            label1.AutoSize = true;
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
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(map2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(imgTeam2);
            panel2.Controls.Add(Team2);
            panel2.Location = new Point(553, 3);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(440, 705);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
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
            panel4.Location = new Point(8, 105);
            panel4.Name = "panel4";
            panel4.Size = new Size(430, 555);
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
            label6.AutoSize = true;
            label6.Location = new Point(8, 673);
            label6.Name = "label6";
            label6.Size = new Size(132, 20);
            label6.TabIndex = 6;
            label6.Text = "HLV Pep Guardiola";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(330, 69);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 4;
            label4.Text = "Chọn sơ đồ";
            // 
            // label2
            // 
            label2.AutoSize = true;
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
            Start.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Start.Location = new Point(461, 259);
            Start.Margin = new Padding(3, 4, 3, 4);
            Start.Name = "Start";
            Start.Size = new Size(86, 31);
            Start.TabIndex = 2;
            Start.Text = "Đấu";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // btnPredict
            // 
            btnPredict.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnPredict.Location = new Point(461, 297);
            btnPredict.Margin = new Padding(3, 4, 3, 4);
            btnPredict.Name = "btnPredict";
            btnPredict.Size = new Size(86, 31);
            btnPredict.TabIndex = 3;
            btnPredict.Text = "Dự đoán";
            btnPredict.UseVisualStyleBackColor = true;
            btnPredict.Click += Predict_Click;
            // 
            // txtInput
            // 
            txtInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtInput.Location = new Point(1011, 672);
            txtInput.Margin = new Padding(3, 4, 3, 4);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(220, 27);
            txtInput.TabIndex = 4;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSend.BackgroundImage = (Image)resources.GetObject("btnSend.BackgroundImage");
            btnSend.BackgroundImageLayout = ImageLayout.Stretch;
            btnSend.Location = new Point(1239, 664);
            btnSend.Margin = new Padding(3, 4, 3, 4);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(50, 44);
            btnSend.TabIndex = 6;
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(1011, 17);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 272);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanelComments
            // 
            flowLayoutPanelComments.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            flowLayoutPanelComments.Location = new Point(1011, 297);
            flowLayoutPanelComments.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanelComments.Name = "flowLayoutPanelComments";
            flowLayoutPanelComments.Size = new Size(278, 365);
            flowLayoutPanelComments.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1303, 715);
            Controls.Add(flowLayoutPanelComments);
            Controls.Add(pictureBox1);
            Controls.Add(btnSend);
            Controls.Add(txtInput);
            Controls.Add(btnPredict);
            Controls.Add(Start);
            Controls.Add(panel2);
            Controls.Add(panel1);
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
            ResumeLayout(false);
            PerformLayout();
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
    }
}
