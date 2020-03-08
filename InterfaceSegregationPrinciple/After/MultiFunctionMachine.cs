using System;

namespace InterfaceSegregationPrinciple
{
    partial class Program
    {
        public class MultiFunctionMachine : IMultiFunctionDevice
        {
            private IPrinter printer;
            private IScanner scanner;

            public MultiFunctionMachine(IPrinter printer, IScanner scanner)
            {
                this.printer = printer ?? throw new ArgumentNullException(paramName: nameof(printer));
                this.scanner = scanner ?? throw new ArgumentNullException(paramName: nameof(scanner));

            }

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
