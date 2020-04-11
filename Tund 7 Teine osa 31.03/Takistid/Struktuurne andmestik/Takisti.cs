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
