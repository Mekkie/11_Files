﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Files
{
    public interface IFileOperation
    {
        string StockFileName(long id);
        string StockFileName(Stock stock);
    }
}