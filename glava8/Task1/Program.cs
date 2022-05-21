using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        private const int TrainsCount = 8;

        static void Main(string[] args)
        {
            Train[] trains = new Train[TrainsCount];
            for (int i = 0; i < trains.Length; i++)
            {
                trains[i] = InputTrain();
            }

            Array.Sort(trains, (a, b) => a.Id.CompareTo(b.Id));

            try
            {
                Console.Write("Введите id чтобы найти поезд: ");
                var id = int.Parse(Console.ReadLine());
                var train = GetTrainById(id, trains);

                OutputTrain(train);
            }
            catch (KeyNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void OutputTrain(Train train)
        {
            Console.WriteLine(
                $"Id: { train.Id };" +
                $" Destination: { train.Destination }; " +
                $"Date: { train.Date.Date }");
        }

        private static Train GetTrainById(int id, Train[] trains)
        {
            foreach (var train in trains)
            {
                if (train.Id == id)
                    return train;
            }


            throw new KeyNotFoundException("Поезд не найден");
        }

        private static Train InputTrain()
        {
            Console.Write("Введите id: ");
            var id = int.Parse(Console.ReadLine());

            Console.Write("Введите место назначения: ");
            var destination = Console.ReadLine();

            Console.Write("Введите время отправления: ");
            var date = DateTime.Parse(Console.ReadLine());

            return new Train(id, destination, date);
        }
    }
}
