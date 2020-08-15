using StrategyDpSample.Abstract_Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDpSample.Context
{
    class DataReader
    {
        IStore store;
        public DataReader(IStore s)
        {
            store = s;
        }
        public void ReadData()
        {
            store.ReadData();
        }
        public void WriteData()
        {
            store.WriteData();
        }

    }
}
