using System;
using System.Collections.Generic;
using System.Linq;
using Phase3_TechnicalAnalysis.Models;

namespace Phase3_TechnicalAnalysis.Services
{
    public static class DataAggregator
    {
        public static List<Candlestick> GetFilteredData(
            StockDataset dataset,
            string interval,
            DateTime startDate,
            DateTime endDate)
        {
            if (dataset == null)
                return new List<Candlestick>();

            List<Candlestick> source = interval.ToLower() switch
            {
                "daily" => dataset.DailyData,
                "weekly" => dataset.WeeklyData,
                "monthly" => dataset.MonthlyData,
                _ => dataset.DailyData
            };

            return source
                .Where(c => c.Date.Date >= startDate.Date && c.Date.Date <= endDate.Date)
                .OrderBy(c => c.Date)
                .ToList();
        }
    }
}