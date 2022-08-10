using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AQL
{
    internal class Sauvegarde
    { 
        /// <summary>
        /// cette methode sert a enregistrer un etudiant
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="numEtudiant"></param>
        public static void EnregistrerEtudiant(string nom, string prenom, int numEtudiant)
        {
            string path = "../../../database/Etudiant/" + numEtudiant + ".txt";
            File.WriteAllText(path, "Nom :" + nom + "\n" + "Prenom : " + prenom);
        }
        /// <summary>
        /// cette methode sert a enregistrer un cours
        /// </summary>
        /// <param name="titre"></param>
        /// <param name="code"></param>
        /// <param name="numeroCours"></param>
        public static void EnregisterCours(string titre, string code, int numeroCours)
        {
            string path = "../../../database/Cours/" + titre + ".txt";
            File.WriteAllText(path, "CodeCours : " + code + "\n" + "NumeroCours : " + numeroCours);
        }
        /// <summary>
        /// cette methode sert a verifier que le nom d'etudiant existe
        /// </summary>
        /// <param name="numeroEtudiant"></param>
        /// <returns>true si le num existe et false si le contraire</returns>
        public static bool NumExist(int numeroEtudiant)
        {
            string path = "../../../database/Etudiant/" + numeroEtudiant + ".txt";
            return File.Exists(path);
        }
        /// <summary>
        /// cette methode sert a verifier qu'un cours existe
        /// </summary>
        /// <param name="titre"></param>
        /// <returns>true si le cours existe et false si le contraire</returns>
        public static bool CoursExist(string titre)
        {
            string path = "../../../database/Cours/" + titre + ".txt";
            return File.Exists (path);

        }
        /// <summary>
        /// cette methode sert a sauvegarder la note
        /// </summary>
        /// <param name="note"></param>
        /// <param name="numEtudiant"></param>
        /// <param name="cours"></param>
        public static void SauvegarderNotes(double note, int numEtudiant, string cours)
        {
            string path = "../../../database/Notes/" + numEtudiant + ".txt";
            File.WriteAllText(path, cours + "\n" + note);
        }
        /// <summary>
        /// cette methode sert a creer la liste d'etudiant
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="numeroEtudiant"></param>
        public static void CreerListeEtudiant(string nom, string prenom, int numeroEtudiant)
        {

            string path = "../../../database/" + "ListeD'etudiant" + ".txt";
            File.AppendAllText(path, $"\n\n Nom : {nom} \n Prenom : {prenom} \n Numero : {numeroEtudiant}\n");
        }
        /// <summary>
        /// cette methode sert a creer la liste de cours
        /// </summary>
        /// <param name="code"></param>
        /// <param name="numCours"></param>
        /// <param name="titre"></param>
        public static void CreerListeCours(string code, int numCours, string titre)
        {

            string path = "../../../database/" + "Liste_De_cours.txt";
            File.AppendAllText(path, $"\n\n Code : {code} \n Titre : {titre} \n Numero : {numCours}\n");
        }
        /// <summary>
        /// cette methode sert a creer la liste des notes des etudiants
        /// </summary>
        /// <param name="titre"></param>
        /// <param name="numEtudiant"></param>
        /// <param name="note"></param>
        public static void CreerListeNotesEtudiant(string titre, int numEtudiant, string note)
        {

            string path = "../../../database/ListeNotes/" +numEtudiant+".txt";
            File.AppendAllText(path, $"\n\n Titre : {titre} \n Note : {note}");
        }

    }
}
    

