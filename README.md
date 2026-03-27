# 📈 Stock Market Analysis Platform

A desktop stock market visualization application built using **C# and .NET Windows Forms**.

The application loads historical stock market data from CSV files and visualizes price movement using **candlestick charts and trading volume graphs**. Users can filter datasets by date range and time aggregation to explore historical market behavior and trends.

This project focuses on applying **financial data processing, chart-based visualization, and object-oriented software design** in a desktop environment.

---

## 🚀 Project Overview

Financial markets generate large volumes of time-series data. Tools that can parse, process, and visualize this information are essential for understanding market trends and price movement.

This project provides a platform for:

* Importing historical stock data
* Parsing OHLC market information
* Visualizing candlestick price movement
* Displaying trading volume
* Filtering datasets by time range and aggregation level
* Comparing multiple stocks simultaneously

---

## 📊 Features

### ✅ Phase 1 — Data Loading & Visualization

* CSV data ingestion (Yahoo Finance format)
* Candlestick chart visualization
* Volume chart display
* Date range filtering
* Time aggregation (Daily, Weekly, Monthly)
* Moving average overlay
* CSV validation and error handling
* Export filtered datasets

---

### 🚧 Phase 2 — Multi-Stock Comparison

* Multi-stock selection via checkbox list
* Dynamic chart panel generation
* Side-by-side stock comparison
* Shared filtering across all stocks
* Combined price + volume chart per stock
* Improved UI layout using FlowLayoutPanel

---

## 🖥️ Visual Output

### 📊 Phase 1 — Single Stock Visualization

* Candlestick + volume chart for a single selected stock
* Basic filtering and data exploration

![Phase 1 Output](images/phase1-chart.png)

---

### 📈 Phase 2 — Multi-Stock Comparison

* Multiple stocks displayed simultaneously
* Dynamic chart panels for each selected symbol
* Shared filtering across all stocks
* Closer to real-world trading platform experience

![Phase 2 Output](images/phase2-multistock.png)

---

## 🧠 Architecture Overview

The application follows a modular object-oriented design:

### Models

* Candlestick
* StockDataset

### Services

* CSV loading
* Data aggregation
* Stock repository

### Rendering

* Chart generation (candlestick + volume)

### UI

* User interaction
* Dynamic panel generation
* Filtering controls

---

## ⚙️ Technologies Used

### Language

* C#

### Framework

* .NET 8 Windows Forms

### Libraries / Components

* WinForms Chart Control
* DataGridView
* CSV processing

---

## 📁 Project Structure

```
stock-market-analysis-platform
│
├── data
├── docs
│   ├── PHASE_1.md
│   ├── PHASE_2.md
│   ├── ARCHITECTURE.md
│   ├── DEMO.md
│   └── SETUP.md
│
├── src
│   └── candlestick-visualization
│       ├── Phase1_CandlestickVisualization
│       └── Phase2_MultiStockAnalysis
│
├── images
│   ├── phase1-chart.png
│   └── phase2-multistock.png
│
├── README.md
├── LICENSE
└── .gitignore
```

---

## 🧪 Running the Project

```bash
cd src/candlestick-visualization/Phase2_MultiStockAnalysis
dotnet run
```

---

## 📌 Data Format

Expected CSV format (Yahoo Finance style):

```
Date,Open,High,Low,Close,Adj Close,Volume
2023-01-03,130.28,130.90,124.17,125.07,125.07,112117500
```

---

## 🔮 Future Development (Phase 3)

* Technical indicators (RSI, MACD)
* Moving averages (SMA, EMA)
* Pattern recognition
* Real-time data integration
* Advanced analytics dashboard

---

## 💡 Key Takeaways

* Built a full pipeline from raw CSV data to visual analysis
* Designed scalable architecture for financial data applications
* Implemented multi-stock comparison similar to trading platforms
* Focused on clean separation of concerns and extensibility

---

## 📄 License

This project is licensed under the **MIT License**.
