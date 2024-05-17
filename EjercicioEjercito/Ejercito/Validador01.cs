using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito.Ejercito
{
    public class Validador01 : IValidador
    {
        public bool isValid(IUnidad unidad)
        {
            return (
                unidad.capacidadDestruccion > 0 &&
                unidad.capacidadMovimiento > 0 &&
                unidad.potenciaFuego > 0 &&
                unidad.precio > 0 &&
                unidad.velocidad > 0);
        }
    }
}
