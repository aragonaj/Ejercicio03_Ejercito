﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desinsectaciones
{
    public interface IValidadorEquipoTrabajo
    {
        bool isValid(IEquipoTrabajo equipoTrabajo);
    }
}
