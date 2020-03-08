using System;

namespace InterfaceSegregationPrinciple
{
    partial class Program
    {
        public class OldFashionedPrinter : IMachine
        {
            public void Fax(Document d)
            {
                throw new NotImplementedException();
            }

            public void Print(Document d)
            {
                //This machine do only printing
            }

            public void Scan(Document d)
            {
                throw new NotImplementedException();
            }
        }
    }
}
