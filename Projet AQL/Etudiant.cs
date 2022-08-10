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
        /// <summary>
        /// le constuteur de la class etudiant
        /// </summary>
        /// <param name="numEtudiant"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        public Etudiant(int numEtudiant,string nom,string prenom)
        {
            Prenom = prenom;
            Nom = nom;
            NumEtudiant = numEtudiant;
        }
        /// <summary>
        /// les encapsulateurs de variables de la class
        /// </summary>
        public int NumEtudiant { get => _numEtudiant; set => _numEtudiant = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }

        public override string ToString()
        {
            return $"Prenom : {Prenom}\n Nom : {Nom} \n NumEtudiant{NumEtudiant}";
        }
    }
}
