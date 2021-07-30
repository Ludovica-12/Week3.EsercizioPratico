using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.EsercizioPratico
{
    class Podcast : FileMultimediali
    {

        public Episodio Episode { get; set; }

        public Podcast(string titolo, Autore author, Episodio episode)
            : base (titolo, author)
        {
            Episode = episode;
        }

        public Podcast()
        {

        }

        public override string Print()
        {
            return $"{base.Print()} - {Episode}";
        }



        internal struct Episodio
        {
            public string Titolo;
            public bool Flag;
            public TimeSpan Durata { get; set; }

            public Episodio(string titolo, bool flag, TimeSpan durata)
            {
                Titolo = titolo;
                Flag = flag;
                Durata = durata;
            }
        }
    }
}
