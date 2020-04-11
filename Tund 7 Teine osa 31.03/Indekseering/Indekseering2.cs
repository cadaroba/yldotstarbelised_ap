using System;
using System.Collections;
namespace Indekseering2{
 class Ringreis{
   Hashtable esinemised=new Hashtable();
   public string this[int kuupaev]{
      get{
         if(esinemised[kuupaev]==null){return "Vaba";}
         return (string)esinemised[kuupaev];
      }
      set{
         if(esinemised[kuupaev]!=null){
            throw new Exception("Juba kinni, esinemine linnas "+
                                              esinemised[kuupaev]);
         }
         esinemised[kuupaev]=value;
      }
   }
 }
 class Test{
  public static void Main(string[] arg){
     Ringreis r=new Ringreis();
     r[3]="Narva";
     r[4]="Tartu";
     Console.WriteLine(r[3]);
     Console.WriteLine(r[5]);
     r[3]="Viljandi";
  }
 }
}
