using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Dominio.Bancario
{
    public class Banco
    {
        public string Nome { get; private set; }

        private readonly ICollection<IConta> _contas = new Collection<IConta>();

        public Banco()
        {
            Nome = "Banco Tabajara";
        }

        public void RegistraConta(IConta conta)
        {
            if (!_contas.Contains(conta))
                _contas.Add(conta);
        }

        public IEnumerable<IConta> TodasAsContas()
        {
            return _contas;
        }

        public string RelatorioDeClientes()
        {
            return TodasAsContas().Aggregate("", (current, conta) => string.Format("{0} {1} \n", current, conta));
        }
    }
}
