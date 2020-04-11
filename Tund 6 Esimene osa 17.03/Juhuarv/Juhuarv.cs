using System;
public class Juhuarv1{
   public static void Main(string[] arg){
      Random r=new Random();
      Console.WriteLine(r.NextDouble()); //Nullist üheni
      Console.WriteLine(r.Next(20)); //Täisarv alla 20
      Console.WriteLine(r.Next(50, 100)); //Viiekümnest sajani
      string[] nimed={"Juku", "Kati", "Mati"};
      Console.WriteLine(nimed[r.Next(nimed.Length)]); //Juhuslik nimi
   }
}
