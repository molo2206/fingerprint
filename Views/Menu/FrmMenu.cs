using Apptest.ClasseFonction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Views.Indentification;

namespace test.Views.Menu
{
    public partial class FrmMenu : Form
    {
        classMenu clm = new classMenu();
        Clsfonctions fx = new Clsfonctions();
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frml = new FrmLogin();
            frml.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            clm.openChildForm(new FrmListUser(), panelPrincipale);
        }
    }
}
