using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito.Ejercito.Movilidad
{
    public class ContextMovilidad : IContextMovilidad
    {
        public IMovilidad movilidad { get; set; }

        public IMovilidad EstablecerMovilidad(IMovilidad movilidad)
        {
            return this.movilidad = movilidad;
        }
        public void Ejecutar()
        {
            this.movilidad.enMovimiento();
        }
    }
}
