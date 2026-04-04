
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Phase3_TechnicalAnalysis.Indicators;
using Phase3_TechnicalAnalysis.Models;
using Phase3_TechnicalAnalysis.Rendering;
using Phase3_TechnicalAnalysis.Services;
using Phase3_TechnicalAnalysis.UI;

namespace Phase3_TechnicalAnalysis
{
    public partial class MainForm : Form
    {
        private Dictionary<string, StockDataset> allStockData = new(StringComparer.OrdinalIgnoreCase);
        private BindingList<Candlestick> visibleCandlesticks = new();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dateTimePickerStart.Value = DateTime.Today.AddYears(-1);
            dateTimePickerEnd.Value = DateTime.Today;

            comboBoxPeriod.Items.Clear();
            comboBoxPeriod.Items.AddRange(new object[] { "Daily", "Weekly", "Monthly" });
            comboBoxPeriod.SelectedItem = "Daily";

            numericUpDownSMA.Minimum = 2;
            numericUpDownSMA.Maximum = 200;
            numericUpDownSMA.Value = 20;

            numericUpDownEMA.Minimum = 2;
            numericUpDownEMA.Maximum = 200;
            numericUpDownEMA.Value = 20;

            checkBoxSMA.Checked = true;
            checkBoxEMA.Checked = false;

            dataGridViewCandlesticks.AutoGenerateColumns = false;
            dataGridViewCandlesticks.DataSource = visibleCandlesticks;

            LoadAvailableStocks();
        }

        private void LoadAvailableStocks()
        {
            string dataDirectory = GetBestDataDirectory();

            allStockData = StockRepository.LoadAllStocks(dataDirectory);

            checkedListBoxStocks.Items.Clear();

            foreach (string symbol in allStockData.Keys.OrderBy(s => s))
            {
                checkedListBoxStocks.Items.Add(symbol);
            }
        }

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            LoadAvailableStocks();

            if (checkedListBoxStocks.Items.Count == 0)
            {
                MessageBox.Show("No stock CSV files were found in the data folder.");
                return;
            }

            MessageBox.Show("Available stock datasets loaded.");
        }

        private void buttonUpdateData_Click(object sender, EventArgs e)
        {
            RenderSelectedStocks();
        }

        private void comboBoxPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBoxStocks.CheckedItems.Count > 0)
            {
                RenderSelectedStocks();
            }
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            if (checkedListBoxStocks.CheckedItems.Count > 0)
            {
                RenderSelectedStocks();
            }
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            if (checkedListBoxStocks.CheckedItems.Count > 0)
            {
                RenderSelectedStocks();
            }
        }

        private void checkedListBoxStocks_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            BeginInvoke(new Action(RenderSelectedStocks));
        }

        private void checkBoxSMA_CheckedChanged(object sender, EventArgs e)
        {
            if (checkedListBoxStocks.CheckedItems.Count > 0)
            {
                RenderSelectedStocks();
            }
        }

        private void checkBoxEMA_CheckedChanged(object sender, EventArgs e)
        {
            if (checkedListBoxStocks.CheckedItems.Count > 0)
            {
                RenderSelectedStocks();
            }
        }

        private void numericUpDownSMA_ValueChanged(object sender, EventArgs e)
        {
            if (checkedListBoxStocks.CheckedItems.Count > 0 && checkBoxSMA.Checked)
            {
                RenderSelectedStocks();
            }
        }

        private void numericUpDownEMA_ValueChanged(object sender, EventArgs e)
        {
            if (checkedListBoxStocks.CheckedItems.Count > 0 && checkBoxEMA.Checked)
            {
                RenderSelectedStocks();
            }
        }

        private void RenderSelectedStocks()
        {
            flowLayoutPanelCharts.Controls.Clear();

            if (allStockData.Count == 0)
            {
                MessageBox.Show("No stock data is loaded. Click Load Data first.");
                return;
            }

            var selectedSymbols = checkedListBoxStocks.CheckedItems
                .Cast<object>()
                .Select(item => item?.ToString())
                .Where(symbol => !string.IsNullOrWhiteSpace(symbol))
                .Cast<string>()
                .ToList();

            if (selectedSymbols.Count == 0)
            {
                visibleCandlesticks = new BindingList<Candlestick>();
                dataGridViewCandlesticks.DataSource = visibleCandlesticks;
                return;
            }

            DateTime startDate = dateTimePickerStart.Value.Date;
            DateTime endDate = dateTimePickerEnd.Value.Date;

            if (endDate < startDate)
            {
                (startDate, endDate) = (endDate, startDate);
            }

            string interval = comboBoxPeriod.SelectedItem?.ToString() ?? "Daily";

            List<Candlestick>? firstStockFiltered = null;

            foreach (string symbol in selectedSymbols)
            {
                if (!allStockData.ContainsKey(symbol))
                    continue;

                List<Candlestick> filtered = DataAggregator.GetFilteredData(
                    allStockData[symbol],
                    interval,
                    startDate,
                    endDate
                );

                if (filtered.Count == 0)
                    continue;

                List<IndicatorPoint>? smaPoints = null;
                List<IndicatorPoint>? emaPoints = null;

                if (checkBoxSMA.Checked)
                {
                    smaPoints = MovingAverageCalculator.CalculateSMA(
                        filtered,
                        (int)numericUpDownSMA.Value
                    );
                }

                if (checkBoxEMA.Checked)
                {
                    emaPoints = ExponentialMovingAverageCalculator.CalculateEMA(
                        filtered,
                        (int)numericUpDownEMA.Value
                    );
                }

                var stockPanel = StockChartPanelFactory.CreateStockPanel(symbol, out var chart);
                ChartRenderer.Render(chart, filtered, symbol, smaPoints, emaPoints);
                flowLayoutPanelCharts.Controls.Add(stockPanel);

                firstStockFiltered ??= filtered;
            }

            visibleCandlesticks = new BindingList<Candlestick>(firstStockFiltered ?? new List<Candlestick>());
            dataGridViewCandlesticks.DataSource = visibleCandlesticks;
        }

        private string GetBestDataDirectory()
        {
            string current = Directory.GetCurrentDirectory();

            string[] candidates =
            {
                Path.Combine(current, "data"),
                Path.Combine(current, "..", "data"),
                Path.Combine(current, "..", "..", "data"),
                Path.Combine(current, "..", "..", "..", "data"),
                Path.GetFullPath(Path.Combine(current, "..", "..", "..", "..", "data"))
            };

            foreach (string path in candidates)
            {
                string fullPath = Path.GetFullPath(path);
                if (Directory.Exists(fullPath))
                    return fullPath;
            }

            return current;
        }
    }
}