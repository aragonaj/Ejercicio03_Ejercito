using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito.Ejercito.Movilidad
{
    public interface IContextMovilidad
    {
        public IMovilidad movilidad { get; set; }
        public IMovilidad EstablecerMovilidad(IMovilidad movilidad);
        public void Ejecutar();
    }
}
