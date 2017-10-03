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

            r1.Responde(requisicao, conta);



            Console.ReadKey();
        }
    }
}
