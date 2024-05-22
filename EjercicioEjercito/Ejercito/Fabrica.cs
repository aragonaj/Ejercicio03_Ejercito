using EjercicioEjercito.Ejercito.Blindaje;
using EjercicioEjercito.Ejercito.Movilidad;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito.Ejercito
{
    public class Fabrica : IFabrica
    {
        public IValidador validador { get; set; }
        public IUnidad ingresarUnidad(
            EnumBlindajeTipo blindajeTipo, 
            EnumMovilidadTipo movilidadTipo, 
            double capacidadDestrucion = 0, 
            double capacidadMovimiento = 0, 
            double potenciaFuego = 0, 
            double precio = 0, 
            double velocidad = 0)
        {
            IUnidad unidad = new Unidad();
            switch (blindajeTipo){

            }
            switch (movilidadTipo)
            {

            }
            if (capacidadDestrucion != 0 && unidad != null)
                unidad.capacidadDestruccion = capacidadDestrucion;
            if (capacidadMovimiento != 0 && unidad != null)
                unidad.capacidadMovimiento = capacidadMovimiento;
            if (potenciaFuego != 0 && unidad != null)
                unidad.potenciaFuego = potenciaFuego;
            if (precio != 0 && unidad != null)
                unidad.precio = precio;
            if (velocidad != 0 && unidad != null)
                unidad.velocidad = velocidad;
            if (unidad != null)
            {
                if (validador.isValid(unidad))
                {
                    return unidad;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }// fin del else
        }// fin de ingresarUnidad
    }// fin de la clase
}
