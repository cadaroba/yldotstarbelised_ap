using System;
using System.Collections.Generic;
using System.Linq;

class Massiivitehted4{
    public static void Main(string[] arg) {
        int[] m = { 2, 6, 4, 5, 3, 2 };
        Console.WriteLine("Neljast suuremaid: " + m.Count(a => a > 4));
        Console.WriteLine("Neljast suuremad: "+
             string.Join(" ", m.Where(a => a > 4)));
        Console.WriteLine("Esimene neist: " + m.First(a => a > 4));

        Console.WriteLine("Kahega korrutatult: " +
             string.Join(" ", m.Select(a => a * 2)));
	    Console.WriteLine("Arvud ja ruudud: " +
             string.Join(" ", m.SelectMany(a => new int[]{a, a * a})));

			 Console.WriteLine("Kuni väärtuseni 5: " +
             string.Join(" ", m.TakeWhile(a => a != 5)));
        Console.WriteLine("Alates väärtusest 5: " +
             string.Join(" ", m.SkipWhile(a => a != 5)));
        Console.WriteLine("Kahanevalt sorditult "+ 
               string.Join(" ",m.OrderBy(a => -a)));


        int[] m1 = {181, 172, 140, 173, 189, 200, 178, 210, 199};
        Console.WriteLine("üle 180cm: " +
             string.Join(" ", m1.Where(a => a > 180)));



        int[] m2 = m1.OrderBy(a => a).ToArray();
        Console.WriteLine("jarjestatud: " +
             string.Join(" ", m2));
    }   
}