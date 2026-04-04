using System.Collections.Generic;
using System.Linq;
using Phase3_TechnicalAnalysis.Models;

namespace Phase3_TechnicalAnalysis.Indicators
{
    public static class MovingAverageCalculator
    {
        public static List<IndicatorPoint> CalculateSMA(List<Candlestick> candles, int period)
        {
            var result = new List<IndicatorPoint>();

            if (candles == null || candles.Count < period)
                return result;

            for (int i = period - 1; i < candles.Count; i++)
            {
                decimal avg = candles
                    .Skip(i - period + 1)
                    .Take(period)
                    .Average(c => c.Close);

                result.Add(new IndicatorPoint
                {
                    Date = candles[i].Date,
                    Value = avg
                });
            }

            return result;
        }
    }
}