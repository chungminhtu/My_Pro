﻿using MMHDemo;
using MMHDemo.EntityFrameworkCore;
using MMHDemo.personInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acme.PhoneBookDemo.Migrations.Seed.Host
{
    public class InitialPeopleCreator
    {
        private readonly MMHDemoDbContext _context;

        public InitialPeopleCreator(MMHDemoDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            var douglas = _context.Persons.FirstOrDefault(p => p.EmailAddress == "douglas.adams@fortytwo.com");
            if (douglas == null)
            {
                _context.Persons.Add(
                    new Person
                    {
                        Name = "Rafiul",
                        Surname = "Islam",
                        EmailAddress = "rafi.cse.ru@gmail.com"
                    });
            }

            var asimov = _context.Persons.FirstOrDefault(p => p.EmailAddress == "isaac.asimov@foundation.org");
            if (asimov == null)
            {
                _context.Persons.Add(
                    new Person
                    {
                        Name = "Abu",
                        Surname = "Hanif",
                        EmailAddress = "hanif@gmail.com"
                    });
            }
        }
    }
}


