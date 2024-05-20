using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaOrdenadores
{
    // DECORADORES
    public class RAMMaximaDecorador : IOrdenador
    {
        IOrdenador _ordenador;
        public RAMMaximaDecorador(IOrdenador ordenador)
        {
            _ordenador = ordenador;
        }
        public double Precio { get => this._ordenador.Precio = 200; set { } }
        public int RAM { get => this._ordenador.RAM = 100; set {} }
        public int AlmacenamientoInterno { get; set; }
    }// fin de la clase
    public class DiscoSolidoDecorador : IOrdenador
    {
        IOrdenador _ordenador;
        public DiscoSolidoDecorador(IOrdenador ordenador)
        {
            _ordenador = ordenador;
        }
        public double Precio { get => this._ordenador.Precio +100; set { } }
        public int RAM { get; set; }
        public int AlmacenamientoInterno { get => this._ordenador.AlmacenamientoInterno *2; set { } }
    }// Fin de la clase
    public class AVerSiCuelaDecorador : IOrdenador
    {
        public IOrdenador _ordenador;
        public AVerSiCuelaDecorador(IOrdenador ordenador)
        {
            _ordenador = ordenador;
        }
        public double Precio { get => this._ordenador.Precio *2; set { } }
        public int RAM { get; set; }
        public int AlmacenamientoInterno { get; set; }
    }
    // Fin de los DECORADORES
    public class OrdenadorBase : IOrdenador
    {
        public double Precio { get; set; } = 100;
        public int RAM { get; set; } = 10;
        public int AlmacenamientoInterno { get; set; } = 100;
    }
}
