using System;

namespace MyApps
{
    class Program
    {
        static void Calculator(string phrase)
        {
            switch (phrase)
            {
                case "+":
                    {
                        Console.WriteLine("Введите выражение в формате: число операция число");
                        string phrases = Console.ReadLine();
                        string[] words = phrases.Split(' ');

                        bool y1, y2, y3;
                        y1 = double.TryParse(words[0], out var value1);
                        y2 = char.TryParse(words[1], out var op);
                        y3 = double.TryParse(words[2], out var value2);


                        if (y1 == y2 == y3)
                        {
                            Console.WriteLine("Сумма = " + (value1 + value2));
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            Console.WriteLine("Неверные данные");
                            Console.WriteLine(" ");
                        }

                        break;
                    }
                case "-":
                    {
                        Console.WriteLine("Введите выражение в формате: число операция число");
                        string phrases = Console.ReadLine();
                        string[] words = phrases.Split(' ');

                        bool y1, y2, y3;
                        y1 = double.TryParse(words[0], out var value1);
                        y2 = char.TryParse(words[1], out var op);
                        y3 = double.TryParse(words[2], out var value2);


                        if (y1 == y2 == y3)
                        {
                            Console.WriteLine("Разность = " + (value1 - value2));
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            Console.WriteLine("Неверные данные");
                            Console.WriteLine(" ");
                        }

                        break;
                    }
                case "*":
                    {
                        Console.WriteLine("Введите выражение в формате: число операция число");
                        string phrases = Console.ReadLine();
                        string[] words = phrases.Split(' ');

                        bool y1, y2, y3;
                        y1 = double.TryParse(words[0], out var value1);
                        y2 = char.TryParse(words[1], out var op);
                        y3 = double.TryParse(words[2], out var value2);


                        if (y1 == y2 == y3)
                        {
                            Console.WriteLine("Произведение = " + (value1 * value2));
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            Console.WriteLine("Неверные данные");
                            Console.WriteLine(" ");
                        }
                        break;
                    }
                case "/":
                    {
                        Console.WriteLine("Введите выражение в формате: число операция число");
                        string phrases = Console.ReadLine();
                        string[] words = phrases.Split(' ');

                        bool y1, y2, y3;
                        y1 = double.TryParse(words[0], out var value1);
                        y2 = char.TryParse(words[1], out var op);
                        y3 = double.TryParse(words[2], out var value2);


                        if ((y1 == y2 == y3) & (value2 != 0))
                        {
                            Console.WriteLine("Частное = " + (value1 / value2));
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            Console.WriteLine("Неверные данные");
                            Console.WriteLine(" ");
                        }

                        break;
                    }
                case "^":
                    {
                        Console.WriteLine("Введите число и степень в формате: число степень");
                        bool y1, y2;
                        string phrases = Console.ReadLine();
                        string[] words = phrases.Split(' ');

                        y1 = double.TryParse(words[0], out var value1);
                        y2 = int.TryParse(words[1], out var power);

                        if (y1 == y2)
                        {
                            double t = 1;
                            for (int i = 1; i <= power; i++)
                            {
                                t = t * value1;
                            }
                            Console.WriteLine(power + " степень числа " + value1 + " = " + t);
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            Console.WriteLine("Неверные данные");
                            Console.WriteLine(" ");
                        }

                        break;
                    }
                case "sin":
                    {
                        Console.WriteLine("Введите число: ");
                        string s = Console.ReadLine();
                        double temp = double.Parse(s);
                        Console.WriteLine("Sin = " + Math.Sin(temp));
                        Console.WriteLine(" ");
                        break;
                    }
                case "cos":
                    {
                        Console.WriteLine("Введите число: ");
                        string s = Console.ReadLine();
                        double temp = double.Parse(s);
                        Console.WriteLine("Cos = " + Math.Cos(temp));
                        Console.WriteLine(" ");
                        break;
                    }
                case "tg":
                    {
                        Console.WriteLine("Введите число: ");
                        string s = Console.ReadLine();
                        double temp = double.Parse(s);
                        Console.WriteLine("Tangens = " + Math.Tan(temp));
                        Console.WriteLine(" ");
                        break;
                    }
                case "ctg":
                    {
                        Console.WriteLine("Введите число: ");
                        string s = Console.ReadLine();
                        double temp = double.Parse(s);
                        Console.WriteLine("Cotangens = " + (1/Math.Tan(temp)));
                        Console.WriteLine(" ");
                        break;
                    }
                case "0":
                    Console.WriteLine("Выход");
                    break;
                default:
                    Console.WriteLine("Неизвестная операция");
                    break; 
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

                Calculator(phrase);
            }
                }
            }
        }