using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rubToUsd = 76, usdToRub = 75, euroToRub = 80, rubToEuro = 81;
            float rub;
            float usd;
            float euro;
            string userInput;
            string stopWord = "exit";
            bool canExamination = true;
            float currencyCount;

            Console.WriteLine(" Добро пожаловать в обменник валют, здесь вы можете обменять рубли на доллары, доллары на рубли, рубли на евро и евро на рубли ");

            Console.Write(" Введите баланс рублей ");
            rub = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Введите баланс долларов ");
            usd = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Введите баланс евро ");
            euro = Convert.ToInt32(Console.ReadLine());

            while (canExamination)
            {
                Console.WriteLine(" 1 - обменять рубли на доллары ");
                Console.WriteLine(" 2 - обменять доллары на рубли ");
                Console.WriteLine(" 3 - обменять рубли на евро ");
                Console.WriteLine(" 4 - обменять евро на рубли ");
                userInput = Console.ReadLine();
                if (userInput == stopWord)
                {
                    canExamination = false;
                }
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine(" Обмен рублей на доллары ");
                        Console.Write(" Сколько вы хотите обменять ");
                        currencyCount = Convert.ToInt32(Console.ReadLine());
                        if (rub >= currencyCount)
                        {
                            rub -= currencyCount;
                            usd += currencyCount / rubToUsd;
                        }
                        else
                        {
                            Console.WriteLine(" Недопустимое кол-во рублей ");
                        }
                        break;
                    case "2":
                        Console.WriteLine(" Обмен долларов на рубли ");
                        Console.Write(" Сколько вы хотите обменять ");
                        currencyCount = Convert.ToInt32(Console.ReadLine());
                        if (usd >= currencyCount)
                        {
                            usd -= currencyCount;
                            rub += currencyCount * usdToRub;
                        }
                        else
                        {
                            Console.WriteLine(" Недопустимое кол-во долларов ");
                        }
                        break;
                    case "3":
                        Console.WriteLine(" Обмен рублей на евро ");
                        Console.Write(" Сколько вы хотите обменять ");
                        currencyCount = Convert.ToInt32(Console.ReadLine());
                        if (rub >= currencyCount)
                        {
                            rub -= currencyCount;
                            euro += currencyCount / rubToEuro;
                        }
                        else
                        {
                            Console.WriteLine(" Недопустимое кол-во рублей ");
                        }
                        break;
                    case "4":
                        Console.WriteLine(" Обмен Евро на рубли ");
                        Console.Write(" Сколько вы хотите обменять ");
                        currencyCount = Convert.ToInt32(Console.ReadLine());
                        if (euro >= currencyCount)
                        {
                            euro -= currencyCount;
                            rub += currencyCount * euroToRub;
                        }
                        else
                        {
                            Console.WriteLine(" Недопустимое кол-во евро ");
                        }
                        break;
                }
                Console.WriteLine(" Ваш баланс рублей " + rub + " баланс долларов " + usd + " баланс евро " + euro);
            }
        }
    }
}
