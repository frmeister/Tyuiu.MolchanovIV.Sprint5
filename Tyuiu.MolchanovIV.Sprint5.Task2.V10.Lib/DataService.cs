using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MolchanovIV.Sprint5.Task2.V10.Lib
{
    public class DataService : ISprint5Task2V10
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string filepath = $@"{Path.GetTempPath()}";
            string filename = "OutPutFileTask2.csv";
            string path = Path.Combine(filepath, filename);

            FileInfo fileinfo = new FileInfo(path);

            if (File.Exists(path)) File.Delete(path);

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] > 0) matrix[i, j] = 1;
                    else matrix[i, j] = 0;

                    string output = Convert.ToString(matrix[i, j]);

                    if (j != columns - 1)
                    {
                        output += ";";
                        File.AppendAllText(path, output);
                    }
                    else File.AppendAllText(path, output + Environment.NewLine);
                }

            return path;
        }
    }
}
