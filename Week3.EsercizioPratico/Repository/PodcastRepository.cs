using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.EsercizioPratico
{ 
    class PodcastRepository : IRepository<Podcast>
    {
        static List<Podcast> podcast = new List<Podcast>
        {
            //podcast.Add(new Podcast(("Titolo1"),
            //    Autore("Nome1","Cognome1", new DateTime(1998)),
            //    Episodio("Terzo",false,new TimeSpan (55,35,60)))),

            /*TODO:Ho incontrato un errore di sintassi, so che il modo di scrivere non è come scritto
                   di seguito, ma l'ho voluto lasciare solo per la stampa, commento quello precedente perchè è come
                   l'avrei voluto scrivere ma mi da errore*/

            new Podcast(("Titolo2"),
                new Podcast.Autore("Nome2","Cognome2", new DateTime(1994)),
                new Podcast.Episodio("Primo",false,new TimeSpan (52,60,60))),

            new Podcast(("Titolo3"),
                new Podcast.Autore("Nome3","Cognome3", new DateTime(1978)),
                new Podcast.Episodio("Quarto",false,new TimeSpan (34,35,12))),
        };
        public List<Podcast> Fetch()
        {
            return podcast;
        }
    }
}
