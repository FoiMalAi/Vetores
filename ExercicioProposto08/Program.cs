namespace ExercicioProposto08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[] Altura = new double[N];
            char[] Sexo = new char[N];

            for (int i = 0; i < N; i++)
            {
                string[] S = Console.ReadLine().Split(' ');
                Altura[i] = double.Parse(S[0]);
                Sexo[i] = char.Parse(S[1]);
            }

            double Menor = Altura[0];
            double Maior = 0;

            for (int i = 0; i < N; i++)
            {
                if (Altura[i] > Maior)
                {
                    Maior = Altura[i];
                }
            }

            for (int i = 0; i < Altura.Length; i++) // percorre o vetor para encontrar o menos numero.
            {
                if (Altura [i] < Menor)
                {
                    Menor = Altura[i];
                }  
            }

            int SomaF = 0;
            int SomaM = 0;
            double MediaF= 0;
            double SomaAF = 0;

            
            for (int i = 0; i < N; i++)
            {
                if (Sexo[i] == 'F')
                {
                    SomaF++;
                    SomaAF += Altura[i];                    
                }
                else
                {
                    SomaM++;
                }                
            }

            if (SomaF == 0)
            {
                Console.WriteLine("Não existem mulheres informadas");
            }
            else
            {
                MediaF = SomaAF / SomaF;
            }

            Console.WriteLine("Menor alura = " + Menor.ToString("F2"));
            Console.WriteLine("Maior altra = " + Maior.ToString("F2"));
            Console.WriteLine("Media das alturas das mulheres = " + MediaF.ToString("F2"));
            Console.WriteLine("Numero de homens = " + SomaM);
        }
    }
}
