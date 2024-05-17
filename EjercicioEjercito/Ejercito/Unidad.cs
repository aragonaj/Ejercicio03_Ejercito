using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito.Ejercito
{
    public class Unidad : IUnidad
    {
        public string nombreUnidad { get; set; }
        public double velocidad { get; set; }
        public double blindaje { get; set; }
        public double potenciaFuego { get; set; }
        public double precio { get; set; }
        public double capacidadDestruccion { get; set; }
        public double capacidadMovimiento { get; set; }
        public double evaluarCapacidadMilitar()
        {
            double capacidadMilitar = (potenciaFuego * capacidadMovimiento / 2) / (100 - blindaje);
            return capacidadMilitar;
        }
    }
}
