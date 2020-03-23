using System;
using System.Collections.Generic;
using System.Linq;

namespace StockPurchaseDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("APL", "Apple");
            stocks.Add("AMZ", "Amazon");
            stocks.Add("ORA", "Oracle");
            

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

            purchases.Add((ticker: "GM", shares: 150, price: 23.21));
            purchases.Add((ticker: "CAT", shares: 35, price: 20.11));
            purchases.Add((ticker: "APL", shares: 50, price: 145.13));
            purchases.Add((ticker: "AMZ", shares: 90, price: 245.99));
            purchases.Add((ticker: "ORA", shares: 32, price: 98.78));

            
            var stockInfo = new Dictionary<string, double>();

            foreach (var purchase in purchases)
            {
                var stock = stocks[purchase.ticker];
        
                var newPurchases = purchases.Where(x => purchase.ticker == x.ticker);

                foreach (var newP in newPurchases)
                {
                    var stockValue = Math.Round(newP.price * newP.shares, 2);

                    stockInfo.Add(stock, stockValue);
                }
                
            }

            foreach (var info in stockInfo)
            {
                Console.WriteLine($"The stock {info.Key} is worth ${info.Value}");
            }
        }
    }
}
