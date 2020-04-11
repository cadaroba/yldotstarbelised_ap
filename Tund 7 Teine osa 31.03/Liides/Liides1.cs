using System;
namespace Liides1{
 class Inimene{
   protected int vanus;
   public Inimene(int uvanus){
      vanus=uvanus;
   }
   public virtual void YtleVanus(){
      Console.WriteLine("Minu vanus on "+vanus+" aastat");
   }
 }
 interface IViisakas{
   void Tervita(String tuttav);
 }
 class Laps:Inimene, IViisakas {
   public Laps(int vanus):base(vanus){}
   public void Tervita(String tuttav){
     Console.WriteLine("Tere, "+tuttav);
   }
 }
 class Koer: IViisakas{
   public void Tervita(String tuttav){
      Console.WriteLine("Auh!");
   }
 }
 class InimTest{
  static void TuleSynnipaevale(IViisakas v){
     v.Tervita("vanaema");
  }
  public static void Main(string[] arg){
     Laps juku=new Laps(6);
     juku.YtleVanus();
     Koer muki=new Koer();
     TuleSynnipaevale(juku);
     TuleSynnipaevale(muki);
  }
 }
}

//* Katseta, mis juhtub, kui Lapse tervita kirjutada väikese tähega. - ei tööta, Laps does not implement interface member