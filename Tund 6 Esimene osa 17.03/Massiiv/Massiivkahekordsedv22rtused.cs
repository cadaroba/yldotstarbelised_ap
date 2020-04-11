using System;
class Massiiv6{
   static void KorrutaKahega(int[] mas){
      for(int i=0; i<mas.Length; i++){
         mas[i]=mas[i]*2;
      }
   }
   static void Tryki(int[] mas){
      for(int i=0; i<mas.Length; i++){
         Console.WriteLine(mas[i]);
      }
      Console.WriteLine();
   }
   public static void Main(string[] arg){
      int[] m=new int[3]{40, 48, 33};
      KorrutaKahega(m);
      Tryki(m);
   }
}
