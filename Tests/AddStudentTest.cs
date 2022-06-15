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
    public class AddStudentTest : BaseTests
    {

        [Test]
        public void Test_AddStudent_UrlHeadingTitle()
        {
            var addStudent = new AddStudentPage(driver);
            addStudent.Open();
            Assert.AreEqual(addStudent.GetPageUrl(), driver.Url);
            Assert.That("Register New Student", Is.EqualTo(addStudent.GetPageHeadingTexts()));
            Assert.That(addStudent.GetPageTitle, Is.EqualTo("Add Student"));
        }
        [Test]
        public void Test_AddStudent_HomeLink()
        {
            var addStudent = new AddStudentPage(driver);        
            addStudent.Open();
            Assert.That(driver.Url, Is.EqualTo(addStudent.GetPageUrl()));
            Assert.That(driver.Url, Is.EqualTo(addStudent.GetPageUrl()));
            Assert.That(addStudent.GetPageTitle, Is.EqualTo("Add Student"));
        }
        [Test]
        public void Test_AddStudent_AddValidStudent()
        {
            var add_Student = new AddStudentPage(driver);
            add_Student.Open();
            string name = "Pesho" + DateTime.Now.Ticks;
            string email = "Pesho" + DateTime.Now.Ticks + "@gmail.com";
            add_Student.AddStudent(name, email);
            var view_student = new ViewStudentsPage(driver);
            Assert.IsTrue(view_student.isOpen());
            var students = view_student.GetRegisteredStudents();
            var lastStudent = students.Last();
            string expected = name + " (" + email + ")";
            Assert.Contains(lastStudent, students);
        }

        [Test]
        public void Test_AddStudent_AddInValidStudent()
        {
            var add_Student = new AddStudentPage(driver);
            add_Student.Open();
            string name = "";
            string email = "";
            add_Student.AddStudent(name, email);
            Assert.IsTrue(add_Student.isOpen());
            Assert.That(add_Student.ErrorMessage.Text, Is.EqualTo("Cannot add student. Name and email fields are required!"));
        }

        //[Test]
        //public void TestHomePageVieWStudentsLink()
        //{
        //    var homePage = new HomePage(driver);
        //    homePage.Open();
        //    homePage.ViewStudentsLink.Click();
        //    var viewStudent = new ViewStudentsPage(driver);           
        //    Assert.That(viewStudent.GetPageTitle, Is.EqualTo("Students"));
        //    Assert.That(driver.Url, Is.EqualTo(viewStudent.GetPageUrl()));
        //}

        //[Test]
        //public void TestHomePageAddStudentsLink()
        //{
        //    var homePage = new HomePage(driver);
        //    homePage.Open();
        //    homePage.AddStudentLink.Click();
        //    var addStudent = new AddStudentPage(driver);
        //    Assert.That(addStudent.GetPageTitle, Is.EqualTo("Add Student"));
        //    Assert.That(driver.Url, Is.EqualTo(addStudent.GetPageUrl()));
        //}

        //[Test]
        //public void TestHomePageViewStudents()
        //{
        //    var homePage = new HomePage(driver);
        //    homePage.Open();
        //    homePage.ViewStudentsLink.Click();
        //    Assert.That(new ViewStudentsPage(driver).GetPageTitle, Is.EqualTo("Students"));
        //}

        //[Test]
        //public void TestHomePageStudentCount()
        //{
        //    var homePage = new HomePage(driver);
        //    homePage.Open();
        //    Assert.Greater(homePage.GetStudentCount(), 0);  
        //}

    }
}
