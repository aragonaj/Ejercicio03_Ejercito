using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desinsectaciones
{
    public interface IValidadorTrabajador
    {
        bool isValid(ITrabajador trabajador);
    }
}
