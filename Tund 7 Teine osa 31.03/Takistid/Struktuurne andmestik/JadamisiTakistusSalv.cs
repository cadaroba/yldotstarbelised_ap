using System;
using System.Text;
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
