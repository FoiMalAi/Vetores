namespace ExercicioProposto02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int N = int.Parse(Console.ReadLine());
            int [] vet = new int[N];

            string[] S = Console.ReadLine().Split(' ');
            // Coleta de dados
            for (int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(S[i]);
            }
            // calculo de n pares e soma dos numeros
            int par;
            int soma = 0;
            for (int i = 0; i < N; ++i)
            {
                
                if (vet[i] % 2 == 0)
                {
                    par = vet[i];
                    soma++;

                    Console.Write(par + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}
