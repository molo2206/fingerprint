

using Apptest.ClasseFonction;
using Apptest.Connexion;
using ChurchSolution;
using ChurchSolution.ClasseModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Guna.UI2.Native.WinApi;

namespace Apptest.Controller
{
    public class ClsAuthentification
    {
        public MySqlConnection conn;
        public MySqlCommand cmd;
        public IDataReader dr = null;
        //public SqlDataAdapter datApt;
        public DataSet daset = null;
        public MySqlDataAdapter dp;
        public DataSet dst = null;
        ClsConnexion cnx = new ClsConnexion();
        Clsfonctions fx = new Clsfonctions();

        static ClsAuthentification clsAuth;

        public static ClsAuthentification GetInstance()
        {
            if (clsAuth == null)
                clsAuth = new ClsAuthentification();
            return clsAuth;
        }

        public void InitialiserConnexion()
        {
            try
            {
                cnx.connect();
                conn = new MySqlConnection(cnx.chemin);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SetParametre(IDbCommand cmd, string name, DbType type, int length, object valeurname)
        {
            //Déclaration et la création de l'objet parametre sur l'objet commande
            IDbDataParameter param = cmd.CreateParameter();
            //Affectation du nom de parametre sur la variable parametre créée
            param.ParameterName = name;
            //Affectation de la longueur du parametre
            param.Size = length;
            //Affectation de type de données au parametre créé
            param.DbType = type;
            if (valeurname == null)
            {
                param.DbType = DbType.String;
                param.Value = DBNull.Value;
            }
            else
                param.Value = valeurname;
            cmd.Parameters.Add(param);
        }
        public void CreateUser(ClsUtilisateur objetuser, int choix)
        {
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = conn.CreateCommand();
                switch (choix)
                {
                    case 1:
                        cmd.CommandText = "insert into t_users values (@id,@full_name,@email,@phone,@profil,@fingerprint,@gender) ";
                        SetParametre(cmd, "@id", DbType.Int32, 50, objetuser.id);
                        SetParametre(cmd, "@full_name", DbType.String, 50, objetuser.full_name);
                        SetParametre(cmd, "@email", DbType.String, 50, objetuser.email);
                        SetParametre(cmd, "@phone", DbType.String, 50, objetuser.phone);
                        if (objetuser.profil != null)
                            SetParametre(cmd, "@profil", DbType.Binary, Int32.MaxValue, objetuser.profil);
                        else
                            SetParametre(cmd, "@profil", DbType.Binary, Int32.MaxValue, DBNull.Value);
                        SetParametre(cmd, "@fingerprint", DbType.String, 20000, objetuser.fingerprint);
                        SetParametre(cmd, "@gender", DbType.String, 50, objetuser.genre);
                        cmd.ExecuteNonQuery();
                            MessageBox.Show("Enregistrement reçu!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 2:
                        //cmd.CommandText = "update Membre set nom_complet=@nom,sexe=@sexe,adresse=@adresse,etat_civil=@etatcivil,phone=@phone,photo=@photo,CODE_CELLULE=@cellule,date_modif=@date_modif where code=@code";
                        //SetParametre(cmd, "@code", DbType.String, 50, pt.Code.ToUpper());
                        //SetParametre(cmd, "@nom", DbType.String, 50, pt.Nom.ToUpper());
                        //SetParametre(cmd, "@sexe", DbType.String, 50, pt.Sexe.ToUpper());
                        //SetParametre(cmd, "@Adresse", DbType.String, 50, pt.Adresse.ToUpper());
                        //SetParametre(cmd, "@etatcivil", DbType.String, 50, pt.EtaCivil.ToUpper());
                        //SetParametre(cmd, "@phone", DbType.String, 50, pt.Phone.ToUpper());
                        //if (pt.Photo != null)
                        //    SetParametre(cmd, "@photo", DbType.Binary, Int32.MaxValue, pt.Photo);
                        //else
                        //    SetParametre(cmd, "@photo", DbType.Binary, Int32.MaxValue, DBNull.Value);
                        //SetParametre(cmd, "@cellule", DbType.String, 50, pt.Cellule.ToUpper());
                        //SetParametre(cmd, "@date_modif", DbType.String, 50, pt.Date);
                        //cmd.ExecuteNonQuery(); fx.Messages(1);
                        break;
                    case 3:
                        //cmd.CommandText = "delete from Membre where Id_Memb=@id";
                        //MessageBox.Show("Suppression reçu!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }

                cmd.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }
        public void chargementGridOptimise(string mysql, DataGridView grid)
        {
            try
            {
                InitialiserConnexion();
                conn.Open();
                MySqlDataAdapter n = new MySqlDataAdapter(mysql, conn);
                System.Data.DataTable v = new DataTable();
                n.Fill(v);
                grid.DataSource = v;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Autocomplete(string rqt, string colone, TextBox auto)
        {
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new MySqlCommand(rqt, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    auto.AutoCompleteCustomSource.Add(dr[colone].ToString());

                }
                cmd.Dispose();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }

        }
        public string Test_fingerprint(string colonne)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new MySqlCommand("select * from t_users where full_name='" + colonne + "'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["fingerprint"].ToString());

                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return resultat;
        }

        public string VerifyFingerPrint(string colonne)
        {
            string resultat = "";
            try
            {
                InitialiserConnexion();
                if (!conn.State.ToString().ToLower().Equals("open")) conn.Open();
                cmd = new MySqlCommand("select * from t_users where fingerprint like '%" + colonne + "%'", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resultat = (dr["full_name"].ToString());

                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();

            }
            return resultat;
        }

        public void Photo(string table, string text, PictureBox pict)
        {
            try
            {
                InitialiserConnexion();
                cmd = new MySqlCommand("select profil from " + table + " where fingerprint='" + text + "'", conn);
                MySqlDataAdapter dap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dap.Fill(ds);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    Byte[] dat = new Byte[0];
                    dat = (Byte[])(ds.Tables[0].Rows[0]["profil"]);
                    MemoryStream men = new MemoryStream(dat);
                    pict.Image = System.Drawing.Image.FromStream(men);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public void Fingerprint(string table, string text, PictureBox pict)
        {
            try
            {
                InitialiserConnexion();
                cmd = new MySqlCommand("select * from " + table + " where full_name='" + text + "'", conn);
                MySqlDataAdapter dap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dap.Fill(ds);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    Byte[] dat = new Byte[0];
                    dat = (Byte[])(ds.Tables[0].Rows[0]["profil"]);
                    MemoryStream men = new MemoryStream(dat);
                    pict.Image = System.Drawing.Image.FromStream(men);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }

   

}
