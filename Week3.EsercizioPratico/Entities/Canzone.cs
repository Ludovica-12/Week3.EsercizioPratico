using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.EsercizioPratico
{
    class Canzone : FileMultimediali
    {
         public GenereEnum Genere { get; set; }

        public Canzone(string titolo, Autore author, GenereEnum genere)
            : base(titolo, author)
        {
            Genere = genere;
        }

        public Canzone()
        {

        }

        public override string Print()
        {
            return $"{base.Print()} - {Genere}";
        }


    }

    public enum GenereEnum
    {
        Pop,
        Rock,
        Opera,
    }
    
}
