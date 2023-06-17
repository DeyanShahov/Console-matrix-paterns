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
                Console.Clear();//clear console
                Console.WriteLine();//add new line for bether reading
                action.ExecuteAction(numberPattern);//run pattern
                Console.WriteLine();//add new line for bether reading

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
                case 8:
                    count++;
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
                case 9:
                    for (int i = 1; i <= num; i++)
                    {
                        for (int j = 1; j <= num; j++)
                        {
                            int result = i * j;
                            Console.Write(result < 10 ? $" {result} " : $"{result} ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 10:
                    for (int i = 1; i <= num; i++)
                    {
                        for (int j = 1; j <= 3; j++)
                        {
                            Console.Write($" {j} {i}");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 11:
                    for (int i = 1; i <= num; i++)
                    {
                        for (int j = 1; j <= 3; j++)
                        {
                            Console.Write($" {i} {j}");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 12:
                    for (int i = 1; i <= num; i++)
                    {
                        int sum = i;

                        for (int j = 1; j <= num; j++)
                        {
                            Console.Write(sum < 10 ? $" {sum} " : $"{sum} ");
                            sum += num;
                        }
                        Console.WriteLine();
                    }
                    break;
                case 13:
                    Console.Write("Not implemented yet");
                    break; //ToDo ...
                case 14:
                    for (int i = 0; i < num; i++)
                    {
                        for (int j = 0; j < num; j++)
                            Print((num - i) + num * j);
                     
                        Console.WriteLine();
                    }
                    break;
                case 15:
                    for (int i = 0; i < num; i++)
                    {
                        for (int j = 0; j < num; j++)
                        {
                            int x = (num - i) + num * j;
                            int y = num * j + i + 1;
                            Print(j % 2 == 0 ? x : y);
                        }
                        Console.WriteLine();
                    }
                    break;
                case 16:
                    for (int i = 0; i < num; i++)
                    {
                        for (int j = 1; j <= num; j++)
                        {
                            int result = i + j;

                            Print(result);
                        }
                        Console.WriteLine();
                    }
                    break;
                default:
                    Console.WriteLine("Невалиден номер на действие");
                    break;
            }
        }

        private static void Print(int x)
        {
            Console.Write(x < 10 ? $" {x} " : $"{x} ");
        }
    }
}