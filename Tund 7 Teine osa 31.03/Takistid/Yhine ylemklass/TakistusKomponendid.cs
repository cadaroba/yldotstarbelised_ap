using System;
namespace TakistusKomponendid {
    abstract class TakistusKomponent {
        public abstract double LeiaTakistus();
        public abstract double LeiaMaksimumVool();
        public double LeiaVoolVastavaltPingele(double Pinge) {
            return Pinge / LeiaTakistus();
        }
        public bool KasLubatudPinge(double Pinge) {
            return LeiaVoolVastavaltPingele(Pinge) < LeiaMaksimumVool();
        }
    }
}

namespace TakistusKomponendid {
    class Takisti:TakistusKomponent {
        protected double R, MaxN;
        public Takisti(double Takistus, double MaksimumV6imsus) {
            this.R = Takistus;
            this.MaxN = MaksimumV6imsus;
        }
        public override double LeiaTakistus() {
            return R;
        }
        public override double LeiaMaksimumVool() {
            return Math.Sqrt(MaxN / R);
        }
    }
}

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

namespace TakistusKomponendid {
    class TakistusKomponentideProov {
        public static void Main(string[] arg) {
            JadamisiTakistiteSalv ts1 = 
                new JadamisiTakistiteSalv(5);
            ts1.LisaTakistusKomponent(new Takisti(10, 2));
            ts1.LisaTakistusKomponent(new Takisti(10, 1));
            JadamisiTakistiteSalv ts2 = 
                new JadamisiTakistiteSalv(5);
            ts2.LisaTakistusKomponent(new Takisti(15, 10));
            JadamisiTakistiteSalv ts3 = 
                new JadamisiTakistiteSalv(5);
            ts3.LisaTakistusKomponent(ts1);
            ts3.LisaTakistusKomponent(ts2);
            Console.WriteLine("Esimese salve maksimumvool: " +
                  ts1.LeiaMaksimumVool());
            Console.WriteLine("Teise salve maksimumvool: " +
                  ts2.LeiaMaksimumVool());
            Console.WriteLine("Kolmanda salve maksimumvool: " +
                  ts3.LeiaMaksimumVool());
        }
    }
}
