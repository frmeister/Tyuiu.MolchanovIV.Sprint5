using System.Runtime.CompilerServices;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MolchanovIV.Sprint5.Task6.V28.Lib
{
    public class DataService : ISprint5Task6V28
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                while((line = reader.ReadLine()) != null)
                {
                    string numStr = "";

                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] != ' ' && char.IsDigit(line[i]))
                        {
                            numStr += line[i];
                        }
                        else
                        {
                            if (numStr.Length == 4) count++;
                            numStr = "";
                        }
                    }

                    if (numStr.Length == 4) count++;
                }
            }

            return count;
        }
    }
}
