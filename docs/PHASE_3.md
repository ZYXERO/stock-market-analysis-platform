# 📉 Phase 3 — Technical Analysis

Phase 3 extends the stock analysis platform by introducing **technical indicators**, enabling deeper insight into market trends and price behavior.

This phase builds directly on Phase 2 by adding an analytical layer on top of multi-stock visualization.

---

## 🎯 Objective

Enhance the platform to support:

- Trend analysis
- Smoothing of price data
- Identification of momentum and direction

---

## 📊 Features Implemented

### ✅ Simple Moving Average (SMA)
- Calculates average closing price over a specified period
- Smooths short-term fluctuations
- Helps identify overall trend direction

---

### ✅ Exponential Moving Average (EMA)
- Weighted moving average
- Gives higher importance to recent prices
- More responsive to price changes than SMA

---

### ✅ Indicator Controls (UI)
- Toggle SMA and EMA on/off
- Adjustable period values (e.g., 20, 50)
- Dynamic updates when values change

---

### ✅ Chart Overlay Integration
- Indicators rendered directly on candlestick charts
- Multiple indicators can be displayed simultaneously
- Works across all selected stocks

---

## 🖥️ Visual Output

Below is an example of technical indicators applied to multi-stock charts:

![Phase 3 Output](../images/Phase3-TechnicalAnalysis.jpg)

---

## 🧠 Technical Implementation

### Indicators Layer

- **MovingAverageCalculator**
  - Computes SMA values
  - Uses sliding window average

- **ExponentialMovingAverageCalculator**
  - Applies exponential smoothing formula
  - Uses previous EMA values for calculation

---

### Rendering Enhancements

- Extended `ChartRenderer` to:
  - Plot SMA and EMA as line series
  - Overlay indicators on candlestick chart
  - Maintain chart clarity and scaling

---

### UI Integration

- Added:
  - Checkboxes for SMA and EMA
  - Numeric inputs for period selection
- Events trigger re-rendering dynamically

---

## 🔄 Data Flow (Phase 3)

```

Filtered Candlestick Data
↓
Indicator Calculations (SMA / EMA)
↓
ChartRenderer (Overlay Indicators)
↓
Updated Chart Display

```id="3d3ptn"

---

## 📈 Example Use Case

> A user selects AAPL and AMZN and enables SMA (20) and EMA (50)

The application:
- Calculates moving averages
- Overlays them on each chart
- Allows comparison of trend behavior across stocks

---

## 🚀 Impact of Phase 3

- Transforms the app from visualization tool → analysis tool
- Introduces real-world trading concepts
- Enables users to identify:
  - Trends
  - Momentum shifts
  - Potential entry/exit signals

---

## 🔮 Future Extensions

- RSI (Relative Strength Index)
- MACD (Moving Average Convergence Divergence)
- Bollinger Bands
- Signal-based alerts (buy/sell)

---

## 💡 Summary

Phase 3 introduces a critical layer of financial analysis by integrating technical indicators into the visualization pipeline.

This enhancement significantly increases the platform’s usefulness and brings it closer to real-world trading and analytics tools.