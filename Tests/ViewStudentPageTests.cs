
using NUnit.Framework;
using WebDriver_POM_Example.Pages;

namespace WebDriver_POM_Example.Tests
{
    public class ViewStudentPageTests : BaseTests
    {
        [Test]
        public void Test_ViewStudentPage_TitleAndHeading()
        {
            var studentPage = new ViewStudentsPage(driver);
            studentPage.Open();
            Assert.That(studentPage.GetPageTitle(), Is.EqualTo("Students"));
            Assert.That(studentPage.GetPageHeadingTexts(), Is.EqualTo("Registered Students"));
        }

        [Test]
        public void Test_CheckStudents()
        {
            var studentPage = new ViewStudentsPage(driver);
            studentPage.Open();
            var students = studentPage.GetRegisteredStudents();
            foreach (var student in students)
            {
                Assert.IsTrue(student.IndexOf("(") > 0);
                Assert.IsTrue(student.LastIndexOf(")") == student.Length -1);
            }

        }
    }
}
