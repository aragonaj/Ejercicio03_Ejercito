using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaOrdenadores
{
    public interface IOrdenador
    {
        double Precio { get; set; }
        int RAM { get; set; }
        int AlmacenamientoInterno { get; set; }
        string mostrarDatos();
    }
}
