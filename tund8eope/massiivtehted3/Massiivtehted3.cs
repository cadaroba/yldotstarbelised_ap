using System;
using System.Collections.Generic;
using System.Linq;

class Massiivitehted3
{
    public static void Main(string[] arg)
    {
        string[] jukukeeled = { "eesti", "vene" };
        string[] katikeeled = { "eesti", "soome", "inglise" };
        Console.WriteLine("Kahe peale oskavad: " + 
             string.Join(" ",jukukeeled.Union(katikeeled)));
        Console.WriteLine("Mõlemad oskavad (ühisosa): " +
             string.Join(" ", jukukeeled.Intersect(katikeeled)));
        Console.WriteLine("Ainult Juku oskab: " +
             string.Join(" ", jukukeeled.Except(katikeeled)));
        Console.WriteLine("Kõik oskused loetelus: " +
             string.Join(" ", jukukeeled.Concat(katikeeled)));

        int[] m1 = {9, 4, 1, 10, 21, 11, 19};
        int[] m2 = {5, 34, 18, 6, 16, 13, 15};
        int[] m3 = {74, 60, 112, 110, 42, 223, 4};
        Console.WriteLine(": " + string.Join(" ", m1.Intersect(m2).Intersect(m3)));
        Console.WriteLine(": " + string.Join(" ", m1.Except(m2)));
        Console.WriteLine(": " + string.Join(" ", m1.Union(m2).Union(m3)));

    }
}