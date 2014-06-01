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
            this.Pasy.Add("N", new List<Pas> { new Pas(kierynek) });
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
