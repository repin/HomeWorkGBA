using System;

namespace HomeWorkGBA.Lesson7_1
{
    class Lesson7_1 : ILesson
    {
        public string lessonID => "7-1";

        public string discriprions => "Нахождение количествапутей в ячейку";

        public void Demo()
        {
            CountTriectories(3, 6);
            CountTriectories(10, 6);
            CountTriectories(10, 16);
            CountTriectories(2, 2);
            CountTriectories(7, 9);

        }

        public void CountTriectories(int a, int b)
        {
            int[,] array = new int[a, b];
            for (int i = 0; i < b; i++)
            {
                array[0, i] = 1;
            }
            for (int i = 0; i < a; i++)
            {
                array[i, 0] = 1;
                for (int k = 0; k < b; k++)
                {
                    if (i == 0 || k == 0)
                        continue;
                    array[i, k] = array[i - 1, k] + array[i, k - 1];
                }
            }
            Console.WriteLine($"Количество путей в матрице {a}x{b} сотавляет: {array[a - 1, b - 1]}");
            TestDispleyMatrix(array, a, b);
        }

        private void TestDispleyMatrix(int[,] array, int a, int b)
        {
            Console.WriteLine("Вывод матрицы для проверки:");
            for (int i = 0; i < a; i++)
            {
                for (int k = 0; k < b; k++)
                {
                    string t = array[i, k].ToString();
                    
                    for (int z = 0; z < 15 - t.Length; z++)
                    {
                        t = t + " ";
                    }
                    Console.Write(t);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}