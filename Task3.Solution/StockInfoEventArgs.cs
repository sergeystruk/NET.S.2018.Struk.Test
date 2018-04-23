using System;

namespace Task3.Solution
{
    public class StockInfoEventArgs : EventArgs
    {
        public int USD { get; set; }
        public int Euro { get; set; }
    }
}