using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerEjercicio.recursos
{
    public class Calculador
    {
        public Calculador()
        {
            Console.WriteLine("\ncalculadora iniciada\n");
        }
        public double Calcular(double valor1, double valor2, string operacion)
        {
            double resultado = 0;
            switch (operacion)
            {
                case "1":
                    resultado = this.Sumar(valor1, valor2);
                    break;
                case "2":
                    resultado = this.Restar(valor1, valor2);
                    break;
                case "3":
                    resultado = this.Multiplicar(valor1, valor2);
                    break;
                case "4":
                    resultado = this.Dividir(valor1, valor2);
                    break;
            }

            return resultado;
        }

        private double Sumar(double numero1, double numero2)
        {
            return numero1 + numero2;
        }
        private double Restar(double numero1, double numero2)
        {
            return numero1 - numero2;
        }
        private double Dividir(double numero1, double numero2)
        {
            return numero1 / numero2;
        }
        private double Multiplicar(double numero1, double numero2)
        {
            return numero1 * numero2;
        }
    }
}
