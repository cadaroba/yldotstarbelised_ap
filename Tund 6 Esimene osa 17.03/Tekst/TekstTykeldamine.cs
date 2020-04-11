using System;
class Tekst3{
  public static void Main(string[] arg){
    string s="Tallinn,Tartu,Narva";
    string[] linnad=s.Split(new char[]{','});
    foreach(string linn in linnad){
       Console.WriteLine(linn);
    }
    Console.WriteLine(String.Join("; ", linnad));
  }
}
