﻿namespace SintaxeForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());

            string[] vet = new string[N];

            for (int i = 0; i < N; i++)
            {
                vet[i] = Console.ReadLine();
            }

            foreach (string x in vet) 
            {
                Console.WriteLine(x);
            }
        }
    }
}
