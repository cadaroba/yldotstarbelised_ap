using System;
class Massiiv2{
   public static void Main(string[] arg){
      int[] m=new int[3];
      m[0]=40;
      m[1]=48;
      m[2]=33;
      int summa=0;
      for(int i=0; i<m.Length; i++){
         summa+=m[i];
      }
      Console.WriteLine(summa);
   }
}
