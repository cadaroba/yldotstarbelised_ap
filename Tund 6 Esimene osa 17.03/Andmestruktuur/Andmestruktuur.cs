using System;
namespace Punktid{
   struct Punkt{
       public int x;
       public int y;
   }
   class Punktiproov{
     public static void Main(string[] arg){
         Punkt p1;
         p1.x=3;
         p1.y=5;
         Punkt p2=p1;  //Väärtused kopeeritakse
         p1.x=2;
         Console.WriteLine(p2.x+" "+p2.y);
     }
   }
}
