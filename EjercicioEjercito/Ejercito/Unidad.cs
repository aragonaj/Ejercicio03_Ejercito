using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito.Ejercito
{
    // DECORATOR PATTERN
    public class UnidadDecorador : IUnidad
    {
        IUnidad Base;
        public UnidadDecorador(IUnidad Base)
        {
            this.Base = Base;
        }// fin del constructor
        public double velocidad { get => this.Base.velocidad * 1.05; set { } }
        public double potenciaFuego { get; set; }
        public double precio { get; set; }
        public double capacidadDestruccion { get; set; }
        public double capacidadMovimiento { get; set; }
    }// fin de la clase
    // Fin del DECORATOR PATTERN
    public class Unidad : IUnidad
    {
        public double velocidad { get; set; }
        public double potenciaFuego { get; set; }
        public double precio { get; set; }
        public double capacidadDestruccion { get; set; }
        public double capacidadMovimiento { get; set; }
        public double evaluarCapacidadMilitar()
        {
            double capacidadMilitar = (potenciaFuego * capacidadMovimiento / 2) / (100);
            return capacidadMilitar;
        }
    }// fin de la clase
}
