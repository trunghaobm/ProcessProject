using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using ProcessProject.OtherClass;
using ProcessProject.OtherForm;
using ProcessProject.DB_Access;

namespace ProcessProject
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void picStudentClick_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Microsoft Sans Serif", 25))
            {
                e.Graphics.DrawString("Sinh Viên", myFont, Brushes.Black, new Point(2, 2));
            }
        }

        private void picLoginClick_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Microsoft Sans Serif", 25))
            {
                e.Graphics.DrawString("Log in", myFont, Brushes.Black, new Point(2, 2));
            }
        }

        private void picLoginClick_Click(object sender, EventArgs e)
        {
            picLoginClick.BackColor = Color.LightGray;


            picStudentClick.BackColor = Color.Gray;
            LoginForm login = new LoginForm();
            AllUser.OpoenChildForm(login, panelFormControl);
        }

        private void picStudentClick_Click(object sender, EventArgs e)
        {
            picStudentClick.BackColor = Color.LightGray;

            picLoginClick.BackColor = Color.Gray;

            panelFormControl.Controls.Clear();
        }

        private void tmLog_Tick(object sender, EventArgs e)
        {
        }
    }
}
