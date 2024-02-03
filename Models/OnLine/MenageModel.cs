using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apptest.Models.OnLine
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Dataallcritere
    {
        [JsonProperty("id")]
        public string Id;

        [JsonProperty("menageid")]
        public string Menageid;

        [JsonProperty("cretereid")]
        public string Cretereid;

        [JsonProperty("created_at")]
        public DateTime CreatedAt;

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt;

        [JsonProperty("status")]
        public int Status;

        [JsonProperty("deleted")]
        public int Deleted;

        [JsonProperty("datacritere")]
        public Datacritere Datacritere;
    }

    public class Datacritere
    {
        [JsonProperty("id")]
        public string Id;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("created_at")]
        public object CreatedAt;

        [JsonProperty("updated_at")]
        public object UpdatedAt;

        [JsonProperty("status")]
        public int Status;

        [JsonProperty("deleted")]
        public int Deleted;
    }

    public class Datapersonne
    {
        [JsonProperty("id")]
        public string Id;

        [JsonProperty("nom")]
        public string Nom;

        [JsonProperty("postnom")]
        public string Postnom;

        [JsonProperty("prenom")]
        public string Prenom;

        [JsonProperty("sexe")]
        public string Sexe;

        [JsonProperty("phone_1")]
        public string Phone1;

        [JsonProperty("phone_2")]
        public string Phone2;

        [JsonProperty("roleid")]
        public string Roleid;

        [JsonProperty("typepersonneid")]
        public string Typepersonneid;

        [JsonProperty("manageid")]
        public string Manageid;

        [JsonProperty("nom_pere")]
        public string NomPere;

        [JsonProperty("nom_mere")]
        public string NomMere;

        [JsonProperty("probleme_sante")]
        public string ProblemeSante;

        [JsonProperty("lieu_naissance")]
        public string LieuNaissance;

        [JsonProperty("datenaiss")]
        public string Datenaiss;

        [JsonProperty("sous_moustiquaire")]
        public string SousMoustiquaire;

        [JsonProperty("photo")]
        public string Photo;

        [JsonProperty("femme_allaitante")]
        public string FemmeAllaitante;

        [JsonProperty("femme_enceinte")]
        public string FemmeEnceinte;

        [JsonProperty("bar_code")]
        public object BarCode;

        [JsonProperty("empreinte_digital")]
        public object EmpreinteDigital;

        [JsonProperty("created_at")]
        public DateTime CreatedAt;

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt;

        [JsonProperty("status")]
        public int Status;

        [JsonProperty("deleted")]
        public int Deleted;

        [JsonProperty("datatype_personne")]
        public DatatypePersonne DatatypePersonne;

        [JsonProperty("datarole")]
        public Datarole Datarole;
    }

    public class Datarole
    {
        [JsonProperty("id")]
        public string Id;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("created_at")]
        public object CreatedAt;

        [JsonProperty("updated_at")]
        public object UpdatedAt;

        [JsonProperty("status")]
        public int Status;

        [JsonProperty("deleted")]
        public int Deleted;
    }

    public class DatatypePersonne
    {
        [JsonProperty("id")]
        public string Id;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("created_at")]
        public object CreatedAt;

        [JsonProperty("updated_at")]
        public object UpdatedAt;

        [JsonProperty("status")]
        public int Status;

        [JsonProperty("deleted")]
        public int Deleted;
    }

    public class Datum
    {
        [JsonProperty("id")]
        public string Id;

        [JsonProperty("code_menage")]
        public string CodeMenage;

        [JsonProperty("adresse_actuel")]
        public string AdresseActuel;

        [JsonProperty("taille")]
        public int Taille;

        [JsonProperty("habitation")]
        public string Habitation;

        [JsonProperty("origine")]
        public string Origine;

        [JsonProperty("userid")]
        public string Userid;

        [JsonProperty("created_at")]
        public DateTime CreatedAt;

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt;

        [JsonProperty("status")]
        public int Status;

        [JsonProperty("deleted")]
        public int Deleted;

        [JsonProperty("dataallcritere")]
        public List<Dataallcritere> Dataallcritere;

        [JsonProperty("datapersonne")]
        public List<Datapersonne> Datapersonne;
    }

    public class Root
    {
        [JsonProperty("message")]
        public string Message;

        [JsonProperty("code")]
        public int Code;

        [JsonProperty("data")]
        public List<Datum> Data;
    }
}

