using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AQL
{
    internal class Note
    {
        private int _numCours;
        private double _noteCours;
        private Etudiant _etudiant;

        /// <summary>
        /// le constuteur de la class note
        /// </summary>
        /// <param name="numCours"></param>
        /// <param name="note"></param>
        /// <param name="etudiant"></param>
        public Note(int numCours, double note,Etudiant etudiant)
        {
            NumCours = numCours;
            NoteCours = note;
            Etudiant = etudiant;
        }

        /// <summary>
        /// les encapsulateurs de variables de la class
        /// </summary>
        public int NumCours { get => _numCours; set => _numCours = value; }
        public double NoteCours { get => _noteCours; set => _noteCours = value; }
        internal Etudiant Etudiant { get => _etudiant; set => _etudiant = value; }
    }
}
