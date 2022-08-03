using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet_AQL;
namespace Projet_AQL
{
    public class Application
    {
        static List<Etudiant> mesEtudiants = new();
        static List<Cours> mesCours = new();
        static List<note> mesNotes = new();
        public static void Start()
        {
            int choix;
            Console.WriteLine("1-Creer etudiant \n 2-Afficher Etudiants \n 3-Creer cours \n " +
                              "4-Afficher les cours \n 5-Saisir les notes \n 6- Afficher les notes");

            int.TryParse(Console.ReadLine(), out choix);

            switch (choix)
            {
                case 1:
                    creerEtudiant();
                    break;
                case 2:
                    AfficherEtudiant();
                    break;
                case 3:
                    CreerCours();
                    break;
                case 4:
                    AfficherCours();
                    break;
                case 6:
                    Affichernotes();
                    break;
                    
            }

        }

        public static void creerEtudiant()
        {
            int numeroEtudiant=0;
            string nom = String.Empty;
            string prenom = String.Empty;

            Console.Write("Entrez le numero de l'etudiant");
            int.TryParse(Console.ReadLine(), out numeroEtudiant);

            Console.Write("Entrez le nom de l'etudiant");
            nom = Console.ReadLine();

            Console.Write("Entrez le prenom de l'etudiant");
            prenom = Console.ReadLine();


            Etudiant etudiant = new(numeroEtudiant, nom, prenom);
            mesEtudiants.Add(etudiant);
            EnregistrerEtudiant(nom, prenom, numeroEtudiant);
        }



        public static void AfficherEtudiant()
        {
            foreach(Etudiant etudiant in mesEtudiants)
            {
                Console.WriteLine(etudiant);
            }
        }

        public static void CreerCours()
        {
            int numeroCours = 0;
            string code = String.Empty;
            string titre = String.Empty;

            Console.Write("Entrez le numero du cours");
            int.TryParse(Console.ReadLine(), out numeroCours);

            Console.Write("Entrez le code du cours");
            code = Console.ReadLine();

            Console.Write("Entrez le titre du cours");
            titre = Console.ReadLine();

            EnregisterCours(titre,code,numeroCours);
        }



        public static void EnregistrerEtudiant(string nom,string prenom,int numEtudiant)
        {
            string path = "../../../database/Etudiant/" + nom+"_"+prenom + ".txt";
            File.WriteAllText(path, numEtudiant.ToString());        
        }

        public static void EnregisterCours(string titre,string code,int numeroCours)
        {
            string path = "../../../database/Etudiant/" + titre+ ".txt";
            File.WriteAllText(path, code);
            File.WriteAllText(path, numeroCours.ToString());
        }

        public static void AfficherCours()
        { foreach (Cours cours in mesCours)
                Console.WriteLine(cours);
            }
        public static void Affichernotes()
        {
            foreach (note note in mesNotes)
                Console.WriteLine(note);
        }

    }
}