using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp1
{
    public class StateStorage
    {
        private List<BFSState> states; // Список всех состояний
        private int currentIndex; // Текущее состояние

        public StateStorage()
        {
            states = new List<BFSState>();
            currentIndex = 0;
        }

        // Добавление нового состояния в список
        public void AddState(BFSState state)
        {
            if (state == null)
            {
                throw new ArgumentNullException(nameof(state), "Состояние не может быть null.");
            }
            states.Add(state);
        }

        // Переход к следующему состоянию
        public void NextState()
        {
            if (currentIndex < states.Count - 1)
            {
                currentIndex++;
            }
        }

        // Переход к предыдущему состоянию
        public void PrevState()
        {
            if (currentIndex > 0)
            {
                currentIndex--;
            }
        }

        // Текущее состояние
        public BFSState GetState()
        {
            return states[currentIndex];
        }

        // Сброс индекса для нового прохода по списку состояний
        public void Reset()
        {
            currentIndex = 0;
        }

        // Сохранение списка состояний в файл
        public void SaveToFile(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, states);
            }
        }

        // Загрузка списка состояний из файла
        public void LoadFromFile(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                states = (List<BFSState>)formatter.Deserialize(fs);
                Reset(); // Сброс индекса после загрузки новых данных
            }
        }
    }
}