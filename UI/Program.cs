using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dominio;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente c1 = new ContaCorrente("João", 600.50);
            ContaCorrente c2 = new ContaCorrente("Maria", 200.25);
            ContaEspecial e1 = new ContaEspecial("Daniel", 400, 200);
            ContaEspecial e2 = new ContaEspecial("Manoel", 410, 100);

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
                                        c1.Debito(valor);
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
                                        c2.Debito(valor);
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
                                        e1.Debito(valor);
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
                                        e2.Debito(valor);
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
                                        c1.Credito(valor);
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
                                        c2.Credito(valor);
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
                                        e1.Credito(valor);
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
                                        e2.Credito(valor);
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
