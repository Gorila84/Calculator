using Calculator.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        void DeleteCustomer(int customerId);
        int AddCustomer(Customer customer);
        int UpdateCustomer(Customer customer);
        Customer GetCustomer(int customerId);
        IQueryable<Customer> GetAllCustomers();
    }
}
