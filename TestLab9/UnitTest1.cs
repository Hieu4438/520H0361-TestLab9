using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollector.InProcDataCollector;
using StudentServiceLib;

namespace TestLab9
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Score8_GradeA()
        {
            char res = 'A';
            
            double[] cases = {8.0,8,8.5,9,9.5,10};
            Test_WhenScore_GradeIs(cases, res);
        }

        [TestMethod]
        public void Test_ScoreBelow8LargeEqual7_GradeB()
        {
            char res = 'B';
            double[] cases = {7, 7.0, 7.5, 7.9 };
            Test_WhenScore_GradeIs(cases, res);
        }


        public void Test_WhenScore_GradeIs(double[] cases, char res)
        {

            Student a = new Student();
            for (int i = 0; i < cases.Length; i++)
            {
                a.Score = cases[i];
                Assert.AreEqual(res, a.getLetterScore());
            }
        }
    }
}   