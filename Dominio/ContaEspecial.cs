namespace Dominio
{
    public class ContaEspecial : ContaCorrente
    {
        public double Limite { get; set; }

        public ContaEspecial()
        {
            Limite = 0;
        }

        public ContaEspecial(string nome, double saldo, double limite)
            : base(nome, saldo)
        {
            Limite = limite;
        }

        public override double Saldo()
        {
            return SaldoCliente + Limite;
        }

        public override void Debito(double valor, out string mensagem)
        {
            if (SaldoCliente + Limite >= valor)
            {
                SaldoCliente = SaldoCliente - valor;
                mensagem = "Debito efetuado com sucesso";
            }
            else
                mensagem = "Saldo insuficiente";
        }

        public override string ToString()
        {
            return string.Format("{0} \nLimite: {1}", base.ToString(), Limite);
        }
    }
}