using System;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    [Serializable]
    public class BFSState
    {
        public Queue<int> Queue { get; set; } // Очередь вершин
        public bool[] Visited { get; set; } // Посещенные вершины
        public double[,] Matrix; // Матрица смежности
        public int K { get; } // Шаг алгоритма

        public BFSState(Queue<int> queue, bool[] visited, double[,] matrix, int k)
        {
            Queue = queue;
            Visited = visited;
            Matrix = matrix;
            K = k;
        }
    }
}