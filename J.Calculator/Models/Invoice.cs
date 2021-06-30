using System;
using System.Collections.Generic;

namespace J.Calculator.Models
{
    public class Invoice
    {
        public Guid Id { get; set; }
        public string InvoiceNo { get; set; }
        public decimal Amount { get; set; }
        public IEnumerable<Charge> Charges { get; set; } = new List<Charge>();
    }
}