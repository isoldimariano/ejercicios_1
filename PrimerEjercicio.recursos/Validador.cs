using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrimerEjercicio.recursos
{
    public class Validador
    {
        private string [] opcionesValidas =
        {
            "1", "2", "3", "4"
        };
        public bool ValidarOpcionEscogida(string opcionEscogida)
        {
            return this.opcionesValidas.Contains(opcionEscogida);
        }

        public bool ValidarNumeros(string valor1, string valor2)
        {

            bool validado1 = true;
            bool validado2 = true;
            double numero1 = 0;
            double numero2 = 0;

            if (!double.TryParse(valor1, out numero1))
            {
                Console.WriteLine("numero ingresado {0} invalido", valor1);
                validado1 = false;
            }
            if (!double.TryParse(valor2, out numero2))
            {
                Console.WriteLine("numero ingresado {0} invalido", valor2);
                validado2 = false;
            }

            return validado1 & validado2;
        }
    }
}
