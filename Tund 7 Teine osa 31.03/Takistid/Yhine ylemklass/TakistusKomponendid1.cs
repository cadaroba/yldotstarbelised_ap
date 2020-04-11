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
