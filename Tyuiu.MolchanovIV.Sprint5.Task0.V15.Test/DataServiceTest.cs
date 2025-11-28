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
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;

            Assert.IsTrue(fileExists);

        }
    }
}
