using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class xPositivo : xEstadoDeUmaConta
    {
        public void Depositar(Conta conta, double valor)
        {
            //conta.Saldo += (valor * 0.98);
            StatusAtual(conta);


        }

        public void Sacar(Conta conta, double valor)
        {
            //conta.Saldo -= valor;
            StatusAtual(conta);
        }

        public void StatusAtual(Conta conta)
        {
            if (conta.Saldo < 0)
            {
                //conta.Status = new Negativo();
            }
        }
    }
}
