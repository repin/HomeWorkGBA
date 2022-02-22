using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkGBA.lesson3_1
{
    class Lesson3_1 : ILesson
    {
        public string lessonID => "3-1";

        public string discriprions => "Класс, структура, дистанция";

        /// <summary>
        /// Метод запуска алгоритма, прогоняем 3 раза, чтобы посмотреть на влияние сторонних процессов на компьютере
        /// </summary>
        public void Demo()
        {
            Console.WriteLine("Начало выполниня ДЗ 3-1");
            for (int i = 0; i < 3; i++)
            {
                Work(10000);
                Work(20000);
                Work(30000);
                Work(50000);
                Work(100000);
                Work(100000000);
            }
            Console.WriteLine("Конец выполнения урока");
        }

        /// <summary>
        /// Метод прогонки алгоритма с подсчетом времени исполнения функцию
        /// </summary>
        /// <param name="n">количество элементов тестирования</param>
        public void Work(int n)
        {
            Stopwatch sw = new Stopwatch();
            double[] x = new double[n];
            double[] y = new double[n];
            double[] z = new double[n];
            double[] k = new double[n];
            Random h = new Random();
            for (int i = 0; i < n; i++)
            {
                x[i] = h.NextDouble();
                y[i] = h.NextDouble();
                z[i] = h.NextDouble();
                k[i] = h.NextDouble();
            }
            sw.Start();
            for (int i = 0; i < n; i++)
            {
                DistanceClass(x[i], y[i], z[i], k[i]);
            }
            sw.Stop();
            var sw1 = sw.Elapsed;
            sw.Reset();
            sw.Start();
            for (int i = 0; i < n; i++)
            {
                DistanceStruct(x[i], y[i], z[i], k[i]);
            }
            sw.Stop();
            var sw2 = sw.Elapsed;
            sw.Reset();
            sw.Start();
            for (int i = 0; i < n; i++)
            {
                Distance(x[i], y[i], z[i], k[i]);
            }
            sw.Stop();
            var sw3 = sw.Elapsed;
            sw.Reset();

            Console.WriteLine($"{n}|{sw1}|{sw2}|{Math.Round(sw2.TotalMilliseconds / sw1.TotalMilliseconds, 3)}|               |{sw3}|{Math.Round(sw3.TotalMilliseconds / sw2.TotalMilliseconds, 3)}");
        }


        /// <summary>
        /// Алгоритм подсчета длины линии через класс
        /// </summary>
        /// <param name="k">1 координата 1 точки</param>
        /// <param name="t">2 координата 1 точки</param>
        /// <param name="r">1 координата 2 точки</param>
        /// <param name="z">2 координата 2 точки</param>
        private void DistanceClass(double k, double t, double r, double z)
        {
            PointClassDouble p1Class = new PointClassDouble() { x = k, y = t };
            PointClassDouble p2Class = new PointClassDouble() { x = r, y = z };
            double x = p1Class.x - p2Class.x;
            double y = p1Class.y - p2Class.y;
            double leght = Math.Sqrt((x * x) + (y * y));
        }
        /// <summary>
        /// Алгоритм подсчета длины линии через структуру
        /// </summary>
        /// <param name="k">1 координата 1 точки</param>
        /// <param name="t">2 координата 1 точки</param>
        /// <param name="r">1 координата 2 точки</param>
        /// <param name="z">2 координата 2 точки</param>
        private void DistanceStruct(double k, double t, double r, double z)
        {
            PointStructDouble p1Class = new PointStructDouble() { x = k, y = t };
            PointStructDouble p2Class = new PointStructDouble() { x = r, y = z };
            double x = p1Class.x - p2Class.x;
            double y = p1Class.y - p2Class.y;
            double leght = Math.Sqrt((x * x) + (y * y));
        }


        /// <summary>
        /// Для примера и сравнения метод без использования классов и структур
        /// </summary>
        /// <param name="k"></param>
        /// <param name="t"></param>
        /// <param name="r"></param>
        /// <param name="z"></param>
        private void Distance(double k, double t, double r, double z)
        {

            double x = k - r;
            double y = t - z;
            double leght = Math.Sqrt((x * x) + (y * y));
        }




    }
}
