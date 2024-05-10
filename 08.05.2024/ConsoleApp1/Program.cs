using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        //Задача 37
        // Объявление делегата для вычисления площади треугольника
        //delegate double Triangle(double a, double b, double c);

        //Задача 44
        //delegate int Sum(int m, int n);

        //Задача 40
        //delegate double Average(int m, int n);

        static void Main(string[] args)
        {
            List<Zakaz> zakazs = new List<Zakaz>();
            while (true)
            {
                Console.WriteLine("Добавить объект");
                Console.WriteLine("Вывод информации");
                Console.WriteLine("Выход");
                string v = Console.ReadLine();
                switch(v)
                {
                    case "1":
                        string fam = Console.ReadLine();
                        zakazs.Add(new Zakaz(fam,size, comfort));
                        break;
                    case " 2":
                        break;
                    case "Q":
                        break;
                    default:
                        break;
                }
            }



            //Задача 40 эта задача остается под вопросом на разработку

            // Присваивание адреса метода через конструктор
            //Average del = new Average(Average1); // делегат указывает на метод Average1
            //double result = del.Invoke(1, 10);
            //Console.WriteLine($"Среднее арифметическое от 1 до 10: {result}");

            //del = Average1; // Теперь делегат указывает на метод Average1
            //result del = (10, 20);
            //Console.WriteLine($"Среднее арифметическое от 10 до 20: {result} ");

            //del = Average1;
            //result del = (20, 30);
            //Console.WriteLine($"Среднее арифметическое от 20 до 30: {result} ");


            //Задача 44

            // Создаем экземпляр делегата
            //Sum del = new Sum(Sum1);

            //// Применяем созданный делегат три раза
            //int result1 = del.Invoke(1, 10); // Сокращенный синтаксис вызова делегата
            //Console.WriteLine($"Сумма от 1 до 10: {result1}");

            //del = Sum1;
            //int result2 = del.Invoke(10, 20); // Сокращенный синтаксис вызова делегата
            //Console.WriteLine($"Сумма от 10 до 20: {result2}");

            //del = Sum1;
            //int result3 = del.Invoke(20, 30); // Сокращенный синтаксис вызова делегата
            //Console.WriteLine($"Сумма от 20 до 30: {result3}");

        }

        // Объявляем статический метод для вычисления среднего арифметического
        //public static double Average1(int m, int n)
        //{
        //    double sum = 0;
        //    for (int i=m; i<=n; i++)
        //    {
        //        sum += i;
        //    }
        //    result sum/ (n - m + 1);
        //}


        //Задача 44
        //public static int Sum1(int m, int n)
        //{
        //    int sum = 0;
        //    for (int i = m; i <= n; i++)
        //    {
        //        sum += i;
        //    }
        //    return sum;
        //}


        //Задача 37
        //Triangle del = new Triangle(TriangleArea);

        //double a1 = 3.2, b1 = 5.3, c1 = 7.1;
        //double area1 = del.Invoke(a1, b1, c1);
        //Console.WriteLine($"Площадь треугольника со сторонами {a1}, {b1}, {c1} равна: {area1}");

        //double a2 = 6.2, b2 = 7.3, c2 = 1.1;
        //double area2 = del.Invoke(a2, b2, c2);
        //Console.WriteLine($"Площадь треугольника со сторонами {a2}, {b2}, {c2} равна: {area2}");

        //double a3 = 5.2, b3 = 7.1, c3 = 4.1;
        //double area3 = del.Invoke(a3, b3, c3);
        //Console.WriteLine($"Площадь треугольника со сторонами {a3}, {b3}, {c3} равна: {area3}");

    }


        //Задача 37
        //static double TriangleArea(double a, double b, double c)
        //{
        //    // Полупериметр треугольника
        //    double p = (a + b + c) / 2.0;
        //    // Формула Герона для площади
        //    return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        //}


        

    



}

