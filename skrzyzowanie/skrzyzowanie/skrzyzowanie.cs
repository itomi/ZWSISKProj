using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skrzyzowanie
{
    class Skrzyzowanie {
        Dictionary<String, List<Pas> > Pasy = new Dictionary<String,List<Pas> >();

        public Skrzyzowanie() {
            this.Pasy.Add("N", new List<Pas> { 
                new Pas(kierunek.lewo, 10, false, 5),
                new Pas(kierunek.prosto, 10,false, 2),
                new Pas(kierunek.prawo, 10, false, 1) 
            });
            this.Pasy.Add("E", new List<Pas> { 
                new Pas(kierunek.lewo, 10, false, 5),
                new Pas(kierunek.prosto, 10,false, 2),
                new Pas(kierunek.prawo, 10, false, 1) 
            });
            this.Pasy.Add("W", new List<Pas> { 
                new Pas(kierunek.lewo, 10, false, 5),
                new Pas(kierunek.prosto, 10,false, 2),
                new Pas(kierunek.prawo, 10, false, 1) 
            });
            this.Pasy.Add("S", new List<Pas> { 
                new Pas(kierunek.lewo, 10, false, 5),
                new Pas(kierunek.prosto, 10,false, 2),
                new Pas(kierunek.prawo, 10, false, 1) 
            });
        }
    }

    enum kierunek { 
        lewo, prosto, prawo 
    };

    class Pas
    {
        kierunek kier;
        int iloscSamochodow;
        bool czyRuchDozwolony;
        int kosztWlaczenia;

        public Pas() {
        }

        public Pas(kierunek kieru, int iloscSamochodow, bool czyRuchDozwolony, int kosztWlaczenia) {
            this.kier = kieru;
            this.iloscSamochodow = iloscSamochodow;
            this.czyRuchDozwolony = czyRuchDozwolony;
            this.kosztWlaczenia = kosztWlaczenia;
        }
    }
}
