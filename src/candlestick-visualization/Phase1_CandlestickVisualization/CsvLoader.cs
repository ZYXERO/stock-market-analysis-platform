using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace CandlestickVisualization
{
    public static class CsvLoader
    {
        public static List<Candlestick> ReadCandlesticksFromFile(string filePath)
        {
            var result = new List<Candlestick>();

            if (!File.Exists(filePath))
                return result;

            var lines = File.ReadAllLines(filePath);

            if (lines.Length <= 1)
                return result;

            string[] header = SplitCsv(lines[0]).Select(h => h.Trim().Trim('"')).ToArray();

            int iDate = IndexOfHeader(header, "Date");
            int iOpen = IndexOfHeaderContains(header, "Open");
            int iHigh = IndexOfHeaderContains(header, "High");
            int iLow = IndexOfHeaderContains(header, "Low");
            int iClose = IndexOfHeaderContains(header, "Close");
            int iVol = IndexOfHeaderContains(header, "Volume");

            if (new[] { iDate, iOpen, iHigh, iLow, iClose, iVol }.Any(i => i < 0))
                return result;

            var culture = CultureInfo.InvariantCulture;
            var numberStyles = NumberStyles.Any;

            for (int i = 1; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i]))
                    continue;

                string[] parts = SplitCsv(lines[i]).Select(p => p.Trim().Trim('"')).ToArray();

                int maxNeeded = new[] { iDate, iOpen, iHigh, iLow, iClose, iVol }.Max();
                if (parts.Length <= maxNeeded)
                    continue;

                if (!DateTime.TryParse(parts[iDate], culture, DateTimeStyles.None, out DateTime date))
                    continue;

                if (!decimal.TryParse(parts[iOpen], numberStyles, culture, out decimal open))
                    continue;

                if (!decimal.TryParse(parts[iHigh], numberStyles, culture, out decimal high))
                    continue;

                if (!decimal.TryParse(parts[iLow], numberStyles, culture, out decimal low))
                    continue;

                if (!decimal.TryParse(parts[iClose], numberStyles, culture, out decimal close))
                    continue;

                if (!long.TryParse(parts[iVol], numberStyles, culture, out long volume))
                    continue;

                result.Add(new Candlestick
                {
                    Date = date,
                    OpeningPrice = open,
                    MaximumPrice = high,
                    MinimumPrice = low,
                    ClosingPrice = close,
                    Volume = volume
                });
            }

            return result.OrderBy(c => c.Date).ToList();
        }

        private static int IndexOfHeader(string[] header, string name)
        {
            return Array.FindIndex(header,
                h => string.Equals(h, name, StringComparison.OrdinalIgnoreCase));
        }

        private static int IndexOfHeaderContains(string[] header, string fragment)
        {
            return Array.FindIndex(header,
                h => h.IndexOf(fragment, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        private static string[] SplitCsv(string line)
        {
            var list = new List<string>();
            bool inQuotes = false;
            int start = 0;

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '"')
                    inQuotes = !inQuotes;
                else if (line[i] == ',' && !inQuotes)
                {
                    list.Add(line.Substring(start, i - start));
                    start = i + 1;
                }
            }

            list.Add(line.Substring(start));
            return list.ToArray();
        }
    }
}