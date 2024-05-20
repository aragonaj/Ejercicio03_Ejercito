using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaOrdenadores
{
    public interface IFabrica
    {
        public IOrdenador ingresarOrdenador(double Precio, int RAM, int AlmacenamientoInterno);
    }
}
