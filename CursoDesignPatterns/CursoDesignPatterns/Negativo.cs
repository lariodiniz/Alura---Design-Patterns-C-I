using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class xNegativo : xEstadoDeUmaConta
    {
        public void Depositar(Conta conta, double valor)
        {
            //conta.Saldo += (valor * 0.95);
            StatusAtual(conta);
        }

        public void Sacar(Conta conta, double valor)
        {
            throw new Exception("Contas com valores Negativos não realizam Saques.");
        }

        public void StatusAtual(Conta conta)
        {
            if (conta.Saldo >= 0)
            {
                //conta.Status = new Positivo();
            }
        }
    }
}
