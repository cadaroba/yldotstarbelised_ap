using System;
public class Valik1{
   public static void Main(string[] arg){
      double saiahind=1.70;
      double leivahind=2;
      double piimahind=0.5;

      Console.WriteLine("Kas saia ka soovid? (jah/ei)");
      string vastus=Console.ReadLine();
      if(vastus=="jah"){
         summa=saiahind;
      }

      Console.WriteLine("Kas leiba ka soovid? (jah/ei)");
      string vastus=Console.ReadLine();
      if(vastus=="jah"){
         summa=saiahind+leivahind;
      }

      Console.WriteLine("Kas piima ka soovid? (jah/ei)");
      string vastus=Console.ReadLine();
      if(vastus=="jah"){
         summa=saiahind+leivahind+piimahind;
      }

      Console.WriteLine("Kogusumma: "+summa);
   }
}
