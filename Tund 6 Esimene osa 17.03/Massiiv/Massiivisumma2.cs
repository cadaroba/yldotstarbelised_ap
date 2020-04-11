using System;
class Massiiv7{
   public static void Main(string[] arg){
      int[] m=new int[3]{40, 48, 33};
      foreach(int arv in m){
        Console.WriteLine(arv);
      }
   }
}

//foreach - tsükkel
//Kui on vaja kogumi kõik elemendid läbi käia, 
//kuid samas pole tähtis läbikäigu järjekord, siis sellisel 
//puhul aitab all näites paistev foreach-tsükkel. Selle abi saab näiteks summa arvutamise
// juures pruukida. 

