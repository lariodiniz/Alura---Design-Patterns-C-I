using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class FiltroSaldoMenor100 : Filtro
    {
        public FiltroSaldoMenor100()
        {
        }

        public FiltroSaldoMenor100(Filtro outroFiltro) : base(outroFiltro)
        {
        }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> retornar = new List<Conta>();
            foreach (Conta conta in contas)
            {
                if (conta.Saldo < 100) retornar.Add(conta);
            }

            return retornar;
        }
    }
}
