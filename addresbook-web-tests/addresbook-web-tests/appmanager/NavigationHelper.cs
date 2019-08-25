﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddresbookTests
{
    public class NavigationHelper : HelperBase
    {
        private string baseURL;

        public NavigationHelper(ApplicationManager manager, string baseURL) : base(manager)
        {
            this.baseURL = baseURL;
        }

        public void GoToHomePage()
        {
            if (driver.Url == baseURL + "/addressbook/")
            {
                return;
            }
            driver.Navigate().GoToUrl(baseURL + "/addressbook/");
        }

        public void GoToGroupsPage()
        {
            if (driver.Url == baseURL + "/addressbook/group.php"
                && IsElementPresent(By.Name("new")))
            {
                return;
            }
            driver.FindElement(By.LinkText("groups")).Click();
        }

        public void GoToAddContactsPage()
        {
            if (driver.Url == baseURL + "/addressbook/edit.php")
            {
                return;
            }
            driver.FindElement(By.LinkText("add new")).Click();
        }

        public void GoToEditContactsPage(int v)
        {
            if (driver.Url == baseURL + "/addressbook/edit.php?id=" + v)
            {
                return;
            }
            driver.FindElements(By.CssSelector("img[title=\"Edit\"]"))[v].Click();
        }

        public void ReturnToHomePage()
        {
            if (driver.Url == baseURL + "/addressbook/")
            {
                return;
            }
            driver.FindElement(By.LinkText("home")).Click();
        }
    }
}
