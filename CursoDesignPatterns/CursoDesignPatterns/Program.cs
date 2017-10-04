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

            Imposto iss = new ISS(new ImpostoMuitoAlto());
            Orcamento orcamento = new Orcamento(500);
            double valor = iss.Calcula(orcamento);

            Console.WriteLine(valor);



            Console.ReadKey();
        }
    }
}
