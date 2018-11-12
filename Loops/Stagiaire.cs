using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public class Stagiaire
    {
        #region proprietes
        private int id_Stagiaire;
        private string prenom;      
        private int id_Teacher;
        #endregion
        #region Constructeurs
        public Stagiaire(string Prenom, int Idteacher, int IdStagiaire)
        {
            prenom = Prenom;           
            Id_Teacher = Idteacher;
            Id_Stagiaire = IdStagiaire;
        }

        public Stagiaire() { }
        #endregion
        #region Accesseurs
        public string Prenom { get => prenom; set => prenom = value; }
        public int Id_Stagiaire { get => id_Stagiaire; set => id_Stagiaire = value; }
        public int Id_Teacher { get => id_Teacher; set => id_Teacher = value; }
        #endregion
        #region ToString
        public override string ToString()
        {
            return "id: "+Id_Stagiaire+" prenom: "+Prenom;
        }
        #endregion
        #region methodes
        public List<Stagiaire> GetStagiairesList()
        {
            var stagiairesList = new List<Stagiaire>();

            stagiairesList.Add(new Stagiaire("Narimane", 1, 1));
            stagiairesList.Add(new Stagiaire("Pauline", 2, 2));
            stagiairesList.Add(new Stagiaire("Chloe", 3, 3));
            stagiairesList.Add(new Stagiaire("Nathalie", 3, 4));
            stagiairesList.Add(new Stagiaire("Marion", 2, 5));
            stagiairesList.Add(new Stagiaire("Marion", 1, 6));
            stagiairesList.Add(new Stagiaire("Amine", 1, 7));
            stagiairesList.Add(new Stagiaire("Fatima", 2, 8));
            stagiairesList.Add(new Stagiaire("Jonathan", 3, 9));
            stagiairesList.Add(new Stagiaire("Johan", 2, 10));
            stagiairesList.Add(new Stagiaire("Nabil", 1, 11));

            return stagiairesList;
        }
        
        #endregion
    }
}

