using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projet_Final
{
    class De
    {
        private string lettre;
        char lettrelance;
        public De(string lettre)
        { if (lettre.Length == 6)
            { this.lettre = lettre; }
            else { this.lettre = lettre; } }

        //Initialisation simple de la classe, en vérifiant bien que les dés soient de taille 6
       
        public void Lance(Random r)
        { int random = r.Next(0,5); this.lettrelance = lettre[random]; }

        public char Lettrelance { get { return lettrelance; } }
        public string Lettre { get { return lettre; } }

        //Fonctions permetant d'attribuer une face visible aléatoire au dé, et retourner cette dernière, ainsi que son ensemble de face

        public override string ToString()
        { return "Faces du dé: " + FaceDuDé() + "\nLa face lancé est : " + lettrelance; }

        private string FaceDuDé()
        {  string faceDuDé = ""; for (int i = 0; i < lettre.Length; i++)
            { faceDuDé += lettre[i] + " ;"; }
            return faceDuDé; }
        //Fonction permettant d'afficher les différentes carractéristiques du dé si besoin (utile pour les tests, au final on s'en sert pas)
    }
}
