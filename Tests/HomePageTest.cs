using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Students_UI_Tests_POM.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriver_POM_Example.Pages;

namespace WebDriver_POM_Example.Tests
{
    public class HomePageTest : BaseTests
    {

        [Test]
        public void TestHomePage_UrlHeadingTitle_0101()
        {
            var homePage = new HomePage(driver);
            homePage.Open();
            Assert.AreEqual(homePage.GetPageUrl(), driver.Url);
            Assert.That("Students Registry", Is.EqualTo(homePage.GetPageHeadingTexts()));
            Assert.That(homePage.GetPageTitle, Is.EqualTo("MVC Example"));
        }
        [Test]
        public void TestHomePage_ViewStudents_OpenedTrue_0102()
        {
            var homePage = new HomePage(driver);
            homePage.Open();
            homePage.ViewStudentsLink.Click();
            Assert.IsTrue(new ViewStudentsPage(driver).isOpen());
        }
        [Test]
        public void TestHomePage_ViewStudents_ContentTure_0103()
        {
            var homePage = new HomePage(driver);
            homePage.Open();
            homePage.ViewStudentsLink.Click();
            Assert.That(new ViewStudentsPage(driver).GetPageTitle, Is.EqualTo("Students"));
        }
        [Test]
        public void TestHomePage_AddStudentPageLink_OpenedTrue_0202()
        {
            var homePage = new HomePage(driver);
            homePage.Open();
            homePage.AddStudentLink.Click();
            Assert.IsTrue(new AddStudentPage(driver).isOpen());
        }
        [Test]
        public void TestHomePageStudentCount()
        {
            var homePage = new HomePage(driver);
            homePage.Open();

            Assert.Greater(homePage.GetStudentCount(), 0);
        }
    }
}
