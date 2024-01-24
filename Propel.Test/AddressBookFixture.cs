﻿using PropelAddressBook.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propel.Test
{
    public class AddressBookFixture
    {
        public readonly IList<Contact> _contacts; 
        public AddressBookFixture()
        {
            _contacts = new List<Contact>()
            {
                new Contact() { Id = 1, FirstName = "Jack", LastName = "Jackson", Phone = "111-111-1111",
                    Address = new Address{
                        Name = "1 Main Street",
                        Postcode = "hd1 1dh",
                        State = "Yorkshire",
                        Active = true
                    },
                    Active = true},
                new Contact() { Id = 2, FirstName = "John", LastName = "Johnson", Phone = "222-222-2222",
                    Address = new Address{
                        Name = "2 Side Street",
                        Postcode = "hd2 2dh",
                        State = "Yorkshire",
                        Active = true
                    },
                    Active = true},
                new Contact() { Id = 3, FirstName = "Sarah", LastName = "Sarahson", Phone = "333-333-3333",
                    Address = new Address{
                        Name = "3 Otherside Street",
                        Postcode = "hd3 3dh",
                        State = "Yorkshire",
                        Active = true
                    },
                    Active = false}
            };
        }
    }
}

