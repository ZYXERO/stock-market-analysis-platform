using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Phase2_MultiStockAnalysis.UI
{
    public static class StockChartPanelFactory
    {
        public static Panel CreateStockPanel(string symbol, out Chart chart)
        {
            var container = new Panel
            {
                Width = 980,
                Height = 420,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10),
                BackColor = Color.White
            };

            var label = new Label
            {
                Text = symbol,
                Dock = DockStyle.Top,
                Height = 32,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };

            chart = new Chart
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                BorderlineColor = Color.LightGray,
                BorderlineDashStyle = ChartDashStyle.Solid,
                BorderlineWidth = 1
            };

            container.Controls.Add(chart);
            container.Controls.Add(label);

            return container;
        }
    }
}