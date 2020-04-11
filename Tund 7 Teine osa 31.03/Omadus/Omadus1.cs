using System;
namespace Omadused1{
 class Ilmaandmed{
   private int temper;
   public int Temperatuur{
      get{return temper;}
      set{temper=value;} //value on sisendväärtuse nimi
   }
 }
 class Test{
   public static void Main(string[] arg){
      Ilmaandmed jaam1=new Ilmaandmed();
      jaam1.Temperatuur=15;
      Console.WriteLine(jaam1.Temperatuur);
   }
 }
}
