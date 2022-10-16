Console.WriteLine("Выберете задачу 64/ 66 / 68");
int task = int.Parse(Console.ReadLine());

switch (task)
{
    case 64:
        Task64();
        break;
    case 66:
        Task66();
        break;
    case 68:
        Task68();
        break;
    default:
        Console.WriteLine("Это нам не задавали! Это мы не проходили");
        break;

}
void Task64()
{
    Console.Write("Задача 64: Задайте значения N и M. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.");

    Console.Clear();
    Console.Write("Введите число M: ");
    int M = int.Parse(Console.ReadLine());
    Console.Write("Введите число N: ");
    int N = int.Parse(Console.ReadLine());

    if (M > N) between_M_and_N(N, M);
    else between_M_and_N(M, N);
    void between_M_and_N(int M, int N)
    {
        if (M == N)
        {
            Console.Write(M);
        }
        else
        {
            Console.Write(M);
            between_M_and_N(M + 1, N);
        }
    }

}
void Task66()
{
    Console.Write("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.");

    Console.Clear();
    Console.Write("Введите число M: ");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число N: ");
    int N = Convert.ToInt32(Console.ReadLine());

    SumMN(M, N);


    void SumMN(int M, int N)
    {
        {
            Console.Write(SumMN(M - 1, N));
        }

        int SumMN(int M, int N)
        {
            int resalt = M;
            if (M == N)
                return 0;
            else
            {
                M++;
                resalt = M + SumMN(M, N);
                return resalt;
            }
        }
    }
}
void Task68()
    {
        Console.Write("Задача 68: Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.");

        Console.Clear();
        Console.Write("Введите число M: ");
        int M = int.Parse(Console.ReadLine());
        Console.Write("Введите число N: ");
        int N = int.Parse(Console.ReadLine());

        AkkermanFunction(M, N);

        void AkkermanFunction(int M, int N)
        {
            Console.Write(Akkerman(M, N));
        }

        int Akkerman(int M, int N)
        {
            if (M == 0)
            {
                return N + 1;
            }
            else if (N == 0 && M > 0)
            {
                return Akkerman(M - 1, 1);
            }
            else
            {
                return (Akkerman(M - 1, Akkerman(M, N - 1)));
            }
        }

    }