using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skrzyzowanie
{
    class Skrzyzowanie {
        Dictionary<String, List<Pas> > Pasy = new Dictionary<String,List<Pas> >();
        ArrayList wszystkiePasy = new ArrayList();
        public Skrzyzowanie() {
            
            List<Pas> nPasy =new List<Pas> { 
                new Pas(kierunek.lewo, 10, false, 5),
                new Pas(kierunek.prosto, 10,false, 2),
                new Pas(kierunek.prawo, 10, false, 1) 
                };
            this.Pasy.Add("N", nPasy);

            List<Pas> ePasy = new List<Pas> { 
                new Pas(kierunek.lewo, 10, false, 5),
                new Pas(kierunek.prosto, 10,false, 2),
                new Pas(kierunek.prawo, 10, false, 1) 
                };
            this.Pasy.Add("E", ePasy);

            List<Pas> wPasy = new List<Pas> { 
                new Pas(kierunek.lewo, 10, false, 5),
                new Pas(kierunek.prosto, 10,false, 2),
                new Pas(kierunek.prawo, 10, false, 1) 
                };
            this.Pasy.Add("W", wPasy);

            List<Pas> sPasy = new List<Pas> { 
                new Pas(kierunek.lewo, 10, false, 5),
                new Pas(kierunek.prosto, 10,false, 2),
                new Pas(kierunek.prawo, 10, false, 1) 
                };
            this.Pasy.Add("S", sPasy);

            wszystkiePasy.AddRange(nPasy);
            wszystkiePasy.AddRange(ePasy);
            wszystkiePasy.AddRange(wPasy);
            wszystkiePasy.AddRange(sPasy);

        }

        public int modifyState(bool[] swiatla)
        {
            int najwieksza = 0;
            for (int i = 0; i < swiatla.Length;i++)
            {
                if (swiatla[i])
                {
                    Pas foo = (Pas)wszystkiePasy[i];
                    int wyzerowana = foo.wyzeroj();
                    if (wyzerowana > najwieksza) najwieksza = wyzerowana;
                }
            }
            return najwieksza;
        }

        public bool isEmpty()
        {
            foreach(KeyValuePair<String, List<Pas> > pas in Pasy) {
                List<Pas> pasyList = pas.Value;
                foreach (Pas pasik in pasyList)
                {
                    if (Convert.ToBoolean(pasik.getIloscSamochodow())) {
                        return false;
                    }
                }
            }
            return false;
        }
    }

    enum kierunek { 
        lewo, prosto, prawo 
    };

    class Pas
    {
        kierunek kier;
        int iloscSamochodow;
        bool czyRuchDozwolony { get; set; }
        int kosztWlaczenia { get; set; }
        int licznik;

        public Pas() {
        }

        public Pas(kierunek kieru, int iloscSamochodow, bool czyRuchDozwolony, int kosztWlaczenia)  {
            this.kier = kieru;
            this.iloscSamochodow = iloscSamochodow;
            this.czyRuchDozwolony = czyRuchDozwolony;
            this.kosztWlaczenia = kosztWlaczenia;
        }

        public int getIloscSamochodow()
        {
            return this.iloscSamochodow;
        }

        public int wyzeroj()
        {
            int foo = iloscSamochodow;
            iloscSamochodow = 0;
            return foo;
        }
    }
}
