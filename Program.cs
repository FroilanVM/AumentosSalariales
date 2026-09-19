using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AumentosSalariales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string continuar = "s";

            while (continuar == "s")
            {
                Console.WriteLine("Digite la cedula del empleado:");
                string cedula = Console.ReadLine();

                Console.WriteLine("Digite el nombre del empleado:");
                string nombre = Console.ReadLine();

                int tipoEmpleado;

                Console.WriteLine("Digite el tipo de empleado:");
                Console.WriteLine("1 - Operario");
                Console.WriteLine("2 - Tecnico");
                Console.WriteLine("3 - Profesional");

                while (!int.TryParse(Console.ReadLine()?.Trim(), out tipoEmpleado) || tipoEmpleado < 1 || tipoEmpleado > 3)
                {
                    Console.WriteLine("Entrada invalida. Introduzca el tipo de empleado (1, 2 o 3):");
                }

                Console.WriteLine("Digite la cantidad de horas trabajadas:");
                double horas = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite el precio por hora:");
                double precioHora = double.Parse(Console.ReadLine());

                double salarioOrdinario = horas * precioHora;

                double porcentajeAumento = 0;
                string nombreTipoEmpleado = "";

                if (tipoEmpleado == 1)
                {
                    porcentajeAumento = 0.15;
                    nombreTipoEmpleado = "Operario";
                }
                else if (tipoEmpleado == 2)
                {
                    porcentajeAumento = 0.10;
                    nombreTipoEmpleado = "Tecnico";
                }
                else if (tipoEmpleado == 3)
                {
                    porcentajeAumento = 0.05;
                    nombreTipoEmpleado = "Profesional";
                }

                double aumento = salarioOrdinario * porcentajeAumento;

                double salarioBruto = salarioOrdinario + aumento;

                double deduccionCCSS = salarioBruto * 0.0917;

                double salarioNeto = salarioBruto - deduccionCCSS;

                Console.WriteLine();
                Console.WriteLine("========== RESULTADOS ==========");
                Console.WriteLine($"Cedula: {cedula}");
                Console.WriteLine($"Nombre de empleado: {nombre}");
                Console.WriteLine($"Tipo de empleado: {nombreTipoEmpleado}");
                Console.WriteLine($"Salario por hora: ${precioHora:n2}");
                Console.WriteLine($"Cantidad de horas: {horas}");
                Console.WriteLine($"Salario ordinario: ${salarioOrdinario:n2}");
                Console.WriteLine($"Aumento: ${aumento:n2}");
                Console.WriteLine($"Salario bruto: ${salarioBruto:n2}");
                Console.WriteLine($"Deduccion CCSS: ${deduccionCCSS:n2}");
                Console.WriteLine($"Salario neto: ${salarioNeto:n2}");
                Console.WriteLine("================================");

                Console.WriteLine();
                Console.WriteLine("¿Desea ingresar otro empleado? (s/n)");
                continuar = Console.ReadLine().ToLower();
            }
        }
    }
}