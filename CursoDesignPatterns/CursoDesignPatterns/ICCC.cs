using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class ICCC : TemplateDeImpostoCondicional
    {
        public ICCC(Imposto outroImposto) : base(outroImposto)
        {
        }

        public ICCC() : base()
        {
        }

        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor < 1000;
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            if (orcamento.Valor >= 1000 && orcamento.Valor <= 3000)
            {
                return orcamento.Valor * 0.07;
            }
            else
            {
                return orcamento.Valor * 0.08 + 30;
            }
        }
    }
}
