using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace companhiaAerea
{
    class Assento
    {
        private bool disponibilidade;
        private string codPoltrona;

        public Assento()
        {
            this.disponibilidade = true;
            this.codPoltrona = AlfanumericoAleatorio(3);
        }

        public static string AlfanumericoAleatorio(int tamanho)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, tamanho)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return result;
        }

        public void SetDispo()
        {
            disponibilidade = false;
        }
    }
}
