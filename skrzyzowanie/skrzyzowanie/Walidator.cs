using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skrzyzowanie
{
    class Walidator
    {

        bool walidacja(bool[] wektor)
        {
            if (wektor.Length != 12)
            {
                System.Console.WriteLine("zla dlugosc wektora");
                return false;
            }
            if (wektor[0])//N.lewo
            {
                //if (wektor[0]) return false;//N.lewo
                //if (wektor[1]) return false;//N.prosto
                //if (wektor[2]) return false;//N.prawo
                if (wektor[3]) return false;//E.lewo
                if (wektor[4]) return false;//E.prosto
                //if (wektor[5]) return false;//E.prawo
                if (wektor[6]) return false;//W.lewo
                if (wektor[7]) return false;//W.prosto
                //if (wektor[8]) return false;//W.prawo
                //if (wektor[9]) return false;//S.lewo
                if (wektor[10]) return false;//S.prosto
                if (wektor[11]) return false;//S.prawo
            }
            if (wektor[1])//N.prosto
            {
                //if (wektor[0]) return false;//N.lewo
                //if (wektor[1]) return false;//N.prosto
                //if (wektor[2]) return false;//N.prawo
                if (wektor[3]) return false;//E.lewo
                if (wektor[4]) return false;//E.prosto
                //if (wektor[5]) return false;//E.prawo
                if (wektor[6]) return false;//W.lewo
                if (wektor[7]) return false;//W.prosto
                if (wektor[8]) return false;//W.prawo
                if (wektor[9]) return false;//S.lewo
                //if (wektor[10]) return false;//S.prosto
                //if (wektor[11]) return false;//S.prawo
            }
            if (wektor[2])//N.prawo
            {
                //if (wektor[0]) return false;//N.lewo
                //if (wektor[1]) return false;//N.prosto
                //if (wektor[2]) return false;//N.prawo
                //if (wektor[3]) return false;//E.lewo
                if (wektor[4]) return false;//E.prosto
                //if (wektor[5]) return false;//E.prawo
                //if (wektor[6]) return false;//W.lewo
                //if (wektor[7]) return false;//W.prosto
                //if (wektor[8]) return false;//W.prawo
                if (wektor[9]) return false;//S.lewo
                //if (wektor[10]) return false;//S.prosto
                //if (wektor[11]) return false;//S.prawo
            }
            if (wektor[3])
            {
                //if (wektor[0]) return false;//N.lewo
                //if (wektor[1]) return false;//N.prosto
                //if (wektor[2]) return false;//N.prawo
                //if (wektor[3]) return false;//E.lewo
                //if (wektor[4]) return false;//E.prosto
                //if (wektor[5]) return false;//E.prawo
                //if (wektor[6]) return false;//W.lewo
                if (wektor[7]) return false;//W.prosto
                if (wektor[8]) return false;//W.prawo
                if (wektor[9]) return false;//S.lewo
                if (wektor[10]) return false;//S.prosto
                //if (wektor[11]) return false;//S.prawo
            }
            if (wektor[4])
            {
                //if (wektor[0]) return false;//N.lewo
                //if (wektor[1]) return false;//N.prosto
                //if (wektor[2]) return false;//N.prawo
                //if (wektor[3]) return false;//E.lewo
                //if (wektor[4]) return false;//E.prosto
                //if (wektor[5]) return false;//E.prawo
                if (wektor[6]) return false;//W.lewo
                //if (wektor[7]) return false;//W.prosto
                //if (wektor[8]) return false;//W.prawo
                if (wektor[9]) return false;//S.lewo
                if (wektor[10]) return false;//S.prosto
                if (wektor[11]) return false;//S.prawo
            }
            if (wektor[5])
            {
                //if (wektor[0]) return false;//N.lewo
                //if (wektor[1]) return false;//N.prosto
                //if (wektor[2]) return false;//N.prawo
                //if (wektor[3]) return false;//E.lewo
                //if (wektor[4]) return false;//E.prosto
                //if (wektor[5]) return false;//E.prawo
                if (wektor[6]) return false;//W.lewo
                //if (wektor[7]) return false;//W.prosto
                //if (wektor[8]) return false;//W.prawo
                //if (wektor[9]) return false;//S.lewo
                //if (wektor[10]) return false;//S.prosto
                //if (wektor[11]) return false;//S.prawo
            }
            if (wektor[6])
            {
                //if (wektor[0]) return false;//N.lewo
                //if (wektor[1]) return false;//N.prosto
                //if (wektor[2]) return false;//N.prawo
                //if (wektor[3]) return false;//E.lewo
                //if (wektor[4]) return false;//E.prosto
                //if (wektor[5]) return false;//E.prawo
                //if (wektor[6]) return false;//W.lewo
                //if (wektor[7]) return false;//W.prosto
                //if (wektor[8]) return false;//W.prawo
                if (wektor[9]) return false;//S.lewo
                if (wektor[10]) return false;//S.prosto
                //if (wektor[11]) return false;//S.prawo
            }
            if (wektor[7])
            {
                //if (wektor[0]) return false;//N.lewo
                //if (wektor[1]) return false;//N.prosto
                //if (wektor[2]) return false;//N.prawo
                //if (wektor[3]) return false;//E.lewo
                //if (wektor[4]) return false;//E.prosto
                //if (wektor[5]) return false;//E.prawo
                //if (wektor[6]) return false;//W.lewo
                //if (wektor[7]) return false;//W.prosto
                //if (wektor[8]) return false;//W.prawo
                if (wektor[9]) return false;//S.lewo
                if (wektor[10]) return false;//S.prosto
                //if (wektor[11]) return false;//S.prawo
            }
            if (wektor[8])
            {
                //if (wektor[0]) return false;//N.lewo
                //if (wektor[1]) return false;//N.prosto
                //if (wektor[2]) return false;//N.prawo
                //if (wektor[3]) return false;//E.lewo
                //if (wektor[4]) return false;//E.prosto
                //if (wektor[5]) return false;//E.prawo
                //if (wektor[6]) return false;//W.lewo
                //if (wektor[7]) return false;//W.prosto
                //if (wektor[8]) return false;//W.prawo
                //if (wektor[9]) return false;//S.lewo
                if (wektor[10]) return false;//S.prosto
                //if (wektor[11]) return false;//S.prawo
            }
            
            
            return true;
        }
    }
}
