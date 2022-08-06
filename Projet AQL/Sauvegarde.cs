using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AQL
{
    internal class Sauvegarde
    { 
        public static void EnregistrerEtudiant(string nom, string prenom, int numEtudiant)
        {
            string path = "../../../database/Etudiant/" + numEtudiant + ".txt";
            File.WriteAllText(path, "Nom :" + nom + "\n" + "Prenom : " + prenom);
        }

        public static void EnregisterCours(string titre, string code, int numeroCours)
        {
            string path = "../../../database/Cours/" + titre + ".txt";
            File.WriteAllText(path, "CodeCours : " + code + "\n" + "NumeroCours : " + numeroCours);
        }

        public static bool NumExist(int numeroEtudiant)
        {
            string path = "../../../database/Etudiant/" + numeroEtudiant + ".txt";
            return File.Exists(path);
        }

        public static bool CoursExist(string titre)
        {
            string path = "../../../database/Cours/" + titre + ".txt";
            return File.Exists (path);
        }

        public static void SauvegarderNotes(double note, int numEtudiant, string cours)
        {
            string path = "../../../database/Notes/" + numEtudiant + ".txt";
            File.WriteAllText(path, cours + "\n" + note);
        }

        public static void CreerListeEtudiant(string nom, string prenom, int numeroEtudiant)
        {

            string path = "../../../database/" + "ListeD'etudiant" + ".txt";
            File.AppendAllText(path, $"\n\n Nom : {nom} \n Prenom : {prenom} \n Numero : {numeroEtudiant}\n");
        }

        public static void CreerListeCours(string code, int numCours, string titre)
        {

            string path = "../../../database/" + "Liste_De_cours.txt";
            File.AppendAllText(path, $"\n\n Code : {code} \n Titre : {titre} \n Numero : {numCours}\n");
        }

        public static void CreerListeNotesEtudiant(string titre, int numEtudiant, string note)
        {

            string path = "../../../database/ListeNotes/" +numEtudiant+".txt";
            File.AppendAllText(path, $"\n\n Titre : {titre} \n Note : {note}");
        }

    }
}
    

