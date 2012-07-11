namespace Dominio.Bancario
{
    public class ContaEspecial : ContaCorrente
    {
        private double Limite { get; set; }
        
        public ContaEspecial(int numero, string nome, double saldo, double limite)
            : base(numero, nome, saldo)
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

        public override string Extrato()
        {
            return string.Format("{0} - Limite: {1} - Saldo Total: {2}", base.Extrato(), Limite, Saldo());
        }
    }
}