using System;

namespace MyApps
{
    class Program
    {
        static void Calculator(string phrase)
        {
            Console.Clear();
            if (phrase == "+" || phrase == "-" || phrase == "*" || phrase == "^" || phrase == "/")
            {
                Console.WriteLine("Введите два числа через пробел: ");
                string phrases = Console.ReadLine();
                string[] words = phrases.Split(' ');

                bool y1, y2, y3;
                y1 = double.TryParse(words[0], out var value1);
                y2 = double.TryParse(words[1], out var value2);
                y3 = char.TryParse(phrase, out var operation);

                if (y1 == y2)
                {
                    if (operation == '+')
                    {
                        Console.WriteLine("результат операциии = " + (value1 + value2));
                        Console.WriteLine(" ");
                    }
                    if (operation == '-')
                    {
                        Console.WriteLine("результат операциии = " + (value1 - value2));
                        Console.WriteLine(" ");
                    }
                    if (operation == '*')
                    {
                        Console.WriteLine("результат операциии = " + (value1 * value2));
                        Console.WriteLine(" ");
                    }
                    if ((operation == '/') & (value2 != 0))
                    {
                        Console.WriteLine("результат операциии = " + (value1 / value2));
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine("Неверные данные");
                        Console.WriteLine(" ");
                    }
                    if (operation == '^')
                    {
                        double t = 1;
                        for (int i = 1; i <= value2; i++)
                        {
                            t = t * value1;
                        }
                        Console.WriteLine(value2 + " степень числа " + value1 + " = " + t);
                        Console.WriteLine(" ");
                    }
                }
                else
                {
                    Console.WriteLine("Неверные данные");
                    Console.WriteLine(" ");
                }
            }


            if (phrase == "sin")
                    {
                        Console.WriteLine("Введите число: ");
                        string s = Console.ReadLine();
                        double temp = double.Parse(s);
                        Console.WriteLine("Sin = " + Math.Sin(temp));
                        Console.WriteLine(" ");
                    }
            if (phrase == "cos")
                    {
                        Console.WriteLine("Введите число: ");
                        string s = Console.ReadLine();
                        double temp = double.Parse(s);
                        Console.WriteLine("Cos = " + Math.Cos(temp));
                        Console.WriteLine(" ");
                    }
            if (phrase == "tg")
                    {
                        Console.WriteLine("Введите число: ");
                        string s = Console.ReadLine();
                        double temp = double.Parse(s);
                        Console.WriteLine("Tangens = " + Math.Tan(temp));
                        Console.WriteLine(" ");
                    }
            if (phrase == "ctg")
                    {
                        Console.WriteLine("Введите число: ");
                        string s = Console.ReadLine();
                        double temp = double.Parse(s);
                        Console.WriteLine("Cotangens = " + (1 / Math.Tan(temp)));
                        Console.WriteLine(" ");
                    }
                    
            }


        static void Main(string[] args)
        {
            string phrase = "none";

            while (phrase != "0")
            {
                Console.WriteLine("Выберите операцию: ");
                Console.WriteLine(" ");
                Console.WriteLine("+  -  *  /   ^");
                Console.WriteLine("sin  cos  tg  ctg");
                Console.WriteLine(" ");
                Console.WriteLine("Для выхода введите 0");
                Console.WriteLine(" ");

                phrase = Console.ReadLine();

                if (phrase == "0") break;
                else Calculator(phrase);


            }
        }
    }
}
