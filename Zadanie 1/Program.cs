
using System;

class Program
{
    static void Main()
    {
        int[,] tablica = new int[10, 10];

        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                // Wiersze parzyste - wypełnianie rosnąco
                for (int j = 0; j < 10; j++)
                {
                    tablica[i, j] = i * 10 + j + 1;
                }
            }
            else
            {
                // Wiersze nieparzyste - wypełnianie malejąco
                for (int j = 9; j >= 0; j--)
                {
                    tablica[i, j] = i * 10 + (9 - j) + 1;
                }
            }
        }

        // Wyświetlanie tablicy
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(tablica[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
