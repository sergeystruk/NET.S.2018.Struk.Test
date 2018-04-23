using System;

namespace Task3.Solution
{
    public class Stock
    {
        public event EventHandler<StockInfoEventArgs> CurrencySelled = delegate (object sourse, StockInfoEventArgs args) { };

        public void Market()
        {
            StockInfoEventArgs eventArgs = new StockInfoEventArgs();
            Random rnd = new Random();
            eventArgs.USD = rnd.Next(20, 40);
            eventArgs.Euro = rnd.Next(30, 50);
            OnCurrenceSelled(this, eventArgs);
        }

        protected virtual void OnCurrenceSelled(object source, StockInfoEventArgs e)
        {
            CurrencySelled?.Invoke(source, e);
        }
    }
}