using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Zakaz
    {
        /// <summary>
        /// Поле Фамилия
        /// </summary>
        private string fam;

        /// <summary>
        /// Поле кол-во мест в номере
        /// </summary>
        private int size;

        /// <summary>
        /// Поле комфорт (люкс, полулюкс и т.п.)
        /// </summary>
        private string comfort;

        /// <summary>
        /// Св-во доступа к полю Фамилия 
        /// </summary>
        public string Fam { get { return fam; } set { fam = value; } }

        /// <summary>
        /// Св-во доступа к полю кол-во мест в номере
        /// </summary>
        public int Size { get { return size; } set { size = value; } }

        /// <summary>
        /// Св-во доступа к полю комфорт
        /// </summary>
        public string Comfort { get { return comfort; } set { comfort = value; } }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Zakaz() { }

        /// <summary>
        /// Конструктор с одним параметром
        /// </summary>
        /// <param name="fam"></param>
        public Zakaz(string fam)
        {
            this.Fam = fam;
        }

        /// <summary>
        /// Конструктор с двумя параметрами
        /// </summary>
        /// <param name="fam">фамилия</param>
        /// <param name="size">кол-во мест в номере</param>
        public Zakaz(string fam, int size)
        {
            this.Fam = fam;
            this.Size = size;
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="fam">фамилия</param>
        /// <param name="size">кол-во мест в номере</param>
        /// <param name="comfort">комфорт</param>
        public Zakaz(string fam, int size, string comfort)
        {
            this.Fam = fam;
            this.Size = size;
            this.Comfort = comfort; 
        }

        /// <summary>
        /// Метод для вывода информации
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine($"Фамилия: {fam}\nМеста в номере: {size}\nКомфорт: {comfort}");
        }


    }
}
