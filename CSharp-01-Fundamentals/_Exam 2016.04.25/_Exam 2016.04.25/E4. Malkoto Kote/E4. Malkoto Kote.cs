using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char symb = char.Parse(Console.ReadLine());

        int spaceCounter = 0;

        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string(' ', i));

            Console.Write(new string(symb, n - i));

            if (i == n / 2 - 1)
            {
                Console.Write(new string(' ', n / 2 - 1));
                Console.Write(symb);
                Console.Write(' ');
                Console.Write(symb);
                Console.Write(new string(' ', n / 2 - 1));
            }
            else
            {
                Console.Write(new string(' ', n));
            }

            Console.Write(new string(symb, n - i));
            //Console.Write(new string(' ', i));

            spaceCounter++;
            Console.WriteLine();
        }


        //mid
        for (int i = 1; i <= n / 3; i++)
        {
            Console.Write(new string(' ', spaceCounter));
            Console.Write(new string(symb, 2 * n + 1));
            //Console.Write(new string(' ', spaceCounter));

            Console.WriteLine();
        }

        //bot 

        int decreaser = 0;

        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string(' ', n + 1 + i));
            Console.Write(new string(symb, n - 2 - decreaser));
            //Console.Write(new string(' ', n + 1 + i));

            decreaser += 2;
            Console.WriteLine();
        }
    }
}