using System;

class Program
{
    static void Main(string[] args)
    {
        int num, a = 0, b = 1, c = 0;
        bool pertence = false;

        Console.Write("Digite um número inteiro: ");
        num = int.Parse(Console.ReadLine());

        while (c < num)
        {
            c = a + b;
            a = b;
            b = c;
            if (c == num)
            {
                pertence = true;
            }
        }

        if (pertence)
        {
            Console.WriteLine("{0} pertence à sequência de Fibonacci.", num);
        }
        else
        {
            Console.WriteLine("{0} não pertence à sequência de Fibonacci.", num);
        }
    }
}