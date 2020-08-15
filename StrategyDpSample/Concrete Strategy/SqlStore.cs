using StrategyDpSample.Abstract_Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDpSample.Concrete_Strategy
{
    class SqlStore : IStore
    {
        public void ReadData()
        {
            Console.WriteLine("Read data from SQL Database");
        }

        public void WriteData()
        {
            Console.WriteLine("Write data in SQL DB");
        }
    }
}
