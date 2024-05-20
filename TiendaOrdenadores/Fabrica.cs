using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaOrdenadores
{
    public class Fabrica : IFabrica
    {
        public IOrdenador ingresarOrdenador(double Precio, int RAM, int AlmacenamientoInterno)
        {
            IOrdenador ordenadorBase = new OrdenadorBase();
            return ordenadorBase;
        }
    }
}
