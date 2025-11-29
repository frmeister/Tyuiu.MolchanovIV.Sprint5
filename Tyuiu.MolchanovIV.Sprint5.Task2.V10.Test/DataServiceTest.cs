using Tyuiu.MolchanovIV.Sprint5.Task2.V10.Lib;

namespace Tyuiu.MolchanovIV.Sprint5.Task2.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            string filepath = $@"{Path.GetTempPath()}";
            string filename = "OutPutFileTask2.txt";
            string path = Path.Combine(filepath, filename);

            Assert.IsTrue(File.Exists(path));
        }
    }
}
