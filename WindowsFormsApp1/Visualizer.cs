using System;
using System.Drawing;

namespace WindowsFormsApp1
{
    public class Visualizer
    {
        // Отрисовка графа на основе матрицы смежности
        public void DrawGraph(Graphics graphics, BFSState state, int width, int height)
        {
            if (graphics == null || state == null)
            {
                throw new ArgumentNullException("Graphics и состояние не должны быть null.");
            }
            double[,] matrix = state.Matrix;
            bool[] visited = state.Visited;
            int size = matrix.GetLength(0);
            float radius = Math.Min(width, height) / 3f; // Адаптация радиуса под размеры окна
            PointF center = new PointF(width / 2f, height / 2f);
            PointF[] points = new PointF[size];

            // Расчет позиций вершин
            for (int i = 0; i < size; i++)
            {
                double angle = 2 * Math.PI * i / size;
                points[i] = new PointF(
                    center.X + radius * (float)Math.Cos(angle),
                    center.Y + radius * (float)Math.Sin(angle));
            }

            // Отрисовка рёбер
            Pen pen = new Pen(Color.Red, 1);
            Font font = new Font("Arial", 10);
            Brush textBrush = Brushes.Black;
            int k = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++, k++)
                {
                    if (matrix[i, j] > 0)
                    {
                        graphics.DrawLine(pen, points[i], points[j]);
                    }
                }
            }

            // Отрисовка вершин и номеров
            float vertexDiameter = 24; // Увеличен для лучшей видимости
            for (int i = 0; i < size; i++)
            {
                // Посетили вершины или ещё нет
                if (visited[i])
                {
                    graphics.FillEllipse(Brushes.Blue, points[i].X - vertexDiameter / 2, points[i].Y - vertexDiameter / 2,
                        vertexDiameter, vertexDiameter);
                }
                else
                {
                    graphics.FillEllipse(Brushes.Green, points[i].X - vertexDiameter / 2, points[i].Y - vertexDiameter / 2,
                        vertexDiameter, vertexDiameter);
                }

                // Добавляем номер вершины
                graphics.DrawString((i + 1).ToString(), font, textBrush, points[i].X - vertexDiameter / 4,
                    points[i].Y - vertexDiameter / 4);
            }
        }
    }
}