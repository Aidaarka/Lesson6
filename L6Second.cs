using System;
using System.Collections.Generic;
namespace Lesson6.L6Second
{
    class Passport
    {
        public int PassSeries { get; set; }
        public int PassNumber { get; set; }
        public string FIO { get; set; }

    }
    class PassPost 
    {
        public static void Main()
        {
            List<Passport> pass = new List<Passport>();
            Random rnd = new Random();

            Console.WriteLine("Введите необходимое количество паспортов.");
            int quantity = Convert.ToInt32(Console.ReadLine());

            int passSeries;
            int passSeriesAuto;
            int passNumberAuto;
            
            Console.WriteLine("Выберите способ генерации серии паспорта:" +
                                "\n1 - автоматическая генерация\n2 - ручной ввод.");
            int numberGenerate = Convert.ToInt32(Console.ReadLine());

            if (numberGenerate == 1)
            {
                for (int i = 0; i < quantity; i++)
                {
                    Console.WriteLine("Введите ФИО.");
                    string fio = Console.ReadLine();
                    passSeriesAuto = rnd.Next(1000, 9999);
                    passNumberAuto = rnd.Next(100000, 999999);
                    pass.Add(new Passport() { PassSeries = passSeriesAuto, PassNumber = passNumberAuto, FIO = fio });
                }
            }
            else if (numberGenerate == 2)
            {
                for (int i = 0; i < quantity; i++)
                {
                    Console.WriteLine("Введите ФИО.");
                    string fio = Console.ReadLine();
                    Console.WriteLine("Введите серию паспорта.");
                    passSeries = Convert.ToInt32(Console.ReadLine());
                    passNumberAuto = rnd.Next(100000, 999999);
                    pass.Add(new Passport() { PassSeries = passSeries, PassNumber = passNumberAuto, FIO = fio });
                }
            }
            else 
                Console.WriteLine("Некорректный ввод, пожалуйста попробуйте заново.");

            foreach (var item in pass)
            {
                Console.WriteLine("Серия паспорта: {0}; Номер паспорта: {1} ФИО: {2}", 
                                    item.PassSeries, item.PassNumber, item.FIO);
            }
        }
    }
}
