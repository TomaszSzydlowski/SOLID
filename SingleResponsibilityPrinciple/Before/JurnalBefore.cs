using System;
using System.Collections.Generic;

namespace SingleResponsibilityPrinciple
{
    public class JurnalBefore
    {
        private readonly List<string> entries = new List<string>();
        private static int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{++count}:{text}");
            return count;
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }

        //You don't need the code, the OpenClose rule has been broken

        //public void Save(string fileName)
        //{
        //    File.WriteAllText(fileName, ToString());
        //}

        //public static Jurnal Load(string fileName)
        //{

        //}

        //public void Load(Uri uri)
        //{

        //}

    }
}
