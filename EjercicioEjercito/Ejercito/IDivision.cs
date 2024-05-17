using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito.Ejercito
{
    public interface IDivision
    {
        public void Add(IUnidad unidad);
        int mostrarNumeroUnidades();
    }
}
