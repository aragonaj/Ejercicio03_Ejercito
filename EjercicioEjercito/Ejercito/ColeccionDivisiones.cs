using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito.Ejercito
{
    public class ColeccionDivisiones : IColeccionDivisiones
    {
        // PROPIEDADES
        List<IDivision> divisiones = new List<IDivision>();
        int numeroDivisiones = 0;
        double totalPrecioEjercito = 0;
        double totalBlindajeEjercito = 0;
        double totalPotenciaEjercito = 0;
        // FUNCIONES
        public void Add(IDivision division)
        {
            divisiones.Add(division);
            numeroDivisiones++;
            totalPrecioEjercito += division.precio;
            totalBlindajeEjercito += division.blindaje;
            totalPotenciaEjercito += division.potenciaFuego;
        }
        public double calcularBlindajeEjercito()
        {
            return totalBlindajeEjercito;
        }
        public double calcularCapacidadMilitarEjercito()
        {
            throw new NotImplementedException();
        }
        public double calcularCapacidadMovimientoEjercito()
        {
            throw new NotImplementedException();
        }
        public double calcularCostesEjercito()
        {
            return totalPrecioEjercito;
        }
        public double calcularPotenciaEjercito()
        {
            return totalPotenciaEjercito;
        }
        public void ListarDivisiones()
        {
            foreach (var item in divisiones)
            {
                Console.WriteLine(item);
            }// fin del foreach
        }// fin de ListarDivisiones
    }// fin de la clase
}
