using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class CreditCard : CustomerProduct
    {
        public int CardNumber { get; set; }

        public DateTime ExpirationDate { get; set; }
    }
}
