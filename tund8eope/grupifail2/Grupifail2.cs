using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.IO;
public class Grupifail2{
  public static void Main(string[] argumendid){
     var lapsed=File.ReadAllLines("nimedpikkused.txt").Select(rida => rida.Split(' ')).
	      Select(m => new{eesnimi=m[0], pikkus=int.Parse(m[1])});
     var lapsedPikkusteJarjekorras=lapsed.OrderBy(laps => laps.pikkus);
	 foreach(var laps in lapsedPikkusteJarjekorras){
	     Console.WriteLine(laps.eesnimi+" pikkusega "+laps.pikkus);
	 }

	 File.WriteAllLines("sortpikkused.txt", 
	     lapsedPikkusteJarjekorras.Select(laps => laps.pikkus+" "+laps.eesnimi));
	 var lapsedPikkusKymnenditena=lapsed.GroupBy(laps => laps.pikkus/10*10);


	 foreach(var kymnend in lapsedPikkusKymnenditena){
	    string[] eesnimed=kymnend.Select(laps => laps.eesnimi).ToArray<string>();
	    Console.WriteLine(kymnend.Key+", "+kymnend.Count()+" last: "+
		   String.Join(", ", kymnend.Select(laps => laps.eesnimi+"-"+laps.pikkus)));
	 }


     var lapsed1 = File.ReadAllLines("linn.txt").Select(rida => rida.Split(' ')).
			 Select(m => new {eesnimi = m[0], linn = m[1]});
		foreach (var laps in lapsed1){
			Console.WriteLine(laps.eesnimi + " linnast " + laps.linn);
		}
  }
}