using System;
using MyFirstLib;

namespace Methodes_for_the_salary_split
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, я поомогу Вам распределить зарплату!\n Напишите пожалуйста сумму вашей ЗП в этом месяце.");
            double salary=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Понятно, ваша ЗП={0} рублей",salary);
            Console.WriteLine("Теперь введите пожалуйста, сколько вы в среднем расходуете на съём квартиры?");
            double rent=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Понятно, значит {0} рублей \nА сколько у Вас в среднем уходит средств на продукты?", rent);
            double food = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ясно, значит {0} рублей \nА сколько у Вас в среднем уходит средств на транспорт?", food);
            double transport = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ясно, значит {0} рублей \nА сколько Вы хотите в тратить на развитие в процентах? ", transport);
            double improvement_percentage = Convert.ToDouble(Console.ReadLine()); 
            double _salary = salary;
            double _rent = rent;
            double _food = food;
            double _transport = transport;
            double _improvement_percentage = improvement_percentage;

            double rest = GetRest(_salary, _rent, _food, _transport);
            double improve = Get4Improve(salary, _improvement_percentage);
            Console.WriteLine("Я тут прикинул и получилось,что Вам необходимо откложить:{0} на брокерский счёт или другой способ инвестирования,{1}" +
                " на развитие,{2} на развлечение. У Вас останется {3}",salary*0.1 ,improve   , salary - rent - food - transport-(2*salary*0.1),rest);
            //SalarySplitter.GetRest(_salary, _rent, _food, _transport);
            Console.Read();
        }
        static double GetRest(double _salary, double _rent, double _food, double _transport)
        {
            double salary_rest = _salary - _rent - _food - _transport - 2 * _salary * 0.1;
            return salary_rest;

        }
        static double Get4Improve(double _salary, double _improvement_percentage)
        {
            double money_for_improvement = _salary * _improvement_percentage / 100;
            return money_for_improvement;

        }
    }
}
