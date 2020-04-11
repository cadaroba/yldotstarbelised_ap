using System;
class Alamprogramm{
   static int Korruta(int arv1, int arv2){
      return arv1*arv2;
   }
   public static void Main(string[] arg){
      int a=4;
      int b=6;
      Console.WriteLine("{0} korda {1} on {2}", a, b, Korruta(a, b));
      Console.WriteLine(Korruta(3, 5));
   }
}
