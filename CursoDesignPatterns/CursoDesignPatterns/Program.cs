using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Imposto iss = new ISS();
            Imposto icms = new ICMS();


            Orcamento orcament = new Orcamento(500.0);
            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            calculador.RealizaCalculo(orcament, icms);
            calculador.RealizaCalculo(orcament, iss);


            Imposto iccc = new ICCC();

            Orcamento orcamento = new Orcamento(1500.00);
            //calculador.RealizaCalculo(orcament, iccc);

            Console.WriteLine(iccc.Calcula(orcament));*/
            /*
                        EstrategiaDeInvestimento convervador = new Conservador();
                        Conta conta = new Conta();
                        conta.Deposita(1000);

                        RealizadorDeInvestimentos investimento = new RealizadorDeInvestimentos();
                        investimento.Investir(conta, convervador);*/
            /*
                        CalculadorDeDescontos calculador = new CalculadorDeDescontos();
                        Orcamento orcamento = new Orcamento(500);

                        orcamento.AdicionaItem(new Item("CANETA", 250));
                        orcamento.AdicionaItem(new Item("LAPIS", 250));
                        orcamento.AdicionaItem(new Item("GELADEIRA", 250));
                        orcamento.AdicionaItem(new Item("FOGAO", 250));
                        orcamento.AdicionaItem(new Item("MICROONDAS", 250));
                        orcamento.AdicionaItem(new Item("XBOX", 250));

                        double desconto = calculador.Calcula(orcamento);

                        Console.WriteLine(desconto);*/
            /*
                        Conta conta = new Conta("Artur Dent");
                        conta.Deposita(969.0);

                        Requisicao requisicao = new Requisicao(Formato.CSV);
                        Resposta r1 = new RespostaEmCsv();
                        Resposta r2 = new RespostaXML();
                        Resposta r3 = new RespostaEmPorcento();
                        Resposta r4 = new SemFormato();

                        r1.OutraResposta = r2;
                        r2.OutraResposta = r3;
                        r3.OutraResposta = r4;

                        r1.Responde(requisicao, conta);*/
            /*
                        Conta c1 = new Conta("Artur Dent");
                        c1.Deposita(969.0);

                        Conta c2 = new Conta("Ford");
                        c2.Deposita(5.66);

                        Conta c3 = new Conta("Zhanphord");
                        c3.Deposita(964841889.32);

                        TemplateRelatorio RSimples = new RelatorioSimples();
                        TemplateRelatorio RComplexo = new RelatorioComplexos();

                        IList<Conta> contas = new List<Conta>();

                        contas.Add(c1);
                        contas.Add(c2);
                        contas.Add(c3);

                        RSimples.Imprimir(contas);
                        RComplexo.Imprimir(contas);*/
            /*
                        Imposto iss = new ISS(new ImpostoMuitoAlto());
                        Orcamento orcamento = new Orcamento(500);
                        double valor = iss.Calcula(orcamento);

                        Console.WriteLine(valor);
                        */
            /*
Orcamento reforma = new Orcamento(500);
Console.WriteLine(reforma.Valor);
reforma.AplicaDescontoExtra();
reforma.AplicaDescontoExtra();
Console.WriteLine(reforma.Valor);

reforma.Aprova();

reforma.AplicaDescontoExtra();
Console.WriteLine(reforma.Valor);

reforma.Finaliza();*/
            /*
                        Conta c1 = new Conta("Artur Dent");
                        c1.Deposita(100);

                        Console.WriteLine(c1.Status.ToString());
                        Console.WriteLine(c1.Saldo);

                        c1.Saca(99);

                        Console.WriteLine(c1.Status.ToString());
                        Console.WriteLine(c1.Saldo);

                        c1.Deposita(100);

                        Console.WriteLine(c1.Status.ToString());
                        Console.WriteLine(c1.Saldo);*/
            /*  IList<ItemDaNota> itens = new List<ItemDaNota>();

              double valorTotal = 0;

              foreach (ItemDaNota item in itens)
              {
                  valorTotal += item.Valor;
              }

              double impostos = valorTotal + 0.05;

              NotaFiscal nf = new NotaFiscal("razão", "cnpj", DateTime.Now, valorTotal, impostos, itens, "obs qualquer");*/

            NotaFiscalBuilder criador = new NotaFiscalBuilder();
            criador.ParaEmpresa("Caelum Ensino e Inovação")
            .ComCnpj("23.456.789/0001-12")
            .Com(new ItemDaNota("item 1", 100.0))
            .Com(new ItemDaNota("item 2", 200.0))            
            .ComObservacoes("uma obs qualquer");

            criador.AdicionaAcao(new EnviadorDeEmail());
            criador.AdicionaAcao(new NotaFiscalDAO());
            criador.AdicionaAcao(new EnviadorDeSMS());
            criador.AdicionaAcao(new Multiplicador(2));            

            NotaFiscal nf = criador.Constroi();

            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Impostos);

            Console.ReadKey();
        }
    }
}
