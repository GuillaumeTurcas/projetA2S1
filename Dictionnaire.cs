using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projet_Final
{
    class Dictionnaire
    {
        private string[] dictionnaire; public Dictionnaire(string fichier)
        {
            StreamReader strng = null;
            try { strng = new StreamReader(fichier);
                dictionnaire = strng.ReadToEnd().Split(' '); }

            catch (FileNotFoundException f) { Console.WriteLine(f.Message); } }


        public string[] Dico { get { return dictionnaire; } }

        public override string ToString() { return "Ce dictionnaire comporte " + dictionnaire.Length + " mots."; }

        //Initialise la classe, créé le dictionnaire et le sépare pour tout mettre dans un tableau de string. Permet aussi d'appeller les variables et d'écrire les caract. du dico pour les tests

        public int  IndexMin(string mot)
        { int indexMin = 0; int lettre = mot.Length;
            if (mot.Length == 2) { return 0; }
            else {
                while (dictionnaire[indexMin].Length != lettre)
                    { indexMin++; } } return indexMin; }

        public int IndexMax(string mot) {
            int indexMax = 0;
            int lettre = mot.Length;
            if (mot.Length == 15)
            { return dictionnaire.Length; }
            while (dictionnaire[indexMax].Length != lettre + 1) 
            { indexMax++; } return indexMax; }

        //Permet de savoir quel est l'index minimal et maximal pour la recherche d'un mot d'une taille donnée. Facilitera la recherche par dichotomie recursive


        public bool RechDichoRecursif(int debut, int fin, string mot)
        {
            int milieu = (debut + fin) / 2;
            if (debut >= fin) { return false; }
            else
            {   if (string.Equals(mot, dictionnaire[milieu]) == true || string.Equals(mot, dictionnaire[milieu + 1]) == true || string.Equals(mot, dictionnaire[milieu - 1]) == true) {return true; }
                else
                {
                    try
                    {
                        if (string.Compare(dictionnaire[milieu], mot) < 0)
                        { return RechDichoRecursif(milieu + 1, fin, mot); }
                        else if (string.Compare(dictionnaire[milieu], mot) > 0)

                        { return RechDichoRecursif(debut, milieu - 1, mot); }
                        else { return false; }
                    }
                    catch(StackOverflowException)
                    {
                        return false;
                    }
 
                }
            }
        } 
        //Recherche d'un mot dans le dictionnaire par dichotomie recursive
        


    }
}
