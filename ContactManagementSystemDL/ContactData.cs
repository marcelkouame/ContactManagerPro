using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactManagementSystemEntities;

namespace ContactManagementSystemDL
{
    public class ContactData
    {
        public void InsertContact(Contact cContact)
        {
            ContactManagementSystemDBMLDataContext databaseContext = new ContactManagementSystemDBMLDataContext();
            databaseContext.InsertContact(cContact.FirstName, cContact.LastName, cContact.Title, cContact.Company, cContact.Email, cContact.Telephone);
        }

        public List<Contact> GetContact()
        {
            ContactManagementSystemDBMLDataContext databaseContext2 = new ContactManagementSystemDBMLDataContext();
            var tempContact = databaseContext2.GetContacts();
            List<Contact> newContactList = new List<Contact>();

            foreach (GetContactsResult custOrdersDetail in tempContact)
            {
                Contact newContact = new Contact
                {
                    ContactID = custOrdersDetail.ContactID,
                    FirstName = custOrdersDetail.FirstName,
                    LastName = custOrdersDetail.LastName,
                    Title = custOrdersDetail.Title,
                    Company = custOrdersDetail.Company,
                    Email = custOrdersDetail.Email,
                    Telephone = custOrdersDetail.Telephone
                };

                newContactList.Add(newContact);
            }
            return newContactList;
        }
    }
}
