using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchSolution.ClasseModel
{
  public  class ClsUtilisateur
    {
        public int id { get; set; }
        public string full_name { get; set; }
        public string email { get; set; }
        public string genre { get; set; }
        public byte[] profil { get; set; }
        public string phone { get; set; }
        public string fingerprint { get; set; }
    }
}
