using System;
public class Kordus3{
   public static void Main(string[] arg){
      int tund;
      do{
         Console.WriteLine("Sisesta tund vahemikus 0-23");
         tund=int.Parse(Console.ReadLine());
      } while(tund<0 || tund>23);
      Console.WriteLine("Tubli, sisestasid {0}.", tund);
   }
}
