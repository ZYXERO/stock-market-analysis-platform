
namespace Phase3_TechnicalAnalysis
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.buttonUpdateData = new System.Windows.Forms.Button();
            this.dataGridViewCandlesticks = new System.Windows.Forms.DataGridView();
            this.columnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnOpen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnHigh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnClose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxPeriod = new System.Windows.Forms.ComboBox();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelStocks = new System.Windows.Forms.Label();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.checkedListBoxStocks = new System.Windows.Forms.CheckedListBox();
            this.flowLayoutPanelCharts = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxSMA = new System.Windows.Forms.CheckBox();
            this.checkBoxEMA = new System.Windows.Forms.CheckBox();
            this.numericUpDownSMA = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEMA = new System.Windows.Forms.NumericUpDown();
            this.labelSMA = new System.Windows.Forms.Label();
            this.labelEMA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCandlesticks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEMA)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(120, 20);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(250, 26);
            this.dateTimePickerStart.TabIndex = 0;
            this.dateTimePickerStart.ValueChanged += new System.EventHandler(this.dateTimePickerStart_ValueChanged);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(120, 60);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(250, 26);
            this.dateTimePickerEnd.TabIndex = 1;
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePickerEnd_ValueChanged);
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.Location = new System.Drawing.Point(30, 370);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(150, 40);
            this.buttonLoadData.TabIndex = 8;
            this.buttonLoadData.Text = "Load Datasets";
            this.buttonLoadData.UseVisualStyleBackColor = true;
            this.buttonLoadData.Click += new System.EventHandler(this.buttonLoadData_Click);
            // 
            // buttonUpdateData
            // 
            this.buttonUpdateData.Location = new System.Drawing.Point(200, 370);
            this.buttonUpdateData.Name = "buttonUpdateData";
            this.buttonUpdateData.Size = new System.Drawing.Size(170, 40);
            this.buttonUpdateData.TabIndex = 9;
            this.buttonUpdateData.Text = "Render Selected";
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
            this.dataGridViewCandlesticks.Location = new System.Drawing.Point(20, 650);
            this.dataGridViewCandlesticks.Name = "dataGridViewCandlesticks";
            this.dataGridViewCandlesticks.RowHeadersWidth = 62;
            this.dataGridViewCandlesticks.RowTemplate.Height = 28;
            this.dataGridViewCandlesticks.Size = new System.Drawing.Size(1260, 220);
            this.dataGridViewCandlesticks.TabIndex = 10;
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
            this.columnOpen.DataPropertyName = "Open";
            this.columnOpen.HeaderText = "Open";
            this.columnOpen.MinimumWidth = 8;
            this.columnOpen.Name = "columnOpen";
            this.columnOpen.ReadOnly = true;
            // 
            // columnHigh
            // 
            this.columnHigh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnHigh.DataPropertyName = "High";
            this.columnHigh.HeaderText = "High";
            this.columnHigh.MinimumWidth = 8;
            this.columnHigh.Name = "columnHigh";
            this.columnHigh.ReadOnly = true;
            // 
            // columnLow
            // 
            this.columnLow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnLow.DataPropertyName = "Low";
            this.columnLow.HeaderText = "Low";
            this.columnLow.MinimumWidth = 8;
            this.columnLow.Name = "columnLow";
            this.columnLow.ReadOnly = true;
            // 
            // columnClose
            // 
            this.columnClose.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnClose.DataPropertyName = "Close";
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
            // comboBoxPeriod
            // 
            this.comboBoxPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPeriod.FormattingEnabled = true;
            this.comboBoxPeriod.Location = new System.Drawing.Point(120, 100);
            this.comboBoxPeriod.Name = "comboBoxPeriod";
            this.comboBoxPeriod.Size = new System.Drawing.Size(250, 28);
            this.comboBoxPeriod.TabIndex = 2;
            this.comboBoxPeriod.SelectedIndexChanged += new System.EventHandler(this.comboBoxPeriod_SelectedIndexChanged);
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(30, 25);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(83, 20);
            this.labelStartDate.TabIndex = 11;
            this.labelStartDate.Text = "Start Date";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(30, 65);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(77, 20);
            this.labelEndDate.TabIndex = 12;
            this.labelEndDate.Text = "End Date";
            // 
            // labelStocks
            // 
            this.labelStocks.AutoSize = true;
            this.labelStocks.Location = new System.Drawing.Point(30, 145);
            this.labelStocks.Name = "labelStocks";
            this.labelStocks.Size = new System.Drawing.Size(54, 20);
            this.labelStocks.TabIndex = 13;
            this.labelStocks.Text = "Stocks";
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Location = new System.Drawing.Point(30, 105);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(54, 20);
            this.labelPeriod.TabIndex = 14;
            this.labelPeriod.Text = "Period";
            // 
            // checkedListBoxStocks
            // 
            this.checkedListBoxStocks.CheckOnClick = true;
            this.checkedListBoxStocks.FormattingEnabled = true;
            this.checkedListBoxStocks.Location = new System.Drawing.Point(120, 145);
            this.checkedListBoxStocks.Name = "checkedListBoxStocks";
            this.checkedListBoxStocks.Size = new System.Drawing.Size(250, 92);
            this.checkedListBoxStocks.TabIndex = 3;
            this.checkedListBoxStocks.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxStocks_ItemCheck);
            // 
            // flowLayoutPanelCharts
            // 
            this.flowLayoutPanelCharts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelCharts.AutoScroll = true;
            this.flowLayoutPanelCharts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelCharts.Location = new System.Drawing.Point(400, 20);
            this.flowLayoutPanelCharts.Name = "flowLayoutPanelCharts";
            this.flowLayoutPanelCharts.Size = new System.Drawing.Size(880, 610);
            this.flowLayoutPanelCharts.TabIndex = 15;
            this.flowLayoutPanelCharts.WrapContents = false;
            // 
            // checkBoxSMA
            // 
            this.checkBoxSMA.AutoSize = true;
            this.checkBoxSMA.Location = new System.Drawing.Point(34, 255);
            this.checkBoxSMA.Name = "checkBoxSMA";
            this.checkBoxSMA.Size = new System.Drawing.Size(70, 24);
            this.checkBoxSMA.TabIndex = 4;
            this.checkBoxSMA.Text = "SMA";
            this.checkBoxSMA.UseVisualStyleBackColor = true;
            this.checkBoxSMA.CheckedChanged += new System.EventHandler(this.checkBoxSMA_CheckedChanged);
            // 
            // checkBoxEMA
            // 
            this.checkBoxEMA.AutoSize = true;
            this.checkBoxEMA.Location = new System.Drawing.Point(34, 315);
            this.checkBoxEMA.Name = "checkBoxEMA";
            this.checkBoxEMA.Size = new System.Drawing.Size(69, 24);
            this.checkBoxEMA.TabIndex = 6;
            this.checkBoxEMA.Text = "EMA";
            this.checkBoxEMA.UseVisualStyleBackColor = true;
            this.checkBoxEMA.CheckedChanged += new System.EventHandler(this.checkBoxEMA_CheckedChanged);
            // 
            // numericUpDownSMA
            // 
            this.numericUpDownSMA.Location = new System.Drawing.Point(250, 254);
            this.numericUpDownSMA.Name = "numericUpDownSMA";
            this.numericUpDownSMA.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownSMA.TabIndex = 5;
            this.numericUpDownSMA.ValueChanged += new System.EventHandler(this.numericUpDownSMA_ValueChanged);
            // 
            // numericUpDownEMA
            // 
            this.numericUpDownEMA.Location = new System.Drawing.Point(250, 314);
            this.numericUpDownEMA.Name = "numericUpDownEMA";
            this.numericUpDownEMA.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownEMA.TabIndex = 7;
            this.numericUpDownEMA.ValueChanged += new System.EventHandler(this.numericUpDownEMA_ValueChanged);
            // 
            // labelSMA
            // 
            this.labelSMA.AutoSize = true;
            this.labelSMA.Location = new System.Drawing.Point(128, 257);
            this.labelSMA.Name = "labelSMA";
            this.labelSMA.Size = new System.Drawing.Size(92, 20);
            this.labelSMA.TabIndex = 18;
            this.labelSMA.Text = "SMA Period";
            // 
            // labelEMA
            // 
            this.labelEMA.AutoSize = true;
            this.labelEMA.Location = new System.Drawing.Point(128, 317);
            this.labelEMA.Name = "labelEMA";
            this.labelEMA.Size = new System.Drawing.Size(91, 20);
            this.labelEMA.TabIndex = 19;
            this.labelEMA.Text = "EMA Period";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 891);
            this.Controls.Add(this.labelEMA);
            this.Controls.Add(this.labelSMA);
            this.Controls.Add(this.numericUpDownEMA);
            this.Controls.Add(this.numericUpDownSMA);
            this.Controls.Add(this.checkBoxEMA);
            this.Controls.Add(this.checkBoxSMA);
            this.Controls.Add(this.flowLayoutPanelCharts);
            this.Controls.Add(this.checkedListBoxStocks);
            this.Controls.Add(this.labelPeriod);
            this.Controls.Add(this.labelStocks);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.comboBoxPeriod);
            this.Controls.Add(this.dataGridViewCandlesticks);
            this.Controls.Add(this.buttonUpdateData);
            this.Controls.Add(this.buttonLoadData);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Name = "MainForm";
            this.Text = "Phase 3 - Technical Analysis";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCandlesticks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEMA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Button buttonLoadData;
        private System.Windows.Forms.Button buttonUpdateData;
        private System.Windows.Forms.DataGridView dataGridViewCandlesticks;
        private System.Windows.Forms.ComboBox comboBoxPeriod;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelStocks;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.CheckedListBox checkedListBoxStocks;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCharts;
        private System.Windows.Forms.CheckBox checkBoxSMA;
        private System.Windows.Forms.CheckBox checkBoxEMA;
        private System.Windows.Forms.NumericUpDown numericUpDownSMA;
        private System.Windows.Forms.NumericUpDown numericUpDownEMA;
        private System.Windows.Forms.Label labelSMA;
        private System.Windows.Forms.Label labelEMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnOpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnHigh;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLow;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnVolume;
    }
}