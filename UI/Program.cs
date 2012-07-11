using System;
using System.Linq;
using Dominio.Bancario;

namespace UI
{
    class Program
    {
        private static Banco _banco = new Banco();

        static void Main(string[] args)
        {
            RegistrarContas();

            while (true)
            {
                MontaMenu();

                int operacao;
                int.TryParse(Console.ReadLine(), out operacao);

                var conta = SelecionaCliente();

                string mensagem;
                double valor;
                switch (operacao)
                {
                    case 1:
                        Console.Write("Digite o valor a ser debitado da conta: ");
                        double.TryParse(Console.ReadLine(), out valor);
                        conta.Debito(valor, out mensagem);
                        Console.WriteLine(mensagem);
                        Console.WriteLine(conta.Extrato());
                        break;
                    case 2:
                        Console.Write("Digite o valor a ser creditado na conta: ");
                        double.TryParse(Console.ReadLine(), out valor);
                        conta.Credito(valor, out mensagem);
                        Console.WriteLine(mensagem);
                        Console.WriteLine(conta.Extrato());
                        break;
                    case 3:
                        Console.WriteLine(conta.Extrato());
                        break;
                }
                Console.ReadKey();
            }
        }

        private static void MontaMenu()
        {
            Console.Clear();
            Console.WriteLine(string.Format("---::{0}::---", _banco.Nome));
            Console.WriteLine();
            Console.WriteLine("----------::Menu::----------");
            Console.WriteLine("1. Debito");
            Console.WriteLine("2. Crédito");
            Console.WriteLine("3. Extrato de Cliente");
            Console.Write("Escolha uma operação: ");
        }

        private static IConta SelecionaCliente()
        {
            Console.WriteLine("Escolha um cliente pelo numero:");
            Console.WriteLine(_banco.RelatorioDeClientes());
            Console.Write("Numero do cliente: ");

            int numeroConta;
            int.TryParse(Console.ReadLine(), out numeroConta);

            return _banco.TodasAsContas().FirstOrDefault(x => x.RetornaNumeroDaConta() == numeroConta);
        }

        private static void RegistrarContas()
        {
            _banco.RegistraConta(new ContaCorrente(001, "João", 600.50));
            _banco.RegistraConta(new ContaCorrente(002, "Maria", 200.25));
            _banco.RegistraConta(new ContaEspecial(003, "Daniel", 400, 200));
            _banco.RegistraConta(new ContaEspecial(004, "Manoel", 410, 100));
        }
    }
}
