using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest03
    {
        StudentGrades getStudentGrades = new StudentGrades();
        [TestMethod]
        public void CalcGradeTest()
        {
            getStudentGrades.CalcGrades();  
        }
    }
}
