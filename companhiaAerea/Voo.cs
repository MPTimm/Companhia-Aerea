using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace companhiaAerea
{
    class Voo
    {
        private string codLocal;
        private int portao;
        public DateTime data;
        private Aeroporto partida;
        private Aeroporto chegada;
        private int nVoo;
        private DateTime horEmbarque;
        private List<Passageiro> passageiros;
        private List<Assento> assento;

        public Voo(int nv)
        {
            Random randNum = new Random();
            this.codLocal = AlfanumericoAleatorio(6);
            this.portao = randNum.Next();
            this.data = new DateTime(2018, 07, 10);
            this.passageiros = new List<Passageiro>();
            this.partida = new Aeroporto("POA", "Salgado Filho");
            this.chegada = new Aeroporto("SP", "Garulhos");
            this.assento = new List<Assento>();
            this.nVoo = nv;
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
    }
}
