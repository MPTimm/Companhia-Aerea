using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace companhiaAerea
{
    class Passageiro : Cliente
    {
        private string assento;

        public Passageiro(string n, int r, DateTime date) : base(n, r, date)
        {
            
        }

        public string getAssento()
        {
            return this.assento;
        }
    }
}
