using System.Globalization;
namespace Logica_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            DadosConta conta;

            Console.Write("Informe o número da conta: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Nome do titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char DInicial = char.Parse(Console.ReadLine());

            if (DInicial == 's')
            {
                Console.Write("Valor do depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new DadosConta(num, nome, saldo);
            }
            else
            {
                conta = new DadosConta(num, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Informe um valor para depósito: ");
            conta.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine($"Dados atualizados da conta: \n" +
                $"{conta}");

            Console.WriteLine();
            Console.Write("Informe um valor para saque: ");
            conta.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine($"Dados atualizados da conta: \n" +
                $"{conta}");
        }
    }
}