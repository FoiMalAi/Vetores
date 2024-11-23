using System.Net.Http.Headers;

namespace ExercicioProposto05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] V = new int[N];

            string[] S = Console.ReadLine().Split(' ');

            int somaPares = 0;

            for (int i = 0; i < N; i++)
            {
                V[i] = int.Parse(S[i]);
            }

            int soma = 0;
            double media = 0;

            for (int i = 0; i < N; i++)
            {
                if (V[i] % 2 == 0)
                {
                    soma += V[i];
                    somaPares++;
                }
            }

            media = soma / somaPares;

            Console.WriteLine(media.ToString("F1"));
        }
    }
}
