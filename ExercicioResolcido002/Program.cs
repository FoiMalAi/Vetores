using System.Runtime.Serialization;

namespace ExercicioResolcido002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            double[] vet ;

            n = int.Parse(Console.ReadLine());
            vet = new double[n];

            string[] S = Console.ReadLine().Split(' ');

            for (int i = 0;  i < n; i++)
            {
                vet[i] = double.Parse(S[i]);
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(vet[i].ToString("F1") + " ");
            }
            Console.WriteLine();

            double soma = 0.0;
            
            for (int i = 0; i < n; i++)
            {
                soma += vet[i];
            }
            double media = soma / n;

            Console.WriteLine(soma.ToString("F2"));
            Console.WriteLine(media.ToString("F2"));
        }
    }
}
