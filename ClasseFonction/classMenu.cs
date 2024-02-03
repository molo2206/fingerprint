using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apptest.ClasseFonction
{
    public class classMenu
    {
        private Form activeForm = null;
        public void openChildForm(Form childForm,Panel pane)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pane.Controls.Add(childForm);
            pane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
