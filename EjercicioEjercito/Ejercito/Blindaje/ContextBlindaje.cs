﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito.Ejercito.Blindaje
{
    public class ContextBlindaje : IContextBlindaje
    {
        public IBlindaje blindaje { get; set; }

        public void Contexto(IBlindaje blindaje)
        {
            this.blindaje = blindaje;
        }

        public void Ejecutar()
        {
            this.blindaje.blindado();
        }
    }
}