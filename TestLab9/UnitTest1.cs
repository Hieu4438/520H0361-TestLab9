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
            Student a = new Student();
            double[] cases = {8.0,8,8.5,9,9.5,10};
            for (int i = 0; i < cases.Length; i++)
            {
                a.Score = cases[i];
                Assert.AreEqual(res, a.getLetterScore());
            }
        }
    }
}   