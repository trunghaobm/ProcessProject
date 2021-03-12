using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessProject.OtherClass
{
    class AllUser
    {

        public static void OpoenChildForm(Form childform, Panel childform_pnl)
        {
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            childform_pnl.Controls.Add(childform);
            childform_pnl.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
    }
}
