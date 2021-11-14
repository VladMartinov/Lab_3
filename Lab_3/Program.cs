using System;

namespace Lab2__1_6_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания (9 - это 1 индивидуальное,10 - это 2 индивидуальное (Вариант 6) )");
            int N = int.Parse(Console.ReadLine());
            switch (N)
            {
                case 1:
                    {

                        Console.WriteLine("Задание №1");
                        Console.WriteLine("Введите число элементов массива:");
                        int Num = int.Parse(Console.ReadLine());
                        Random rnd = new Random();
                        int l = Num - 3;
                        int j = 0;
                        int z = 1;
                        int[] randAr = new int[Num];
                        Console.WriteLine("\nМассив");
                        for (int i = 0; i <= Num; i++)
                        {
                            randAr[i] = rnd.Next(-30, 45);
                            Console.Write("{0} ", randAr[i]);
                            if (i % 10 == 9 && i != 1)
                            {
                                Console.WriteLine("\n");
                            }
                            z++;
                            if (z > Num)
                            {
                                Console.WriteLine("\nЗапись в обратном порядке");
                                for (int k = Num - 1; k >= 0; k--)
                                {
                                    if (randAr[k] >= 0)
                                    {
                                        Console.Write($"{randAr[k],-4}");
                                        j++;
                                        if (j % 10 == 0)
                                        {
                                            Console.WriteLine("\n");
                                        }
                                    }


                                }
                                break;
                            }

                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Задание №2");
                        int[,] A = new int[7, 7];
                        int B = 1;
                        for (int i = 0; i < 7; i++)
                        {
                            for (int j = 0; j < 7; j++)
                            {
                                A[i, j] = B;
                                B++;
                            }
                        }
                        Console.WriteLine("Обычный вид");
                        foreach (int Z in A)
                        {

                            if (Z % 7 == 0)
                            {
                                Console.WriteLine("{0}", $"{Z,4}");
                            }
                            else
                            {
                                Console.Write("{0}", $"{Z,4}");

                            }
                        }
                        for (int i = 0; i < 7; i++)
                        {
                            for (int j = 0; j < i; j++)
                            {

                                A[i, j] += A[j, i];
                                A[j, i] = A[i, j] - A[j, i];
                                A[i, j] -= A[j, i];
                            }
                        }
                        for (int i = 0; i < 7; i++)
                        {
                            for (int j = 0; j < 7 / 2; j++)
                            {

                                A[i, j] += A[i, 6 - j];
                                A[i, 6 - j] = A[i, j] - A[i, 6 - j];
                                A[i, j] -= A[i, 6 - j];
                            }
                        }

                        Console.WriteLine("\nПоворот на 90 градусов на право");

                        int x = 0;
                        foreach (int H in A)
                        {
                            if (x % 7 == 0)
                            {
                                Console.Write("\n");
                                Console.Write($"{H,4}");
                            }
                            else
                            {
                                Console.Write($"{H,4}");
                            }
                            x++;
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Задание №3");
                        Console.WriteLine("Длинна массива");
                        int D = int.Parse(Console.ReadLine());
                        int[] Ar = new int[D];
                        for (int i = 0; i < D; i++)
                        {
                            Ar[i] = i + 1;
                        }
                        Console.WriteLine("На сколько позиций k сдвинуть массив влево?");
                        int k = int.Parse(Console.ReadLine());
                        k %= D;
                        for (int i = 0; i < k; i++)
                        {
                            int El = Ar[0];
                            for (int j = 0; j < D - 1; j++)
                            {
                                Ar[j] = Ar[j + 1];
                            }
                            Ar[D - 1] = El;
                        }
                        foreach (int El1 in Ar)
                        {
                            Console.Write(El1 + " ");
                        }
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Задание №4");
                        static double[,] S1(double[,] Ar1, double[,] Ar2, out double Avg)    //Функция Суммы:
                        {
                            double[,] S1 = new double[3, 3];
                            Avg = 0;
                            for (int i = 0; i < 3; i++)
                            {
                                for (int j = 0; j < 3; j++)
                                {
                                    S1[i, j] = Ar1[i, j] + Ar2[i, j];
                                    Avg += S1[i, j];
                                }
                            }
                            Avg = Avg / 9;

                            return S1;
                        }
                        static double[,] S2(double[,] Ar1, double[,] Ar2, out double Avg)    //Функция Разности:
                        {
                            double[,] S2 = new double[3, 3];
                            Avg = 0;
                            for (int i = 0; i < 3; i++)
                            {
                                for (int j = 0; j < 3; j++)
                                {
                                    S2[i, j] = Ar1[i, j] - Ar2[i, j];
                                    Avg += Ar1[i, j] + Ar2[i, j];
                                }
                            }
                            Avg = Avg / 9;
                            return S2;
                        }
                        double[,] Ar1 = new double[3, 3];
                        double[,] Ar2 = new double[3, 3];
                        Console.WriteLine("Введите для первого массива:");
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                while (!double.TryParse(Console.ReadLine(), out Ar1[i, j])) ;
                            }
                        }
                        Console.WriteLine("Введите значения для второго массива:");
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                while (!double.TryParse(Console.ReadLine(), out Ar2[i, j])) ;
                            }
                        }
                        double Avg;
                        int x = 0;
                        Console.WriteLine("Сумма Массивов:");
                        foreach (double H in S1(Ar1, Ar1, out Avg))
                        {
                            if (x % 3 == 0)
                            {
                                Console.Write("\n");
                                Console.Write($"{H,4}");
                            }
                            else
                            {
                                Console.Write($"{H,4}");
                            }
                            x++;
                        }
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Задание №5");
                        double[,] Ar1 = new double[5, 5];
                        double[,] Ar2 = new double[5, 5];
                        double[,] r = new double[5, 5];
                        Console.WriteLine("Введите значения для первой матрицы");
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                while (!double.TryParse(Console.ReadLine(), out Ar1[i, j])) ;
                            }
                        }
                        Console.WriteLine("Введите значения для второй матрицы:");
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                while (!double.TryParse(Console.ReadLine(), out Ar2[i, j])) ;
                            }
                        }
                        double[,] S3(double[,] Ar1, double[,] Ar2)
                        {
                            double temp = 0;
                            for (int i = 0; i < 5; i++)
                            {
                                for (int j = 0; j < 5; j++)
                                {
                                    for (int k = 0; k < 5; k++)
                                    {
                                        temp += Ar1[i, k] * Ar2[k, j];
                                    }
                                    r[i, j] = temp;
                                    temp = 0;
                                }
                            }
                            return r;
                        }
                        int x = 0;
                        foreach (double H in S3(Ar1, Ar2))
                        {
                            if (x % 5 == 0)
                            {
                                Console.Write("\n");
                                Console.Write($"{H,6}");
                            }
                            else
                            {
                                Console.Write($"{H,6}");
                            }
                            x++;
                        }
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Задание №6");
                        Console.WriteLine("Введите число элементов массива");
                        int n = Convert.ToInt16(Console.ReadLine());
                        double[] array = new double[n];
                        int i = 0;
                        Console.WriteLine("Введите элемент(ы) массива");
                        while (i < n)
                        {
                            array[i] = double.Parse(Console.ReadLine());
                            Console.WriteLine();
                            i++;
                        }
                        static double sumIterative(double[] array)
                        {
                            double sum = 0;
                            for (int i = 0; i < array.Length; i++)
                            {
                                sum += array[i];
                            }
                            return sum;
                        }
                        Console.WriteLine($"Сумма элементво(Итерационно):  { sumIterative(array)}");
                        static double sumRecursive(double[] array, int i = 0)
                        {
                            if (i >= array.Length)
                            {
                                return 0;
                            }
                            else
                            {
                                return array[i] + sumRecursive(array, i + 1);
                            }
                        }
                        Console.WriteLine($"Сумма элементво(Рекурсивно): {sumRecursive(array)}");
                        static double minIterative(double[] array)
                        {
                            double minValue = array[0];

                            for (int i = 1; i < array.Length; i++)
                            {
                                if (array[i] < minValue)
                                {
                                    minValue = array[i];
                                }
                            }
                            return minValue;
                        }
                        Console.WriteLine($"Минимальный элемент в массиве(Итерационно): {minIterative(array)}");
                        static double minRecursive(double[] array, int i = 0)
                        {

                            if (i + 1 == array.Length)
                            {
                                return array[i];
                            }
                            else
                            {
                                return Math.Min(array[i], minRecursive(array, ++i));
                            }
                        }
                        Console.WriteLine($"Минимальный элемент в массиве(Рекурсивно): {minRecursive(array)}");
                        break;
                    }
                case 7:
                    {
                        static long RecFib(long n)
                        {
                            if ((n == 1) || (n == 2))
                            {
                                return 1;
                            }
                            else
                            {
                                return RecFib(n - 1) + RecFib(n - 2);
                            }
                        }
                        Console.WriteLine("Введите количество чисел ряда фибоначи");
                        int k = int.Parse(Console.ReadLine());
                        int x = 1;
                        while (x < k)
                        {
                            Console.WriteLine(RecFib(x));
                            x++;
                        }
                        break;
                    }
                case 8:
                    {
                        static double DetMatrix(double[,] M) // M- Матрица
                        {
                            if (M.Length == 1)
                            {
                                return M[0, 0];
                            }
                            if (M.Length == 4)
                            {
                                return M[0, 0] * M[1, 1] - M[1, 0] * M[0, 1];
                            }
                            else
                            {
                                double result = 0;

                                for (int i = 0; i < M.GetLength(0); i++)
                                {
                                    double[,] M1 = Min(M, i); // М1- Минор
                                    result += Math.Pow(-1, i) * M[0, i] * DetMatrix(M1);
                                }
                                return result;
                            }

                        }
                        static double[,] Min(double[,] M, int n)
                        {
                            double[,] Res = new double[M.GetLength(0) - 1, M.GetLength(0) - 1]; //Res- результат
                            for (int i = 1; i < M.GetLength(0); i++)
                            {
                                for (int j = 0, column = 0; j < M.GetLength(1); j++)
                                {
                                    if (j == n)
                                        continue;
                                    Res[i - 1, column] = M[i, j];
                                    column++;
                                }
                            }
                            return Res;
                        }
                        Console.WriteLine("Введите длину матрицы N (массив N*N):");
                        N = int.Parse(Console.ReadLine());
                        double[,] M = new double[N, N];
                        Console.WriteLine("Матрица будет заполнена вручную ?(да или нет)");
                        string answer = Console.ReadLine();
                        if (answer == "да")
                        {
                            Console.WriteLine("Введите значения для матрицы:");
                            for (int i = 0; i < N; i++)
                            {
                                for (int j = 0; j < N; j++)
                                {
                                    while (!double.TryParse(Console.ReadLine(), out M[i, j]))
                                        Console.WriteLine("Ошибка ввода числа. Попробуйте еще раз:");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Укажите диапазон рандомных чисел от J до K");
                            Console.WriteLine("J:");
                            int J = int.Parse(Console.ReadLine());
                            Console.WriteLine("M:");
                            int K = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Матрица заполнена случайными числами");
                            Random r = new Random();
                            for (int i = 0; i < N; i++)
                            {
                                for (int j = 0; j < N; j++)
                                {
                                    M[i, j] = r.Next(J, K);
                                    Console.Write($"{M[i, j],4}");
                                }
                                Console.Write('\n');
                            }
                        }
                        Console.WriteLine($"Определитель матрицы : {DetMatrix(M)}");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("Задание №1 (Индивидуальное (Вариант 6))");
                        int[,] mas = new int[9, 9];
                        int B = 1;
                        int i, j;
                        for ( i = 0; i < 9; i++)
                        {
                            for ( j = 0; j < 9; j++)
                            {
                                mas[i, j] = B;
                                B++;
                            }
                        }
                        Console.WriteLine("Обычный вид");
                        foreach (int Z in mas)
                        {

                            if (Z % 9 == 0)
                            {
                                Console.WriteLine("{0}", $"{Z,4}");
                            }
                            else
                            {
                                Console.Write("{0}", $"{Z,4}");

                            }
                        }                                  
                        int t = 1;
                        for (i = 0; i < 9; i++)
                        {
                            for (j = 0; j <= i; j++)
                            {
                                mas[i - j, j] = t++;
                            }
                        }
                        for (j = 1; j < 9; j++)
                        {
                            for (i = 8; i >= j; i--)
                            {
                                mas[i, j + 8 - i] = t++;
                            }
                        }
                        Console.WriteLine("После Линейнейной последовательности");                       
                            for (i = 0; i < 9; i++)
                            {
                                for (j = 0; j < 9; j++)
                                {
                                    Console.Write($"{mas[i, j],4}");
                                }
                                Console.Write("\n");
                            }                                      
                        break;
                    }
                case 10:
                    {
                        Console.WriteLine("Укажите длинну массива");
                        int Len = int.Parse(Console.ReadLine());
                        int[] M = new int[Len];
                        Console.WriteLine("Хотите ввести вручную, рандомно ,или последовательно?(1-вручную,2-рандомно,3-последовательно");
                        int D = int.Parse(Console.ReadLine());
                        if (D == 3)
                        {                          
                            for (int i = 1; i < Len; i++)
                            {
                                M[i] = i + 1;
                                Console.Write("{0} ", M[i]);
                            }
                        }
                        if (D == 2)
                        {                            
                            Console.WriteLine("Укажите диапазон рандомных чисел от J до K");
                            Console.WriteLine("J:");
                            int J = int.Parse(Console.ReadLine());
                            Console.WriteLine("K:");
                            int K = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Массив заполнена случайными числами");
                            Random r = new Random();
                            for (int i = 1; i < Len; i++)
                            {
                                M[i] = r.Next(J, K);
                                Console.Write($"{M[i],4}");

                            }
                        }
                        if (D==1)
                        {
                            Console.WriteLine("Введите значения для матрицы:");
                            for (int i = 0; i <= Len-1; i++)
                            {
                                int C = int.Parse(Console.ReadLine());
                                M[i] = C;
                            }
                        }
                        double d = M[2] - M[1];
                        int a = 0;
                        int res;
                        for (int i = 1; i < Len ; i++)
                        {
                            res = (M[i] - M[0]) / i;
                            if (M[i] - M[i-1] == d)
                            {
                                res = (M[i] - M[0]) / i;
                                a++;
                            }
                            if (i < Len - 1 && a!=0)
                            {
                                Console.WriteLine($"Шаг равен : {res}");
                            }
                            if (i < Len - 1 && a == 0)
                            {
                                Console.WriteLine("FALSE");
                            }
                        }                        
                        break;
                    }
            }
        }
    }
}