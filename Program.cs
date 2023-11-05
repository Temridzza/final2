using System;
using function;

namespace artem
{
    class Program
    {
        public static void Main()
        {
            int Q;
            string Ress;
            string Name;
            Console.WriteLine("Введите ваше имя");
            Name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Добро пожаловать {Name}");
            do
            {
                Function.Menu();
                Q = Convert.ToInt32(Console.ReadLine());
                switch (Q)
                {
                    case 0:
                        Console.Clear();
                        break;

                    case 1:
                        Console.Clear();
                        Function.Kx();
                        break;
                    case 2:
                        Console.Clear();
                        Function.D0_KN();
                        break;
                    case 3:
                        Console.Clear();
                        Function.D0_KX3();
                        break;
                    case 4:
                        Console.Clear();
                        Function.D0_AB();
                        break;
                    case 5:
                        Console.Clear();
                        Function.Do_maxmin();
                        break;
                    case 6:
                        Console.Clear();
                        Function.D0_VAB();
                        break;
                    case 7:
                        Console.Clear();
                        Function.Do_factorial();
                        break;


                }
                Console.WriteLine("\n Вы хотите продолжить Да/Нет[Y/N]:");
                Ress = Console.ReadLine();
                Console.Clear();

            } while (Ress is "Y" or "y"); 
        }
    }
}
