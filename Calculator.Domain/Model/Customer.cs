using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Domain.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NIP { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ICollection<ContactDetail> ContactDetails { get; set;}
    }
}
