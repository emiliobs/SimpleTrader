using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTrade.Domain.Models
{
    public class Account : DomainObject
    {
        
        public User AccountHolder { get; set; }
        public double Balance { get; set; }
        public IEnumerable<AssetTransaction> AssetTransactions { get; set; }
    }
}
