using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.models
{
    public class Corrente : Conta
    {
        public override void Creditar(double valor)
        {
            this.Saldo += valor;
        }
    }
}