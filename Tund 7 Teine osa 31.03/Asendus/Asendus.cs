using System;
namespace Asendus{
 class Inimene{
   protected int vanus;
   public Inimene(int uvanus){
      vanus=uvanus;
   }
   public virtual void YtleVanus(){
      Console.WriteLine("Minu vanus on "+vanus+" aastat");
   }
 }
 class Daam:Inimene {
   public Daam(int vanus):base(vanus){}
   public override void YtleVanus(){
      Console.WriteLine("Minu vanus on "+(vanus-5)+" aastat");   
   }
 }
 class Beib:Daam{
   public Beib(int vanus):base(vanus){}
   new public virtual void YtleVanus(){
       Console.WriteLine("Minu vanus pole sinu asi, vot!");
   }
 }
 sealed class KavalBeib:Beib{ //siit ei saa enam edasi areneda
   public KavalBeib(int vanus):base(vanus){}
   public override void YtleVanus(){
      Console.WriteLine("Arva, kas olen {0}?", vanus+2);
   }
 }
 class InimTest{
  public static void Main(string[] arg){
     KavalBeib kb=new KavalBeib(17);
     Beib b=new Beib(17), bkb=kb;
     Daam d=new Daam(40), db=b, dkb=kb;
     Inimene i=new Inimene(40), id=d, ib=b,ikb=kb;
     kb.YtleVanus();
     b.YtleVanus();
     bkb.YtleVanus();
     d.YtleVanus();
     db.YtleVanus();
     dkb.YtleVanus();
     i.YtleVanus();
     id.YtleVanus();
     ib.YtleVanus();
     ikb.YtleVanus();
  }
 }
}
