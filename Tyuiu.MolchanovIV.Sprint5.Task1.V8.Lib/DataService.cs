using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MolchanovIV.Sprint5.Task1.V8.Lib
{
    public class DataService : ISprint5Task1V8
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string filepath = $@"{Path.GetTempPath()}";
            string filename = "OutPutFileTask1.txt";
            string path = Path.Combine(filepath, filename);

            FileInfo fileinfo = new FileInfo(path);

            if (File.Exists(path)) File.Delete(path);

            for (int i = startValue; i <= stopValue; i++)
            {
                double res = 0.0;
                string output;

                if ((2 * i - 2) == 0)
                {
                    output = Convert.ToString(res);

                    if (i != stopValue)
                    {
                        File.AppendAllText(path, output + Environment.NewLine); continue;
                    }
                    else
                    {
                        File.AppendAllText(path, output); continue;
                    }
                }


                res = (4 - 2 * i) + ((2 + Math.Cos(i)) / (2 * i - 2));
                res = Math.Round(res, 2);
                output = Convert.ToString(res);

                if (i != stopValue) File.AppendAllText(path, output + Environment.NewLine);
                else File.AppendAllText(path, output);
            }

            return path;
        }
    }
}
