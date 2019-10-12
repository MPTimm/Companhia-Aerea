using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace companhiaAerea
{
    class Aeroporto
    {
        private string siglaID;
        private string nome;
        private List<Voo> voos;

        public Aeroporto(string s, string n)
        {
            this.siglaID = s;
            this.nome = n;
            this.voos = new List<Voo>();
        }

        public char vendaAssento(DateTime date)
        {
            foreach(Voo v in voos)
            {
               
                if (Convert.ToBoolean(date = v.data)){

                }
            }
        }
    }
}
