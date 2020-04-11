using System;
namespace Parilus2{
 class Inimene{
   protected int vanus;
   public Inimene(int uvanus){
      vanus=uvanus;
   }
   public void YtleVanus(){
      Console.WriteLine("Minu vanus on "+vanus+" aastat");
   }
 }
 class Modell:Inimene {
   protected int ymberm66t;
   public Modell(int vanus, int uymberm66t):base(vanus){
      ymberm66t=uymberm66t;
   }
   public void Esitle(){
      YtleVanus();
      Console.WriteLine("Mu ymberm66duks on "+ymberm66t+" sentimeetrit");
   }
 }
 class InimTest{
  public static void Main(string[] arg){
     Modell m=new Modell(20, 90);
     m.Esitle();
  }
 }
}
//PÄRILUSEGA NÄIDE