namespace Dominio
{
    public class ContaEspecial : ContaCorrente
    {
        private double limite;
        public ContaEspecial()
            : base()
        {
            Limite = 0;
        }
        public ContaEspecial(string n, double s, double l)
            : base(n, s)
        {
            Limite = l;
        }
        public double Limite
        {
            get { return limite; }
            set { limite = value; }
        }
        public override double Saldo()
        {
            return Saldocliente + Limite;
        }

        public override void debito(double valor)
        {
            if (Saldocliente + Limite >= valor)
            {
                Saldocliente = Saldocliente - valor;

            }
            else
            {
                string erro = "Saldo Insuficiente";
                MessageBox.Show(erro, "ERRO");
            }


        }

        public override string ToString()
        {
            return base.ToString() + "\nLimite: " + Limite;
        }
    }
}