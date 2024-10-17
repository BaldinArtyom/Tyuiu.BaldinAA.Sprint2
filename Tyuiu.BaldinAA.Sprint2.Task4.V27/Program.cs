using Tyuiu.BaldinAA.Sprint2.Task4.V27.Lib;
namespace Tyuiu.BaldinAA.Sprint2.Task4.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Балдин А. А. | ИБКСб-24-1";
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                                          *");
            Console.WriteLine("* Тема: Тернарный оператор                                                                                           *");
            Console.WriteLine("* Задание #4                                                                                                         *");
            Console.WriteLine("* Вариант #27                                                                                                        *");
            Console.WriteLine("* Выполнил: Балдин Артём Александрович | ИБКСб-24-1                                                                  *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                           *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с использованием тернарного оператора                     *");
            Console.WriteLine("* где пользователь вводит значение переменной X,Y с клавиатуры.                                                      *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                   *");
            Console.WriteLine("**********************************************************************************************************************");

            Console.WriteLine("Введите значение переменной x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение переменной y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x, y);

            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                         *");
            Console.WriteLine("**********************************************************************************************************************");

            Console.WriteLine("Значение функции = " + res); ;
        }
    }
}
