using System;
namespace Punktid4{
   class Punkt{
       static int loendur=0;
       private int nr;
       private int x;
       private int y;
       public Punkt(int ux, int uy){
         x=ux; y=uy;
         nr=++loendur;
       }
       public int GetX(){
         return x;
       }
       public int GetY(){
         return y;
       }
       public int GetNr(){
         return nr;
       }
       public void SetX(int ux){
         x=ux;
       }
       public void SetY(int uy){
         y=uy;
       }
       public double KaugusNullist(){
         return Math.Sqrt(x*x+y*y);
       }
   }
   class Punktiproov{
     public static void Main(string[] arg){
         Punkt p1=new Punkt(3, 4);
         Punkt p2=p1; //Kasutab sama mälupiirkonda
         p1.SetX(7);         
         Console.WriteLine(p2.GetNr()+" "+p2.GetX()+" "+p2.GetY());
         Punkt p3=new Punkt(77, 32); //Punkt järgmise järjekorranumbriga
         Console.WriteLine(p3.GetNr());
     }
   }
}
