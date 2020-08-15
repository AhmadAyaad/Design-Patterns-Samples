using StrategyDpSample.Concrete_Strategy;
using StrategyDpSample.Context;
using System;
using System.Data.Common;

namespace StrategyDpSample
{
    class Program
    {
        static void Main(string[] args)
        {
            DataReader dataReader = new DataReader(new SqlStore());
            dataReader.ReadData();
            dataReader.WriteData();
         
            dataReader = new DataReader(new FileStore());
            dataReader.ReadData();
            dataReader.WriteData();

        }
    }
}
