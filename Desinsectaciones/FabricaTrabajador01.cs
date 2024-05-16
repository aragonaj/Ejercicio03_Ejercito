using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desinsectaciones
{
    public class FabricaTrabajador01 : IFabricaTrabajador
    {
        public IValidadorTrabajador validadorTrabajador {  get; set; }
        public ITrabajador ingresarTrabajador(EnumTipoTrabajador tipoTrabajador,
            double ingresoServicio = 0, int numeroPeones = 0)
        {
            ITrabajador trabajador = null;
            switch (tipoTrabajador)
            {
                case EnumTipoTrabajador.Gerente: trabajador = new Gerente(); break;
                case EnumTipoTrabajador.JefeEquipo: trabajador = new JefeEquipo(); break;
                case EnumTipoTrabajador.Peon: trabajador = new Peon(); break;
            }
            if (ingresoServicio != 0 && trabajador != null)
                trabajador.ingresoServicio = ingresoServicio;
            if (numeroPeones != 0 && trabajador != null)
                trabajador.numeroPeones = numeroPeones;
            if (trabajador != null)
            {
                if (validadorTrabajador.isValid(trabajador))
                {
                    return trabajador;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
