using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public abstract class TemplateRelatorio
    {
        public void Imprimir(IList<Conta> contas)
        {
            Console.WriteLine("|------------***------------|");
            Cabecalho();
            Corpo(contas);
            Rodape();
            Console.WriteLine("|------------***------------|");
            Console.WriteLine("");
        }

        protected abstract void Rodape();
        protected abstract void Corpo(IList<Conta> contas);
        protected abstract void Cabecalho();
    }
}
