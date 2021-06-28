using System;

namespace J.Calculator.Models
{
    public class Charge
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public int Type { get; set; }
        public int FkId { get; set; }
    }
}