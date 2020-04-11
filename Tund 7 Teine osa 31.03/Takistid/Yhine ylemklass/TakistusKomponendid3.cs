using System;
namespace TakistusKomponendid {
    class JadamisiTakistiteSalv:TakistusKomponent {
        TakistusKomponent[] Andmed;
        int KomponentideArv = 0;
        const double TyhjaSalveMaksimumVool=16;
        public JadamisiTakistiteSalv(int MaxKogus) {
            Andmed = new TakistusKomponent[MaxKogus];
        }
        public void LisaTakistusKomponent(TakistusKomponent t) {
            Andmed[KomponentideArv] = t;
            KomponentideArv++;
        }
        public override double LeiaTakistus() {
            double abi = 0;
            for (int i = 0; i < KomponentideArv; i++) {
                abi = abi + Andmed[i].LeiaTakistus();
            }
            return abi;
        }
        public override double LeiaMaksimumVool() {
            double MaxVool = TyhjaSalveMaksimumVool;
            for (int i = 0; i < KomponentideArv; i++) {
                if (Andmed[i].LeiaMaksimumVool() < MaxVool) {
                    MaxVool = Andmed[i].LeiaMaksimumVool();
                }
            }
            return MaxVool;
        }
    }
}
