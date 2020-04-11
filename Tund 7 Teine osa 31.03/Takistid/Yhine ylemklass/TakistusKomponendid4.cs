using System;
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
