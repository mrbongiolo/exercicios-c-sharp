namespace Dominio
{
    public abstract class Conta : IConta
    {
        public virtual double Saldo()
        {
            return 0;
        }

        public virtual void Credito(double valor, out string mensagem)
        {
            mensagem = null;
        }

        public virtual void Debito(double valor, out string mensagem)
        {
            mensagem = null;
        }
    }
}