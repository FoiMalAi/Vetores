using System.Runtime.Serialization;

namespace ExercicioProposto03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] vetA = new int[N];
            int[] vetB = new int[N];
            int[] soma = new int[N];

            string[] A = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vetA[i] = int.Parse(A[i]);
            }

            string[] B = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                vetB[i] = int.Parse(B[i]);
            }

            for (int i = 0; i < N; i++)
            {
                soma[i] = vetA[i] + vetB[i];
            }

            for (int i = 0; i < N; i++)
            {
                Console.Write(soma[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
