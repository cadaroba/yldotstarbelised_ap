using System;
using System.Text;
namespace Takistid {
    class Takisti {
        /// <summary>
        /// Takistus
        /// </summary>
        protected double R;
        /// <summary>
        /// Maksimumvõimsus
        /// </summary>
        protected double MaxN;
        public Takisti(double Takistus, double Maksimumv6imsus) {
            this.R = Takistus;
            this.MaxN = Maksimumv6imsus;
        }
        public double LeiaVool(double Pinge) {
            return Pinge / R;
        }
        public double LeiaV6imsus(double Pinge, bool SobivusKontroll) {
            double V6imsus=Pinge * LeiaVool(Pinge);
            if (SobivusKontroll) {
                if (V6imsus > MaxN) {
                    throw new Exception("Pingel " + Pinge + " ületab võimsus " +
                       V6imsus + " lubatud maksimumvõimsust " + MaxN);
                }
            }
            return V6imsus;
        }
        public double LeiaV6imsus(double Pinge) {
            return LeiaV6imsus(Pinge, true);
        }
        public bool KasLubatudVõimsusVastavaltPingele(double Pinge) {
            return LeiaV6imsus(Pinge, false) <= MaxN;
        }
        public double LeiaMaksimumVool() {
            return Math.Sqrt(MaxN / R);
        }
        public double LeiaTakistus() {
            return R;
        }
        public double LeiaMaksimumV6imsus() {
            return MaxN;
        }
    }
}

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