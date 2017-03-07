using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagementSystemEntities
{
    public class Contact : Human
    {
        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }


        public override string GetName()
        {
            FirstName = "Contact Name";
            return FirstName;
        }

        public string GetBase()
        {
            return base.GetName();
        }

        public override string ReturnBaseProperty()
        {
            return base.ReturnBaseProperty();
        }

        public List<Contact> CreateContact()
        {
            Contact newContact = new Contact()
            {
                ContactID = 1,
                FirstName = "James",
                LastName = "Bond",
                Title = "Secret Service Agent",
                Company = "M16",
                Email = "james.bond@M16.spy",
                Telephone = "1234567892"
            };

            List <Contact> newList = new List<Contact>();
            newList.Add(newContact);
            Contact twoNewContact = new Contact()
            {
                ContactID = 2,
                FirstName = "Bob",
                LastName = "Smith",
                Title = "Junior Secret Service Agent",
                Company = "M16",
                Email = "bob.smith@M16.spy",
                Telephone = "1234567893"
            };
            newList.Add(twoNewContact);
            return newList;
        }
    }
}

