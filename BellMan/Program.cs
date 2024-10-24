using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = @"D:\INPUT.TXT";
        int[,] matrix = ReadMatrixFromFile(filePath);

        // In ma trận ra màn hình
        PrintMatrix(matrix);
    }

    static int[,] ReadMatrixFromFile(string path)
    {
        // Đọc toàn bộ dòng từ file
        string[] lines = File.ReadAllLines(path);
        int rowCount = lines.Length;
        int colCount = lines[0].Split(' ').Length;

        // Khởi tạo ma trận
        int[,] matrix = new int[rowCount, colCount];

        // Chuyển đổi từng dòng thành mảng số
        for (int i = 0; i < rowCount; i++)
        {
            string[] values = lines[i].Split(' ');
            for (int j = 0; j < colCount; j++)
            {
                matrix[i, j] = int.Parse(values[j]);
            }
        }

        return matrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rowCount = matrix.GetLength(0);
        int colCount = matrix.GetLength(1);

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}