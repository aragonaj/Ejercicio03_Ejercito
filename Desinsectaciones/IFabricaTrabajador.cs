using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desinsectaciones
{
    public interface IFabricaTrabajador
    {
        IValidadorTrabajador validadorTrabajador {  get; set; }
        ITrabajador ingresarTrabajador(EnumTipoTrabajador tipoTrabajador,
            double ingresoServicio = 0, int numeroPeones = 0);
    }
}
