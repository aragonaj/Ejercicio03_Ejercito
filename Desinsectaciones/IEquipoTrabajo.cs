using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desinsectaciones
{
    public interface IEquipoTrabajo
    {
        int identificadorEquipoTrabajo { get; set; }
        public void Add(ITrabajador trabajador);
        double calcularTotalIngresosServicios();
        double calcularGastoEquipo();
    }
}
