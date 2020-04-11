using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Failivordlus
{
    public static void Main(string[] arg)
    {
        File.WriteAllLines("ainultujujad.txt",
          File.ReadAllLines("ujujad.txt").Except(File.ReadAllLines("jooksjad.txt"))
        );
    }
}