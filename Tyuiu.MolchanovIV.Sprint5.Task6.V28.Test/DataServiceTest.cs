using Tyuiu.MolchanovIV.Sprint5.Task6.V28.Lib;

namespace Tyuiu.MolchanovIV.Sprint5.Task6.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            string path = $@"C:\DataSprint5\InPutDataFileTask6V28.txt";
            int wait = 5;
            var res = ds.LoadFromDataFile(path);

            Assert.AreEqual(res, wait);
        }
    }
}
