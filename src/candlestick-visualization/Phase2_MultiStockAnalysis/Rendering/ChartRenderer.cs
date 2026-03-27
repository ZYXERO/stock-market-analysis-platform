using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;
using Phase2_MultiStockAnalysis.Models;

namespace Phase2_MultiStockAnalysis.Rendering
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

            var legend = new Legend("Legend1");
            chart.Legends.Add(legend);

            chart.Titles.Add($"{symbol} Price & Volume");

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

            chart.Series.Add(priceSeries);
            chart.Series.Add(volumeSeries);
        }

        public static void Render(Chart chart, List<Candlestick> candlesticks, string symbol)
        {
            if (chart.Series.IndexOf("OHLC") < 0 || chart.Series.IndexOf("Volume") < 0)
            {
                ConfigureChart(chart, symbol);
            }

            var priceSeries = chart.Series["OHLC"];
            var volumeSeries = chart.Series["Volume"];

            priceSeries.Points.Clear();
            volumeSeries.Points.Clear();

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

            NormalizeAxes(chart, candlesticks);
            chart.Invalidate();
        }

        private static void NormalizeAxes(Chart chart, List<Candlestick> candlesticks)
        {
            if (candlesticks == null || candlesticks.Count == 0)
                return;

            decimal maxPrice = candlesticks.Max(c => c.High);
            decimal minPrice = candlesticks.Min(c => c.Low);
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