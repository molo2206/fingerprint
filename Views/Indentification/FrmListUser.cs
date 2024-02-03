using Apptest.Controller;
using ChurchSolution.ClasseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace test.Views.Indentification
{

    public partial class FrmListUser : Form
    {
        ClsAuthentification clsauth = new ClsAuthentification();
        ClsUtilisateur cu = new ClsUtilisateur();
        ClsAuthentification auth = new ClsAuthentification();
        public FrmListUser()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FrmFinger frmFinger = new FrmFinger();
            frmFinger.ShowDialog();
        }

        

        private void FrmListUser_Load(object sender, EventArgs e)
        {
            clsauth.chargementGridOptimise("select * from t_users", tableuser);
        }
    }
}
