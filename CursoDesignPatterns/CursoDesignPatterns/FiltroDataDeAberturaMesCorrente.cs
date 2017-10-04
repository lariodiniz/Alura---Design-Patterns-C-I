using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class FiltroDataDeAberturaMesCorrente : Filtro
    {
        public FiltroDataDeAberturaMesCorrente()
        {
        }

        public FiltroDataDeAberturaMesCorrente(Filtro outroFiltro) : base(outroFiltro)
        {
        }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> retornar = new List<Conta>();
            foreach (Conta conta in contas)
            {
                if (conta.DataAbertura.Month == DateTime.Now.Month &&
                   conta.DataAbertura.Year == DateTime.Now.Year) retornar.Add(conta);
            }

            return retornar;
        }
    }
}
