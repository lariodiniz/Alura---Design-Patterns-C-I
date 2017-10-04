using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class FiltroSaldoMaior500 : Filtro
    {
        public FiltroSaldoMaior500()
        {
        }

        public FiltroSaldoMaior500(Filtro outroFiltro) : base(outroFiltro)
        {
        }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> retornar = new List<Conta>();
            foreach (Conta conta in contas)
            {
                if (conta.Saldo > 500000) retornar.Add(conta);
            }

            return retornar;
        }
    }
}
