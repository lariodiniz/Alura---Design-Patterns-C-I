using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class IHIT : TemplateDeImpostoCondicional
    {
        public IHIT(Imposto outroImposto) : base(outroImposto)
        {
        }

        public IHIT() : base()
        {
        }

        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return (ExisteDoisItensComOMesmoNome(orcamento));
        }

        private bool ExisteDoisItensComOMesmoNome(Orcamento orcamento)
        {           


            for (int i = 0; i < orcamento.Itens.Count; i++)
            {
                for (int c = i+1; c < orcamento.Itens.Count; c++)
                {
                    if (orcamento.Itens[i].Nome == orcamento.Itens[c].Nome)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100.0;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * (0.01 * orcamento.Itens.Count);
        }       
    }
}
