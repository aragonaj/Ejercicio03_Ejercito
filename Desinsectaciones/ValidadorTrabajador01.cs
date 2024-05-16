using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desinsectaciones
{
    public class ValidadorTrabajador01 : IValidadorTrabajador
    {
        public bool isValid(ITrabajador trabajador)
        {
            return trabajador.ingresoServicio < 50;
        }
    }
}
