using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class SemFormato : Resposta
    {

        public Resposta OutraResposta { get; set; }

        public void Responde(Requisicao req, Conta conta)
        {
            Console.WriteLine("Formato Não Identificado");           
            
        }
    }
}
