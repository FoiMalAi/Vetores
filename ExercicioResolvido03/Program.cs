namespace ExercicioResolvido03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N; // Quantidade
            double[] vet;

            N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            int[] idades = new int[N];
            double[] alturas = new double[N];    
            
            // Leitura dos dados
            for (int i = 0; i < N; i++)
            {
                string[] S = Console.ReadLine().Split(" "); // Vetor Base
                nomes[i] = S[0];
                idades[i] = int.Parse(S[1]);
                alturas[i] = double.Parse(S[2]);
            }
            // Calculo da atura media das pessaos
            double soma = 0;
            for (int i = 0; i < N; i++)
            {
                soma += alturas[i];
            }
            double media = soma / N;

            Console.WriteLine("Altura Média: " + media.ToString("F2"));


            // Calculo de pessoa com menos de 16 anos

            int cont = 0;
            for (int i = 0; i < N; i++)
            {
                if (idades[i] < 16)
                {
                    cont++;
                }
            }
            double porcentagem = (double)cont / N * 100;
            Console.WriteLine("Pessoas com menos de 16 anos: " 
                + porcentagem.ToString("F1") + "%");

            Console.ReadLine();

        }
    }
}
