using ProcessContracts;
using System;

namespace ProcessB
{
    public class ProcessClassB : IProcess
    {
        public void Execute()
        {
            Console.WriteLine($"{nameof(ProcessClassB)}");
        }
    }
}