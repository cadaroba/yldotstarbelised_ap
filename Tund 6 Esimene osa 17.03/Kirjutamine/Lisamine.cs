using System;
using System.IO;
class Faililisamine{
  public static void Main(string[] arg){
            FileStream f = new FileStream("inimesed.txt", 
                             FileMode.Append, FileAccess.Write);
            StreamWriter valja = new StreamWriter(f);
            valja.WriteLine("Siim");
            valja.WriteLine("Sass");
            valja.Close();     
  }
}

