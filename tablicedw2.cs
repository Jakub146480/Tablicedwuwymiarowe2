using System;

class tablicedw2
{
    static void Main(string[] args)
    {
        int[,] tablica = new int[10, 10];
        int counter = 1;
        int startRow = 0;
        int endRow = 9;
        int startCol = 0;
        int endCol = 9;

        while (startRow <= endRow && startCol <= endCol)
        {
            // Wypełnianie górnej krawędzi
            for (int i = startCol; i <= endCol; i++)
            {
                tablica[startRow, i] = counter;
                counter++;
            }
            startRow++;

            // Wypełnianie prawej krawędzi
            for (int i = startRow; i <= endRow; i++)
            {
                tablica[i, endCol] = counter;
                counter++;
            }
            endCol--;

            // Wypełnianie dolnej krawędzi
            for (int i = endCol; i >= startCol; i--)
            {
                tablica[endRow, i] = counter;
                counter++;
            }
            endRow--;

            // Wypełnianie lewej krawędzi
            for (int i = endRow; i >= startRow; i--)
            {
                tablica[i, startCol] = counter;
                counter++;
            }
            startCol++;
        }

        // Wyświetlanie tablicy
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(tablica[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}