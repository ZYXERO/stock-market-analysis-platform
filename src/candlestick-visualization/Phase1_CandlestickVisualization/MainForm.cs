using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CandlestickVisualization
{
    public partial class MainForm : Form
    {
        private List<Candlestick> allCandlesticks = new List<Candlestick>();
        private BindingList<Candlestick> visibleCandlesticks = new BindingList<Candlestick>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dateTimePickerStart.Value = DateTime.Today.AddYears(-1);
            dateTimePickerEnd.Value = DateTime.Today;

            if (comboBoxPeriod.Items.Count == 0)
            {
                comboBoxPeriod.Items.AddRange(new object[] { "Day", "Week", "Month" });
            }

            comboBoxPeriod.SelectedItem = "Day";

            ChartRenderer.ConfigureChart(chartStockData);

            dataGridViewCandlesticks.AutoGenerateColumns = false;
            dataGridViewCandlesticks.DataSource = visibleCandlesticks;
        }

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            string path = ResolveCsvPath();

            if (string.IsNullOrWhiteSpace(path))
            {
                openFileDialogStockData.InitialDirectory = GetBestDataDirectory();
                openFileDialogStockData.Filter = "CSV Files (*.csv)|*.csv";

                if (openFileDialogStockData.ShowDialog() != DialogResult.OK)
                    return;

                path = openFileDialogStockData.FileName;
            }

            LoadDataFromPath(path);
        }

        private void buttonUpdateData_Click(object sender, EventArgs e)
        {
            if (allCandlesticks == null || allCandlesticks.Count == 0)
            {
                string path = ResolveCsvPath();
                if (string.IsNullOrWhiteSpace(path))
                {
                    MessageBox.Show("Load a CSV file or enter a valid stock symbol and period first.");
                    return;
                }

                LoadDataFromPath(path);
                return;
            }

            RefreshDisplay();
        }

        private void comboBoxPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = ResolveCsvPathFromFields();

            if (!string.IsNullOrWhiteSpace(path))
            {
                LoadDataFromPath(path);
            }
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            if (allCandlesticks.Count > 0)
                RefreshDisplay();
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            if (allCandlesticks.Count > 0)
                RefreshDisplay();
        }

        private void LoadDataFromPath(string path)
        {
            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
            {
                MessageBox.Show("CSV file could not be found.");
                return;
            }

            allCandlesticks = CsvLoader.ReadCandlesticksFromFile(path);

            if (allCandlesticks.Count == 0)
            {
                MessageBox.Show("No valid candlestick rows were found in the selected CSV.");
                visibleCandlesticks = new BindingList<Candlestick>();
                dataGridViewCandlesticks.DataSource = visibleCandlesticks;
                ChartRenderer.Render(chartStockData, new List<Candlestick>());
                return;
            }

            RefreshDisplay();
        }

        private void RefreshDisplay()
        {
            var filtered = FilterCandlesticks(
                allCandlesticks,
                dateTimePickerStart.Value,
                dateTimePickerEnd.Value
            );

            visibleCandlesticks = new BindingList<Candlestick>(filtered);
            dataGridViewCandlesticks.DataSource = visibleCandlesticks;

            ChartRenderer.Render(chartStockData, filtered);
        }

        private List<Candlestick> FilterCandlesticks(List<Candlestick> source, DateTime startDate, DateTime endDate)
        {
            if (source == null)
                return new List<Candlestick>();

            if (endDate < startDate)
            {
                DateTime temp = startDate;
                startDate = endDate;
                endDate = temp;
            }

            return source
                .Where(c => c.Date.Date >= startDate.Date && c.Date.Date <= endDate.Date)
                .OrderBy(c => c.Date)
                .ToList();
        }

        private string ResolveCsvPath()
        {
            string byFields = ResolveCsvPathFromFields();
            if (!string.IsNullOrWhiteSpace(byFields))
                return byFields;

            if (!string.IsNullOrWhiteSpace(openFileDialogStockData.FileName) &&
                File.Exists(openFileDialogStockData.FileName))
            {
                return openFileDialogStockData.FileName;
            }

            return null;
        }

        private string ResolveCsvPathFromFields()
        {
            string symbol = (textBoxSymbol.Text ?? string.Empty).Trim().ToUpperInvariant();
            if (string.IsNullOrWhiteSpace(symbol))
                return null;

            string suffix = GetSelectedPeriodSuffix();
            string directory = GetBestDataDirectory();

            string candidate = Path.Combine(directory, $"{symbol}-{suffix}.csv");
            return File.Exists(candidate) ? candidate : null;
        }

        private string GetSelectedPeriodSuffix()
        {
            string value = comboBoxPeriod?.SelectedItem?.ToString()?.Trim().ToLowerInvariant() ?? "day";

            switch (value)
            {
                case "day":
                case "daily":
                    return "Day";
                case "week":
                case "weekly":
                    return "Week";
                case "month":
                case "monthly":
                    return "Month";
                default:
                    return "Day";
            }
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