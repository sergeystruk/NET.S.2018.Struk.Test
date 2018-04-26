using System;

namespace Task3.Solution
{
    public class Broker
    {
        public string Name { get; set; }

        public Broker(string name, Stock stock)
        {
            this.Name = name;
            Register(stock);
        }

        public void Update(object sourse, StockInfoEventArgs eventArgs)
        {
            if (eventArgs.Euro > 40)
                Console.WriteLine("Банк {0} продает евро;  Курс евро: {1}", this.Name, eventArgs.Euro);
            else
                Console.WriteLine("Банк {0} покупает евро;  Курс евро: {1}", this.Name, eventArgs.Euro);
        }

        public void StopTrade(Stock stock)
        {
            Unregister(stock);
            stock = null;
        }

        private void Register(Stock stock)
        {
            stock.CurrencySelled += Update;
        }

        private void Unregister(Stock stock)
        {
            stock.CurrencySelled -= Update;
        }

        
    }
}