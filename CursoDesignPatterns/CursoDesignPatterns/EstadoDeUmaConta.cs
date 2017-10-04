using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public interface xEstadoDeUmaConta
    {
        void Sacar(Conta conta, double valor);
        void Depositar(Conta conta, double valor);
        void StatusAtual(Conta conta);

    }
}
