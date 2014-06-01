using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skrzyzowanie
{
    class GeneratorSkrzyzowania
    {
        public Skrzyzowanie generujSkrzyzowanie(int minLiczbaSamochodow, int maxLiczbaSamochodow, int wartoscLewo, int wartosProsto, int wartoscPrawo)
        {
            Random random=new Random();

            if (minLiczbaSamochodow < 0) minLiczbaSamochodow = 0;
            if (maxLiczbaSamochodow < 1) maxLiczbaSamochodow = 1;
            
            int nl = random.Next(minLiczbaSamochodow, maxLiczbaSamochodow);
            int nf = random.Next(minLiczbaSamochodow, maxLiczbaSamochodow);
            int nr = random.Next(minLiczbaSamochodow, maxLiczbaSamochodow);
            int el = random.Next(minLiczbaSamochodow, maxLiczbaSamochodow);
            int ef = random.Next(minLiczbaSamochodow, maxLiczbaSamochodow);
            int er = random.Next(minLiczbaSamochodow, maxLiczbaSamochodow);
            int wl = random.Next(minLiczbaSamochodow, maxLiczbaSamochodow);
            int wf = random.Next(minLiczbaSamochodow, maxLiczbaSamochodow);
            int wr = random.Next(minLiczbaSamochodow, maxLiczbaSamochodow);
            int sl = random.Next(minLiczbaSamochodow, maxLiczbaSamochodow);
            int sf = random.Next(minLiczbaSamochodow, maxLiczbaSamochodow);
            int sr = random.Next(minLiczbaSamochodow, maxLiczbaSamochodow);

            int lv = wartoscLewo;
            int fv = wartosProsto;
            int rv = wartoscPrawo;

            if (wartoscLewo < 0)
            {
                lv = random.Next(-wartoscLewo + 1);
            }
            if (wartoscLewo < 0)
            {
                fv = random.Next(-wartosProsto + 1);
            }
            if (wartoscLewo < 0)
            {
                rv = random.Next(-wartoscPrawo + 1);
            }

            return new Skrzyzowanie(nl, nf, nr, el, ef, er, wl, wf, wr, sl, sf, sr, lv, fv, rv);

        }
    }
}
