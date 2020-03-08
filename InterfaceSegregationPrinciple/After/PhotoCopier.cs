using System;

namespace InterfaceSegregationPrinciple
{
    partial class Program
    {
        public class PhotoCopier : IScanner, IPrinter
        {
            public void Print(Document d)
            {
                throw new NotImplementedException();
            }

            public void Scanner(Document d)
            {
                throw new NotImplementedException();
            }
        }
    }
}
