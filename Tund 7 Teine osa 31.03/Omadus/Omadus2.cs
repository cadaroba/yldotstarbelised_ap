using System;
namespace Omadused2{
 class Ilmaandmed{
   private int temper;
   private int muudetud=0;
   private int loetud=0;
   public int Temperatuur{
      get{
        loetud++;
        return temper;
      }
      set{
        muudetud++;
        temper=value;
      } 
   }
   public override string ToString(){
      return "Muudetud: "+muudetud+", loetud:"+ loetud+
                                     ", temperatuur:"+temper;
   }
 }
 class Test{
   public static void Main(string[] arg){
      Ilmaandmed jaam1=new Ilmaandmed();
      jaam1.Temperatuur=15;
      Console.WriteLine(jaam1.Temperatuur);
      Console.WriteLine(jaam1.Temperatuur);
      Console.WriteLine(jaam1);
   }
 }
}
