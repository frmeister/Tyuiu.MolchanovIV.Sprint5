using Tyuiu.MolchanovIV.Sprint5.Task3.V18.Lib;

namespace Tyuiu.MolchanovIV.Sprint5.Task3.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            string filepath = $@"{Path.GetTempPath()}";
            string filename = "OutPutFileTask3.bin";
            string path = Path.Combine(filepath, filename);

            Assert.IsTrue(File.Exists(path));
        }
    }
}
