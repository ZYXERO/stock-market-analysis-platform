# Project Architecture

This document describes the structure and components of the Candlestick Visualization module.

---

## High-Level Overview

The application reads historical stock data from CSV files, converts them into structured objects, and renders candlestick charts using the Windows Forms charting library.

The architecture separates the responsibilities of:

- data loading
- data modeling
- visualization
- user interface

---

## Core Components

### Program.cs

Entry point of the application.

Responsible for starting the Windows Forms application and launching the main interface.


Application.Run(new MainForm());


---

### MainForm.cs

The primary user interface controller.

Responsibilities include:

- handling user input
- loading CSV datasets
- filtering data by date
- updating chart visualizations
- displaying tabular stock data

The form coordinates interactions between the UI and backend logic.

---

### MainForm.Designer.cs

Auto-generated Windows Forms designer file.

Responsible for defining the layout and UI components such as:

- text boxes
- date pickers
- buttons
- chart controls
- data tables

---

### Candlestick.cs

Defines the data model representing a single trading period.

Each object contains:

- Date
- OpeningPrice
- MaximumPrice
- MinimumPrice
- ClosingPrice
- Volume

This represents standard **OHLCV financial market data**.

---

### CsvLoader.cs

Handles reading stock data from CSV files.

Responsibilities include:

- reading CSV file lines
- parsing numeric and date values
- validating data
- converting rows into `Candlestick` objects

Output:


List<Candlestick>


This list becomes the application's internal dataset.

---

### ChartRenderer.cs

Responsible for rendering candlestick charts and volume charts.

Uses the .NET library:


System.Windows.Forms.DataVisualization.Charting


Responsibilities include:

- creating candlestick chart points
- plotting trading volume
- formatting chart axes
- updating charts when data changes

---

## Data Flow

The application follows this processing pipeline:


CSV Dataset
↓
CsvLoader
↓
List<Candlestick>
↓
MainForm
↓
ChartRenderer
↓
Candlestick Chart + Volume Chart


---

## Repository Structure


StockMarketAnalysisPlatform
│
├─ candlestick-visualization
│ ├─ CandlestickVisualization.sln
│ └─ CandlestickVisualization
│ ├─ Candlestick.cs
│ ├─ CsvLoader.cs
│ ├─ ChartRenderer.cs
│ ├─ MainForm.cs
│ ├─ MainForm.Designer.cs
│ ├─ Program.cs
│ └─ CandlestickVisualization.csproj
│
├─ data
│
├─ docs
│ ├─ SETUP.md
│ ├─ DEMO.md
│ └─ ARCHITECTURE.md


---

## Future Extensions

Planned enhancements for the Stock Market Analysis Platform may include:

- multi-stock chart comparison
- technical indicators (moving averages, RSI, MACD)
- pattern recognition algorithms
- automated trading signal detection
- real-time data integration
- exporting filtered datasets