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
        public void Run() { Start(); }

        static List<Etudiant> mesEtudiants = new();
        static List<Cours> mesCours = new();
        static List<note> mesNotes = new();
        public static void Start()
        {
            Console.Clear();
            int choix;
            Console.WriteLine("1-Creer etudiant \n 2-Afficher Etudiants \n 3-Creer cours \n " +
                              "4-Afficher les cours \n 5-Saisir les notes \n 6- Afficher les notes");

            bool boucle = true;
            do {
            int.TryParse(Console.ReadLine(), out choix);
                switch (choix)
                {
                    case 1:
                        creerEtudiant();
                        boucle = false;
                        break;
                    case 2:
                        AfficherEtudiant();
                        boucle = false;

                        break;
                    case 3:
                        CreerCours();
                        boucle = false;

                        break;
                    case 4:
                        AfficherCours();
                        boucle = false;

                        break;
                    case 5:
                        SaisirNotes();
                        boucle = false;
                        break;
                    case 6:
                        Affichernotes();
                        boucle = false;
                        break;
                    default:
                        Console.WriteLine("Veillez Entrez un choix valide");
                        break;
                }    
            }while(boucle);

        }

        public static void creerEtudiant()
        {
            Console.Clear();
            int numeroEtudiant=0;
            string nom = String.Empty;
            string prenom = String.Empty;

            do {
                Console.Write("Entrez le numero de l'etudiant");
                int.TryParse(Console.ReadLine(), out numeroEtudiant);
            }while (numeroEtudiant<0);
            Console.Clear();

            do
            {
                Console.Write("Entrez le nom de l'etudiant");
                nom = Console.ReadLine();
                } while (string.IsNullOrEmpty(nom));
            Console.Clear();
            do 
            {
                Console.Write("Entrez le prenom de l'etudiant");
                prenom = Console.ReadLine();
                }while(string.IsNullOrEmpty(prenom));

            Console.Clear();
            Console.WriteLine($"Tu viens d'ajouter l'etudiant : \n {nom} {prenom} ---- {numeroEtudiant}");

            Etudiant etudiant = new(numeroEtudiant, nom, prenom);
            mesEtudiants.Add(etudiant);
            Sauvegarde.EnregistrerEtudiant(nom, prenom, numeroEtudiant);
           Sauvegarde.ListeEtudiant(nom, prenom, numeroEtudiant);
            if (Console.ReadKey().Key == ConsoleKey.Q) Start();
        }



        public static void AfficherEtudiant()
        {
            string path = "../../../database/" + "Liste" + ".txt";
            string[] lines = File.ReadAllLines(path);
            string message = "";
            foreach (string line in lines)
            {
                message += line + "\n";
                
            }
            Console.WriteLine(message+"\n");
            if (Console.ReadKey().Key == ConsoleKey.Q) Start();
        }

        public static void CreerCours()
        {
            int numeroCours = 0;
            string code = String.Empty;
            string titre = String.Empty;

            do {
                Console.Write("Entrez le numero du cours : ");
                numeroCours = int.Parse(Console.ReadLine());
            }while(numeroCours<0);

            do {
                Console.Write("Entrez le code du cours : ");
                code = Console.ReadLine();
            }while (String.IsNullOrEmpty(code));


            do {
                Console.Write("Entrez le titre du cours");
                titre = Console.ReadLine();
            }while (string.IsNullOrEmpty(titre));

            Sauvegarde.EnregisterCours(titre, code, numeroCours);

        }



        public static void AfficherCours()
        { foreach (Cours cours in mesCours)
                Console.WriteLine(cours);
        }

        public static void SaisirNotes()
        {
            int numeroEtudiant = 0;
            double note = 0.0;
            string cours = String.Empty;

            do
            {
                Console.Write("Entrez le numero de l'etudiant");
                numeroEtudiant = int.Parse(Console.ReadLine());
                if (!Sauvegarde.NumExist(numeroEtudiant.ToString()))
                    Console.WriteLine("Le numero de l'etudiant est inccorect");

            } while (!Sauvegarde.NumExist(numeroEtudiant.ToString()));

            do {
                Console.WriteLine("Entrez le cours");
                cours = Console.ReadLine();
                if (!Sauvegarde.CoursExist(cours)) Console.WriteLine("Le cours n'existe pas");
            }while (!Sauvegarde.CoursExist(cours));

            do
            {
                Console.WriteLine("Entrez la note");
                double.TryParse(Console.ReadLine(), out note);

            }while(note < 0);

            if (note > 100||note <0) Console.WriteLine("La note est incorect");



            Sauvegarde.SauvegarderNotes(note, numeroEtudiant, cours);
        }


        public static void Affichernotes()
        {
            foreach (note note in mesNotes)
                Console.WriteLine(note);
        }

    }
}