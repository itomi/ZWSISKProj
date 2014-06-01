using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skrzyzowanie
{
    class Skrzyzowanie
    {
        Dictionary<String, Pas> Pasy = new Dictionary<string,Pas>();



    }

    class Pas
    {
        enum kierunek { lewo, prosto, prawo };
        kierunek kier;
        int iloscSamochodow;
        bool czyRuchDozwolony;
        int kosztWlaczenia;
    }
}
