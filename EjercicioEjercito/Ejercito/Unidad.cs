using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito.Ejercito
{
    // DECORATOR PATTERN
    public class superPiloto : IUnidad
    {
        IUnidad unidadSuperPiloto;
        public superPiloto(IUnidad unidad)
        {
            this.unidadSuperPiloto = unidad;
        }
        public double velocidad { get => (this.unidadSuperPiloto.velocidad *10) /100; set { } }
        public double potenciaFuego { get; set; }
        public double precio { get; set; }
        public double capacidadDestruccion { get; set; }
        public double capacidadMovimiento { get; set; }
    }
    public class movilidadDesierto : IUnidad
    {
        IUnidad unidadMovilidadDesierto;
        public movilidadDesierto(IUnidad unidad)
        {
            this.unidadMovilidadDesierto = unidad;
        }
        public double velocidad { get; set; }
        public double potenciaFuego { get; set; }
        public double precio { get; set; }
        public double capacidadDestruccion { get; set; }
        public double capacidadMovimiento { get => (this.unidadMovilidadDesierto.capacidadMovimiento *20) /100; set { } }
    }
    public class superBomba : IUnidad
    {
        IUnidad unidadSuperBomba;
        public superBomba(IUnidad unidad)
        {
            this.unidadSuperBomba = unidad;
        }
        public double velocidad { get; set; }
        public double potenciaFuego { get => this.unidadSuperBomba.potenciaFuego *10; set { } }
        public double precio { get; set; }
        public double capacidadDestruccion { get; set; }
        public double capacidadMovimiento { get; set; }
    }
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
