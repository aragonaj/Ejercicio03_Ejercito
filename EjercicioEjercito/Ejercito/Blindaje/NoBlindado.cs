﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito.Ejercito.Blindaje
{
    public class NoBlindado : IBlindaje
    {
        public string blindado()
        {
            //Console.WriteLine("0");
            return "0";
        }
    }
}
