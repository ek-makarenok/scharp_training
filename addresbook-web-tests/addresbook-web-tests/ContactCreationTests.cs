﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddresbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            GoToHomePage();
            Login(new AccountData("admin", "secret"));
            GoToContactsPage();
            FillContactForm(new ContactData("testfn", "testln"));
            SubmitContactCreation();
            ReturnToHomePage();
            Logout();
        }
    }
}
