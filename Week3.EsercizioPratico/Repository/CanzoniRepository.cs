using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.EsercizioPratico
{
    class CanzoniRepository : IRepository<Canzone>
    {
        static List<Canzone> canzone = new List<Canzone>
        {
            //canzone.Add(new Canzone("Bad Habits",
            //    Author("Nome1","Cognome1", new DateTime(1998)),
            //    GenereEnum.Pop)),

            /*TODO:Ho incontrato un errore di sintassi, so che il modo di scrivere non è come scritto
                   di seguito, ma l'ho voluto lasciare solo per la stampa, commento quello precedente perchè è come
                   l'avrei voluto scrivere ma mi da errore*/ 

            new Canzone("Superclassico", 
                new FileMultimediali.Autore("Nome2","Cognome2", new DateTime(1888)), 
                GenereEnum.Opera),

            new Canzone("Beggin", 
                new FileMultimediali.Autore("Nome3","Cognome3", new DateTime(1968)), 
                GenereEnum.Rock)
        };
    
        public List<Canzone> Fetch()
        {
            return canzone;
        }
    };
}
