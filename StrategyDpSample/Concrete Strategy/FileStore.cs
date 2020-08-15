using StrategyDpSample.Abstract_Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDpSample.Concrete_Strategy
{
    class FileStore : IStore
    {
        public void ReadData()
        {
            Console.WriteLine("Read data from a file");
        }

        public void WriteData()
        {
            Console.WriteLine("Write data in a file");
        }
    }
}
