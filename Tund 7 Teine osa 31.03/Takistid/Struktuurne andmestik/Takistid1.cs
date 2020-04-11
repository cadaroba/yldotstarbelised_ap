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
    class JadamisiTakistusSalv {
        Takisti[] Andmed;
        int TakistiteArv = 0;
        const int TyhjaSalveMaksimumvool = 16;
        public JadamisiTakistusSalv(int TakistiteMaksimumArv) {
            Andmed = new Takisti[TakistiteMaksimumArv];
        }
        public void LisaTakisti(Takisti t) {
            if (TakistiteArv < Andmed.Length) {
                Andmed[TakistiteArv] = t;
                TakistiteArv++;
            } else {
                throw new Exception("Takistussalv täis!");
            }
        }
        public double LeiaKoguTakistus() {
            double summa = 0;
            for (int i = 0; i < TakistiteArv; i++) {
                summa = summa + Andmed[i].LeiaTakistus();
            }
            return summa;
        }
        public double LeiaMaksimumVool() {
            double MaxVool = TyhjaSalveMaksimumvool;
            for (int i = 0; i < TakistiteArv; i++) {
                if (Andmed[i].LeiaMaksimumVool() < MaxVool) {
                    MaxVool = Andmed[i].LeiaMaksimumVool();
                }
            }
            return MaxVool;
        }
        public bool KasLubatudV6imsusVastavaltPingele(double Pinge) {
            double TekkivVool = Pinge / LeiaKoguTakistus();
            return TekkivVool <= LeiaMaksimumVool();
        }
    }
}

namespace Takistid {
    class TakistusSalveProov {
        public static void Main(string[] arg) {
            JadamisiTakistusSalv Salv = new JadamisiTakistusSalv(5);
            Salv.LisaTakisti(new Takisti(10, 1));
            Salv.LisaTakisti(new Takisti(10, 2));
            Console.WriteLine("Kogutakistus: "+Salv.LeiaKoguTakistus());
            Console.WriteLine("Maksimumvool: " + Salv.LeiaMaksimumVool());
            Console.WriteLine("Kas 12 Volti salve klemmidel lubatud: " +
                                    Salv.KasLubatudV6imsusVastavaltPingele(12));
        }
    }
}
