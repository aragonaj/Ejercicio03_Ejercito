using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito.Ejercito
{
    public class Menu
    {
        string opcion = "";
        public void MuestraOpciones()
        {
            Console.WriteLine("CREACIÓN DE UNA DIVISIÓN: ");
            Console.WriteLine("1. ARTILLERÍA");
            Console.WriteLine("2. CABALLERÍA");
            Console.WriteLine("3. INFANTERÍA");
            Console.WriteLine();
            Console.WriteLine("X Salir");
        }
    }
}
