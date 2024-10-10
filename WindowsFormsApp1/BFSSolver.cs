using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class BFSSolver
    {
        private Queue<int> queue; // Очередь вершин
        private bool[] visited; // Посещенные вершины
        private double[,] matrix; // Матрица смежности
        private int k; // Следующий шаг для k-го состояния
        private int totalVertices; // Размерность матрицы
        // Конструктор, принимающий матрицу смежности
        public BFSSolver(double[,] adjacencyMatrix)
        {
            if (adjacencyMatrix == null)
            {
                throw new ArgumentNullException(nameof(adjacencyMatrix),
                    "Матрица смежности не может быть null.");
            }
            totalVertices = adjacencyMatrix.GetLength(0);
            matrix = new double[totalVertices, totalVertices];
            Array.Copy(adjacencyMatrix, matrix, adjacencyMatrix.Length);
            queue = new Queue<int>();
            queue.Enqueue(0);
            visited = new bool[totalVertices];
            k = 0; // Начинаем с 0-го состояния
        }

        // Метод для выполнения одного шага алгоритма
        public void Step()
        {
            if (HasCompleted()) return; // Закончились шаги

            // Выполняем шаг
            int v = queue.Dequeue();
            visited[v] = true;

            // Проверяем смежные вершины
            for (int i = 0; i < totalVertices; i++)
            {
                if (!visited[i] && matrix[i, v] > 0)
                {
                    queue.Enqueue(i);
				}
            }

            k++; // Переход к следующему шагу
        }

        // Метод для сохранения текущего состояния алгоритма
        public BFSState SaveState()
        {
            double[,] distancesCopy = new double[totalVertices, totalVertices];
            Array.Copy(matrix, distancesCopy, matrix.Length);
            bool[] visitedCopy = new bool[totalVertices];
            Array.Copy(visited, visitedCopy, visited.Length);
            return new BFSState(new Queue<int>(queue), visitedCopy, distancesCopy, k);
        }

        // Метод для восстановления состояния алгоритма
        public void RestoreState(BFSState state)
        {
            if (state == null)
            {
                throw new ArgumentNullException(nameof(state),
                    "Состояние не может быть null.");
            }
            k = state.K;
            matrix = state.Matrix;
            queue = state.Queue;
            visited = state.Visited;
        }

        // Все решили
        public bool HasCompleted()
        {
            return queue.Count == 0;
        }
    }
}