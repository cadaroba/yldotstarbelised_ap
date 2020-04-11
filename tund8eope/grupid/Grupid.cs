using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
public class Grupid{
  public static void Main(string[] arg){
     IEnumerable<int> arvud=Enumerable.Range(101, 20); //alates 101st 20 arvu
	 Console.WriteLine(String.Join(" ", arvud));
	 var grupid=from arv in arvud group arv by arv%3;
	 foreach(var grupp in grupid){
	   Console.WriteLine("Jääk "+grupp.Key+" arvud "+String.Join(" ",grupp));
	 }
	 
	 IEnumerable<IGrouping<int, int>> grupid2=arvud.GroupBy(arv => arv % 3);
	 foreach(IGrouping<int, int> grupp in grupid2){
	   Console.WriteLine("Jääk "+grupp.Key+"  arvud "+String.Join(" ",grupp));	   
	   int[] grupiarvud=grupp.ToArray<int>();
	   Console.WriteLine("Esimene: "+grupiarvud[0]);
     }

    string[] eesnimed = {"Olle", "Jaanus", "Kullar", "Aimar", "Anni"};
	var grupid1 = from nimi in eesnimed group nimi by nimi.Count();
		foreach (var grupp in grupid1){
			Console.WriteLine("nimed " + String.Join(" ", grupp));
		}
	}
}









