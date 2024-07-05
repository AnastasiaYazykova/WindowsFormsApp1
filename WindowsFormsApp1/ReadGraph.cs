using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ReadGraph : Form
    {
        AdjacencyMatrix data { get; set; }
        private event Action<AdjacencyMatrix> _dataDelegate; // Делегат для передачи данных
        public ReadGraph(AdjacencyMatrix data)
        {
            InitializeComponent();
            this.data = data;
        }
        public void AddEvent(Action<AdjacencyMatrix> dataDelegate)
        {
            _dataDelegate += dataDelegate;
        }

        // Ввод графа
        private void read_Click(object sender, EventArgs e)
        {
            try
            {
                // Разбор строк
                string[] lines = textBox1.Text.Split('\n');
                int size = lines.Length;
                double[,] matrix = new double[size, size];
                for (int i = 0; i < size; i++)
                {
                    string[] entries = lines[i].Replace("\r", "").Split(new[] { ' ', '\t' },
                        StringSplitOptions.RemoveEmptyEntries);
                    if (entries.Length != size)
                    {
                        throw new Exception("Матрица должна быть квадратной.");
                    }
                    for (int j = 0; j < size; j++)
                    {
                        if (!double.TryParse(entries[j], out matrix[i, j]))
                        {
                            if (entries[j] == "inf")
                            {
                                matrix[i, j] = double.PositiveInfinity;
                            }
                            else
                            {
                                throw new Exception($"Некорректное значение в строке {i + 1}, столбце {j + 1}.");
                            }
                        }
                    }
                }
                data.Matrix = matrix;
                _dataDelegate?.Invoke(data);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Закрываем форму
        private void close_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ReadGraph_Load(object sender, EventArgs e)
        {

        }
    }
}