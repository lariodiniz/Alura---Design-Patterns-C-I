using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class NotaFiscalBuilder
    {
        public String RazaoSocial { get; private set; }
        public String Cnpj { get; private set; }
        public String Observacoes { get; private set; }
        public DateTime Data { get; private set; }

        private double ValorTotal;
        private double Impostos;
        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();

        private IList<AcaoAposGerarNota> todasAcoesASeremExecutadas;// = new List<AcaoAposGerarNota>();

        public void AdicionaAcao(AcaoAposGerarNota novaAcao)
        {
            todasAcoesASeremExecutadas.Add(novaAcao);            
        }

        public NotaFiscalBuilder ParaEmpresa(String razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder (IList<AcaoAposGerarNota> acoes)
        {
            this.Data = DateTime.Now;
            todasAcoesASeremExecutadas = acoes;
        }

        public NotaFiscalBuilder ComCnpj(String cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder NaData(DateTime data)
        {
            this.Data = data;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(String observacoes)
        {
            this.Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder Com(ItemDaNota item)
        {
            todosItens.Add(item);
            ValorTotal += item.Valor;

            Impostos += item.Valor * 0.05;
            return this;
        }

        public NotaFiscal Constroi()
        {
            NotaFiscal nf = new NotaFiscal(this.RazaoSocial, this.Cnpj, this.Data, this.ValorTotal, 
                this.Impostos, this.todosItens, this.Observacoes);

            foreach (AcaoAposGerarNota acao in todasAcoesASeremExecutadas)
            {
                acao.Executa(nf);
            }


            return nf;
        }

    }

    

}