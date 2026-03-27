namespace CandlestickVisualization
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.openFileDialogStockData = new System.Windows.Forms.OpenFileDialog();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.buttonUpdateData = new System.Windows.Forms.Button();
            this.dataGridViewCandlesticks = new System.Windows.Forms.DataGridView();
            this.chartStockData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxSymbol = new System.Windows.Forms.TextBox();
            this.comboBoxPeriod = new System.Windows.Forms.ComboBox();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelStockSymbol = new System.Windows.Forms.Label();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.columnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnOpen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnHigh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnClose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCandlesticks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStockData)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(130, 30);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(260, 26);
            this.dateTimePickerStart.TabIndex = 0;
            this.dateTimePickerStart.ValueChanged += new System.EventHandler(this.dateTimePickerStart_ValueChanged);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(130, 80);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(260, 26);
            this.dateTimePickerEnd.TabIndex = 1;
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePickerEnd_ValueChanged);
            // 
            // openFileDialogStockData
            // 
            this.openFileDialogStockData.FileName = "openFileDialogStockData";
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.Location = new System.Drawing.Point(130, 230);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(120, 40);
            this.buttonLoadData.TabIndex = 4;
            this.buttonLoadData.Text = "Load Data";
            this.buttonLoadData.UseVisualStyleBackColor = true;
            this.buttonLoadData.Click += new System.EventHandler(this.buttonLoadData_Click);
            // 
            // buttonUpdateData
            // 
            this.buttonUpdateData.Location = new System.Drawing.Point(270, 230);
            this.buttonUpdateData.Name = "buttonUpdateData";
            this.buttonUpdateData.Size = new System.Drawing.Size(120, 40);
            this.buttonUpdateData.TabIndex = 5;
            this.buttonUpdateData.Text = "Update Data";
            this.buttonUpdateData.UseVisualStyleBackColor = true;
            this.buttonUpdateData.Click += new System.EventHandler(this.buttonUpdateData_Click);
            // 
            // dataGridViewCandlesticks
            // 
            this.dataGridViewCandlesticks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCandlesticks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCandlesticks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnDate,
            this.columnOpen,
            this.columnHigh,
            this.columnLow,
            this.columnClose,
            this.columnVolume});
            this.dataGridViewCandlesticks.Location = new System.Drawing.Point(20, 460);
            this.dataGridViewCandlesticks.Name = "dataGridViewCandlesticks";
            this.dataGridViewCandlesticks.RowHeadersWidth = 62;
            this.dataGridViewCandlesticks.RowTemplate.Height = 28;
            this.dataGridViewCandlesticks.Size = new System.Drawing.Size(1180, 250);
            this.dataGridViewCandlesticks.TabIndex = 7;
            // 
            // chartStockData
            // 
            this.chartStockData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartStockData.Location = new System.Drawing.Point(430, 20);
            this.chartStockData.Name = "chartStockData";
            this.chartStockData.Size = new System.Drawing.Size(770, 420);
            this.chartStockData.TabIndex = 6;
            this.chartStockData.Text = "chartStockData";
            // 
            // textBoxSymbol
            // 
            this.textBoxSymbol.Location = new System.Drawing.Point(130, 130);
            this.textBoxSymbol.Name = "textBoxSymbol";
            this.textBoxSymbol.Size = new System.Drawing.Size(260, 26);
            this.textBoxSymbol.TabIndex = 2;
            this.textBoxSymbol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxPeriod
            // 
            this.comboBoxPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPeriod.FormattingEnabled = true;
            this.comboBoxPeriod.Items.AddRange(new object[] {
            "Day",
            "Week",
            "Month"});
            this.comboBoxPeriod.Location = new System.Drawing.Point(130, 180);
            this.comboBoxPeriod.Name = "comboBoxPeriod";
            this.comboBoxPeriod.Size = new System.Drawing.Size(260, 28);
            this.comboBoxPeriod.TabIndex = 3;
            this.comboBoxPeriod.SelectedIndexChanged += new System.EventHandler(this.comboBoxPeriod_SelectedIndexChanged);
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(20, 35);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(83, 20);
            this.labelStartDate.TabIndex = 8;
            this.labelStartDate.Text = "Start Date";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(20, 85);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(77, 20);
            this.labelEndDate.TabIndex = 9;
            this.labelEndDate.Text = "End Date";
            // 
            // labelStockSymbol
            // 
            this.labelStockSymbol.AutoSize = true;
            this.labelStockSymbol.Location = new System.Drawing.Point(20, 135);
            this.labelStockSymbol.Name = "labelStockSymbol";
            this.labelStockSymbol.Size = new System.Drawing.Size(106, 20);
            this.labelStockSymbol.TabIndex = 10;
            this.labelStockSymbol.Text = "Stock Symbol";
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Location = new System.Drawing.Point(20, 185);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(54, 20);
            this.labelPeriod.TabIndex = 11;
            this.labelPeriod.Text = "Period";
            // 
            // columnDate
            // 
            this.columnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnDate.DataPropertyName = "Date";
            this.columnDate.HeaderText = "Date";
            this.columnDate.MinimumWidth = 8;
            this.columnDate.Name = "columnDate";
            this.columnDate.ReadOnly = true;
            // 
            // columnOpen
            // 
            this.columnOpen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnOpen.DataPropertyName = "OpeningPrice";
            this.columnOpen.HeaderText = "Open";
            this.columnOpen.MinimumWidth = 8;
            this.columnOpen.Name = "columnOpen";
            this.columnOpen.ReadOnly = true;
            // 
            // columnHigh
            // 
            this.columnHigh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnHigh.DataPropertyName = "MaximumPrice";
            this.columnHigh.HeaderText = "High";
            this.columnHigh.MinimumWidth = 8;
            this.columnHigh.Name = "columnHigh";
            this.columnHigh.ReadOnly = true;
            // 
            // columnLow
            // 
            this.columnLow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnLow.DataPropertyName = "MinimumPrice";
            this.columnLow.HeaderText = "Low";
            this.columnLow.MinimumWidth = 8;
            this.columnLow.Name = "columnLow";
            this.columnLow.ReadOnly = true;
            // 
            // columnClose
            // 
            this.columnClose.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnClose.DataPropertyName = "ClosingPrice";
            this.columnClose.HeaderText = "Close";
            this.columnClose.MinimumWidth = 8;
            this.columnClose.Name = "columnClose";
            this.columnClose.ReadOnly = true;
            // 
            // columnVolume
            // 
            this.columnVolume.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnVolume.DataPropertyName = "Volume";
            this.columnVolume.HeaderText = "Volume";
            this.columnVolume.MinimumWidth = 8;
            this.columnVolume.Name = "columnVolume";
            this.columnVolume.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 731);
            this.Controls.Add(this.labelPeriod);
            this.Controls.Add(this.labelStockSymbol);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.comboBoxPeriod);
            this.Controls.Add(this.textBoxSymbol);
            this.Controls.Add(this.chartStockData);
            this.Controls.Add(this.dataGridViewCandlesticks);
            this.Controls.Add(this.buttonUpdateData);
            this.Controls.Add(this.buttonLoadData);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Name = "MainForm";
            this.Text = "Candlestick Visualization";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCandlesticks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStockData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.OpenFileDialog openFileDialogStockData;
        private System.Windows.Forms.Button buttonLoadData;
        private System.Windows.Forms.Button buttonUpdateData;
        private System.Windows.Forms.DataGridView dataGridViewCandlesticks;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStockData;
        private System.Windows.Forms.TextBox textBoxSymbol;
        private System.Windows.Forms.ComboBox comboBoxPeriod;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelStockSymbol;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnOpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnHigh;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLow;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnVolume;
    }
}