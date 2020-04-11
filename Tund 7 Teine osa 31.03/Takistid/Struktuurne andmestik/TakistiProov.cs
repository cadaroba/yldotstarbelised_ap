using System;
using System.Text;
namespace Takistid {
    class TakistiProov {
        public static void Main(string[] arg) {
            Takisti t1 = new Takisti(5, 2); //5 oomi, 2 watti
            double PatareiPinge = 1.5; //volti
            if (t1.KasLubatudVõimsusVastavaltPingele(PatareiPinge)) {
                Console.WriteLine("Patareilt " + PatareiPinge + "V  saadakse " +
                    " takistiga " + t1.LeiaTakistus() + " oomi vool " + 
                      t1.LeiaVool(PatareiPinge) + "A ja " +
                    " võimsus " + t1.LeiaV6imsus(PatareiPinge) + "W");
            } else {
                Console.WriteLine("Pingel "+PatareiPinge+"V tekkiv võimsus "+
                   t1.LeiaV6imsus(PatareiPinge, false)+"W ületab lubatud "+
                   "võimsust "+t1.LeiaMaksimumV6imsus()+"W");
            }
        }
    }
}
