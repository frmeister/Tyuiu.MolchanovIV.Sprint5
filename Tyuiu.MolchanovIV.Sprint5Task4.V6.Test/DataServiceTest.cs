using System.IO;
using Tyuiu.MolchanovIV.Sprint5Task4.V6.Lib;

namespace Tyuiu.MolchanovIV.Sprint5Task4.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            string path = $@"C:\DataSprint5\InPutDataFileTask4V6.txt";

            var res = ds.LoadFromDataFile(path);
            double wait, input;

            input = Convert.ToDouble(File.ReadAllText(path));

            wait = Math.Round((1 / Math.Cos(input)) + 2.2 * Math.Pow(input, 2), 3);

            Assert.AreEqual(res, wait);



        }
    }
}
