using Calculator.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Domain.Interfaces
{
    public interface IContactDetailRepository
    {
        void DeleteContactDetail(int contactDetailId);
        int AddContactDetail(ContactDetail contactDetail);
        int UpdateContactDetail(ContactDetail contactDetail);
        ContactDetail GetContactDetail(int contactDetailId);
        IQueryable<ContactDetail> GetAllContactDetails();
    }
}
