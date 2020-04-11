using System;
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
