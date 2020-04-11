using System;
class Tekst1{
  public static void Main(string[] arg){
    string s="Juku tuli kooli";
    Console.WriteLine("Pikkus: "+s.Length);
    Console.WriteLine(s.Substring(5, 4));
    Console.WriteLine("'tuli' kohal "+s.IndexOf("tuli"));
  }
}
