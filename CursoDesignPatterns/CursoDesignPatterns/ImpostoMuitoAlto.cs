using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class ImpostoMuitoAlto : TemplateDeImpostoCondicional
    {

        public ImpostoMuitoAlto(Imposto outroImposto) : base(outroImposto)
        {
        }

        public ImpostoMuitoAlto() : base()
        {
        }

        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return true;
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2 + CalculoDoOutroImposto(orcamento);
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            throw new NotImplementedException();
        }
    }
}
