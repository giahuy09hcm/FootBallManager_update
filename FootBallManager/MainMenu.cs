
using System;
using System.Drawing;
using System.Windows.Forms;
//using FootBallManager.Forms;
using Guna.UI2.WinForms;
using Xceed.Wpf.Toolkit;

namespace FootBallManager
{
    public partial class MainMenu : Form
    {

        private Form currentChildForm;

        public MainMenu()
        {
            InitializeComponent();
            InitializeCustomComponents();

        }

        private void InitializeCustomComponents()
        {
            // Initialize buttons
            InitializeButton(out btnMuaGiai, "Home", new Point(248, 97), new Size(979, 666), btnMuaGiai_Click);
            InitializeButton(out btnPreseason, "Preseason", new Point(248, 97), new Size(979, 666), btnPreseason_Click);

        }

        private void InitializeButton(out Guna2GradientButton button, string text, Point location, Size size, EventHandler onClick)
        {
            button = new Guna2GradientButton();
            button.Text = text;
            button.Location = location; // Set button position
            button.Size = size; // Set button size
            button.Click += onClick;

            this.Controls.Add(button);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void OpenChildForm(Form childForm)
        {
            // Close the current child form if it exists
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            // Set the new form as the current child form
            currentChildForm = childForm;

            // Set the child form properties
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Add the child form to the parent form's controls
            this.Controls.Add(childForm);
            this.Tag = childForm;

            // Bring the child form to the front and show it
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnMuaGiai_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new MuaGiai());
        }

        private void btnInfoTeam_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Infoteam());
        }

        private void btnLich_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Lich());
        }

        private void btnPreseason_Click(object sender, EventArgs e)
        {
            //Show Giao Diện
            //OpenChildForm(new Form1());
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Rules());
        }

        private void btnBXH_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new BXH());
        }

        private void PanelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
