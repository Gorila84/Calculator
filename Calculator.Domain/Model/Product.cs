using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Domain.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal NetPurchasePrice { get; set; }
        public decimal NetPrice { get; set; }
        public string Color { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
