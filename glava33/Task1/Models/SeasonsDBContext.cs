﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace Task1.Models
{
    public class SeasonsDBContext : DataContext
    {
        public SeasonsDBContext(string fileOrServerOrConnection) : base(fileOrServerOrConnection)
        {
        }
        public Table<Seasons> Seasonst { get; set; }
    }
}
