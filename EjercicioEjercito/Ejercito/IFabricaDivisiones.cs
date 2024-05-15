using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito.Ejercito
{
    public interface IFabricaDivisiones
    {
        IValidador validador { get; set; }
        IDivision ingresarDivision(EnumTipoDivision tipo, double blindaje = 0, double capacidadDestrucion = 0,
            double capacidadMovimiento = 0, string nombreUnidad = "", double potenciaFuego = 0, 
            double precio = 0, double velocidad = 0);
    }
}
