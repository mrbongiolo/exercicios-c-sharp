using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Contapolimorfica
{
    //classe base (abstrata)
    public abstract class Conta
    {
        public virtual double Saldo()
        {
            return 0;
        }

    }

    //classe herdeira (herda da classe Conta)
    public class Contacorrente : Conta
    {
        private string nome;
        private double saldocliente;

        public Contacorrente()
        {
            Nome = "";
            Saldocliente = 0;
        }

        public Contacorrente(string n, double s)
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
                MessageBox.Show(erro, "ERRO");
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
    
    //classe herdeira (herda da classe ContaCorrente)
    public class Contaespecial : Contacorrente
    {
        private double limite;
        public Contaespecial()
            : base()
        {
            Limite = 0;
        }
        public Contaespecial(string n, double s, double l)
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

    //Parte Principal do Programa
    public class Principal
    {
        static void Main(string[] args)
        {
            Contacorrente c1 = new Contacorrente("João", 600.50);
            Contacorrente c2 = new Contacorrente("Maria", 200.25);
            Contaespecial e1 = new Contaespecial("Daniel", 400, 200);
            Contaespecial e2 = new Contaespecial("Manoel", 410, 100);

            Conta[] vetor = new Conta[4];
            vetor[0] = c1;
            vetor[1] = c2;
            vetor[2] = e1;
            vetor[3] = e2;

            string saida = "";
            foreach (Conta atual in vetor)
            {
                saida += "\n" + atual + "\nSaldo Total: " + atual.Saldo();
            }
            MessageBox.Show(saida, "TABAJARA SOFT ");
            int op;
            double valor;
            op = 0;

            while (op != 5)
            {
                int operando;
                operando = 0;
                Console.Clear();
                DateTime hoje = DateTime.Now;
                Console.WriteLine("TABAJARA HOME BANK ©\n\n{0}\n\n1 - Debito Conta Corrente\n2 - Debito Conta Especial\n3 - Credito Conta Corrente\n4 - Credito Conta Especial\n5 - Sair", hoje);
                Console.WriteLine("\n\nOpção: ");
                op = Int32.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        {
                            int operando2 = 0;
                            Console.Clear();
                            Console.WriteLine("TABAJARA HOME BANK ©\n\n");
                            Console.WriteLine("Escolha o Cliente: \n1 - João\n2 - Maria");
                            operando2 = Int32.Parse(Console.ReadLine());
                            switch (operando2)
                            {
                                case 1:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("TABAJARA HOME BANK ©\n\n");
                                        Console.WriteLine("Entre com o valor: ");
                                        valor = double.Parse(Console.ReadLine());
                                        c1.debito(valor);
                                        Console.WriteLine("\nAguarde !!!");
                                        string saida2 = "";
                                        foreach (Conta atual in vetor)
                                        {
                                            saida2 += "\n" + atual + "\nSaldo Total: " + atual.Saldo();
                                        }
                                        MessageBox.Show(saida2, "TABAJARA SOFT ");
                                        break;
                                    }

                                case 2:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("TABAJARA HOME BANK ©\n\n");
                                        Console.WriteLine("Entre com o valor: ");
                                        valor = double.Parse(Console.ReadLine());
                                        c2.debito(valor);
                                        Console.WriteLine("\nAguarde !!!");
                                        string saida2 = "";
                                        foreach (Conta atual in vetor)
                                        {
                                            saida2 += "\n" + atual + "\nSaldo Total: " + atual.Saldo();
                                        }
                                        MessageBox.Show(saida2, "TABAJARA SOFT ");
                                        break;
                                    }
                                default:
                                    {
                                        string erro555 = "Cliente invalido";
                                        MessageBox.Show(erro555, "ERRO");
                                        break;
                                    }
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("TABAJARA HOME BANK ©\n\n");
                            Console.WriteLine("Escolha o Cliente: \n1 - Daniel\n2 - Manoel");
                            operando = Int32.Parse(Console.ReadLine());
                            switch (operando)
                            {
                                case 1:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("TABAJARA HOME BANK ©\n\n");
                                        Console.WriteLine("Entre com o valor: ");
                                        valor = double.Parse(Console.ReadLine());
                                        e1.debito(valor);
                                        Console.WriteLine("\nAguarde !!!");
                                        string saida2 = "";
                                        foreach (Conta atual in vetor)
                                        {
                                            saida2 += "\n" + atual + "\nSaldo Total: " + atual.Saldo();
                                        }
                                        MessageBox.Show(saida2, "TABAJARA SOFT ");
                                        break;
                                    }

                                case 2:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("TABAJARA HOME BANK ©\n\n");
                                        Console.WriteLine("Entre com o valor: ");
                                        valor = double.Parse(Console.ReadLine());
                                        e2.debito(valor);
                                        Console.WriteLine("\nAguarde !!!");
                                        string saida2 = "";
                                        foreach (Conta atual in vetor)
                                        {
                                            saida2 += "\n" + atual + "\nSaldo Total: " + atual.Saldo();
                                        }
                                        MessageBox.Show(saida2, "TABAJARA SOFT ");
                                        break;
                                    }
                                default:
                                    {
                                        string erro555 = "Cliente invalido";
                                        MessageBox.Show(erro555, "ERRO");
                                        break;
                                    }
                            }
                            break;
                        }








                    case 3:
                        {
                            int operando3 = 0;
                            Console.Clear();
                            Console.WriteLine("TABAJARA HOME BANK ©\n\n");
                            Console.WriteLine("Escolha o Cliente: \n1 - João\n2 - Maria");
                            operando3 = Int32.Parse(Console.ReadLine());
                            switch (operando3)
                            {
                                case 1:
                                    {

                                        Console.Clear();
                                        Console.WriteLine("TABAJARA HOME BANK ©\n\n");
                                        Console.WriteLine("Entre com o valor: ");
                                        valor = double.Parse(Console.ReadLine());
                                        c1.credito(valor);
                                        Console.WriteLine("\nAguarde !!!");
                                        string saida3 = "";
                                        foreach (Conta atual in vetor)
                                        {
                                            saida3 += "\n" + atual + "\nSaldo Total: " + atual.Saldo();
                                        }
                                        MessageBox.Show(saida3, "TABAJARA SOFT ");
                                        break;
                                    }

                                case 2:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("TABAJARA HOME BANK ©\n\n");
                                        Console.WriteLine("Entre com o valor: ");
                                        valor = double.Parse(Console.ReadLine());
                                        c2.credito(valor);
                                        Console.WriteLine("\nAguarde !!!");
                                        string saida3 = "";
                                        foreach (Conta atual in vetor)
                                        {
                                            saida3 += "\n" + atual + "\nSaldo Total: " + atual.Saldo();
                                        }
                                        MessageBox.Show(saida3, "TABAJARA SOFT ");
                                        break;
                                    }
                                default:
                                    {
                                        string erro555 = "Cliente invalido";
                                        MessageBox.Show(erro555, "ERRO");
                                        break;
                                    }
                            }
                            break;



                        }
                    case 4:
                        {
                            int operando4 = 0;
                            Console.Clear();
                            Console.WriteLine("TABAJARA HOME BANK ©\n\n");
                            Console.WriteLine("Escolha o Cliente: \n1 - Daniel\n2 - Manoel");
                            operando4 = Int32.Parse(Console.ReadLine());
                            switch (operando4)
                            {
                                case 1:
                                    {

                                        Console.Clear();
                                        Console.WriteLine("TABAJARA HOME BANK ©\n\n");
                                        Console.WriteLine("Entre com o valor: ");
                                        valor = double.Parse(Console.ReadLine());
                                        e1.credito(valor);
                                        Console.WriteLine("\nAguarde !!!");
                                        string saida3 = "";
                                        foreach (Conta atual in vetor)
                                        {
                                            saida3 += "\n" + atual + "\nSaldo Total: " + atual.Saldo();
                                        }
                                        MessageBox.Show(saida3, "TABAJARA SOFT ");
                                        break;
                                    }

                                case 2:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("TABAJARA HOME BANK ©\n\n");
                                        Console.WriteLine("Entre com o valor: ");
                                        valor = double.Parse(Console.ReadLine());
                                        e2.credito(valor);
                                        Console.WriteLine("\nAguarde !!!");
                                        string saida3 = "";
                                        foreach (Conta atual in vetor)
                                        {
                                            saida3 += "\n" + atual + "\nSaldo Total: " + atual.Saldo();
                                        }
                                        MessageBox.Show(saida3, "TABAJARA SOFT ");
                                        break;
                                    }
                                default:
                                    {
                                        string erro555 = "Cliente invalido";
                                        MessageBox.Show(erro555, "ERRO");
                                        break;
                                    }
                            }

                            break;


                        }
                    case 5:
                        {
                            break;
                        }


                    default:
                        {
                            string erro556 = "Opção invalida";
                            MessageBox.Show(erro556, "ERRO");
                            break;
                        }


                }


            }


        }
    }
}
