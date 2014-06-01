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

        public Skrzyzowanie(int nl, int nf, int nr, int el, int ef, int er, int wl, int wf, int wr, int sl, int sf, int sr, int lv, int fv, int rv)
        {

            List<Pas> nPasy = new List<Pas> { 
                new Pas(kierunek.lewo, nl, false, lv),
                new Pas(kierunek.prosto, nf,false, fv),
                new Pas(kierunek.prawo, nr, false, rv) 
                };
            this.Pasy.Add("N", nPasy);

            List<Pas> ePasy = new List<Pas> { 
                new Pas(kierunek.lewo, el, false, lv),
                new Pas(kierunek.prosto, ef,false, fv),
                new Pas(kierunek.prawo, er, false, rv) 
                };
            this.Pasy.Add("E", ePasy);

            List<Pas> wPasy = new List<Pas> { 
                new Pas(kierunek.lewo, wl, false, lv),
                new Pas(kierunek.prosto, wf,false, fv),
                new Pas(kierunek.prawo, wr, false, rv) 
                };
            this.Pasy.Add("W", wPasy);

            List<Pas> sPasy = new List<Pas> { 
                new Pas(kierunek.lewo, sl, false, lv),
                new Pas(kierunek.prosto, sf,false, fv),
                new Pas(kierunek.prawo, sr, false, rv) 
                };
            this.Pasy.Add("S", sPasy);

            wszystkiePasy.AddRange(nPasy);
            wszystkiePasy.AddRange(ePasy);
            wszystkiePasy.AddRange(wPasy);
            wszystkiePasy.AddRange(sPasy);

        }

        private void setPasy(ArrayList pasy)
        {
            this.wszystkiePasy = pasy;
        }

        private void setDictPasy(Dictionary<String, List<Pas>> dict)
        {
            this.Pasy = dict;
        }

        public Tuple<int, int, int> modifyState(bool[] swiatla)
        {
            int najwieksza = 0;
            int suma = 0;
            int iloscStojacych = 0;

            for (int i = 0; i < swiatla.Length;i++)
            {
                if (swiatla[i])
                {
                    Pas foo = (Pas)wszystkiePasy[i];
                    int wyzerowana = foo.wyzeroj();
                    suma += wyzerowana;
                    if (wyzerowana > najwieksza) najwieksza = wyzerowana;
                }
            }

            for(int i=0;i<wszystkiePasy.Count;i++)
            {
                Pas foo = (Pas)wszystkiePasy[i];
                iloscStojacych+=foo.getIloscSamochodow();
            }
            Tuple<int, int, int> zmiany = new Tuple<int, int, int>(najwieksza, suma, iloscStojacych);//największa,suma
            return zmiany;
        }

        public bool isEmpty()
        {
            foreach (Pas pasik in wszystkiePasy)
            {
                if(Convert.ToBoolean(pasik.getIloscSamochodow())) {
                    return false;
                }
            }
            return true;
        }

        public bool isEmpty2()
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
            return true;
        }

        public Skrzyzowanie copy()
        {
            Skrzyzowanie s = new Skrzyzowanie();
            ArrayList listaPasow = new ArrayList();
            Dictionary<String, List<Pas> > dictionary = new Dictionary<String,List<Pas>>();

            foreach(Pas pas in this.wszystkiePasy) {
                listaPasow.Add(pas.copy());
            }

            s.setPasy(listaPasow);

            object[] pasy = (listaPasow.GetRange(0, 3).ToArray());
            dictionary.Add("N", new List<Pas>{ (Pas)pasy[0], (Pas)pasy[1], (Pas)pasy[2] });
            pasy = (listaPasow.GetRange(3, 3).ToArray());
            dictionary.Add("E", new List<Pas> { (Pas)pasy[0], (Pas)pasy[1], (Pas)pasy[2] });
            pasy = (listaPasow.GetRange(6, 3).ToArray());
            dictionary.Add("W", new List<Pas> { (Pas)pasy[0], (Pas)pasy[1], (Pas)pasy[2] });
            pasy = (listaPasow.GetRange(9, 3).ToArray());
            dictionary.Add("S", new List<Pas>{ (Pas)pasy[0], (Pas)pasy[1], (Pas)pasy[2] });

            return s;
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

        public Pas copy()
        {
            return new Pas(this.kier, this.iloscSamochodow, this.czyRuchDozwolony, this.kosztWlaczenia);
        }
    }
}
