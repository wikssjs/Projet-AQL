using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AQL
{
    internal class Sauvegarde
    { //NomClass : Sauvegarde
        //Commence ici
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

        public static bool NumExist(string numeroEtudiant)
        {
            string path = "../../../database/Etudiant/" + numeroEtudiant + ".txt";
            return File.Exists(path);
        }

        public static bool CoursExist(string cours)
        {
            string path = "../../../database/Cours/" + cours + ".txt";
            return File.Exists(path);
        }

        public static void SauvegarderNotes(double note, int numEtudiant, string cours)
        {
            string path = "../../../database/Notes/" + numEtudiant + ".txt";
            File.WriteAllText(path, note + "\n" + cours);
        }

        public static void ListeEtudiant(string nom, string prenom, int numeroEtudiant)
        {

            string path = "../../../database/" + "Liste" + ".txt";
            File.AppendAllText(path, $"\n\n  Nom : {nom} \n Prenom : {prenom} \n Numero : {numeroEtudiant}\n");
        }

        //fini ici

    }
}
    

