using Calculator.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Domain.Interfaces
{
    public interface IAddressRepository
    {
        void DeleteAddress(int AddressId);
        int AddAddress(Address Address);
        int UpdateAddress(Address Address);
        Address GetAddress(int AddressId);
        IQueryable<Address> GetAllAddresss();
    }
}
