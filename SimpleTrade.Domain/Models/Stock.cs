namespace SimpleTrade.Domain.Models
{
    public class Stock  : DomainObject
    {
       
        public string Symbol { get; set; }
        public double PricePerShare { get; set; }
    }
}
