using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleContas
{
    public class Conta
    {
        public Conta(long numero) 
        {
            this.Numero = numero;
        }
        public Conta() { }
        public long Numero { get; private set; }
        public decimal Saldo { get; set; }
    }
}
