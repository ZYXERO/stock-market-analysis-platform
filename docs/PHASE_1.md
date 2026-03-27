# Phase 1 — Data Loading & Candlestick Visualization

## Objective

The goal of Phase 1 was to build the core foundation of the stock analysis platform by focusing on data ingestion, processing, and visualization.

---

## Key Features

### CSV Data Loading

- Loads historical stock data from CSV files
- Supports Yahoo Finance format
- Parses OHLCV (Open, High, Low, Close, Volume)

---

### Data Processing

- Converts raw CSV data into structured `Candlestick` objects
- Ensures data consistency through validation
- Skips malformed or invalid rows

---

### Candlestick Chart Visualization

- Displays stock price movement using candlestick charts
- Each candlestick represents:
  - Open
  - High
  - Low
  - Close

---

### Volume Visualization

- Displays trading volume below the price chart
- Helps correlate price movement with market activity

---

### Filtering Capabilities

- Stock symbol selection
- Date range filtering
- Time aggregation:
  - Daily
  - Weekly
  - Monthly

---

### Moving Average Overlay

- Adds smoothing to price data
- Helps identify trends over time

---

### Export Functionality

- Allows exporting filtered datasets to CSV
- Enables reuse of processed data

---

## Architecture Contributions

- Introduced `Candlestick` data model
- Implemented CSV parsing and validation
- Built chart rendering system
- Established UI for data interaction

---

## Outcome

Phase 1 resulted in a fully functional application capable of loading, filtering, and visualizing a single stock dataset using candlestick and volume charts.