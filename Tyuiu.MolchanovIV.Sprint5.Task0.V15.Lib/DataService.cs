using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MolchanovIV.Sprint5.Task0.V15.Lib
{
    public class DataService : ISprint5Task0V15
    {
        public string SaveToFileTextData(int x)
        {
            string filepath = $@"{Path.GetTempPath()}";
            string filename = "OutPutFileTask0.txt";
            string path = Path.Combine(filepath, filename);

            double result = Math.Round((x) / (Math.Pow(x, 3) + 2), 3);

            File.WriteAllText(path, Convert.ToString(result));

            return path;
        }
    }
}
