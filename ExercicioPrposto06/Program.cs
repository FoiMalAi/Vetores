namespace ExercicioPrposto06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] V = new int[N]; 

            string[] Name = new string[N];
            int[] Age = new int[N]; 

            for (int i = 0; i < N; i++)// Leitura de dados
            {
                string[] S = Console.ReadLine().Split(' ');
                Name[i] = S[0];
                Age[i] = int.Parse(S[1]);
            }
            //Calculo da pessoa mais velha
            
            int  MaisVelhoPosicao= 0;
            for (int i = 0; i < N; i++)
            {
                if (Age[i] > Age[MaisVelhoPosicao]) // comparando as posições
                {
                    MaisVelhoPosicao = i; // declarando a posição de Name em pessoa
                }
            }

            Console.WriteLine("Pessoa mais velha: " + Name[MaisVelhoPosicao]);
        }
    }
}
