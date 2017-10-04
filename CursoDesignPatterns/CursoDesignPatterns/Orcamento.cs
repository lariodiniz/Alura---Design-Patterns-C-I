using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Orcamento
    {
        public double Valor { get; set; }
        public IList<Item> Itens { get; private set; }

        public EstadoDeUmOrcamento EstadoAtual { get; set; }
        /* Forma Que eu Criei
        public EstadoDeUmOrcamento DescontoNoEstado { get; set; }*/

        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
            this.EstadoAtual = new EmAprovacao();
            /* Forma Que eu Criei
             * this.DescontoNoEstado = null;*/
         }

         public void AdicionaItem(Item item)
         {
             Itens.Add(item);
         }

         public void AplicaDescontoExtra()
         {
             /* Forma Que eu Criei
             if(EstadoAtual != DescontoNoEstado)
             {
                 DescontoNoEstado = EstadoAtual;
                 EstadoAtual.AplicaDescontoExtra(this);
             }
             else
             {
                 throw new Exception("Já foi dado desconto para este Orçamento com o Status Atual");
             } */

            /*Forma do Curso */

        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }
    }
}
