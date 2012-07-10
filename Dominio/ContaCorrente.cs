namespace Dominio
{
    public class ContaCorrente : Conta
    {
        public string Nome { get; set; }
        public double SaldoCliente { get; set; }

        public ContaCorrente(string nome, double saldo)
        {
            Nome = nome;
            SaldoCliente = saldo;
        }

        protected ContaCorrente()
        {
        }

        public override void Credito(double valor, out string mensagem)
        {
            SaldoCliente = SaldoCliente + valor;
            mensagem = "Credito efetuado com sucesso";
        }

        public override void Debito(double valor, out string mensagem)
        {
            if (SaldoCliente >= valor)
            {
                SaldoCliente = SaldoCliente - valor;
                mensagem = "Debito efetuado com sucesso";
            }
            else
                mensagem = "Saldo insuficiente";
        }

        public override double Saldo()
        {
            return SaldoCliente;
        }

        public override string ToString()
        {
            return string.Format("Cliente: {0} \n Saldo: {1}", Nome, SaldoCliente);
        }
    }
}