// See https://aka.ms/new-console-template for more information
using System;

public class TriangleDrawer
{
    public void DrawTriangle(int size)
    {
        for (int i = 1; i <= size; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Üçgenin boyutunu girin: ");
        int size = int.Parse(Console.ReadLine());

        TriangleDrawer triangleDrawer = new TriangleDrawer();
        triangleDrawer.DrawTriangle(size);
    }
}

