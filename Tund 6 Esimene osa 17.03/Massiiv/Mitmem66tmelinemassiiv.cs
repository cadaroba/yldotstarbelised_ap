using System;
class Massiiv8{
   public static void Main(string[] arg){
      int[,] m=new int[2,3]{
         {40, 48, 33},
         {17, 23, 36}
       };
      Console.WriteLine(m[0, 1]); //48
      Console.WriteLine("M66dete arv: "+m.Rank);
      Console.WriteLine("Ridade arv: "+m.GetLength(0));
      Console.WriteLine("Veergude arv: "+m.GetLength(1)); 
                              //elemente mõõtmes nr. 1
      int summa=0;
      foreach(int arv in m){
        summa+=arv;
      }
      Console.WriteLine("Summa: "+summa);
   }
}
