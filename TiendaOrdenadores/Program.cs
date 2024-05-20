// Creamos un ordenador base. 
// Precio 100 euros, RAM 10GB, Almacenamiento 100Gb

// RAMMaximaDecorator
// Precio 200 euros, RAM 100GB

// DiscoSolidoDecorator
// Precio base + 100, Almacenamiento base *2

// AVerSiCuelaDecorator
// Precio *2

using TiendaOrdenadores;
IOrdenador ordenadorBasico = new OrdenadorBase();
IOrdenador aumentarRAM = new RAMMaximaDecorador(ordenadorBasico);
IOrdenador aumentarAlmacenamientoInterno = new DiscoSolidoDecorador(ordenadorBasico);
IOrdenador aVerSiCuela = new AVerSiCuelaDecorador(ordenadorBasico);

IOrdenador ordenadorLuisa = new RAMMaximaDecorador(new DiscoSolidoDecorador(ordenadorBasico));
IOrdenador ordenadorGeronimo = new DiscoSolidoDecorador(new AVerSiCuelaDecorador(ordenadorBasico));

Console.WriteLine(ordenadorLuisa.mostrarDatos());
Console.WriteLine(ordenadorGeronimo.mostrarDatos());

