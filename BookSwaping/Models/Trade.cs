using System.Reflection.Metadata.Ecma335;

namespace BookSwaping.Models
{
    public class Trade
    {
        public int TradeId { get; set; }
        public Book Book { get; set; }
        public User Owner { get; set; }
        public User Buyer { get; set; }
        // 0 = waiting for buyer  
        // 1 = Canceled
        // 2 = successfull
        // 3 = error
        
        public int StatusCode { get; set; }
    }
}
