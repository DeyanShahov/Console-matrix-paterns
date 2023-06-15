using System;
using System.Threading.Channels;

namespace Console_matrix_paterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ActionExecutor action = new ActionExecutor();

            while (true)
            {
                Console.Write("Изберете номер на шаблон: ");
                int numberPattern = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine();
                action.ExecuteAction(numberPattern);
                Console.WriteLine();

            }

        }
    }

    internal class ActionExecutor
    {
        public void ExecuteAction(int numberPattern)
        {
            int num = 5;
            int count = 1;

            switch (numberPattern)
            {
                case 1:
                    for (int i = 0; i < num; i++)
                    {
                        for (int j = 0; j < num; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    for (int i = 0; i < num; i++)
                    {
                        for (int j = 0; j < num; j++)
                        {
                            Console.Write($"{i + 1} ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    for (int i = 0; i < num; i++)
                    {
                        for (int j = 0; j < num; j++)
                        {
                            Console.Write($"{j + 1} ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 4:
                    for (int i = num; i > 0; i--)
                    {
                        for (int j = num; j > 0; j--)
                        {
                            Console.Write($"{i} ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 5:
                    for (int i = 0; i < num; i++)
                    {
                        for (int j = num; j > 0; j--)
                        {
                            Console.Write($"{j} ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 6:
                    for (int i = 1; i <= num; i++)
                    {
                        for (int j = 1; j <= num; j++)
                        {
                            Console.Write(count < 10 ? $" {count++} " : $"{count++} ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 7:
                    for (int i = 0; i < num; i++)
                    {
                        for (int j = 0; j < num; j++)
                        {
                            Console.Write(count < 10 ? $" {count} " : $"{count} ");
                            count += 2;
                        }
                        Console.WriteLine();
                    }
                    break;
                default:
                    Console.WriteLine("Невалиден номер на действие");
                    break;
            }
        }
    }
}