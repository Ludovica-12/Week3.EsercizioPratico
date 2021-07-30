using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.EsercizioPratico
{
    class FileMultimediali
    {
        public string Titolo { get; set; }

        public Autore Author { get; set; }

        public FileMultimediali(string titolo, Autore author)
        {
            Titolo = titolo;
            Author = author;
        }

        public FileMultimediali()
        {

        }

        public virtual string Print()
        {
            return $"{Titolo} - {Author}";
        }

        internal struct Autore
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime AnnoDiNascita { get; set; }

            public Autore(string firstName, string lastName, DateTime annoDiNascita)
            {
                FirstName = firstName;
                LastName = lastName;
                AnnoDiNascita = annoDiNascita;
            }
        }
    }
}
