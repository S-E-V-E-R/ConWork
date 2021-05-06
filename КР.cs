using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Оголошення масиву та допоміжних змінних

            Random rand = new Random();
            int n = 8;
            int[,] arr = new int[n, n];

            int sumDiag = 0;
            int[] sumRow = new int[n];
            int countRow = 0;

            // Ініціалізація елементів масиву

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i,j] = rand.Next(56, 99);

                    Console.Write(arr[i,j] + " ");

                }
                Console.WriteLine();
            }

            //Знаходження суми елементів головної діагоналі та рядків масиву

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

            //Знаходження кiлькiсть рядкiв, якi мають бiльше значення суми елементiв, нiж на головнiй дiагоналi

            for (int i = 0; i < n; i++)
            {
                if (sumRow[i] > sumDiag)
                    countRow++;   
                
            }
            Console.WriteLine();
            Console.WriteLine("Кiлькiсть рядкiв, якi мають бiльше значення суми елементiв, нiж на головнiй дiагоналi: " + countRow);
            Console.WriteLine();

            //Заміна першого рядка масиву останнім 
            for (int i = 0; i < n; i++)
            {
                int tmp = arr[0, i];
                arr[0, i] = arr[n-1, i];
                arr[n-1, i] = tmp;

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
