# Phase 2 — Multi-Stock Comparison & Dynamic Charting

## Objective

Expand the platform from single-stock analysis to multi-stock comparison while improving UI organization and scalability.

---

## Key Features

### Multi-Stock Selection

- Users can select multiple stocks simultaneously
- Implemented using a checkbox list UI component

---

### Dynamic Chart Generation

- Each selected stock generates its own chart panel
- Charts are created dynamically at runtime
- Implemented using `FlowLayoutPanel`

---

### Combined Price + Volume Chart

- Each stock panel includes:
  - Candlestick chart (price)
  - Volume chart (below)

---

### Shared Filtering System

- Single set of filters applied across all stocks:
  - Date range
  - Time interval (Daily / Weekly / Monthly)

---

### Improved UI Layout

- Replaced single chart view with stacked panels
- Better organization for comparing multiple stocks
- Scalable layout for additional stocks

---

## Technical Additions

### New Components

- `StockDataset`
  - Groups data by symbol and interval

- `StockRepository`
  - Loads all CSV files from the data folder
  - Organizes datasets by stock symbol

- `DataAggregator`
  - Handles filtering logic

- `StockChartPanelFactory`
  - Dynamically creates UI panels and charts

---

## Architecture Improvements

- Separation of concerns:
  - Models → Data structures
  - Services → Data processing
  - Rendering → Chart logic
  - UI → Interaction and layout

---

## Outcome

Phase 2 transforms the application into a multi-stock analysis tool, enabling side-by-side comparison of stock performance, similar to real-world trading platforms.