using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito.Ejercito
{
    public class Validador01 : IValidador
    {
        public bool isValid(IDivision division)
        {
            return (division.blindaje > 0 &&
                division.capacidadDestruccion > 0 &&
                division.capacidadMovimiento > 0 &&
                division.nombreUnidad != null &&
                division.potenciaFuego > 0 &&
                division.precio > 0 &&
                division.velocidad > 0);
        }
    }
}
