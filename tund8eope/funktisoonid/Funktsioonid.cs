using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Funktsioonid{
    public static string Sorenda(string tekst) {
      return string.Join(" ", tekst.ToCharArray());
    }
    public static int pikkus(string tekst){
      return tekst.Length;
    }
    public static string nimi(string tekst) {
        return tekst.Substring(1) + tekst[0];
        //return tekst.Substring(2) + tekst[0];
    }

    public static void Main(string[] arg) {
        string[] eesnimed = { "Juku", "Kati", "Katrin", "Madis" };
	  IEnumerable<int> pikkused=eesnimed.Select(pikkus);
	  Console.WriteLine(String.Join(" ", pikkused));
        IEnumerable<string> vastus=eesnimed.Select(Sorenda);
        foreach(String element in vastus){
          Console.WriteLine(element);
        }
        foreach(String element in eesnimed){
          Console.WriteLine (nimi(element));
        } 
    }
}