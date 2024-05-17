using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desinsectaciones
{
    public class EquipoTrabajo : IEquipoTrabajo
    {
        List<ITrabajador> trabajadores = new List<ITrabajador>();
        public int identificadorEquipoTrabajo { get; set; }
        int numeroTrabajadores = 0;
        double totalIngresosServicios = 0;
        public void Add(ITrabajador trabajador)
        {
            trabajadores.Add(trabajador);
            numeroTrabajadores++;
            totalIngresosServicios += trabajador.ingresoServicio;
        }
        public double calcularTotalIngresosServicios()
        {
            return totalIngresosServicios;
        }
        public double calcularGastoEquipo()
        {
            return totalIngresosServicios + (20 * totalIngresosServicios / 100);
        }
    }
}
