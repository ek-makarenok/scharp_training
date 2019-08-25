using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddresbookTests
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            ContactData contact = new ContactData("testfn", "testln");
            contact.Middlename = "middlename";
            contact.Nickname = "nick";

            app.Contacts.Create(contact);
        }
    }
}
