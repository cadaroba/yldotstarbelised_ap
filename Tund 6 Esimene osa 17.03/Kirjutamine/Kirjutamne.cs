using System;
using System.IO;
class Failikirjutus{
  public static void Main(string[] arg){
            FileStream f = new FileStream("inimesed.txt", 
                            FileMode.Create, FileAccess.Write);
            StreamWriter valja = new StreamWriter(f);
            valja.WriteLine("Juku");
            valja.WriteLine("Kati");
            valja.Close();     
  }
}
