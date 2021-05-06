using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int m = 6;
            const int n = 8;
            const int min = 10;
            const int max = 99;

            var arr = new int[m, n];
            var rand = new Random();

            // Оголошення масиву
            for (var i = 0; i < m; i++)
                for (var j = 0; j < n; j++)
                    arr[i, j] = rand.Next(min, max + 1);

            // Вивід масиву
            Console.WriteLine("Масив :");
            for (int i = 0; i < arr.GetLength(0); i++, Console.WriteLine())
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write("{0,3}", arr[i, j]);

            // Знаходження середнього арифметичного
            var avg = new double[m];
            for (int i = 0; i < m; i++)
            {
                var sum = 0.0d;
                for (int j = 0; j < n; j++)
                {
                    sum += arr[i, j];
                }
                avg[i] = sum / n;


            }
            Console.WriteLine("Середні значення:");
            foreach (var a in avg)
            {
                Console.WriteLine(a);
            }

            var indexMin = 0;
            var indexMax = 0;
            var avgMin = 100d; // Початкове мінімальне значення
            var avgMax = -100d; //Початкове максимальне значення

            //Знаходження індексів рядків з максимальним і мінімальним середнім значенням
            for (int i = 0; i < m; i++)
            {
                if (avg[i] < avgMin) //Перший індекс серед мінімальних
                {
                    indexMin = i;
                    avgMin = avg[i];

                }
                if (avg[i] >= avgMax) //Останній індекс серед максимальних
                {
                    indexMax = i;
                    avgMax = avg[i];
                }

            }

            //Заміна значень рядків між собою
            for (int i = 0; i < n; i++)
            {
                var tmp = arr[indexMin, i];
                arr[indexMin, i] = arr[indexMax, i];
                arr[indexMax, i] = tmp;
            }

            //Вивід массиву з заміненими рядками
            Console.WriteLine("Оновлений масив c заміненими рядками:");
            for (int i = 0; i < arr.GetLength(0); i++, Console.WriteLine())
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write("{0,3}", arr[i, j]);
            Console.ReadKey();
        }
    }
}
