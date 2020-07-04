using SimpleTrade.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTrade.Domain.Models
{
    public class Asset  :DomainObject
    {
       
        public Account  Account { get; set; }
        public Stock Stock { get; set; }
        public int Shares { get; set; }
    }
}
