namespace Dominio
{
    public class ContaCorrente : Conta
    {
        private string nome;
        private double saldocliente;

        public ContaCorrente()
        {
            Nome = "";
            Saldocliente = 0;
        }

        public ContaCorrente(string n, double s)
        {
            Nome = n;
            Saldocliente = s;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public double Saldocliente
        {
            get { return saldocliente; }
            set { saldocliente = value; }
        }


        public void credito(double valor)
        {
            Saldocliente = Saldocliente + valor;
        }
        public virtual void debito(double valor)
        {
            if (Saldocliente >= valor)
            {
                Saldocliente = Saldocliente - valor;

            }
            else
            {
                string erro = "Saldo Insuficiente";
                //MessageBox.Show(erro, "ERRO");
            }
        }
        public override double Saldo()
        {
            return Saldocliente;
        }

        public override string ToString()
        {
            return "\nNome: " + Nome + "\n\nSaldo: " + Saldocliente;
        }
    }
}