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
        public void ExecuteAction(int number)
        {
            int num = 5;

            switch (number)
            {
                case 1:
                    string paternName = "Patern 1";
                    int numPattern = 1;               

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
                    string paternName2 = "Patern 2";
                    int numPattern2 = 2;

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
                    string paternName3 = "Patern 3";
                    int numPattern3 = 3;

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
                    string paternName4 = "Patern 4";
                    int numPattern4 = 4;

                    for (int i = num; i > 0; i--)
                    {
                        for (int j = num; j > 0; j--)
                        {
                            Console.Write($"{i} ");
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