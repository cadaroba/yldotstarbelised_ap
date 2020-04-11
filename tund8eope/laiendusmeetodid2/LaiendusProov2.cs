using System;
using LaiendusMeetodid;
public class LaiendusProov2{
  public static void Main(string[] arg){
    Console.WriteLine("Tere".Pikkus());
	Console.WriteLine("5 pirni ja 12 õuna".ArvudeSumma());
	Console.WriteLine(3.astmes(2));

	int[] arvud={2,4,5};
	arvud.Tyhjenda();
	Console.WriteLine(String.Join(" ", arvud));

    
  }
}