using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito.Ejercito
{
    public interface IColeccionDivisiones
    {
        public void Add(IDivision division);
        void listarUnidades();
        double calcularPotenciaEjercito();
        double calcularBlindajeEjercito();
        double calcularCapacidadMovimientoEjercito();
        double calcularCapacidadMilitarEjercito();
        double calcularCostesEjercito();
        int mostrarNumeroUnidades();
    }
}
