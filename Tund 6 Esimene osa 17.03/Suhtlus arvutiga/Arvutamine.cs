using System;
class Arvutus{
   public static void Main(string[] arg){
      Console.WriteLine("pikkus:");
      string tekst1=Console.ReadLine();
      int arv1=int.Parse(tekst1);
      Console.WriteLine("laius:");
      int arv2=int.Parse(Console.ReadLine());
      Console.WriteLine("pikkus {0} ja {1} laiuse korrutis on {2} ruutmeetrit",
              arv1, arv2, arv1*arv2);
   }
}
