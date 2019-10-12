using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace companhiaAerea
{
    public class Cliente
    {
        private string nome;
        private int RG;
        private DateTime dataNasc;

        public Cliente(string n, int r, DateTime date)
        {
            this.nome = n;
            this.RG = r;
            this.dataNasc = date;

        }
    }

     
}
