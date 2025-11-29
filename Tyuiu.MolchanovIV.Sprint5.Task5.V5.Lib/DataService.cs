using System.Globalization;
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
                    string curStr = "";

                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] != ' ')
                        {
                            curStr += line[i];
                        }
                        else
                        {
                            double currentNum = Convert.ToDouble(curStr, CultureInfo.InvariantCulture);
                            if (firstItr) { min = currentNum; max = currentNum; firstItr = false; }
                            if (currentNum > max) max = currentNum;
                            if (currentNum < min) min = currentNum;

                            curStr = "";
                        }
                    }
                    
                }
            }

            res = max - min;

            return res;
        }
    }
}
