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
        IOrdenador OrdenadorBase;

        public RAMMaximaDecorador(IOrdenador ordenador)
        {
            OrdenadorBase = ordenador;
        }
        public double Precio { get => this.OrdenadorBase.Precio =200; set { } }
        public int RAM { get => this.OrdenadorBase.RAM = 100; set {} }
        public int AlmacenamientoInterno { get; set; } = 100;
        public string mostrarDatos()
        {
            return $"Precio: {this.Precio}, RAM: {this.RAM}, Almacenamiento interno: {this.AlmacenamientoInterno}";
        }
    }// fin de la clase
    public class DiscoSolidoDecorador : IOrdenador
    {
        IOrdenador OrdenadorBase;
        public DiscoSolidoDecorador(IOrdenador ordenador)
        {
            OrdenadorBase = ordenador;
        }
        public double Precio { get => this.OrdenadorBase.Precio +100; set { } }
        public int RAM { get; set; } = 10;
        public int AlmacenamientoInterno { get => this.OrdenadorBase.AlmacenamientoInterno *2; set { } }
        public string mostrarDatos()
        {
            return $"Precio: {this.Precio}, RAM: {this.RAM}, Almacenamiento interno: {this.AlmacenamientoInterno}";
        }
    }// Fin de la clase
    public class AVerSiCuelaDecorador : IOrdenador
    {
        public IOrdenador OrdenadorBase;
        public AVerSiCuelaDecorador(IOrdenador ordenador)
        {
            OrdenadorBase = ordenador;
        }
        public double Precio { get => this.OrdenadorBase.Precio *2; set { } }
        public int RAM { get; set; } = 10;
        public int AlmacenamientoInterno { get; set; } = 100;
        public string mostrarDatos()
        {
            return $"Precio: {this.Precio}, RAM: {this.RAM}, Almacenamiento interno: {this.AlmacenamientoInterno}";
        }
    }
    // Fin de los DECORADORES
    public class OrdenadorBase : IOrdenador
    {
        public double Precio { get; set; } = 100;
        public int RAM { get; set; } = 10;
        public int AlmacenamientoInterno { get; set; } = 100;
        public string mostrarDatos()
        {
            return $"Precio: {Precio}, RAM: {RAM}, Almacenamiento interno: {AlmacenamientoInterno}";
        }
    }
}
