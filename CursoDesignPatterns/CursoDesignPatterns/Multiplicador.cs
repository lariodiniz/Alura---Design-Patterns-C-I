using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Multiplicador : AcaoAposGerarNota
    {
        public double Fator { get; private set; }

        public Multiplicador(double fator)
        {
            this.Fator = fator;
        }

        public void Executa(NotaFiscal nf)
        {
            double multiplicado = nf.ValorBruto * this.Fator;
            Console.WriteLine("Valor da nota multiplicado por {0}: {1}", this.Fator, multiplicado);
        }
    }
}
