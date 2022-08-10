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
        static readonly List<Note> mesNotes = new();

        /// <summary>
        /// Lancer l'application
        /// </summary>
        public static void Start()
        {
            Console.Clear();
            int choix;
            Console.WriteLine("\t0-Quitter \n \t1-Creer etudiant \n \t2-Afficher Etudiants \n \t3-Creer cours \n " +
                              "\t4-Afficher les cours \n \t5-Saisir les notes \n \t6- Afficher les notes");

            bool boucle = true;
            do {
                Console.Write(" >");
            int.TryParse(Console.ReadLine(), out choix);
                switch (choix)
                {
                    case 0:
                        boucle = false; 
                        break;
                    case 1:
                        CreerEtudiant();
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
                        AfficherNotes();
                        boucle = false;
                        break;
                    default:
                        Console.WriteLine("Veillez Entrez un choix valide !");
                        break;
                }    
            }while(boucle);

        }
        /// <summary>
        /// cette methode sert a creer un etudiant 
        /// </summary>
        public static void CreerEtudiant()
        {
            Console.Clear();
            int numeroEtudiant=0;
            string nom = String.Empty;
            string prenom = String.Empty;

            do {
                Console.Write("Entrez le numero de l'etudiant : ");
                int.TryParse(Console.ReadLine(), out numeroEtudiant);

                if (Sauvegarde.NumExist(numeroEtudiant))
                {
                    Console.WriteLine("Numero incorrect");
                    continue;
                }
            }while (numeroEtudiant<0||Sauvegarde.NumExist(numeroEtudiant));

            Console.Clear();

            do
            {
                Console.Write("Entrez le nom de l'etudiant : ");
                nom = Console.ReadLine();
                } while (string.IsNullOrEmpty(nom));

            Console.Clear();

            do 
            {
                Console.Write("Entrez le prenom de l'etudiant : ");
                prenom = Console.ReadLine();
                }while(string.IsNullOrEmpty(prenom));

            Console.Clear();
            Console.WriteLine($"Tu viens d'ajouter l'etudiant : \n {nom} {prenom} ---- {numeroEtudiant}");
            Console.WriteLine("Appuyer su 'Q' pour retourner au menu");

            Etudiant etudiant = new(numeroEtudiant, nom, prenom);
            mesEtudiants.Add(etudiant);
            Sauvegarde.EnregistrerEtudiant(nom, prenom, numeroEtudiant);
           Sauvegarde.CreerListeEtudiant(nom, prenom, numeroEtudiant);

            if (Console.ReadKey().Key == ConsoleKey.Q) Start();
        }


        /// <summary>
        /// cette methode sert a afficher un etudiant 
        /// </summary>
        public static void AfficherEtudiant()
        {
            Console.Clear();
            string path = "../../../database/" + "ListeD'etudiant" + ".txt";
            string[] lines = File.ReadAllLines(path);
            string message = "";

            foreach (string line in lines)
            {
                message += line + "\n";
                
            }

            Console.WriteLine(message+"\n");
            Console.WriteLine("Appuyer sur 'Q' pour quitter");

            if (Console.ReadKey().Key == ConsoleKey.Q) Start();
        }
        /// <summary>
        /// cette methode sert a creer un cours
        /// </summary>
        public static void CreerCours()
        {
            Console.Clear();
            int numeroCours = 0;
            string code = String.Empty;
            string titre = String.Empty;

            do {
                Console.Write("Entrez le titre du cours : ");
                titre = Console.ReadLine();
            }while (string.IsNullOrEmpty(titre));

            do {
                Console.Write("Entrez le numero du cours : ");
                int.TryParse(Console.ReadLine(),out numeroCours);
            }while(numeroCours<0);

            do {
                Console.Write("Entrez le code du cours : ");
                code = Console.ReadLine();
            }while (String.IsNullOrEmpty(code));


            Cours cours = new(numeroCours, code, titre);
            mesCours.Add(cours);
            Sauvegarde.EnregisterCours(titre, code, numeroCours);
            Sauvegarde.CreerListeCours(code,numeroCours,titre);
            Console.WriteLine("Apuyer sur 'Q' pour quitter");

            if (Console.ReadKey().Key == ConsoleKey.Q) Start();
        }


        /// <summary>
        /// cette methode sert a afficher un cours
        /// </summary>
        public static void AfficherCours()
        {
            Console.Clear();
            string path = "../../../database/" + "Liste_De_cours" + ".txt";
            string[] lines = File.ReadAllLines(path);
            string message = "";
            foreach (string line in lines)
            {
                message += line + "\n";

            }
            Console.WriteLine(message + "\n");
            Console.WriteLine("Appuyer sur 'Q' pour quitter");
            if (Console.ReadKey().Key == ConsoleKey.Q) Start();
        }
        /// <summary>
        /// cette methode sert a saisir une note d'un etudiant
        /// </summary>
        public static void SaisirNotes()
        {
            Console.Clear();

            int numeroEtudiant = 0;
            double noteCours = 0.0;
            string titre= String.Empty;

            do
            {
                    Console.Write("Entrez le numero de l'etudiant : ");
                    int.TryParse(Console.ReadLine(),out numeroEtudiant);
                
                    if (!Sauvegarde.NumExist(numeroEtudiant))
                    {
                        Console.WriteLine("Le numero de l'etudiant est inccorect");
                    }

            } while (!Sauvegarde.NumExist(numeroEtudiant));


            do
            {
                Console.WriteLine("Entrez le cours : ");
                titre = Console.ReadLine();
                if (!Sauvegarde.CoursExist(titre)) Console.WriteLine("Le cours n'existe pas");
            }while (!Sauvegarde.CoursExist(titre));

            do
            {
                Console.WriteLine("Entrez la note : ");
                double.TryParse(Console.ReadLine(), out noteCours);
            if (noteCours > 100||noteCours <0) Console.WriteLine("La note doit etre entre 0 et 100");

            }while(noteCours < 0||noteCours >100);

            Sauvegarde.CreerListeNotesEtudiant(titre,numeroEtudiant,noteCours.ToString());

            Start();

        }

        /// <summary>
        /// cette methode sert a afficher les notes d'un etudiant
        /// </summary>
        public static void AfficherNotes()
        {
                int numeroEtudiant = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Entrez numero de l'etudiant");
                int.TryParse(Console.ReadLine(), out numeroEtudiant);
            } while (numeroEtudiant < 0 || !Sauvegarde.NumExist(numeroEtudiant));

            string path = "../../../database/ListeNotes/"+numeroEtudiant+".txt";
            string[] lines = File.ReadAllLines(path);
            string message = "";
            foreach (string line in lines)
            {
                message += line + "\n";

            }
            Console.WriteLine(message + "\n");
            if (Console.ReadKey().Key == ConsoleKey.Q) Start();
        }
         
    }
}