using System;
namespace Indekseering1{
 class Ruuduarvutus{
   public int this[int nr]{
      get{return nr*nr;}
   }
 }
 class Test{
  public static void Main(string[] arg){
     Ruuduarvutus r=new Ruuduarvutus();
     Console.WriteLine(r[3]);
  }
 }
}
