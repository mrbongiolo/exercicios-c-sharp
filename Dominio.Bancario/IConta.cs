namespace Dominio.Bancario
{
    public interface IConta
    {
        double Saldo();

        void Credito(double valor, out string mensagem);

        void Debito(double valor, out string mensagem);

        int RetornaNumeroDaConta();

        string Extrato();
    }
}
