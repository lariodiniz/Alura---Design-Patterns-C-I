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

            EstrategiaDeInvestimento convervador = new Conservador();
            Conta conta = new Conta();
            conta.Deposita(1000);

            RealizadorDeInvestimentos investimento = new RealizadorDeInvestimentos();
            investimento.Investir(conta, convervador);


            Console.ReadKey();
        }
    }
}
