using System;
using System.Collections.Generic;
using System.Linq;
using Phase2_MultiStockAnalysis.Models;

namespace Phase2_MultiStockAnalysis.Services
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