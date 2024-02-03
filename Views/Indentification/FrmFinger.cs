using AxZKFPEngXControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxZKFPEngXControl;
using Apptest.Controller;
using ChurchSolution.ClasseModel;
using Apptest.ClasseFonction;
using Guna.UI2.WinForms;

namespace test.Views.Indentification
{
    public partial class FrmFinger : Form
    {
        ClsUtilisateur cu = new ClsUtilisateur();
        ClsAuthentification auth = new ClsAuthentification();
        Clsfonctions fx = new Clsfonctions();
        ClsAuthentification clsauth = new ClsAuthentification();

        private AxZKFPEngX ZkFprint = new AxZKFPEngX();
        private bool Check;
        public FrmFinger()
        {
            InitializeComponent();
        }
        private void FrmFinger_Load(object sender, EventArgs e)
        {
            Controls.Add(ZkFprint);
            InitialAxZkfp();
            clsauth.chargementGridOptimise("select * from t_users", tableuser);
        }

        private void InitialAxZkfp()
        {
            try
            {
                ZkFprint.OnImageReceived += zkFprint_OnImageReceived;
                ZkFprint.OnFeatureInfo += zkFprint_OnFeatureInfo;
                //zkFprint.OnFingerTouching 
                //zkFprint.OnFingerLeaving
                ZkFprint.OnEnroll += zkFprint_OnEnroll;

                if (ZkFprint.InitEngine() == 0)
                {
                    ZkFprint.FPEngineVersion = "9";
                    ZkFprint.EnrollCount = 3;
                    deviceSerial.Text += " " + ZkFprint.SensorSN + " Count: " + ZkFprint.SensorCount.ToString() + " Index: " + ZkFprint.SensorIndex.ToString();
                    ShowHintInfo("Device successfully connected");
                }

            }
            catch (Exception ex)
            {
                ShowHintInfo("Device init err, error: " + ex.Message);
            }
        }

        private void zkFprint_OnImageReceived(object sender, IZKFPEngXEvents_OnImageReceivedEvent e)
        {
            Graphics g = fpicture.CreateGraphics();
            Bitmap bmp = new Bitmap(fpicture.Width, fpicture.Height);
            g = Graphics.FromImage(bmp);
            int dc = g.GetHdc().ToInt32();
            ZkFprint.PrintImageAt(dc, 0, 0, bmp.Width, bmp.Height);
            g.Dispose();
            fpicture.Image = bmp;
        }

        private void zkFprint_OnFeatureInfo(object sender, IZKFPEngXEvents_OnFeatureInfoEvent e)
        {

            String strTemp = string.Empty;
            if (ZkFprint.EnrollIndex != 1)
            {
                if (ZkFprint.IsRegister)
                {
                    if (ZkFprint.EnrollIndex - 1 > 0)
                    {
                        int eindex = ZkFprint.EnrollIndex - 1;
                        strTemp = "Please scan again ..." + eindex;
                    }
                }
            }
            ShowHintInfo(strTemp);
        }
        private void zkFprint_OnEnroll(object sender, IZKFPEngXEvents_OnEnrollEvent e)
        {
            if (e.actionResult)
            {
                string template = ZkFprint.EncodeTemplate1(e.aTemplate);
                txtTemplate.Text = template;
                ShowHintInfo("Registration successful. You can verify now");
                btnRegister.Enabled = false;
                btnVerify.Enabled = true;
            }
            else
            {
                ShowHintInfo("Error, please register again.");

            }
        }
        private void zkFprint_OnCapture(object sender, IZKFPEngXEvents_OnCaptureEvent e)
        {
            string template = ZkFprint.EncodeTemplate1(e.aTemplate);
            //txtTemplate1.Text = template;
            for (int x = 0; x < tableuser.Rows.Count - 1; x++)
            {
                if (ZkFprint.VerFingerFromStr(ref template, tableuser.Rows[x].Cells[5].Value.ToString(), false, ref Check))
                {
                    full_name.Text = clsauth.VerifyFingerPrint(tableuser.Rows[x].Cells[5].Value.ToString());
                    //clsauth.Photo("t_users", clsauth.VerifyFingerPrint(tableuser.Rows[x].Cells[5].Value.ToString()),profil);
                    clsauth.Fingerprint("t_users", full_name.Text, profil);
                    ShowHintInfo("Verified");
                }
                else
                    ShowHintInfo("Not Verified");
                    //full_name.Text = "";
                    //profil.Image = null;
            }
          
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ZkFprint.CancelEnroll();
            ZkFprint.EnrollCount = 3;
            ZkFprint.BeginEnroll();
            ShowHintInfo("Please give fingerprint sample.");
        }
        private void ShowHintInfo(String s)
        {
            prompt.Text = s;
        }
        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (ZkFprint.IsRegister)
            {
                ZkFprint.CancelEnroll();
            }
            ZkFprint.OnCapture += zkFprint_OnCapture;
            ZkFprint.BeginCapture();
            ShowHintInfo("Please give fingerprint sample.");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            fpicture.Image = null;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTemplate.Text.Equals(""))
                {
                    MessageBox.Show("Ajouter avant tout ton empreint digital!");
                }
                else
                {
                    cu.full_name = full_name.Text;
                    cu.genre = gender.Text;
                    cu.email = email.Text;
                    cu.phone = phone.Text;
                    cu.fingerprint = txtTemplate.Text;
                    cu.profil = fx.GetBytePhoto(profil.Image);
                    auth.CreateUser(cu, 1);
                    clsauth.chargementGridOptimise("select * from t_users", tableuser);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
        void effacer()
        {
            full_name.Text = null;
            profil.Image = null; 
            fpicture.Image = null;


        }

        private void profil_Click(object sender, EventArgs e)
        {
            fx.Photos(profil);
        }
    }
}
