namespace ExercicioReslvido09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] NomeP = new string[N];
            double[] Pcompra = new double[N];
            double[] Pvenda = new double[N];
            
            for (int i = 0; i < N; i++)
            {
                string[] S = Console.ReadLine().Split(' ');
                NomeP[i] = S[0];
                Pcompra[i] = double.Parse(S[1]);
                Pvenda[i] = double.Parse(S[2]);
            }

            // calculo das porcentagens do lucro
            double porcentagemLcro = 0.0;
            double lucro = 0.0;
            int somaL10 = 0;
            int somal20 = 0;
            int somal_20 = 0;

            for (int i = 0; i < N; i++)
            {
                lucro = Pvenda[i] - Pcompra[i];

                porcentagemLcro = (lucro / Pcompra[i]) * 100.0;

                if (porcentagemLcro < 10.0)
                {
                    somaL10++;
                }
                else if (porcentagemLcro >= 10.0 && porcentagemLcro<= 20.0)
                {
                     somal20++;
                }
                else
                {
                    somal_20++;
                }
            }

            Console.WriteLine("Lucro abaixo de 10%: " + somaL10);
            Console.WriteLine("Lucro entre 10% e 20%: " + somal20);
            Console.WriteLine("Lucro acima de 20%: " + somal_20);

            // Soma compra e soma venda

            double SomaCompra = 0.0;
            for (int i = 0; i < N; i++)
            {
                SomaCompra += Pcompra[i];
            }

            Console.WriteLine("SoValor total de compra: " + SomaCompra.ToString("F2"));

            double SomaVenda = 0.0;
            for (int i = 0; i < N; i++)
            {
                SomaVenda += Pvenda[i];
            }

            double lucroT = SomaVenda - SomaCompra; 

            Console.WriteLine("Valor total de venda: " + SomaVenda.ToString("F2"));
            Console.WriteLine("Lucro total: " +  lucroT.ToString("F2"));            
        }
    }
}
