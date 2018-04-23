using System;

namespace Task3.Solution
{
    public class Bank
    {
        public string Name { get; set; }

        public Bank(string name)
        {
            this.Name = name;
        }

        public void Register(Stock stock)
        {
            stock.CurrencySelled += Update;
        }

        public void Unregister(Stock stock)
        {
            stock.CurrencySelled -= Update;
        }

        public void Update(object sourse, StockInfoEventArgs eventArgs)
        {
            if (eventArgs.Euro > 40)
                Console.WriteLine("Банк {0} продает евро;  Курс евро: {1}", this.Name, eventArgs.Euro);
            else
                Console.WriteLine("Банк {0} покупает евро;  Курс евро: {1}", this.Name, eventArgs.Euro);
        }
    }
}