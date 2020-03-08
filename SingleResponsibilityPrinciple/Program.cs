using System;
using System.Diagnostics;
using System.IO;

namespace OpenClosedPrinciple
{

    class Program
    {
        static void Main(string[] args)
        {
            var j = new JurnalAfter();
            j.AddEntry("Tom Hank");
            j.AddEntry("Chevrolet Lacetti");
            Console.WriteLine(j);

            var fm = new FileManager();
            var fileName = @"C:\Users";
            fm.SaveToFile(j, fileName);
            Process.Start(fileName);
        }
    }
}
