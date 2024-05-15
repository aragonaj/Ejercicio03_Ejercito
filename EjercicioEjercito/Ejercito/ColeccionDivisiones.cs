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
        int numeroUnidades = 0;
        double totalPrecioEjercito = 0;
        double totalBlindajeEjercito = 0;
        double totalPotenciaEjercito = 0;
        double totalCapacidadMilitar = 0;
        double totalCapacidadMovimiento = 0;
        // FUNCIONES
        public void Add(IDivision division)
        {
            divisiones.Add(division);
            numeroUnidades++;
            totalPrecioEjercito += division.precio;
            totalBlindajeEjercito += division.blindaje;
            totalPotenciaEjercito += division.potenciaFuego;
            totalCapacidadMovimiento += division.capacidadMovimiento;
            totalCapacidadMilitar += division.evaluarCapacidadMilitar();
        }
        public double calcularBlindajeEjercito()
        {
            return totalBlindajeEjercito;
        }
        public double calcularCapacidadMilitarEjercito()
        {
            return totalCapacidadMilitar;
        }
        public double calcularCapacidadMovimientoEjercito()
        {
            return totalCapacidadMovimiento;
        }
        public double calcularCostesEjercito()
        {
            return totalPrecioEjercito;
        }
        public double calcularPotenciaEjercito()
        {
            return totalPotenciaEjercito;
        }
        public int mostrarNumeroUnidades()
        {
            return numeroUnidades;
        }
        public void listarDivisiones()
        {
            for (var unidad = 0; unidad < divisiones.Count; unidad++)
            {
                Console.WriteLine(divisiones[unidad].nombreUnidad);
            }// fin del for
        }// fin de listarDivisiones
    }// fin de la clase
}
