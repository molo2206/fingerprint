using Apptest.Connexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apptest.Connexion
{
    public class ClsConfiguration
    {
        public static String connec;
        public static String dataS;
        public static String initcat;
        public static String id;
        public static String pass;
        public static String niveau;
        //===================
        public static int testlog;
        public static String codfact;
        public static string codrec;

        public static void TestFile()
        {
            if (System.IO.Directory.Exists(ClsConstante.Table.InitialDirectory) == true) { }

            else
            {
                Directory.CreateDirectory(ClsConstante.Table.InitialDirectory);
            }

            if (File.Exists(ClsConstante.Table.chemin) == true)
            {

            }
            else
            {
                //FrmServeur frm = new FrmServeur();
                //frm.ShowDialog();
            }
        }
    }
}
