namespace WindowsFormsApp1
{
    public class SolverManager
    {
        private BFSSolver solver; // Решатель
        private StateStorage storage; // Хранилище состояний

        public SolverManager()
        {
            storage = new StateStorage();
        }

        // Запуск решателя с параметрами и сохранение состояний
        public void Execute(AdjacencyMatrix parameters)
        {
            // Инициализация решателя с начальными параметрами
            solver = new BFSSolver(parameters.Matrix);

            // Начальное состояние
            storage.AddState(solver.SaveState());

            // Выполнение всех шагов алгоритма и сохранение состояний
            while (!IsAlgorithmComplete())
            {
                solver.Step();
                storage.AddState(solver.SaveState());
            }
        }

        // Проверка, завершен ли алгоритм
        private bool IsAlgorithmComplete()
        {
            return solver.HasCompleted();
        }

        // Получение объекта хранилища для доступа к сохраненным состояниям
        public StateStorage GetStateStorage()
        {
            return storage;
        }
    }
}