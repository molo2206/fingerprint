using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apptest.ClasseFonction
{
    public class Clsfonctions
    {
        public void Picture_Rond(PictureBox p)
        {
            System.Drawing.Drawing2D.GraphicsPath gd = new System.Drawing.Drawing2D.GraphicsPath();
            gd.AddEllipse(0, 0, p.Width - 3, p.Height - 3);
            System.Drawing.Region rg = new Region(gd);
            p.Region = rg;
        }
        public void formulaire(Form fr)
        {
            Form f = new Form();
            f.ShowDialog();
        }
        public bool Messages(int choix)
        {
            bool retour = false;
            switch (choix)
            {
                case 1:
                    //correct co = new correct();
                    //co.showdialog();
                    break;
                case 2:
                    //Incomplet i = new Incomplet();
                    //i.ShowDialog();
                    break;
                case 3:
                    //Vide v = new Vide();
                    //v.ShowDialog();
                    break;
                case 4:
                    //Modifier m = new Modifier();
                    //m.ShowDialog();
                    break;
                case 5:
                    //Confirmation cf = new Confirmation();
                    //cf.ShowDialog();
                    break;
                case 6:
                    //Erreur er = new Erreur();
                    //er.ShowDialog();
                    break;
                case 7:
                    //AutreConf autr = new AutreConf();
                    //autr.ShowDialog();
                    break;
                case 8:
                    //Invalide inv = new Invalide();
                    //inv.ShowDialog();
                    break;
            }
            return retour;
        }
        public void verifier_Character(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }
        public void verifier_Numerique(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        int nbrfois = 0;
        public int occurrence(DataGridView table, string code)
        {
            string id;
            for (int i = 0; i < table.Rows.Count - 1; i++)
            {
                id = (table.Rows[i].Cells[0].Value.ToString());
                if (id == code)
                {
                    nbrfois = +1;
                }

            }
            return nbrfois;
        }
        public void ajouter(DataGridView dt, string id, string design, int qte)
        {
            try
            {
                if (design.Equals("") || qte.Equals(""))
                {
                    MessageBox.Show("Veuilez completer les champs !");
                }
                else
                {
                    dt.Rows.Add(id, design, qte);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }
        public void chargerUserControl(Panel panel, UserControl user)
        {
            panel.Controls.Clear();
            panel.Controls.Add(user);
            panel.Show();
        }
        public void initialiserTable(DataGridView table)
        {
            int x = table.Rows.Count - 2;
            for (int y = 0; y < x; y++)
            {
                table.Rows.RemoveAt(y);
            }
        }
        int ligne;
        public void Supprimer(DataGridView table)
        {
            string indexe = table.CurrentRow.Index.ToString();
            ligne = int.Parse(indexe);
            table.Rows.RemoveAt(ligne);
        }
        string nomFichier = "";
        public void Photos(PictureBox photo)
        {
            OpenFileDialog fl = new OpenFileDialog();
            fl.Filter = "(Photo)|*.jpg;*.jpeg;*.ico|(Photo png)|*.png|(Toutes)|*.*";
            fl.ShowDialog();
            nomFichier = fl.FileName.ToString();
            photo.ImageLocation = nomFichier;
        }
        public byte[] GetBytePhoto(Image image)
        {
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(image, typeof(byte[]));
            return arr;
        }
    }
}
