using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito.Ejercito.Blindaje
{
    public interface IContextBlindaje
    {
        public IBlindaje blindaje { get; set; }
        public IBlindaje EstablecerBlindaje(IBlindaje blindaje);
        public void Ejecutar();
    }
}
