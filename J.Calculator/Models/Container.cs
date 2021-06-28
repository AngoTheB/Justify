using System;
using System.Collections.Generic;

namespace J.Calculator.Models
{
    public class Container
    {
        public Guid Id { get; set; }
        public string ContainerNo { get; set; }
        public DateTime Date { get; set; }
        public IEnumerable<Charge> Charges { get; set; }
        public IEnumerable<Invoice> Invoices { get; set; }
    }
}