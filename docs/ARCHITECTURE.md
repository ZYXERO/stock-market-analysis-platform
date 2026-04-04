```md id="b9x8pt"
# 🧠 Architecture Overview — Stock Market Analysis Platform

This document outlines the system design and architecture used to build the Stock Market Analysis Platform.

The application follows a **modular, layered architecture** to ensure scalability, maintainability, and clear separation of concerns.

---

## 🏗️ High-Level Architecture

The system is divided into five core layers:

```

Data Layer → Models → Services → Rendering → UI

```

Each layer has a specific responsibility, allowing the application to evolve across phases without breaking existing functionality.

---

## 📦 Core Components

### 📁 Models

Represents structured data used across the application.

- **Candlestick**
  - Stores OHLC (Open, High, Low, Close) data
  - Includes volume and timestamp

- **StockDataset**
  - Groups candlestick data by:
    - Daily
    - Weekly
    - Monthly

- **IndicatorPoint**
  - Represents calculated indicator values (SMA / EMA)
  - Contains date + computed value

---

### ⚙️ Services

Handles data ingestion and transformation logic.

- **CsvLoader**
  - Parses CSV files
  - Converts raw data into Candlestick objects

- **DataAggregator**
  - Filters data by:
    - Date range
    - Time interval (Daily / Weekly / Monthly)

- **StockRepository**
  - Loads all datasets from `/data` directory
  - Organizes them into structured collections

---

### 📊 Indicators (Phase 3)

Responsible for technical analysis calculations.

- **MovingAverageCalculator (SMA)**
  - Calculates simple moving average over a given period

- **ExponentialMovingAverageCalculator (EMA)**
  - Calculates weighted moving average
  - Gives higher importance to recent data

---

### 🎨 Rendering Layer

Responsible for visualization.

- **ChartRenderer**
  - Renders:
    - Candlestick charts
    - Volume charts
    - Indicator overlays (SMA / EMA)
  - Uses WinForms DataVisualization library

---

### 🖥️ UI Layer

Handles user interaction and layout.

- **MainForm**
  - Core application interface
  - Controls:
    - Date selection
    - Stock selection
    - Indicator toggles
  - Triggers data processing and rendering

- **StockChartPanelFactory**
  - Dynamically generates chart panels for each stock
  - Enables scalable multi-stock rendering (Phase 2+)

---

## 🔄 Data Flow

```

CSV Files → CsvLoader → Candlestick Objects
↓
StockRepository
↓
DataAggregator (filtering)
↓
Indicator Calculations (SMA / EMA)
↓
ChartRenderer
↓
UI (MainForm)

```

---

## 🧩 Design Principles

### 1. Separation of Concerns
Each component handles a specific responsibility:
- Data parsing
- Data processing
- Visualization
- User interaction

---

### 2. Modularity
Each phase builds on top of previous functionality without modifying core logic.

- Phase 1 → Base visualization
- Phase 2 → Multi-stock scaling
- Phase 3 → Indicator overlay

---

### 3. Extensibility
New features can be added easily:
- Additional indicators (RSI, MACD)
- New chart types
- API integration

---

### 4. Reusability
Core services (like CSV loading and filtering) are reused across all phases.

---

## 📈 Evolution Across Phases

| Phase | Architecture Impact |
|------|--------------------|
| Phase 1 | Core pipeline (CSV → Chart) |
| Phase 2 | UI scalability + multi-entity rendering |
| Phase 3 | Analytical layer (Indicators) |

---

## 🚀 Future Architecture Enhancements

- Introduce MVC or MVVM pattern
- Add service abstraction layers (interfaces)
- Integrate external APIs (real-time data)
- Add caching for performance optimization

---

## 💡 Summary

This architecture enables:

- Clean separation between logic and UI
- Easy expansion for new financial features
- Scalable visualization for multiple datasets
- Structured approach to technical analysis implementation

The system evolves naturally across phases while maintaining code clarity and maintainability.
```
