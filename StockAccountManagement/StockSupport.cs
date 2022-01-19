using System;
using System.Collections.Generic;
using System.Text;

namespace StockAccountManagement
{
    class StockSupport
    {
        public List<Stocks> stocksList { get; set; }

        public class Stocks
        {
            public string StockName { get; set; }
            public int shares { get; set; }
            public int Price { get; set; }
        }
    }
}
