using System;
using System.Collections.Generic;
using System.IO;
using Phase2_MultiStockAnalysis.Models;

namespace Phase2_MultiStockAnalysis.Services
{
    public static class StockRepository
    {
        public static Dictionary<string, StockDataset> LoadAllStocks(string dataFolderPath)
        {
            var stockMap = new Dictionary<string, StockDataset>(StringComparer.OrdinalIgnoreCase);

            if (!Directory.Exists(dataFolderPath))
                return stockMap;

            string[] files = Directory.GetFiles(dataFolderPath, "*.csv");

            foreach (string file in files)
            {
                string fileName = Path.GetFileNameWithoutExtension(file);
                string[] parts = fileName.Split('-');

                if (parts.Length != 2)
                    continue;

                string symbol = parts[0].Trim().ToUpper();
                string interval = parts[1].Trim().ToLower();

                if (!stockMap.ContainsKey(symbol))
                {
                    stockMap[symbol] = new StockDataset
                    {
                        Symbol = symbol
                    };
                }

                List<Candlestick> candles = CsvLoader.LoadCandlesticks(file);

                switch (interval)
                {
                    case "day":
                        stockMap[symbol].DailyData = candles;
                        break;
                    case "week":
                        stockMap[symbol].WeeklyData = candles;
                        break;
                    case "month":
                        stockMap[symbol].MonthlyData = candles;
                        break;
                }
            }

            return stockMap;
        }
    }
}