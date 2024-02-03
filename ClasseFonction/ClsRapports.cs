using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apptest.ClasseFonction
{
    public class ClsRapports
    {
        private static ClsRapports rapport;
        //  Rapport_Contribution_mansuelle rap = new Rapport_Contribution_mansuelle();

        public ClsRapports GetInstance()
        {
            if (rapport == null)
                rapport = new ClsRapports();
                return rapport;
        }

        //public DataSet liste(string requete)
        //{
        //    gl.InitialiserConnexion();

        //    try
        //    {
        //        gl.conn.Open();
        //        gl.cmd = new SqlCommand(requete, gl.conn);
        //        gl.dp = new SqlDataAdapter(gl.cmd);
        //        gl.dst = new DataSet();
        //        gl.dp.Fill(gl.dst, requete);
        //        gl.conn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    return gl.dst;

        //}
        //public DataSet listes(string table, string colone, string champ)
        //{
        //    gl.InitialiserConnexion();

        //    try
        //    {
        //        gl.conn.Open();
        //        gl.cmd = new SqlCommand(" select * from " + table + " where '" + colone + "''" + champ + "'", gl.conn);
        //        gl.dp = new SqlDataAdapter(gl.cmd);
        //        gl.dst = new DataSet();
        //        gl.dp.Fill(gl.dst, table);
        //        gl.conn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    return gl.dst;

        //}
        //public DataSet listeup(string table, string colonne1, string dp)
        //{
        //    gl.InitialiserConnexion();

        //    try
        //    {
        //        gl.conn.Open();
        //        gl.cmd = new SqlCommand("SELECT * from " + table + " where " + colonne1 + " = '" + dp + "'", gl.conn);

        //        gl.dp = new SqlDataAdapter(gl.cmd);
        //        gl.dst = new DataSet();
        //        gl.dp.Fill(gl.dst, table);
        //        gl.conn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    return gl.dst;

        //}
        //public DataSet Selection_Date(string date1, string date2)
        //{
        //    gl.InitialiserConnexion();

        //    try
        //    {
        //        gl.conn.Open();
        //        gl.cmd = new SqlCommand("select * from V_CULTE where DATE_CULTE between CONVERT(varchar(10), '" + date1 + "', 103) and CONVERT(varchar(10), '" + date2 + "', 103)", gl.conn);
        //        gl.dp = new SqlDataAdapter(gl.cmd);
        //        gl.dst = new DataSet();
        //        gl.dp.Fill(gl.dst, "V_CULTE");
        //        gl.conn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    return gl.dst;
        //}
        //public DataSet list(string bon)
        //{
        //    gl.InitialiserConnexion();

        //    try
        //    {
        //        gl.conn.Open();
        //        gl.cmd = new SqlCommand("select * from [V_Operation_fINISH 4] where code ='" + bon + "'", gl.conn);
        //        gl.dp = new SqlDataAdapter(gl.cmd);
        //        gl.dst = new DataSet();
        //        gl.dp.Fill(gl.dst, "[V_Operation_fINISH 4]");
        //        gl.conn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    return gl.dst;
        //}
        //public DataSet Selection_Date_bapteme(string date1, string date2)
        //{
        //    gl.InitialiserConnexion();

        //    try
        //    {
        //        gl.conn.Open();
        //        gl.cmd = new SqlCommand("select * from V_bapteme where DATE_OPERATION between CONVERT(varchar(10), '" + date1 + "', 103) and CONVERT(varchar(10), '" + date2 + "', 103)", gl.conn);
        //        gl.dp = new SqlDataAdapter(gl.cmd);
        //        gl.dst = new DataSet();
        //        gl.dp.Fill(gl.dst, "V_bapteme");
        //        gl.conn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    return gl.dst;
        //}
        //public DataSet Selection_Date_concen(string date1, string date2)
        //{
        //    gl.InitialiserConnexion();

        //    try
        //    {
        //        gl.conn.Open();
        //        gl.cmd = new SqlCommand("select * from V_Concencration where DATE between CONVERT(varchar(10), '" + date1 + "', 103) and CONVERT(varchar(10), '" + date2 + "', 103)", gl.conn);
        //        gl.dp = new SqlDataAdapter(gl.cmd);
        //        gl.dst = new DataSet();
        //        gl.dp.Fill(gl.dst, "V_Concencration");
        //        gl.conn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    return gl.dst;
        //}
        //public DataSet Selection_Presence(string date1)
        //{
        //    gl.InitialiserConnexion();

        //    try
        //    {
        //        gl.conn.Open();
        //        gl.cmd = new SqlCommand("select * from V_SELECT_PRESENCE where convert(date, date_presence, 103) = convert(date,'" + date1 + "', 103)", gl.conn);
        //        gl.dp = new SqlDataAdapter(gl.cmd);
        //        gl.dst = new DataSet();
        //        gl.dp.Fill(gl.dst, "V_SELECT_PRESENCE");
        //        gl.conn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    return gl.dst;
        //}
        //public DataSet Selection_Date_oper(string date1, string date2)
        //{
        //    gl.InitialiserConnexion();

        //    try
        //    {
        //        gl.conn.Open();
        //        gl.cmd = new SqlCommand("select * from [V_Operation_Montant] where ADDDATE between CONVERT(varchar(10), '" + date1 + "', 103) and CONVERT(varchar(10), '" + date2 + "', 103)", gl.conn);
        //        gl.dp = new SqlDataAdapter(gl.cmd);
        //        gl.dst = new DataSet();
        //        gl.dp.Fill(gl.dst, "V_Operation_Montant");
        //        gl.conn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    return gl.dst;
        //}
        //public DataSet journal(string date1, string date2)
        //{
        //    gl.InitialiserConnexion();

        //    try
        //    {
        //        gl.conn.Open();
        //        gl.cmd = new SqlCommand("select * from Journal_Filtre where date between CONVERT(varchar(10), '" + date1 + "', 103) and CONVERT(varchar(10), '" + date2 + "', 103)", gl.conn);
        //        gl.dp = new SqlDataAdapter(gl.cmd);
        //        gl.dst = new DataSet();
        //        gl.dp.Fill(gl.dst, "Journal_Filtre");
        //        gl.conn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    return gl.dst;
        //}

    }
}
