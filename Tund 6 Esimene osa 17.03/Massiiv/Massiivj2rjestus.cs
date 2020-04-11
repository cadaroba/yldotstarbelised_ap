using System;
class Massiiv4{
   public static void Main(string[] arg){
      int[] m=new int[3]{40, 48, 33};
      Array.Sort(m);
      for(int i=0; i<m.Length; i++){
         Console.WriteLine(m[i]);
      }
   }
}
