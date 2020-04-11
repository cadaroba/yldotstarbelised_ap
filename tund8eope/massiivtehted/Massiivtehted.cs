using System;
using System.Collections.Generic;
using System.Linq;

class Massiivitehted {
    public static void Main(string[] arg) {
            int[] m = {2, 6, 4, 5, 3, 2};
            Console.WriteLine(string.Join(" ", m));
            IEnumerable<int> erinevad = m.Distinct();
            Console.WriteLine(string.Join(" ", erinevad));
            int[] m2 = erinevad.ToArray<int>();
            Console.WriteLine(string.Join(" ", m2));
            int[] m3 = m.Distinct().ToArray();
            Console.WriteLine(string.Join(" ", m3));

            Console.WriteLine("Elementide arv: " + m.Count());
            Console.WriteLine("Tagurpidi: " + string.Join(" ", m.Reverse()));
            Console.WriteLine("Neli esimest: " + string.Join(" ", m.Take(4)));
            Console.WriteLine("Kolm viimast: " + string.Join(" ", 
              m.Reverse().Take(3).Reverse()));
    }
}