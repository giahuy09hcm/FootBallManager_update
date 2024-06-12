namespace FootBallManager
{
    partial class PieChartForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // PieChartForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Name = "PieChartForm";
            this.Text = "Biểu đồ Tỷ lệ chiến thắng";
            this.ResumeLayout(false);
        }

        private Panel panel1;
    }
}