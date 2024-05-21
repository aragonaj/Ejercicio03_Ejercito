using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito.Ejercito
{
    public class Division : IDivision, IUnidad
    {
        List<IUnidad> division = new();
        int numeroUnidades = 0;

        // IUnidad
        public IBlindaje blindaje { get; set; }
        public IMovimiento movimiento { get; set; }
        public double velocidad { get; set; }
        public double potenciaFuego { get; set; }
        public double precio { get; set; }
        public double capacidadDestruccion { get; set; }
        public double capacidadMovimiento { get; set; }
        // IDivision
        public void Add(IUnidad unidad)
        {
            division.Add(unidad);
            numeroUnidades++;
        }
        public int mostrarNumeroUnidades()
        {
            return numeroUnidades;
        }
    }// fin de la clase
}
