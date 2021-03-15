using ProcessProject.OtherClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessProject.OtherForm
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void _Load()
        {
            picShowStudent.BackColor = Color.LightGray;
            picAddNewStudent.BackColor = Color.Gray;
            ShowStudent std = new ShowStudent();
            AllUser.OpenChildForm(std, panelFormControl);
        }

        private void Student_Load(object sender, EventArgs e)
        {
            _Load();
        }

        private void picShowStudent_Paint(object sender, PaintEventArgs e)
        {
            AllUser.PanitEvent(e, "Show", "Microsoft Sans Serif", 14, Brushes.Black, new Point(2, 2));
        }

        private void picAddNewStudent_Paint(object sender, PaintEventArgs e)
        {
            AllUser.PanitEvent(e, "Add", "Microsoft Sans Serif", 14, Brushes.Black, new Point(2, 2));
        }

        private void picShowStudent_Click(object sender, EventArgs e)
        {
            _Load();
        }

        private void picAddNewStudent_Click(object sender, EventArgs e)
        {
            picAddNewStudent.BackColor = Color.LightGray;
            picShowStudent.BackColor = Color.Gray;

            AddStudent std = new AddStudent();
            AllUser.OpenChildForm(std, panelFormControl);
        }
    }
}
