namespace ExercicioProposto07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            
            string[] Name = new string[N];
            double[] Nota1 = new double[N];
            double[] Nota2 = new double[N];

            for (int i = 0; i < N; i++)
            {
                string[] S = Console.ReadLine().Split(' ');
                Name[i] = S[0];
                Nota1[i] = double.Parse(S[1]);
                Nota2[i] = double.Parse(S[2]);
            }
           
            Console.WriteLine("Alunos aprovados: ");

            for (int i = 0; i < N; i++)
            {
                if ((Nota1[i] + Nota2[i]) / 2.0 >= 6.0)
                {
                    Console.WriteLine(Name[i]);
                }
            }
        }
    }
}
