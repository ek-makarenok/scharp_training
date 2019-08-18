using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddresbookTests
{
    [TestFixture]
    public class GroupModificationTests : TestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("testgrname_Mod");
            newData.Header = "testgrheader_Mod";
            newData.Footer = "testgrfooter_Mod";

            app.Groups.Modify(1, newData);
        }
    }
}
