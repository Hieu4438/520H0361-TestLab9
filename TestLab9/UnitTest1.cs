using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollector.InProcDataCollector;
using StudentServiceLib;

namespace TestLab9
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        [DataRow(new double[] { 8.0, 8, 8.5, 9, 9.5, 10 }, 'A')]
        [DataRow(new double[] { 7, 7.0, 7.5, 7.9 }, 'B')]
        [DataRow(new double[] { 6.9, 6.5, 6.0, 5, 5.0, 5.1 }, 'C')]
        [DataRow(new double[] { 4.9, 4.5, 3.5, 3.50, 3.6, 3.9 }, 'D')]
        [DataRow(new double[] { 3.49, 3.4, 0, 3.2, 2.5 }, 'E')]
        public void Test_WhenScore_GradeIs(double[] cases, char res)
        {

            Student a = new Student();
            for (int i = 0; i < cases.Length; i++)
            {
                a.Score = cases[i];
                Assert.AreEqual(res, a.getLetterScore());
            }
        }


        [TestMethod]
        [ExpectedException(typeof(SystemException))]
        [DataRow(new double[] { -1, -10, -9, -4, -5, -1.1, -0.05, -0.0002 })]
        [DataRow(new double[] { 11, 10.0001, 10.052, 12, 10.00002, 10.00003})]
        public void throwSystemError_WhenScoreIs(double[] cases)
        {
            Student a = new Student();
            for (int i = 0; i < cases.Length; i++)
            {
                a.Score = cases[i];
            }
        }
    }
}   