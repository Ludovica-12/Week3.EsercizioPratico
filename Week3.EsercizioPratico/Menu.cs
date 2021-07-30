using System;
using System.Collections.Generic;

namespace Week3.EsercizioPratico
{
    static class Menu
    {
        public static CanzoniRepository canzoniR = new CanzoniRepository();
        public static PodcastRepository podcastR = new PodcastRepository();
        internal static void Start()
        {
            bool continuare = true;
            int scelta;

            while (continuare)
            {
                Console.WriteLine("Premi 1 per visualizzare tutte le Canzoni");
                Console.WriteLine("Premi 2 per visualizzare tutti i Podcast");
                Console.WriteLine("Premi 3 per visualizzare i Generi delle Canzoni");
                Console.WriteLine("Premi 0 per uscire");

                do
                {
                    Console.WriteLine("\nFai la tua scelta\n");
                } while (!int.TryParse(Console.ReadLine(), out scelta));

                switch (scelta)
                {
                    case 1:
                        {
                            List<Canzone> canzone = canzoniR.Fetch();
                            Stampa(canzone);
                            break;
                        }
                    case 2:
                        {
                            List<Podcast> podcast = podcastR.Fetch();
                            Stampa(podcast);
                            break;
                        }
                    case 3:
                        {
                            ScegliGenere();
                            break;
                        }
                    case 0:
                        {
                            continuare = false;
                            break;
                        }
                }
            }
        }

        private static void ScegliGenere()
        {
            Console.WriteLine("Scegli tra questi Generi");
            char option;

            do
            {
                Console.WriteLine("Premi 1 per visualizzare le Canzoni °°°POP°°°");
                Console.WriteLine("Premi 2 per visualizzare le Canzoni °°°ROCK°°°");
                Console.WriteLine("Premi 3 per visualizzare le Canzoni °°°OPERA°°°");
                Console.WriteLine("Premi q per uscire");

                option = Console.ReadKey().KeyChar;
                switch (option)
                {
                    //TODO: ciclare la lista delle canzoni e tramite enum scegliere il genere richiesto

                    case '1':
                       
                        break;
                    case '2':
                        
                        break;
                    case '3':
                      
                        break;
                    case 'q':
                        //Esci
                        Console.WriteLine("\nRitorna Presto!");
                        return;
                    default:
                        Console.WriteLine("Scelta non disponibile. Riprova!");
                        break;
                }

            } while (!(option == 'q'));


        }

        private static void Stampa(List<Canzone> canzoni)
        {
            foreach(var canzone in canzoni)
            {
                Console.WriteLine(canzone.Print());
            }
        }
        private static void Stampa(List<Podcast> podcasts)
        {
            foreach (var podcast in podcasts)
            {
                Console.WriteLine(podcast.Print());
            }
        }
    }
}