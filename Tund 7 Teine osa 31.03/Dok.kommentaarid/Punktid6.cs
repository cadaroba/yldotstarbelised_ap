using System;
namespace Punktid6{
   /// <summary>
   ///   Tasandi punkti andmete hoidmine
   /// </summary>
   class Punkt{
       /// <summary>
       ///    Muutuja ainult lugemiseks. 
       ///    Andmed sisestatavad vaid konstruktoris.
       /// </summary>
       private readonly int x;
       private readonly int y;
       /// <summary>
       ///    Algandmed punkti loomisel kindlasti vajalikud
       /// </summary>
       public Punkt(int ux, int uy){
         x=ux; y=uy;
       }
       public int GetX(){
         return x;
       }
       public int GetY(){
         return y;
       }
       /// <summary>
       ///   Kaugus arvutatakse Pythagorase teoreemi järgi.
       /// </summary>
       public double KaugusNullist(){
         return Math.Sqrt(x*x+y*y);
       }
   }
   /// <summary>
   ///    Eraldi klass punkti katsetamiseks.
   /// </summary>
   class Punktiproov{
     public static void Main(string[] arg){
         Punkt p1=new Punkt(3, 4);
         Console.WriteLine(p1.KaugusNullist());
     }
   }
}
