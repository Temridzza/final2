using System;
namespace function
{
    class Function
    {
        public static void Menu()
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Введите 1 для решения уравнения y=kx");
            Console.WriteLine("Введите 2 для решения уравнения y=(k-n)x");
            Console.WriteLine("Введите 3 для решения уравнения y=kx^3+c");
            Console.WriteLine("Введите 4 для сравнеия чисел A и B");
            Console.WriteLine("Введите 5 для нахождения max, min");
            Console.WriteLine("Введите 6 для сравнения выражения (A+B)^2 И (A-B)^2");
            Console.WriteLine("Введите 7 для решения факториала n!");
            Console.WriteLine("------------------------------------------------------");
        }
        public static void Kx()
        {
            int Y, K, X;
            Console.WriteLine("Решение уравнения y=kx");
            Console.WriteLine("Введите k");
            K = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите х");
            X = Convert.ToInt32(Console.ReadLine());
            Y = K * X;
            Console.WriteLine($" Ответ: {Y}");
        }
        public static void D0_KN()
        {
            int Y, K, N, X;
            Console.WriteLine("Решение уравнения y=(k-n)x");
            Console.WriteLine("Введите k");
            K = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите n");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите х");
            X = Convert.ToInt32(Console.ReadLine());
            Y = (K - N) * X;
            Console.WriteLine($" Ответ: {Y}");
        }
        public static void D0_KX3()
        {
            int Y, K, C, X;
            Console.WriteLine("Решение уравнения y=kx^3+c");
            Console.WriteLine("Введите k");
            K = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите x");
            X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите c");
            C = Convert.ToInt32(Console.ReadLine());
            Y = (K * X * X * X) + C;
            Console.WriteLine($" Ответ: {Y}");
        }
        public static void D0_AB()
        {
            int A, B;
            Console.WriteLine("Сравнение чисел AB");
            Console.WriteLine("Введите A");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B");
            B = Convert.ToInt32(Console.ReadLine());
            if (A > B)
                Console.WriteLine("A больше B");
            else if (A < B)
                Console.WriteLine("A меньше B");
            else Console.WriteLine("A равно B");
        }
        public static void Do_maxmin()
        {
            int A, B;
            Console.WriteLine("Нахождение max, min");
            Console.WriteLine("Введите A");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B");
            B = Convert.ToInt32(Console.ReadLine());
            if (A > B)
            {
                Console.WriteLine("A максимальное");
                Console.WriteLine("B минимальное");
            }
            else if (A < B)
            { Console.WriteLine("B максимальное"); Console.WriteLine("A минимальное"); }
            else { Console.WriteLine("--------"); }
        }
        public static void D0_VAB()
        {
            int A, B, A1, B1;
            Console.WriteLine("Сравнение выражений (A+B)^2 и (A-B)^2");
            Console.WriteLine("Введите A");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B");
            B = Convert.ToInt32(Console.ReadLine());
            A1 = (A + B) * (A + B);
            B1 = (A - B) * (A - B);
            if (A1 > B1)
                Console.WriteLine("(A+B)^2 > (A-B)^2");
            else if (A1 < B1)
                Console.WriteLine("(A+B)^2 < (A-B)^2");
            else Console.WriteLine("(A+B)^2 = (A-B)^2");
        }
        public static void Do_factorial()
        {
            int p, y;
            Console.WriteLine("Решение факториала n!");
            Console.WriteLine("Введите n");
            p = Convert.ToInt32(Console.ReadLine());

            y = 1;
            for (int i = 1; i <= p; i++) y *= i;
            Console.WriteLine($"Факториал P! = {y}");
        }

    }
}
