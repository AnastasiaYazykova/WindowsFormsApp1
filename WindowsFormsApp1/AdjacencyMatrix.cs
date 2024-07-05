using System;

namespace WindowsFormsApp1
{
    [Serializable]
    public class AdjacencyMatrix
    {
        // Поле для хранения матрицы смежности
        public double[,] Matrix { get; set; }

        // Конструктор класса, принимающий двумерный массив
        public AdjacencyMatrix(double[,] matrix)
        {
            // Проверка входных данных на null
            if (matrix == null)
            {
                throw new ArgumentNullException(nameof(matrix), "Матрица не может быть null.");
            }

            // Создание копии матрицы, чтобы избежать изменения извне
            int totalVertices = matrix.GetLength(0);
            Matrix = new double[totalVertices, totalVertices];
            Array.Copy(matrix, Matrix, matrix.Length);
        }
    }
}