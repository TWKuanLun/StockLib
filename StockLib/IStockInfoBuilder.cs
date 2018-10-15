﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StockLib
{
    public interface IStockInfoBuilder
    {
        Task<List<StockInfo>> GetStocksInfo(bool needHistory, params StockQuery[] queries);
        Task<List<StockInfo>> GetStocksInfo(bool needHistory, Dictionary<string, StockType> queries);
    }
}
