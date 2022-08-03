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
            EnregistrerEtudiant(nom, prenom, numeroEtudiant);
            ListeEtudiant(nom, prenom, numeroEtudiant);
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

            EnregisterCours(titre, code, numeroCours);

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
                if (!NumExist(numeroEtudiant.ToString()))
                    Console.WriteLine("Le numero de l'etudiant est inccorect");

            } while (!NumExist(numeroEtudiant.ToString()));

            do {
                Console.WriteLine("Entrez le cours");
                cours = Console.ReadLine();
                if (!CoursExist(cours)) Console.WriteLine("Le cours n'existe pas");
            }while (!CoursExist(cours));

            do
            {
                Console.WriteLine("Entrez la note");
                double.TryParse(Console.ReadLine(), out note);

            }while(note < 0);

            if (note > 100||note <0) Console.WriteLine("La note est incorect");



            SauvegarderNotes(note, numeroEtudiant, cours);
        }


        public static void Affichernotes()
        {
            foreach (note note in mesNotes)
                Console.WriteLine(note);
        }

        //NomClass : Sauvegarde
        //Commence ici
        public static void EnregistrerEtudiant(string nom,string prenom,int numEtudiant)
        {
            string path = "../../../database/Etudiant/" +numEtudiant + ".txt";
            File.WriteAllText(path,"Nom :"+nom+"\n"+ "Prenom : "+prenom);        
        }

        public static void EnregisterCours(string titre,string code,int numeroCours)
        {
            string path = "../../../database/Cours/" + titre+ ".txt";
            File.WriteAllText(path, "CodeCours : "+code+"\n"+"NumeroCours : "+numeroCours);
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

        public static void SauvegarderNotes(double note,int numEtudiant,string cours)
        {
            string path = "../../../database/Notes/" + numEtudiant + ".txt";
            File.WriteAllText(path,note+"\n"+cours);
        }

        public static void ListeEtudiant(string nom ,string prenom,int numeroEtudiant)
        {

            string path = "../../../database/" + "Liste" + ".txt";
            File.AppendAllText(path,$"\n\n  Nom : {nom} \n Prenom : {prenom} \n Numero : {numeroEtudiant}\n");
        }

        //fini ici

    }
}