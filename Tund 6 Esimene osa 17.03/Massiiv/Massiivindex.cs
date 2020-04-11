using System;
class Massiiv5{
   static void Tryki(int[] mas){
      for(int i=0; i<mas.Length; i++){
         Console.WriteLine(mas[i]);
      }
      Console.WriteLine();
   }
   public static void Main(string[] arg){
      int[] m=new int[3]{40, 48, 33};
      int[] m2=m; //Viide samale massiivile
      Tryki(m2);
      m[1]=32;
      Tryki(m2);
      int[] m3=(int[])m.Clone(); //Andmete koopia
      m[1]=20;
      Tryki(m3);
      Array.Clear(m3, 0, m3.Length); //Tühjendus
      Tryki(m3);
      Console.WriteLine(Array.IndexOf(m,33));
      Console.WriteLine(Array.IndexOf(m,17)); //puuduv element
   }
}
