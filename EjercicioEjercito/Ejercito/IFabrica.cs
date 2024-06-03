using EjercicioEjercito.Ejercito.Blindaje;
using EjercicioEjercito.Ejercito.Movilidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito.Ejercito
{
    public interface IFabrica
    {
        IValidador validador { get; set; }
        IUnidad ingresarUnidad(
            EnumBlindajeTipo blindaje,
            EnumMovilidadTipo movilidad,
            double capacidadDestrucion = 0,
            double capacidadMovimiento = 0, 
            double potenciaFuego = 0, 
            double precio = 0, 
            double velocidad = 0);
    }
}
