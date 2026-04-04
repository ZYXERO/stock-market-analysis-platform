````md
# 🎬 Demo — Stock Market Analysis Platform

This document provides a walkthrough of the application and how to demonstrate its core functionality across all phases.

---

## 🎯 Demo Objective

Show how the platform:

- Loads and processes stock data
- Visualizes price movement using candlestick charts
- Compares multiple stocks simultaneously
- Applies technical indicators (SMA & EMA)

---

## 🧪 Demo Setup

### 1. Run the Application

```bash
cd src/candlestick-visualization/Phase3_TechnicalAnalysis
dotnet run
````

---

### 2. Load Data

* Click **"Load Datasets"**
* The application scans the `/data` folder
* Available stock symbols appear in the list

---

## 📊 Phase 1 Demo — Single Stock

### Steps:

1. Select one stock (e.g., AAPL)
2. Choose:

   * Start Date
   * End Date
   * Period (Daily / Weekly / Monthly)
3. Click **"Render Selected"**

### What to highlight:

* Candlestick chart shows price movement
* Volume bars displayed below
* Data table updates with filtered results

---

## 📈 Phase 2 Demo — Multi-Stock Comparison

### Steps:

1. Select multiple stocks (e.g., AAPL, AMZN, ABBV)
2. Click **"Render Selected"**

### What to highlight:

* Each stock appears in its own chart panel
* Charts are stacked vertically
* All charts share the same filters
* Enables side-by-side comparison

---

## 📉 Phase 3 Demo — Technical Analysis

### Steps:

1. Select at least one stock
2. Enable:

   * ✅ SMA (Simple Moving Average)
   * ✅ EMA (Exponential Moving Average)
3. Adjust periods (e.g., 20, 50)
4. Click **"Render Selected"**

### What to highlight:

* SMA and EMA lines overlay on candlestick chart
* Smooth trend visualization
* Ability to tweak indicator periods dynamically

---

## 💡 Key Talking Points

* Built full pipeline from raw CSV → processed → visualized
* Modular architecture enables easy feature expansion
* Phase progression shows system scalability:

  * Phase 1 → Visualization
  * Phase 2 → Multi-stock scaling
  * Phase 3 → Technical analysis
* Mimics functionality found in real trading platforms

---

## 🧠 Example Use Case

> "A user wants to compare AAPL and AMZN performance over the past year and identify trends using moving averages."

Steps:

* Select AAPL + AMZN
* Set date range (1 year)
* Enable SMA + EMA
* Analyze crossover trends

---

## 🚀 Demo Conclusion

This project demonstrates:

* Data processing from financial datasets
* Interactive UI design
* Multi-entity visualization
* Technical analysis integration

---

## 📌 Future Demo Ideas

* Add RSI / MACD for deeper analysis
* Highlight buy/sell signals
* Integrate real-time stock data APIs

```
```
