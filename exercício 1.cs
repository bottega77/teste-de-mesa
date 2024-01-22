using System;

class Program
{
    static void Main()
    {
        int a = 10, b = 20, c = (a + b) / 2, cont;
        int[] v = new int[3];
        c = c - 40;
        v[2] = a + b + c;

        Console.WriteLine($"A: {a}\nB: {b}\nC: {c}\nV: {v[2]}");
    }
}