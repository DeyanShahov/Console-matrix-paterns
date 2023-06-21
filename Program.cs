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
                            PrintInt(i + 1);
                        }
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    for (int i = 0; i < num; i++)
                    {
                        for (int j = 0; j < num; j++)
                            PrintInt(j + 1);
                        Console.WriteLine();
                    }
                    break;
                case 4:
                    for (int i = num; i > 0; i--)
                    {
                        for (int j = num; j > 0; j--)
                            PrintInt(i);
                        Console.WriteLine();
                    }
                    break;
                case 5:
                    for (int i = 0; i < num; i++)
                    {
                        for (int j = num; j > 0; j--)
                            PrintInt(j);
                        Console.WriteLine();
                    }
                    break;
                case 6:
                    for (int i = 1; i <= num; i++)
                    {
                        for (int j = 1; j <= num; j++)
                        {
                            PrintInt(count++);
                        }
                        Console.WriteLine();
                    }
                    break;
                case 7:
                    for (int i = 0; i < num; i++)
                    {
                        for (int j = 0; j < num; j++)
                        {
                            PrintInt(count);
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
                            PrintInt(count);
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
                            PrintInt(i * j);
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
                            PrintInt(sum);
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
                            PrintInt((num - i) + num * j);

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
                            PrintInt(j % 2 == 0 ? x : y);
                        }
                        Console.WriteLine();
                    }
                    break;
                case 16:
                    for (int i = 0; i < num; i++)
                    {
                        for (int j = 1; j <= num; j++)
                        {
                            PrintInt(i + j);
                        }
                        Console.WriteLine();
                    }
                    break;
                case 17:
                    for (int i = 1; i <= num; i++)
                    {
                        int sum = i - 1;
                        for (int j = 0; j < num; j++)
                        {
                            PrintInt(i + sum);
                            sum += 2;
                        }
                        Console.WriteLine();
                    }
                    break;
                case 18:
                    for (int x = 0; x < num; x++)
                    {
                        for (int z = 0; z < num; z++) PrintInt((x + z) % 2);
                        Console.WriteLine();
                    }
                    break;
                case 19:
                    for (int i = 0; i < num; i++)
                    {
                        for (int j = 0; j < num; j++)
                        {
                            PrintInt((i + j) % 2 != 0 ? 0 : 1);
                        }
                        Console.WriteLine();
                    }
                    break;
                case 20:
                    for (int i = 0; i < num; i++)
                    {
                        for (int j = 0; j < num; j++)
                        {
                            PrintInt(i % 2 == 0 ? j % 2 == 0 ? 1 : 0 : 0);
                        }
                        Console.WriteLine();
                    }
                    break;
                case 21:
                    for (int i = 0; i < num; i++)
                    {
                        for (int j = 0; j < num; j++)
                        {
                            PrintInt(i % 2 == 0 ? j % 2 == 0 ? 0 : 1 : 0);
                        }
                        Console.WriteLine();
                    }
                    break;
                case 22:
                    for (int i = 0; i < num; i++)
                    {
                        for (int j = 0; j < num; j++)
                        {
                            PrintInt(i % 2 == 0 ? 0 : 1);
                        }
                        Console.WriteLine();
                    }
                    break;
                case 23:
                    for (int i = 0; i < num; i++)
                    {
                        for (int j = 0; j < num; j++)
                        {
                            PrintInt(i % 2 == 0 ? 1 : 0);
                        }
                        Console.WriteLine();
                    }
                    break;
                case 24:
                    for (int i = 0; i < num; i++)
                    {
                        for (int j = 0; j < num; j++)
                        {
                            PrintInt(j % 2 == 0 ? 0 : 1);
                        }
                        Console.WriteLine();
                    }
                    break;
                case 25:
                    for (int i = 0; i < num; i++)
                    {
                        for (int j = 0; j < num; j++)
                        {
                            PrintInt(j % 2 == 0 ? 1 : 0);
                        }
                        Console.WriteLine();
                    }
                    break;
                case 26:
                    for (char i = 'A'; i <= 'E'; i++)
                    {
                        for (int j = 0; j < num; j++)
                        {
                            PrintChar(i);
                        }
                        Console.WriteLine();
                    }
                    break;
                case 27:
                    for (int i = 0; i < num; i++)
                    {
                        for (char j = 'A'; j <= 'E'; j++)
                        {
                            PrintChar(j);
                        }
                        Console.WriteLine();
                    }
                    break;
                case 28:
                    for (char i = 'E'; i >= 'A'; i--)
                    {
                        for (int j = 0; j < num; j++)
                        {
                            PrintChar(i);
                        }
                        Console.WriteLine();
                    }
                    break;
                case 29:
                    for (int i = 0; i < num; i++)
                    {
                        for (char j = 'E'; j >= 'A'; j--)
                        {
                            PrintChar(j);
                        }
                        Console.WriteLine();
                    }
                    break;
                case 30:
                    for (int i = 0; i < num; i++)
                    {
                        for (int j = 0; j < num; j++)
                        {
                            PrintChar((char)(64 + count++));
                        }
                        Console.WriteLine();
                    }
                    break;
                case 31:
                    for (int i = 0; i < num; i++)
                    {
                        for (int j = 0; j < num; j++)
                        {
                            PrintChar((char)(65 + i + j));
                        }
                        Console.WriteLine();
                    }
                    break;
                case 32:
                    for (int i = 0; i < num; i++)
                    {
                        for (int j = 0; j < num; j++)
                        {
                            PrintChar((char)(65 + i + (j * num)));
                        }
                        Console.WriteLine();
                    }
                    break;
                case 33:
                    Console.Write("Not implemented yet");
                    break; //ToDo ...
                case 34:
                    for (int i = 0; i < num; i++)
                    {
                        for (int j = 0; j < num; j++)
                        {
                            PrintChar(i >= j ? '*' : ' ');
                        }
                        Console.WriteLine();
                    }
                    break;
                case 35:
                    for (int i = 0; i < num; i++)
                    {
                        for (int j = 0; j < num; j++)
                        {
                            if (i >= j) PrintInt(i + 1);
                        }
                        Console.WriteLine();
                    }
                    break;
                case 36:
                    for (int i = 0; i < num; i++)
                    {
                        for (int j = 0; j < num; j++)
                        {
                            if(i >= j) PrintInt(j + 1);
                        }
                        Console.WriteLine();
                    }
                    break;
                case 37:
                    for (int i = 0; i < num; i++)
                    {
                        for (int j = 0; j < num; j++)
                        {
                            if( i >= j ) PrintInt(num - i);
                        }
                        Console.WriteLine();
                    }
                    break;
                case 38:
                    for (int i = 0; i < num; i++)
                    {
                        for (int j = 0; j < 0; j++)
                        {
                            Console.Write(num - j);
                            if (i >= j) PrintInt(num - j);
                        }
                        Console.WriteLine();
                    }
                    break;
                default:
                    Console.WriteLine("Невалиден номер на действие");
                    break;
            }
        }

        private static void PrintInt(int x)
        {
            Console.Write(x < 10 ? $" {x} " : $"{x} ");
        }

        private static void PrintChar(char ch)
        {
            Console.Write("{0} ", ch);
        }
    }
}