using Tyuiu.MolchanovIV.Sprint5.Task7.V30.Lib;

namespace Tyuiu.MolchanovIV.Sprint5.Task7.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            string filepath = $@"{Path.GetTempPath()}";
            string filename = "OutPutDataFileTask7V30.txt.";
            string outputPath = Path.Combine(filepath, filename);

            Assert.IsTrue(File.Exists(outputPath));

        }
    }
}
