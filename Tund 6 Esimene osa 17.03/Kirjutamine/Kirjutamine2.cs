using System;
using System.IO;
class Failikirjutus2{
 public static void Main(String[] arg){
    File.WriteAllText("tervitus.txt", "tere");
 }
}
