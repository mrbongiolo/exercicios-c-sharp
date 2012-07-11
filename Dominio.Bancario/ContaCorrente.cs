namespace Dominio.Bancario
{
    public class ContaCorrente : IConta
    {
        private int Numero { get; set; }
        private string Nome { get; set; }
        protected double SaldoCliente { get; set; }

        public ContaCorrente(int numero, string nome, double saldo)
        {
            Numero = numero;
            Nome = nome;
            SaldoCliente = saldo;
        }

        public void Credito(double valor, out string mensagem)
        {
            SaldoCliente = SaldoCliente + valor;
            mensagem = "Credito efetuado com sucesso";
        }

        public virtual void Debito(double valor, out string mensagem)
        {
            if (SaldoCliente >= valor)
            {
                SaldoCliente = SaldoCliente - valor;
                mensagem = "Debito efetuado com sucesso";
            }
            else
                mensagem = "Saldo insuficiente";
        }

        public virtual int RetornaNumeroDaConta()
        {
            return Numero;
        }

        public virtual double Saldo()
        {
            return SaldoCliente;
        }

        public virtual string Extrato()
        {
            return string.Format("{0} Cliente: {1} - Saldo: {2}", Numero, Nome, SaldoCliente);
        }

        public override string ToString()
        {
            return string.Format("{0} Cliente: {1} ", Numero, Nome);
        }
    }
}