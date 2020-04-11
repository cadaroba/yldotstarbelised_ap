using System;
namespace Punktid2{
   struct Punkt{
       public int x;
       public int y;
   }
   class Punktimassiiv{
     public static void Main(string[] arg){
         Punkt[] pd=new Punkt[10]; //mälu kohe olemas
         for(int i=0; i<10; i++){
           pd[i].x=i;
           pd[i].y=i*i;
         }
         Console.WriteLine(pd[4].y);
     }
   }
}
