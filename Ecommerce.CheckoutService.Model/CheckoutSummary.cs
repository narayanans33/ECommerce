using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.CheckoutService.Model
{
    public class CheckoutSummary
    {
        public List<CheckoutProduct> Items { get; set; }

        public double TotalPrice { get; set; }

        public DateTime Date { get; set; }
    }
}
