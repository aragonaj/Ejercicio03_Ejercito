using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito.Ejercito
{
    public class Menu : IMenu
    {
        public string mostrarOpciones()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("CREACIÓN DE UNA DIVISIÓN: ");
            Console.WriteLine("1. CREAR UNIDAD........................:");
            Console.WriteLine();
            Console.WriteLine("CONSULTA DE ESTADÍSTICAS: ");
            Console.WriteLine("2. CAPACIDAD MILITAR TOTAL DEL EJÉRCITO:");
            Console.WriteLine();
            Console.WriteLine("X Salir");
            Console.WriteLine("----------------------------------------");
            return Console.ReadLine();
        }
        public string mostrarBlindajes()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("TIPOS DE BLINDAJES: ");
            Console.WriteLine();
            Console.WriteLine("1. Sin blindaje..........:");
            Console.WriteLine("2. Blindaje ligero.......:");
            Console.WriteLine("3. Blindaje pesado.......:");
            Console.WriteLine("4. Blindaje contrachapado:");
            Console.WriteLine();
            Console.WriteLine("X Salir");
            Console.WriteLine("----------------------------------------");
            return Console.ReadLine();
        }
        public string mostrarMovilidad()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("TIPOS DE MOVILIDAD: ");
            Console.WriteLine();
            Console.WriteLine("1. En reposo.......:");
            Console.WriteLine("2. A pie...........:");
            Console.WriteLine("3. A tracción oruga:");
            Console.WriteLine("4. Con ruedas......:");
            Console.WriteLine();
            Console.WriteLine("X Salir");
            Console.WriteLine("----------------------------------------");
            return Console.ReadLine();
        }
    }
}
