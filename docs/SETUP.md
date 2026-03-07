# Setup Guide

This document explains how to install dependencies and run the Candlestick Visualization module locally.

---

## System Requirements

The following software must be installed:

- Windows operating system
- .NET 8 SDK

Verify the .NET installation:


dotnet --version


Expected output should start with:


8.x.x


---

## Clone the Repository


git clone https://github.com/ZYXERO/stock-market-analysis-platform.git


Navigate to the project directory:


cd StockMarketAnalysisPlatform/candlestick-visualization/CandlestickVisualization


---

## Restore Dependencies


dotnet restore


---

## Build the Project


dotnet build


---

## Run the Application


dotnet run


The Windows Forms interface will launch and display the candlestick visualization application.

---

## Data Files

Historical stock datasets are located in the repository `data/` folder.

Example dataset files:

- AAPL-Day.csv
- AAPL-Week.csv
- AAPL-Month.csv
- AMZN-Day.csv
- AMZN-Week.csv
- AMZN-Month.csv

The application loads files based on the naming pattern:


StockSymbol-Period.csv


Examples:


AAPL-Day.csv
AMZN-Week.csv


---

## Create a Standalone Executable

To generate a Windows executable version of the application:


dotnet publish -c Release -r win-x64 --self-contained true


The compiled executable will be located in:


candlestick-visualization/CandlestickVisualization/bin/Release/net8.0-windows/win-x64/publish/