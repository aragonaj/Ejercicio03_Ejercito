using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito.Ejercito
{
    public class Menu : IMenu
    {
        public string MostrarOpciones()
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
    }
}
