using System.Collections.Generic;
using System.Linq;
using Phase3_TechnicalAnalysis.Models;

namespace Phase3_TechnicalAnalysis.Indicators
{
    public static class ExponentialMovingAverageCalculator
    {
        public static List<IndicatorPoint> CalculateEMA(List<Candlestick> candles, int period)
        {
            var result = new List<IndicatorPoint>();

            if (candles == null || candles.Count < period || period <= 0)
                return result;

            decimal multiplier = 2m / (period + 1);

            decimal sma = candles
                .Take(period)
                .Average(c => c.Close);

            result.Add(new IndicatorPoint
            {
                Date = candles[period - 1].Date,
                Value = sma
            });

            decimal previousEma = sma;

            for (int i = period; i < candles.Count; i++)
            {
                decimal ema = ((candles[i].Close - previousEma) * multiplier) + previousEma;

                result.Add(new IndicatorPoint
                {
                    Date = candles[i].Date,
                    Value = ema
                });

                previousEma = ema;
            }

            return result;
        }
    }
}