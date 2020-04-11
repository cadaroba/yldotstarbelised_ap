using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;


namespace linq2 {
    class TasandiPunkt {
        int x, y;
        public TasandiPunkt(int ux, int uy) {
            x = ux; y = uy;
        }
        public int KysiX() { return x; }
        public int KysiY() { return y; }
        public override String ToString() { return "(" + x + " " + y + ")"; }
    }
    class RuutudeLooja {
        int kogus;
        public RuutudeLooja(int uusKogus) {
            kogus = uusKogus;
        }
        public IEnumerable<int> Ruudud() {
            for (int i = 1; i <= kogus; i++) {
                yield return i * i;
            }
        }
    }
    class Klassid {
        public static void Main(string[] arg) {
            TasandiPunkt[] punktid = { 
                new TasandiPunkt(3, 5),
                new TasandiPunkt(4, 6) 
             };
            IEnumerable<TasandiPunkt> vastus = 
			     from p in punktid where p.KysiX() > 3 select p;
            Console.WriteLine(string.Join(" ", vastus));
            IEnumerable<TasandiPunkt> vastus2 =  punktid.Where(p => p.KysiX()>3);
            Console.WriteLine(string.Join(" ", vastus2));
            Console.WriteLine(string.Join(" ", 
			     from p in punktid where p.KysiX() > 3 select p.KysiY()));
            Console.WriteLine(string.Join(" ", 
			     punktid.Where(p => p.KysiX()>3).Select(p=>p.KysiY())));

		    RuutudeLooja r = new RuutudeLooja(5);
            Console.WriteLine(string.Join(" ", r.Ruudud().Where(arv => arv > 10)));
            
            // Inimene[] inimene = {
            //     new Inimene(200, "Peep")
            // };
        }
    }
}

//     class Inimene{
//         string nimi;
//         int pikkus;
//         public Inimene(string unimi, int upikkus) {
//             nimi = unimi; pikkus = upikkus;
//         }
//         public string KysiNimi() {return nimi;}
//         public int KysiPikkus() {return pikkus;}
//         public override String ToString() {return nimi + " " + pikkus;}

//     }
// }
