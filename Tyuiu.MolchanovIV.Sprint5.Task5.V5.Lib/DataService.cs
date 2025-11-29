using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MolchanovIV.Sprint5.Task5.V5.Lib
{
    public class DataService : ISprint5Task5V5
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0, min = 0, max = 0;
            bool firstItr = true;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                while((line = reader.ReadLine()) != null)
                {
                    double currentNum = double.Parse(line);

                    if (firstItr) { min = currentNum; max = currentNum; firstItr = false; }
                    if (currentNum > max) max = currentNum;
                    if (currentNum < min) min = currentNum;
                }
            }

            res = max - min;

            return res;
        }
    }
}
