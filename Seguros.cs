/*
 * Classe Base CLIENTE
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Seguros
{
    class Cliente
    {
        //variavel nome
        private string nome;

        //construtor sem parametro
        public Cliente()
        {
            Nome = "";
        }
        
        //construtor com parametro
        public Cliente(string n)
        {
            Nome = n;
        }

        //propriedades da variavel NOME
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        //metodo ToString
        public override string ToString()
        {
            string composite = String.Format("\nNome: {0}", nome);
            return composite;
        }
    }
}

/*
 * Classe Herdeira ASSEGURADO
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Seguros
{
    //herança com a classe Cliente
    class Assegurado:Cliente
    {
        //variavel nome da seguradora
        private string nomeSeguradora;
        //variavel numero do seguro
        private int nSeguro;

        //construtor sem parametros
        public Assegurado()
            : base()
        {
            NomeSeguradora = "";
            NSeguro = 0;
        }

        //construtor com parametros
        public Assegurado(string n, string nSeguradora, int nSeguro)
            : base(n)
        {
            NomeSeguradora = nSeguradora;
            NSeguro = nSeguro;
        }

        //propriedades da variavel NOMESEGURADORA
        public string NomeSeguradora
        {
            get { return nomeSeguradora; }
            set { nomeSeguradora = value; }
        }

        //propriedades da variavel NSEGURO
        public int NSeguro
        {
            get { return nSeguro; }
            set { nSeguro = ((value > 0)? value : 0); }
        }

        //metodo ToString
        public override string ToString()
        {
            string composite = String.Format("{0}\nNome Seguradora: {1}\nNº Seguro: {2}", base.ToString(), NomeSeguradora, NSeguro);
            return composite;
        }
    }
}

/*
 * Classe Herdeira NAO ASSEGURADO
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Seguros
{
    //herança com a classe Cliente
    class NaoAssegurado:Cliente
    {
        //variaveis numero do cheque e numero do banco
        private int nCheque, nBanco;
        
        //variavel valor da consulta
        private double valorConsulta;

        //construtor sem parametros
        public NaoAssegurado()
            : base()
        {
            NCheque = 0;
            NBanco = 0;
            ValorConsulta = 0;
        }

        //construtor com parametros
        public NaoAssegurado(string n, int nC, int nB, double vC)
            : base(n)
        {
            NCheque = nC;
            NBanco = nB;
            ValorConsulta = vC;
        }
        
        //propriedades da variavel NCHEQUE
        public int NCheque
        {
            get { return nCheque; }
            set { nCheque = ((value > 0) ? value : 0); }
        }

        //propriedades da variavel NBANCO
        public int NBanco
        {
            get { return nBanco; }
            set { nBanco = ((value > 0) ? value : 0); }
        }

        //propriedades da variavel VALORCONSULTA
        public double ValorConsulta
        {
            get { return valorConsulta; }
            set { valorConsulta = ((value > 0) ? value : 0); }
        }

        //metodo ToSTring
        public override string ToString()
        {
            string composite = String.Format("{0}\nValor da Consulta: {1:F}\nNº Cheque: {2}\nNº Banco: {3}", base.ToString(), ValorConsulta, NCheque, NBanco);
            return composite;
        }
    }
}







/*
 * Parte Principal do Programa
 * Contem os Menus
 * 
 * Coloquei varios comentarios no programa,
 * para indicar o que esta sendo feito em cada lugar.
 * 
 * Mas, se preferir, pode tira-los.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Seguros
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis nome e nome da seguradora
            string nome, nomeSeguradora;
            
            //variaveis nº do seguro, nº do cheque e nº do banco
            int numSeguro, numCheque, numBanco;
            
            //variavel valor da consulta
            double valorConsulta;

            //variavel posição do vetor
            //ela sera utliziada para que cada objeto criado seja colocado em uma nova posicao no vetor
            int posVetor=0;
            
            //variavel escolha do menu
            int escolhaMenu;

            //criação do vetor de Clientes (20  posições)
            Cliente[] vetorSeguro = new Cliente[20];

            //variavel que controla o while
            int op=1;
            while (op == 1)
            {
                Console.Clear();
                
                //menu de opçoes ao usuario
                Console.Write("Menu");
                Console.WriteLine("\n\n1 - Inserir Assegurado");
                Console.WriteLine("2 - Inserir Nao Assegurado");
                Console.WriteLine("3 - Exibir Vetor de Clientes");
                Console.WriteLine("4 - Sair");

                escolhaMenu = Int32.Parse(Console.ReadLine());

                //inicio do switch
                switch (escolhaMenu)
                {
                    case 1:
                        {
                            //area para inserir dados de um ASSEGURADO
                            Console.Clear();
                            Console.Write("Assegurado");
                            Console.Write("\n\nNome: ");
                            nome = Console.ReadLine();
                            Console.Write("\nNome Seguradora: ");
                            nomeSeguradora = Console.ReadLine();
                            Console.Write("\nNº Seguro: ");
                            numSeguro = Int32.Parse(Console.ReadLine());

                            //criação do objeto da classe Assegurado dentro do vetorSeguro
                            vetorSeguro[posVetor] = new Assegurado(nome, nomeSeguradora, numSeguro);

                            //adiciona + 1 a variavel de posição do vetor
                            posVetor += 1;

                            break;
                        }
                    case 2:
                        {
                            //area para inserir dados de um NAO ASSEGURADO
                            Console.Clear();
                            Console.Write("Nao Assegurado");
                            Console.Write("\n\nNome: ");
                            nome = Console.ReadLine();
                            Console.Write("\nValor da Consulta: ");
                            valorConsulta = Double.Parse(Console.ReadLine());
                            Console.Write("\nNº Cheque: ");
                            numCheque = Int32.Parse(Console.ReadLine());
                            Console.Write("\nNº Banco: ");
                            numBanco = Int32.Parse(Console.ReadLine());

                            //criação do objeto da classe NaoAssegurado dentro do vetorSeguro
                            vetorSeguro[posVetor] = new NaoAssegurado(nome, numCheque, numBanco, valorConsulta);

                            //adiciona + 1 a variavel de posição do vetor
                            posVetor += 1;

                            break;
                        }
                    case 3:
                        {
                            //area para exibir o vetor de clientes
                            Console.Clear();
                            Console.WriteLine("Exibir o vetor de Clientes");
                            foreach (Cliente atual in vetorSeguro)
                            {
                                if (atual != null)
                                {
                                    Console.WriteLine(atual);
                                    Console.ReadKey();
                                }
                            }
                            break;
                        }
                    case 4:
                        {
                            //area para sair do programa
                            op = 2;
                            break;
                        }
                    default:
                        {
                            //opcao default
                            Console.Clear();
                            Console.Write("Opcao Invalida!");
                            Console.ReadKey();
                            break;
                        }
                }
            }
        }
    }
}
