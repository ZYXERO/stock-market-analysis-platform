# Demo Guide

This guide explains how to use the Candlestick Visualization interface once the application is running.

---

## Launch the Application

From the project directory:


cd candlestick-visualization/CandlestickVisualization
dotnet run


The application window will open.

---

## Enter a Stock Symbol

In the **Stock Symbol** input field, type a symbol such as:


AAPL


Other example symbols available in the dataset:

- AMZN
- ABBV
- IBM
- JPM

---

## Choose a Time Period

Use the **Period** dropdown to select the dataset resolution:

- Day
- Week
- Month

The application will automatically attempt to load a matching CSV file from the `data/` folder.

Example:


AAPL-Day.csv


---

## Select a Date Range

Use the **Start Date** and **End Date** selectors to filter the dataset.

Example:

Start Date: 2022-01-01  
End Date: 2023-01-01

---

## Load or Update Data

Click one of the buttons:

### Load Data
Loads the selected dataset into the application.

### Update Data
Re-applies the selected date range filter to the currently loaded dataset.

---

## Visualization Output

The application displays three main components:

### Candlestick Chart

Shows OHLC price data for the selected stock symbol.

Each candlestick represents:

- Opening price
- Highest price
- Lowest price
- Closing price

### Volume Chart

Displays trading volume for the same time period using vertical bars.

### Data Table

Shows the raw stock data in tabular format including:

- Date
- OpeningPrice
- MaximumPrice
- MinimumPrice
- ClosingPrice
- Volume

---

## Candlestick Interpretation

Each candlestick represents one time interval (day/week/month).

Green candles indicate:


ClosingPrice > OpeningPrice


Red candles indicate:


ClosingPrice < OpeningPrice


The vertical line (wick) shows the **high and low price range** during that period.

---

## Example Workflow

1. Launch the application
2. Enter `AAPL` as the stock symbol
3. Select **Day** as the period
4. Choose a start and end date
5. Click **Load Data**
6. Observe the candlestick chart and volume visualization