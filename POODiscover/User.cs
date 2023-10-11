using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POODiscover
{
    public class User
    {
        public const string UserPrefixe = "Player";

        //champ (field)
        private int idUser;

        //propriété (property)
        public int IdUser
        {
            get { return idUser; }
            set { idUser = value; }
        }


        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime BirthDate{ get; set; }

        public Sexe SexeUser { get; set; }

        public enum Sexe
        {
            Homme, 
            Femme
        }
    }
}
