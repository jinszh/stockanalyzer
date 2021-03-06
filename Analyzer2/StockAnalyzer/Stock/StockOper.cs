using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using Stock.Common.Data;

namespace FinanceAnalyzer.Stock
{
    public class StockOper
    {
        public StockOper(double price, int count, OperType type)
        {
            MarketStock stock = new MarketStock();
            stock.UnitPrice = price;
            stock.Count = count;

            TargetStock = stock;
            operType = type;
        }

        public OperType Type
        {
            get
            {
                return operType;
            }
        }

        public double UnitPrice
        {
            get
            {
                return TargetStock.UnitPrice;
            }            
        }

        public int HandCount
        {
            get
            {
                return TargetStock.Count;
            }
        }

        private MarketStock TargetStock;
        private OperType operType;
    }    
}
