using ProcessProject.DB_Access;
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
    public partial class ShowStudent : Form
    {
        public ShowStudent()
        {
            InitializeComponent();
        }

        private void _Load()
        {
            StudenAccess std = new StudenAccess();
            dgvShoStudent.DataSource = std.getStudents();
        }

        private void ShowStudent_Load(object sender, EventArgs e)
        {
            _Load();
        }

        private void dgvShowStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvShoStudent.CurrentCell.RowIndex;
            EditStudent std = new EditStudent(int.Parse(dgvShoStudent.Rows[index].Cells[0].Value.ToString()));
            AllUser.OpenChildForm(std, panelFormControl);
        }
    }
}
