using Tyuiu.MolchanovIV.Sprint5.Task1.V8.Lib;

namespace Tyuiu.MolchanovIV.Sprint5.Task1.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string filepath = $@"{Path.GetTempPath()}";
            string filename = "OutPutFileTask1.txt";
            string path = Path.Combine(filepath, filename);

            Assert.IsTrue(File.Exists(path));
        }
    }
}
