using System.Collections.Generic;

namespace Phase3_TechnicalAnalysis.Models
{
    public class StockDataset
    {
        public string Symbol { get; set; } = string.Empty;

        public List<Candlestick> DailyData { get; set; } = new();
        public List<Candlestick> WeeklyData { get; set; } = new();
        public List<Candlestick> MonthlyData { get; set; } = new();
    }
}