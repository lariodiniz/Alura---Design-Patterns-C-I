using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Conta
    {
        public double Saldo { get; private set; }
        public string Titular { get; private set; }
        public DateTime DataAbertura { get; private set; }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public Conta(string titular)
        {
            this.Titular = titular;
            this.DataAbertura = DateTime.Now;
        }
    }
}
