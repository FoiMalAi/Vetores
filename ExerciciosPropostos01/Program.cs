using System.Transactions;

namespace ExerciciosPropostos01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double[] vet = new double[N];

            string[] S = Console.ReadLine().Split(' ');
            // Coleta de dados
            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(S[i]);
            }
            // calculo do maior
            double maior = 0;
            int posicao = 0;
            for (int i = 0; i < N; ++i)
            {
                if (vet[i] > maior)
                {
                    maior = vet[i];
                    posicao = i; // i é a posição do vetor
                }           
            }
            

            Console.WriteLine(maior.ToString("F1"));
            Console.WriteLine(posicao);
        }
    }
}
