namespace Torneio_de_tenis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                char[] resultados = RecebeResultados();
                char[] venceu = Array.FindAll(resultados, x => x == 'V');

                DefineGrupo(venceu);

                if (DeveContinuar()) break;
            }
        }
        static char[] RecebeResultados()
        {
            char[] resultados = new char[6];

            ValidaResultados(resultados);

            return resultados;
        }
        static void ValidaResultados(char[] resultados)
        {
            for (int i = 0; i < resultados.Length; i++)
            {
                do
                {
                    resultados[i] = Convert.ToChar(Console.ReadLine());
                    if (resultados[i] != 'V' && resultados[i] != 'P') Console.WriteLine("Inválido. Tente novamente");
                }
                while (resultados[i] != 'V' && resultados[i] != 'P');
            }
        }
        private static void DefineGrupo(char[] venceu)
        {
            if (venceu.Length >= 5) Console.WriteLine("\n1");
            else if (venceu.Length >= 3) Console.WriteLine("\n2");
            else if (venceu.Length >= 1) Console.WriteLine("\n1");
            else Console.WriteLine(-1);
        }
        static bool DeveContinuar()
        {
            Console.WriteLine("\nDeseja continuar? [S/N]");
            string continuar = Console.ReadLine();
            return continuar == "N" || continuar == "n";
        }
    }
}
