using System;
namespace AbstraktseKlassiUuring{
 abstract class Kujund{   
   public abstract double KysiPohjaPindala();
   public abstract double KysiKorgus();
   public double KysiRuumala(){
      return KysiPohjaPindala()*KysiKorgus();
   }
 }
 class Tikutops:Kujund{
   public override double KysiPohjaPindala(){return 8;}
   public override double KysiKorgus(){return 1.5;}
 }
   
 
 class Vorstijupp: Kujund{
   int pikkus, raadius;
   public Vorstijupp(int upikkus, int uraadius){
      pikkus=upikkus;
      raadius=uraadius;
   }
   public override double KysiPohjaPindala(){
     return Math.PI*raadius*raadius;
   }
   public override double KysiKorgus(){
     return pikkus;
   }
 }
 class Test{
   public static void Main(string[] arg){
      Tikutops t=new Tikutops();
      Vorstijupp v=new Vorstijupp(10, 3);
      Console.WriteLine("Ruumalad {0} ja {1}", 
                t.KysiRuumala(), v.KysiRuumala());
   }
 }
}
