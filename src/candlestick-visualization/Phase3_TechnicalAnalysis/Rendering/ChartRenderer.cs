using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;
using Phase3_TechnicalAnalysis.Models;

namespace Phase3_TechnicalAnalysis.Rendering
{
    public static class ChartRenderer
    {
        public static void ConfigureChart(Chart chart, string symbol)
        {
            chart.Series.Clear();
            chart.ChartAreas.Clear();
            chart.Legends.Clear();
            chart.Titles.Clear();

            var priceArea = new ChartArea("PriceArea");
            var volumeArea = new ChartArea("VolumeArea");

            priceArea.AxisX.LabelStyle.Format = "yyyy-MM-dd";
            priceArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            priceArea.AxisY.MajorGrid.LineColor = Color.LightGray;
            priceArea.AxisX.IsMarginVisible = true;
            priceArea.AxisX.LabelStyle.Angle = -45;
            priceArea.Position.X = 5;
            priceArea.Position.Y = 5;
            priceArea.Position.Width = 90;
            priceArea.Position.Height = 58;

            volumeArea.AxisX.LabelStyle.Format = "yyyy-MM-dd";
            volumeArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            volumeArea.AxisY.MajorGrid.LineColor = Color.LightGray;
            volumeArea.AxisX.LabelStyle.Angle = -45;
            volumeArea.AxisX.IsMarginVisible = true;
            volumeArea.AlignWithChartArea = "PriceArea";
            volumeArea.Position.X = 5;
            volumeArea.Position.Y = 68;
            volumeArea.Position.Width = 90;
            volumeArea.Position.Height = 22;

            chart.ChartAreas.Add(priceArea);
            chart.ChartAreas.Add(volumeArea);

            chart.Legends.Add(new Legend("Legend1"));
            chart.Titles.Add($"{symbol} Price, Volume, and Indicators");

            var priceSeries = new Series("OHLC")
            {
                ChartType = SeriesChartType.Candlestick,
                ChartArea = "PriceArea",
                XValueType = ChartValueType.Date,
                Legend = "Legend1",
                IsXValueIndexed = true
            };

            priceSeries["PriceUpColor"] = "Lime";
            priceSeries["PriceDownColor"] = "Red";
            priceSeries["OpenCloseStyle"] = "Triangle";
            priceSeries["ShowOpenClose"] = "Both";
            priceSeries["PointWidth"] = "0.8";

            var volumeSeries = new Series("Volume")
            {
                ChartType = SeriesChartType.Column,
                ChartArea = "VolumeArea",
                XValueType = ChartValueType.Date,
                Legend = "Legend1",
                IsXValueIndexed = true
            };

            var smaSeries = new Series("SMA")
            {
                ChartType = SeriesChartType.Line,
                ChartArea = "PriceArea",
                XValueType = ChartValueType.Date,
                BorderWidth = 2,
                Legend = "Legend1"
            };

            var emaSeries = new Series("EMA")
            {
                ChartType = SeriesChartType.Line,
                ChartArea = "PriceArea",
                XValueType = ChartValueType.Date,
                BorderWidth = 2,
                Legend = "Legend1"
            };

            chart.Series.Add(priceSeries);
            chart.Series.Add(volumeSeries);
            chart.Series.Add(smaSeries);
            chart.Series.Add(emaSeries);
        }

        public static void Render(
            Chart chart,
            List<Candlestick> candlesticks,
            string symbol,
            List<IndicatorPoint>? smaPoints = null,
            List<IndicatorPoint>? emaPoints = null)
        {
            if (chart.Series.IndexOf("OHLC") < 0 ||
                chart.Series.IndexOf("Volume") < 0 ||
                chart.Series.IndexOf("SMA") < 0 ||
                chart.Series.IndexOf("EMA") < 0)
            {
                ConfigureChart(chart, symbol);
            }

            var priceSeries = chart.Series["OHLC"];
            var volumeSeries = chart.Series["Volume"];
            var smaSeries = chart.Series["SMA"];
            var emaSeries = chart.Series["EMA"];

            priceSeries.Points.Clear();
            volumeSeries.Points.Clear();
            smaSeries.Points.Clear();
            emaSeries.Points.Clear();

            if (candlesticks == null || candlesticks.Count == 0)
            {
                chart.Invalidate();
                return;
            }

            foreach (var candle in candlesticks)
            {
                var pricePoint = new DataPoint
                {
                    XValue = candle.Date.ToOADate(),
                    YValues = new[]
                    {
                        (double)candle.High,
                        (double)candle.Low,
                        (double)candle.Open,
                        (double)candle.Close
                    }
                };

                priceSeries.Points.Add(pricePoint);
                volumeSeries.Points.AddXY(candle.Date.ToOADate(), (double)candle.Volume);
            }

            if (smaPoints != null)
            {
                foreach (var point in smaPoints)
                {
                    smaSeries.Points.AddXY(point.Date.ToOADate(), (double)point.Value);
                }
            }

            if (emaPoints != null)
            {
                foreach (var point in emaPoints)
                {
                    emaSeries.Points.AddXY(point.Date.ToOADate(), (double)point.Value);
                }
            }

            NormalizeAxes(chart, candlesticks, smaPoints, emaPoints);
            chart.Invalidate();
        }

        private static void NormalizeAxes(
            Chart chart,
            List<Candlestick> candlesticks,
            List<IndicatorPoint>? smaPoints,
            List<IndicatorPoint>? emaPoints)
        {
            if (candlesticks == null || candlesticks.Count == 0)
                return;

            var allPriceValues = new List<decimal>();

            allPriceValues.AddRange(candlesticks.Select(c => c.High));
            allPriceValues.AddRange(candlesticks.Select(c => c.Low));

            if (smaPoints != null)
                allPriceValues.AddRange(smaPoints.Select(p => p.Value));

            if (emaPoints != null)
                allPriceValues.AddRange(emaPoints.Select(p => p.Value));

            decimal maxPrice = allPriceValues.Max();
            decimal minPrice = allPriceValues.Min();
            decimal padding = Math.Max(0.01m, (maxPrice - minPrice) * 0.02m);

            long maxVolume = candlesticks.Max(c => c.Volume);

            var priceArea = chart.ChartAreas["PriceArea"];
            var volumeArea = chart.ChartAreas["VolumeArea"];

            priceArea.AxisY.Minimum = (double)(minPrice - padding);
            priceArea.AxisY.Maximum = (double)(maxPrice + padding);

            volumeArea.AxisY.Minimum = 0;
            volumeArea.AxisY.Maximum = Math.Max(1, maxVolume * 1.1);

            priceArea.AxisX.LabelStyle.Angle = -45;
            volumeArea.AxisX.LabelStyle.Angle = -45;
        }
    }
}