﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTrader.EntityFramework
{
    public class SimpleTraderDbContexfactory : IDesignTimeDbContextFactory<SimpleTraderDbContext>
    {
       

        public SimpleTraderDbContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<SimpleTraderDbContext>();
            options.UseSqlServer("Data Source=.;Initial Catalog=SimpleTraderDB;Integrated Security=True;Pooling=False");
            return new SimpleTraderDbContext(options.Options);
        }
    }
}
