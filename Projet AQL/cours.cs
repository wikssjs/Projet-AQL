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

        public Cours(int numCours, string code, string titre)
        {
            Code = code;
            Titre = titre;
            NumCours = numCours;
        }

        public int NumCours { get => _numcours; set => _numcours = value; }
        public string Code { get => _code; set => _code = value; }
        public string Titre { get => _titre; set => _titre = value; }
        public override string ToString()
        {
            return $"code : {Code}\n titre : {Titre} \n numcours{NumCours}";
        }
    }
}
