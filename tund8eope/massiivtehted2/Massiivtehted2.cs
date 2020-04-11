			  
using System;
using System.Collections.Generic;
using System.Linq;


class Massiivitehted2{
    public static void Main(string[] arg) {
        int[] m = { 2, 6, 4, 5, 3, 2 };
        Console.WriteLine("Algne: " + string.Join(" ", m));
        Console.WriteLine("Elementide arv: " + m.Count());
        Console.WriteLine("Tagurpidi: " + string.Join(" ", m.Reverse()));
        Console.WriteLine("Neli esimest: " + string.Join(" ", m.Take(4)));
        Console.WriteLine("Kolm viimast: " + string.Join(" ", 
              m.Reverse().Take(3).Reverse()));

        Console.WriteLine("Suurim: " + m.Max());
        Console.WriteLine("Vähim: " + m.Min());
        Console.WriteLine("Summa: " + m.Sum());
        Console.WriteLine("Keskmine: " + m.Average());
        Console.WriteLine("Sisaldab 3: " + m.Contains(3));
        
        int[] m1 = {1, 3, 2, 4, 6, 5, 10, 9, 8, 7, 11, 13, 12, 14, 16, 15, 18 , 17, 19};
        Console.WriteLine("Suurim: " + m1.Max());
        Console.WriteLine("Nelja esimese arvu summa: " + string.Join(" ", m1.Take(4).Sum()));
        int[] m2 = m1.Take(4).ToArray();
        Console.WriteLine("Algne: " + string.Join(" ", m2));
        Console.WriteLine("Tagurpidi: " + string.Join(" ", m2.Reverse()));
    }
}