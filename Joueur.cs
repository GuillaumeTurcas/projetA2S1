using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Projet_Final
{
    class Joueur
    {
        private int score;
        private string[] motstrouves;
        private string nom; private int indexJ;
        public Joueur(string nom, int score, string[] motstrouves, int indexJ)
        { this.nom = nom; this.score = score; this.motstrouves = motstrouves; this.indexJ = indexJ; }
        
        //Initialisation de la classe avec ses variables. Une liste aurait ete plus adapte a la place du tableau de string mais vu que les consignes n'etaient pas claires, j'ai change au dernier moment pour un tableau pour etre sure de respecter les consignes

        public string Nom { get { return nom; } }
        public int IndexJ { get { return indexJ; } set { indexJ = value; } } //Seul solution trouve pour savoir combien de mot a trouve le joueur et se balader dans le tableau de string beaucoup plus facilement ainsi
        public int Score { get { return score; } set { score = value; } }
        public string[] Motstrouves { get { return motstrouves; } set { motstrouves = value; } }

        //Permet l'appel des différentes variables et en modifier certaines
        
        public bool Contain(string mot) 
        {   bool contain = true;
            for (int i = 0; i < motstrouves.Length; i++)
            { if(motstrouves[i] == mot) { contain = false; } }
            return contain;
        }

        //Vérifie que le mot n'appartient pas au dictionnaire

        public override string ToString()
        { return "Nom du Joueur : " + nom + "\nScore : " + score; }

        public void AfficherMots()
        {
            int i = 0;
            while (i < indexJ - 1)
            {
                Console.Write(motstrouves[i] + "; ");
                i++;
            }
            Console.WriteLine(motstrouves[i]);
        }

        public void Add_Mot (string mot)
        {
            motstrouves[indexJ] = mot;
        }
        //Affiche  les carrectéristiques du joueur + commande pour ajouter un mot à sa liste
        
    }
}
