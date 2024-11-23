using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace ExercicioProposto04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double[] V = new double[N];

            string[] S = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                V[i] = double.Parse(S[i]);
            }
            double soma = 0;
            for (int i = 0; i < N; i++)
            {
                soma += V[i] ;
            }
            double media = soma / N;

            Console.WriteLine(media);

            for (int i = 0; i < N; i++)
            {
                if (V[i] < media)
                {
                    Console.WriteLine(V[i]);
                }
            }
        }
    }
}
