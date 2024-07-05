using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        AdjacencyMatrix param; // Начальные параметры
        SolverManager manager; // Управленец
        StateStorage storage; // Хранилище состояний

        public Form1()
        {
            InitializeComponent();
            param = null;
            manager = null;
            storage = null;
            dgv1.Rows.Clear();
            dgv1.Columns.Clear();
            next.Enabled = false;
            prev.Enabled = false;
            curState.Text = "Состояние: ...";
            Bitmap buffer = new Bitmap(pic.Width, pic.Height);
            Graphics g = Graphics.FromImage(buffer);
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, pic.Width, pic.Height);
            pic.Image = buffer;
        }

        // Отображение матрицы в DataGridView
        public void DisplayMatrix(DataGridView dgv, double[,] matrix)
        {
            if (dgv == null || matrix == null)
            {
                throw new ArgumentNullException("DataGridView и состояние не должны быть null.");
            }
            int size = matrix.GetLength(0);
            dgv.ColumnCount = size;
            dgv.RowCount = size;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    dgv.Rows[i].Cells[j].Value = matrix[i, j].ToString("F2");
                }
                dgv.Columns[i].Width = 50;
            }
        }

        // Чтение матрицы из файла
        public static double[,] ReadMatrix(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Указанный файл не найден.", filePath);
            }
            string[] lines = File.ReadAllLines(filePath); // Чтение всех строк файла
            int size = lines.Length;
            double[,] matrix = new double[size, size];
            for (int i = 0; i < size; i++)
            {
                string[] entries = lines[i].Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (entries.Length != size)
                {
                    throw new Exception("Матрица в файле должна быть квадратной.");
                }
                for (int j = 0; j < size; j++)
                {
                    if (!double.TryParse(entries[j], out matrix[i, j]))
                    {
                        throw new Exception($"Некорректное значение в строке {i + 1}, столбце {j + 1}.");
                    }
                }
            }
            return matrix;
        }

        // Отрисовка графа и текущего состояния
        private void DrawGraph(BFSState state)
        {
            Visualizer visual = new Visualizer();
            Bitmap buffer = new Bitmap(pic.Width, pic.Height);
            Graphics g = Graphics.FromImage(buffer);
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, pic.Width, pic.Height);
            visual.DrawGraph(g, state, pic.Width, pic.Height);
            pic.Image = buffer;
        }

        // Загружаем граф из выбранного файла
        private void load_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var filePath = openFileDialog.FileName;
                        param = new AdjacencyMatrix(ReadMatrix(filePath));
                        DisplayMatrix(dgv1, param.Matrix);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Ввод графа вручную
        private void read_Click(object sender, EventArgs e)
        {
            param = new AdjacencyMatrix(new double[2, 2]);
            ReadGraph r = new ReadGraph(param);
            if (r.ShowDialog() == DialogResult.OK)
            {
                DisplayMatrix(dgv1, param.Matrix);
            }
        }

        // Решение задачи
        private void find_Click(object sender, EventArgs e)
        {
            if (param != null)
            {
                manager = new SolverManager();
                manager.Execute(param);
                storage = manager.GetStateStorage();
                curState.Text = "Состояние: " + storage.GetState().K;
                DrawGraph(storage.GetState());
                next.Enabled = true;
                prev.Enabled = true;
            }
        }

        // Показ справки по алгоритму
        private void cправкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.ShowDialog();
        }

        // Переход к следующему состоянию
        private void next_Click(object sender, EventArgs e)
        {
            if (storage != null)
            {
                storage.NextState();
                curState.Text = "Состояние: " + storage.GetState().K;
                DrawGraph(storage.GetState());
            }
        }

        // Переход к предыдущему состоянию
        private void prev_Click(object sender, EventArgs e)
        {
            if (storage != null)
            {
                storage.PrevState();
                curState.Text = "Состояние: " + storage.GetState().K;
                DrawGraph(storage.GetState());
            }
        }

        // Сохраняем текущее состояние в указанный файл
        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (storage != null)
                {
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                        saveFileDialog.FilterIndex = 2;
                        saveFileDialog.RestoreDirectory = true;
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            var filePath = saveFileDialog.FileName;
                            storage.SaveToFile(filePath);
                            MessageBox.Show("Состояния сохранены в файл");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось сохранить данные в файл...");
            }
        }

        // Очистка текущего состояния и графа
        private void clear_Click(object sender, EventArgs e)
        {
            param = null;
            manager = null;
            storage = null;
            dgv1.Rows.Clear();
            dgv1.Columns.Clear();
            next.Enabled = false;
            prev.Enabled = false;
            curState.Text = "Состояние: ...";
            Bitmap buffer = new Bitmap(pic.Width, pic.Height);
            Graphics g = Graphics.FromImage(buffer);
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, pic.Width, pic.Height);
            pic.Image = buffer;
        }

        // Сохранение текущего графа в файл
        private void saveGraph_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    saveFileDialog.FilterIndex = 2;
                    saveFileDialog.RestoreDirectory = true;
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var filePath = saveFileDialog.FileName;
                        StreamWriter writer = new StreamWriter(filePath);
                        var matrix = param.Matrix;
                        string s = "";
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                s += matrix[i, j] + " ";
                            }
                            if (i < matrix.GetLength(0) - 1)
                                s += "\n";
                        }
                        writer.WriteLine(s);
                        writer.Close();
                        MessageBox.Show("Данные успешно сохранены в файле " + filePath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось сохранить данные в файл...");
            }
        }

        // Загрузка состояния из файла
        private void loadState_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var filePath = openFileDialog.FileName;
                        storage.LoadFromFile(filePath);
                        MessageBox.Show("Состояния загружены из файла");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}