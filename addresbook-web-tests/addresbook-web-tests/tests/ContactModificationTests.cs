using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddresbookTests
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData newData = new ContactData("testfn_Mod", "testln_Mod");
            newData.Middlename = "middlename_Mod";
            newData.Nickname = "nick_Mod";

            app.Contacts.Modify(2, newData);
        }
    }
}
