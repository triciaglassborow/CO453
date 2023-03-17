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
            getStudentGrades.marks[0] = 0;
            getStudentGrades.marks[1] = 39;
            getStudentGrades.marks[2] = 40;
            getStudentGrades.marks[3] = 49;
            getStudentGrades.marks[4] = 50;
            getStudentGrades.marks[5] = 59;
            getStudentGrades.marks[6] = 60;
            getStudentGrades.marks[7] = 69;
            getStudentGrades.marks[8] = 70;
            getStudentGrades.marks[9] = 100;
            getStudentGrades.CalcGrades();
        }
    }
}
