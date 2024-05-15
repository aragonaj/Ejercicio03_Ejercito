using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito.Ejercito
{
    public interface IDivision
    {
        string nombreUnidad { get; set; }
        double velocidad { get; set; }
        double blindaje { get; set; }
        double potenciaFuego { get; set; }
        double precio { get; set; }
        double capacidadDestruccion { get; set; }
        double capacidadMovimiento { get; set; }

        double evaluarCapacidadMilitar();
    }
}
