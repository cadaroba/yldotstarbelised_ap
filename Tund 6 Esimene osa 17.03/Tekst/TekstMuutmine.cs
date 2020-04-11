using System;
class Tekst2{
  public static void Main(string[] arg){
    string s="Juku tuli kooli";
    Console.WriteLine("Pikkus: "+s.Length);
    Console.WriteLine(s.Substring(5, 4));
    Console.WriteLine("'tuli' kohal "+s.IndexOf("tuli"));
    string s2=s.Insert(9, " vara");
    Console.WriteLine(s2);
    string s3=s.Remove(5, 5); //Kuuendast alates viis tähte
    Console.WriteLine(s3);
    if(s.StartsWith("Juku")){
       Console.WriteLine("Algab Jukuga");
    }
    if(s.IndexOf("kala")==-1){
       Console.WriteLine("Siin ei ole kala");
    }
    Console.WriteLine(s.Replace("tuli", "jooksis"));
  }
}
