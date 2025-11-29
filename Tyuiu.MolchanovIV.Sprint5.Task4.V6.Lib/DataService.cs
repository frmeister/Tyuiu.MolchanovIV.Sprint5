using System.Globalization;
using System.Runtime.CompilerServices;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MolchanovIV.Sprint5Task4.V6.Lib
{
    public class DataService : ISprint5Task4V6
    {
        public double LoadFromDataFile(string path)
        {
            double input, res;
            string inputStr = File.ReadAllText(path);

            input = double.Parse(inputStr, CultureInfo.InvariantCulture);

            res = Math.Round((1 / Math.Cos(input)) + 2.2 * Math.Pow(input, 2), 3);

            return res;
        }
    }
}