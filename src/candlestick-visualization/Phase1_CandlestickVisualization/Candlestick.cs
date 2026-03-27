using System;

namespace CandlestickVisualization
{
    public class Candlestick
    {
        public DateTime Date { get; set; }
        public decimal OpeningPrice { get; set; }
        public decimal MaximumPrice { get; set; }
        public decimal MinimumPrice { get; set; }
        public decimal ClosingPrice { get; set; }
        public long Volume { get; set; }
    }
}