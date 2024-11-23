namespace ExercicioResolvido01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[] Vet;

            N = int.Parse(Console.ReadLine());
            Vet = new int[N];

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                Vet[i] = int.Parse(s[i]); 
            }

            for (int i = 0; i < N; i++)
            {
                if (Vet[i] < 0)
                {
                    Console.WriteLine(Vet[i]);
                }
            }

        }
    }
}
