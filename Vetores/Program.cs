namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] vet;

            N = int.Parse(Console.ReadLine());
            vet = new double[N]; // A attribuição do vetor deve ser feita após a leitura da variavel.
            
            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(vet[i].ToString("F1"));
            }

            Console.ReadLine();

        }
    }
}
