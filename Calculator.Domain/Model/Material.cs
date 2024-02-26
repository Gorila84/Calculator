using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Domain.Model
{
    public class Material
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal PurchasePriceNett { get; set; }
        public double Margin { get; set; }
        public int MeasureId { get; set; }
        public Measure Measure { get; set; }
    }
}
