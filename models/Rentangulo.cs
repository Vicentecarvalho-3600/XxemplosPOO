using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.models
{
    public class Rentangulo
    {
        private double Comprimento;
        private double Largura;

        private bool Valido;

        public void DefinirMedidas(double comprimento, double largura){

            if (comprimento > 0 && largura > 0) {
                Comprimento = comprimento;
                Largura = largura;
                Valido = true;
            } else {
                Console.WriteLine("valores invalidos");
            }
        }

        public double ObterArea() {
            if (Valido) {
                return Comprimento * Largura;
            } else {
                Console.WriteLine("Preencha valores válidos");
                return 0;
            }
        }
    }
}