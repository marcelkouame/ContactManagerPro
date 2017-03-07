using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactManagementSystemDL;
using ContactManagementSystemEntities;

namespace ContactManagementSystemBL
{
    public class ProcessContactBL
    {
        public void ProcessInsertContact(Contact cContact)
        {
            ContactData newContactData = new ContactData();
            newContactData.InsertContact(cContact);
        }

        public List<Contact> GetAllContacts()
        {
            ContactData newContactData = new ContactData();
            return newContactData.GetContact();
        }
    }
}
