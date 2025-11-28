using System.IO.Enumeration;
using Tyuiu.MolchanovIV.Sprint5.Task0.V15.Lib;

namespace Tyuiu.MolchanovIV.Sprint5.Task0.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string filepath = $@"{Directory.GetCurrentDirectory()}";
            string filename = "OutPutFileTask0.txt";
            string path = Path.Combine(filepath, filename);

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;

            Assert.IsTrue(fileExists);

        }
    }
}
