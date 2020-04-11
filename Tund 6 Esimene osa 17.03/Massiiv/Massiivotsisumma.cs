using System;
class Massiiv3{
   static int LeiaSumma(int[] mas){
      int summa=0;
      for(int i=0; i<mas.Length; i++){
         summa+=mas[i];
      }
      return summa;   
   }
   public static void Main(string[] arg){
      int[] m=new int[3]{40, 48, 33};
      int vastus=LeiaSumma(m);
      Console.WriteLine(vastus);
   }
}

