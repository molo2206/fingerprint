using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchSolution
{
   public class ClsMembre
    {
        //string code,code_agent ,nom, postnom, prenom, sexe, adresse, etatcivile, phone, cellule;
        //byte[] photo;
        //int barcode;

        public string Code { get; set; }
        public string Code_Servi { get; set; }
        public string Code_Agent { get; set; }
        public string Code_fonction { get; set; }
        public string Nom { get; set; }
        public string Postnom { get; set; }
        public string Prenom { get; set; }
        public string Sexe { get; set; }
        public string Adresse { get; set; }
        public string EtaCivil { get; set; }
        public string Phone { get; set; }
        public string Cellule { get; set; }
        public string Mail { get; set; }
        public string Ministere { get; set; }
        public byte[] Photo { get; set; }
        public int Barcode { get; set; }
        public string Date { get; set; }
        public string Date_naiss { get; set; }
        public string Lieu { get; set; }
    }
}
