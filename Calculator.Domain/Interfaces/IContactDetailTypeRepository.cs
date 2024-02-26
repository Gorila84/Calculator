using Calculator.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Domain.Interfaces
{
    public interface IContactDetailTypeRepository
    {
        void DeleteContactDetailType(int contactDetailTypeId);
        int AddContactDetailType(ContactDetailType contactDetailType);
        int UpdateContactDetailType(ContactDetailType contactDetailType);
        ContactDetailType GetContactDetailType(int contactDetailTypeId);
        IQueryable<ContactDetailType> GetAllContactDetailTypes();
    }
}
