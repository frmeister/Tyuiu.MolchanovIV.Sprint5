using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MolchanovIV.Sprint5.Task7.V30.Lib
{
    public class DataService : ISprint5Task7V30
    {
        public string LoadDataAndSave(string path)
        {
            string filepath = $@"{Path.GetTempPath()}";
            string filename = "OutPutDataFileTask7V30.txt.";
            string outputPath = Path.Combine(filepath, filename);
            string result = "";

            if (File.Exists(outputPath)) File.Delete(outputPath);

            using (StreamReader reader = new StreamReader(path)) 
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string curStr = "";

                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] != ' ' && char.IsDigit(line[i]))
                        {
                            curStr += line[i];
                        }
                        else
                        {
                            if (curStr.Length == 1) result += "9 ";
                            else if (string.IsNullOrEmpty(curStr)) result += line[i];
                            else result += curStr + " ";
                            curStr = "";
                        }
                    }
                    if (curStr.Length == 1) result += '9';

                    File.AppendAllText(outputPath, result + Environment.NewLine);
                }
            }

            return outputPath;
        }
    }
}
