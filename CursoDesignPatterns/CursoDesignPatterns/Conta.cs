using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Conta
    {
        public interface EstadoDeUmaConta
        {
            void Sacar(Conta conta, double valor);
            void Depositar(Conta conta, double valor);
            void StatusAtual(Conta conta);

        }

        class Positivo : EstadoDeUmaConta
        {
            public void Depositar(Conta conta, double valor)
            {
                conta.Saldo += (valor * 0.98);
                StatusAtual(conta);


            }

            public void Sacar(Conta conta, double valor)
            {
                conta.Saldo -= valor;
                StatusAtual(conta);
            }

            public void StatusAtual(Conta conta)
            {
                if (conta.Saldo < 0)
                {
                    conta.Status = new Negativo();
                }
            }
        }

        class Negativo : EstadoDeUmaConta
        {
            public void Depositar(Conta conta, double valor)
            {
                conta.Saldo += (valor * 0.95);
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
                    conta.Status = new Positivo();
                }
            }
        }
        

        public double Saldo { get; private set; }
        public string Titular { get; private set; }
        public DateTime DataAbertura { get; private set; }
        public EstadoDeUmaConta Status { get; private set; }

        public void Deposita(double valor)
        {
            Status.Depositar(this, valor);
        }

        public void Saca(double valor)
        {
            Status.Sacar(this, valor);
        }

        public Conta(string titular)
        {
            this.Titular = titular;
            this.DataAbertura = DateTime.Now;
            this.Status = new Positivo();
        }
    }
}
