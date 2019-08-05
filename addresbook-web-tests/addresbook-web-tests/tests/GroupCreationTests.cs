﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddresbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            GroupData group = new GroupData("testgrname");
            group.Header = "testgrheader";
            group.Footer = "testgrfooter";

            app.Groups.Create(group);
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData("testgrname");
            group.Header = "";
            group.Footer = "";

            app.Groups.Create(group);
        }
    }
}
