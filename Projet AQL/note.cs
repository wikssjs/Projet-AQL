using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AQL
{
    internal class note
    {
        private int _numCours;
        private int _note;

        public note(int numCours, int note)
        {
            NumCours = numCours;
            Note = note;
        }

        public int NumCours { get => _numCours; set => _numCours = value; }
        public int Note { get => _note; set => _note = value; }

        public override string ToString()
        {
            return $"numero de cours : {NumCours}\n Note : {Note}";
        }
    }
}
