using ProcessContracts;
using System;

namespace ProcessA
{
    public class ProcessClassA : IProcess
    {
        public void Execute()
        {
            Console.WriteLine($"{nameof(ProcessClassA)}");
        }
    }
}