using Calculator.Domain.Interfaces;
using Calculator.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly Context _db;

        public CustomerRepository(Context db)
        {
            _db = db;
        }

        public int AddCustomer(Customer customer)
        {
            _db.Customers.Add(customer);
            _db.SaveChanges();
            return customer.Id;
        }

        public void DeleteCustomer(int customerId)
        {
            var customer = _db.Customers.FirstOrDefault(w => w.Id == customerId);
            if (customer != null)
            {
                _db.Customers.Remove(customer);
                _db.SaveChanges();
            }
        }

        public IQueryable<Customer> GetAllCustomers()
        {

            var customers = _db.Customers;
            return customers;
        }

        public Customer GetCustomer(int customerId)
        {
            var customer = _db.Customers.FirstOrDefault(w => w.Id == customerId);
            return customer;
        }

        public int UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
