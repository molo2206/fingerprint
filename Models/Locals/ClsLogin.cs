using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchSolution.ClasseTraitement
{
    public class ClsLogin
    {

        string code, codeAgent, fonction, nomUser, pwd;
        int niveau;

        public string Code { get; set; }
        public string CodeAgent { get; set; }
        public string Fonction { get; set; }
        public string NomUser { get; set; }
        public string Pwd { get; set; }
        public int Niveau { get; set; }
        public DateTime Date { get; set; }
        //=====================login==========================
        string id, username, motDepasse, fonction1, idAgent;
        int niveau1, codeentreprise;
        public string Id { get; set; }
        public string Username { get; set; }
        public string MotDepasse { get; set; }
        public string Fonction1 { get; set; }
        public string IdAgent { get; set; }
        public int Niveau1 { get; set; }
        public int Code_entreprise { get; set; }
        public string Menu { get; set; }

    }
}
