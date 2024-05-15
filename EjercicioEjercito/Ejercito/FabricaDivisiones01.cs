using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEjercito.Ejercito
{
    public class FabricaDivisiones01 : IFabricaDivisiones
    {
        public IValidador validador { get; set; }
        public IDivision ingresarDivision(EnumTipoDivision tipo, double blindaje = 0, 
            double capacidadDestrucion = 0, double capacidadMovimiento = 0, 
            string nombreUnidad = "", double potenciaFuego = 0, 
            double precio = 0, double velocidad = 0)
        {
            IDivision division = null;
            switch (tipo)
            {
                case EnumTipoDivision.Artilleria: division = new Artilleria(); break;
                case EnumTipoDivision.Caballeria: division = new Caballeria(); break;
                case EnumTipoDivision.Infanteria: division = new Infanteria(); break;
            }// fin del switch
            if (blindaje != 0 && division != null)
                division.blindaje = blindaje;
            if (capacidadDestrucion != 0 && division != null)
                division.capacidadDestruccion = capacidadDestrucion;
            if (capacidadMovimiento != 0 && division != null)
                division.capacidadMovimiento = capacidadMovimiento;
            if (nombreUnidad != "" && division != null)
                division.nombreUnidad = nombreUnidad;
            if (potenciaFuego != 0 && division != null)
                division.potenciaFuego = potenciaFuego;
            if (precio != 0 && division != null)
                division.precio = precio;
            if (velocidad != 0 && division != null)
                division.velocidad = velocidad;
            if (division != null)
            {
                if (validador.isValid(division))
                {
                    return division;
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
        }// fin de ingresarDivision
    }// fin de la clase
}
