using System.IO;
using System.Collections.Generic;

namespace ArrayToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myArrayList = new List<string>() { "week1Box", "week2Box", "week3Box", "week4Box", "week5Box", "week6Box", "week7Box", "week8Box", "week9Box", "week10Box" };
            File.WriteAllLines("output.txt", myArrayList);
        }
    }
}
