using System;
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
