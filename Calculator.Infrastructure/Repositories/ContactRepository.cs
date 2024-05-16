using Calculator.Domain.Interfaces;
using Calculator.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Infrastructure.Repositories
{
    public class ContactRepository : IContactDetailRepository, IContactDetailTypeRepository
    {
        private readonly Context _db;

        public ContactRepository(Context db)
        {
            _db = db;
        }

        public int AddContactDetail(ContactDetail contactDetail)
        {
            _db.ContactDetails.Add(contactDetail);
            _db.SaveChanges();
            return contactDetail.Id;
        }

        public int AddContactDetailType(ContactDetailType contactDetailType)
        {
            _db.ContactDetailTypes.Add(contactDetailType);
            _db.SaveChanges();
            return contactDetailType.Id;
        }

        public void DeleteContactDetail(int contactDetailId)
        {
            var contactDetail = _db.ContactDetails.FirstOrDefault(w => w.Id == contactDetailId);
            if (contactDetail != null)
            {
                _db.ContactDetails.Remove(contactDetail);
                _db.SaveChanges();
            }
        }

        public void DeleteContactDetailType(int contactDetailTypeId)
        {
            var contactDetailType = _db.ContactDetailTypes.FirstOrDefault(w => w.Id == contactDetailTypeId);
            if (contactDetailType != null)
            {
                _db.ContactDetailTypes.Remove(contactDetailType);
                _db.SaveChanges();
            }
        }

        public IQueryable<ContactDetail> GetAllContactDetails()
        {
            var contacts = _db.ContactDetails;
            return contacts;
        }

        public IQueryable<ContactDetailType> GetAllContactDetailTypes()
        {
            var contactsDetail = _db.ContactDetailTypes;
            return contactsDetail;
        }

        public ContactDetail GetContactDetail(int contactDetailId)
        {
            var contactDetail = _db.ContactDetails.FirstOrDefault(w => w.Id == contactDetailId);
            return contactDetail;
        }

        public ContactDetailType GetContactDetailType(int contactDetailTypeId)
        {
            var contactDetailType = _db.ContactDetailTypes.FirstOrDefault(w => w.Id == contactDetailTypeId);
            return contactDetailType;
        }

        public int UpdateContactDetail(ContactDetail contactDetail)
        {
            throw new NotImplementedException();
        }

        public int UpdateContactDetailType(ContactDetailType contactDetailType)
        {
            throw new NotImplementedException();
        }
    }
}
