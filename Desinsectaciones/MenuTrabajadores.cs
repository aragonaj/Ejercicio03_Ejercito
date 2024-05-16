using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desinsectaciones
{
    public class MenuTrabajadores : IEntradaDatosTrabajador
    {
        public string mostrarOpciones()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
            Console.WriteLine("-- CREACIÓN DE UN TRABAJADOR");
            Console.WriteLine("1. GERENTE.......................:");
            Console.WriteLine("2. JEFE DE EQUIPO................:");
            Console.WriteLine("3. PEÓN..........................:");
            Console.WriteLine();
            Console.WriteLine("-- CONSULTA DE ESTADÍSTICAS");
            Console.WriteLine("4. INGRESOS TOTALES POR SERVICIOS:");
            Console.WriteLine("5. GASTO TOTAL DEL EQUIPO........:");
            Console.WriteLine();
            Console.WriteLine("X Salir");
            Console.WriteLine("----------------------------------");
            return Console.ReadLine();
        }
    }
}
