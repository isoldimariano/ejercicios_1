using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimerEjercicio.recursos;

namespace PrimerEjercicio.interfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] opciones = { "1:   - Suma", "2:   - Resta",
                                "3:   - Multiplicacion", "4:   - Division",
                                "x:   - Salir" };
            bool continuar = true;

            do
            {
                Console.WriteLine("\n    --------------\n    Calculadora\n    --------------\n");
                Console.WriteLine("Ingrese la accion que se quiere realizar:");
                foreach (string opcion in opciones)
                {
                    Console.WriteLine(opcion);
                }
                string opcionEscogida = Console.ReadLine().ToLower();

                if (opcionEscogida == "x")
                {
                    Console.WriteLine("fin");
                    continuar = false;
                }
                else
                {
                    bool opcionValidada = false;
                    bool numerosValidados = false;
                    Validador nuevoValidador = new Validador();
                    opcionValidada = nuevoValidador.ValidarOpcionEscogida(opcionEscogida);

                    Console.WriteLine("ingrese el primer numero");
                    string valor1 = Console.ReadLine();
                    Console.WriteLine("ingrese el segundo numero");
                    string valor2 = Console.ReadLine();

                    if (opcionValidada)
                    {
                        numerosValidados = nuevoValidador.ValidarNumeros(valor1, valor2);
                    }

                    if (numerosValidados)
                    {
                        double numero1 = double.Parse(valor1);
                        double numero2 = double.Parse(valor2);
                        Calculador nuevoCalculador = new Calculador();
                        double resultado = nuevoCalculador.Calcular(numero1, numero2, opcionEscogida);
                        Console.WriteLine("El resultado es: {0}", resultado);
                        Console.WriteLine("Presione enter para continuar");
                        Console.ReadLine();
                    }
                }

            } while (continuar);
        }
    }
    
}
