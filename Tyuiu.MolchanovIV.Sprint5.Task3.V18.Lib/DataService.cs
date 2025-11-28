using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MolchanovIV.Sprint5.Task3.V18.Lib
{
    public class DataService : ISprint5Task3V18
    {
        public string SaveToFileTextData(int x)
        {
            string filepath = $@"{Path.GetTempPath()}";
            string filename = "OutPutFileTask3.bin";
            string path = Path.Combine(filepath, filename);

            FileInfo fileinfo = new FileInfo(path);

            if (File.Exists(path)) File.Delete(path);

            double res = Math.Round(2.12 * Math.Pow(x, 3) + 1.05 * Math.Pow(x, 2) + 4.1 * x * 2, 3);
            string output = Convert.ToString(res);

            File.AppendAllText(path, output);

            return path;
        }
    }
}
