using System;
public class Valik1{
   public static void Main(string[] arg){
      double pirnihind=1.70;
      Console.WriteLine("Mitu pirni ostad?");
      double kogus=double.Parse(Console.ReadLine());
      double summa=kogus*pirnihind; //korrutatakse ühe pirni hinnaga
      Console.WriteLine("Kas kilekotti ka soovid? (jah/ei)");
      string vastus=Console.ReadLine();
      if(vastus=="jah"){
         summa=summa+0.70;
      }
      Console.WriteLine("Kogusumma: "+summa);
   }
}
