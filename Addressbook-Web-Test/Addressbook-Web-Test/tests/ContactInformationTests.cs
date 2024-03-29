﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactInformationTests : AuthTestBase
    {
        [Test]
        public void TextContactInformation()
        {
            ContactData fromTable = app.Contact.GetContactInformationTable(3);
            ContactData fromForm = app.Contact.GetContactInformationEditForm(3);

            //verification
            Assert.AreEqual(fromTable, fromForm);
            Assert.AreEqual(fromTable.Address, fromForm.Address);
            Assert.AreEqual(fromTable.AllEmails, fromForm.AllEmails);
            Assert.AreEqual(fromTable.AllPhones, fromForm.AllPhones);
        }


        [Test]
        public void TextContsxtDetailsInformation()
        {
            ContactData fromForm = app.Contact.GetContactInformationEditForm(3);
            ContactData fromDetails = app.Contact.GetContactInformationDetails(3);

            Console.Out.Write(fromForm.AllDetails);

            Console.Out.Write(fromDetails.AllDetails);
            //verification
            Assert.AreEqual(fromDetails.AllDetails, fromForm.AllDetails);

        }
    }
}
