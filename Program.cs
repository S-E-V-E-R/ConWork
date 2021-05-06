using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Объявляем массив

            Random rand = new Random();
            int n = 8;
            int[,] arr = new int[n, n];
            int sumDiag = 0;
            int[] sumRow = new int[n];
            int countRow = 0;
            // Инициализируем каждый элемент массива

            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i,j] = rand.Next(56, 99);

                    Console.Write(arr[i,j] + " ");

                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        sumDiag += arr[i, j];
                    sumRow[i] += arr[i, j]; 
                   
                }

            }
            Console.WriteLine();
            Console.WriteLine("Сума елементiв на головнiй дiагоналi: "+ sumDiag);
            for (int i = 0; i < n; i++)
            {
                if (sumRow[i] > sumDiag)
                    countRow++;   
                
            }
            Console.WriteLine();
            Console.WriteLine("Кiлькiсть рядкiв, якi мають бiльше значення суми елементiв, нiж на головнiй дiагоналi: " + countRow);
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                int tmp = arr[0, i];
                arr[0, i] = arr[n, i];
                arr[n, i] = tmp;

            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    Console.Write(arr[i, j] + " ");

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

}
