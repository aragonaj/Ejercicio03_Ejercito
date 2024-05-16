using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desinsectaciones
{
    public class Gerente : ITrabajador
    {
        public double ingresoServicio { get; set; }
        public int numeroPeones { get; set; } = 0;
    }
}
