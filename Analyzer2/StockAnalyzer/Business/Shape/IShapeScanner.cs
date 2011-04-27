﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FinanceAnalyzer.DB;
using Stock.Common.Data;

namespace FinanceAnalyzer.Business.Shape
{
    interface IShapeScanner
    {
        OperType Analyse(IStockData stock, IStockData prevStock);        
    }
}
