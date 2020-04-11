using System;
using System.IO;
class Faililugemine{
   public static void Main(string[] arg){
        FileStream f = new FileStream("inimesed.txt", 
                       FileMode.Open, FileAccess.Read);
        StreamReader sisse=new StreamReader(f);
        string rida=sisse.ReadLine();
        while(rida!=null){
           Console.WriteLine(rida);
           rida=sisse.ReadLine();
        }
   }
}
