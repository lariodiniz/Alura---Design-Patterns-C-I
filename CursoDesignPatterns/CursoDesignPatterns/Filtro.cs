using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public abstract class Filtro
    {
        public Filtro OutroFiltro { get; set; }

        public Filtro(Filtro outroFiltro)
        {
            this.OutroFiltro = outroFiltro;
        }

        public Filtro()
        {
            this.OutroFiltro = null;
        }

        protected IList<Conta> FiltraDoOutroFiltro(IList<Conta> contas)
        {
            if (OutroFiltro == null) return new List<Conta>();
            return OutroFiltro.Filtra(contas);
        }

        public abstract IList<Conta> Filtra(IList<Conta> contas);
    }
}
