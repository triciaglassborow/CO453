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

            Assert.AreEqual("Fail", getStudentGrades.grades[0]);
            Assert.AreEqual("Fail", getStudentGrades.grades[1]);
            Assert.AreEqual("Third Class", getStudentGrades.grades[2]);
            Assert.AreEqual("Third Class", getStudentGrades.grades[3]);
            Assert.AreEqual("Lower Second Class", getStudentGrades.grades[4]);
            Assert.AreEqual("Lower Second Class", getStudentGrades.grades[5]);
            Assert.AreEqual("Upper Second Class", getStudentGrades.grades[6]);
            Assert.AreEqual("Upper Second Class", getStudentGrades.grades[7]);
            Assert.AreEqual("First Class", getStudentGrades.grades[8]);
            Assert.AreEqual("First Class", getStudentGrades.grades[9]);
        }

        [TestMethod]
        public void ClassStatsTest()
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

            getStudentGrades.ClassStats();

            Assert.AreEqual(0, getStudentGrades.min);
            Assert.AreEqual(100, getStudentGrades.max);
            Assert.AreEqual(53, getStudentGrades.mean);
        }

        [TestMethod]
        public void ClassProfilesTest()
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
            getStudentGrades.ClassProfile();

            Assert.AreEqual(2, getStudentGrades.StatFail);
            Assert.AreEqual(2, getStudentGrades.StatThird);
            Assert.AreEqual(2, getStudentGrades.StatLower);
            Assert.AreEqual(2, getStudentGrades.StatUpper);
            Assert.AreEqual(2, getStudentGrades.StatFirst);
        }
    }
}
