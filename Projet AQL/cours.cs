using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AQL
{

    internal class Cours
    {
        private int _numcours;
        private string _code;
        private string _titre;
        /// <summary>
        /// le constuteur de la class cours
        /// </summary>
        /// <param name="numCours"></param>
        /// <param name="code"></param>
        /// <param name="titre"></param>
        public Cours(int numCours, string code, string titre)
        {
            Code = code;
            Titre = titre;
            NumCours = numCours;
        }
        /// <summary>
        /// les encapsulateurs de variables de la class
        /// </summary>
        public int NumCours { get => _numcours; set => _numcours = value; }
        public string Code { get => _code; set => _code = value; }
        public string Titre { get => _titre; set => _titre = value; }


       
    }
}
