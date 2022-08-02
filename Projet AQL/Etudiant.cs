using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AQL
{
    internal class Etudiant
    {
        private int _numEtudiant ;
        private string _nom;
        private string _prenom;

        public Etudiant(int numEtudiant,string nom,string prenom)
        {
            Prenom = prenom;
            Nom = nom;
            NumEtudiant = numEtudiant;
        }

        public int NumEtudiant { get => _numEtudiant; set => _numEtudiant = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }

        public override string ToString()
        {
            return $"Prenom : {Prenom}\n Nom : {Nom} \n NumEtudiant{NumEtudiant}";
        }
    }
}
