using Tyuiu.MolchanovIV.Sprint5.Task5.V5.Lib;

namespace Tyuiu.MolchanovIV.Sprint5.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            string path = $@"C:\DataSprint5\InPutDataFileTask5V5.txt";
            double wait = 30;

            var res = ds.LoadFromDataFile(path);

            Assert.AreEqual(res, wait);

        }
    }
}
