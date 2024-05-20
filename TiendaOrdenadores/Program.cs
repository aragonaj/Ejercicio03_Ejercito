// Creamos un ordenador base. 
// Precio 100 euros, RAM 10GB, Almacenamiento 100Gb

// RAMMaximaDecorator
// Precio 200 euros, RAM 100GB

// DiscoSolidoDecorator
// Precio base + 100, Almacenamiento base *2

// AVerSiCuelaDecorator
// Precio *2

using TiendaOrdenadores;
IFabrica fabricaOrdenadores = new Fabrica();
IOrdenador OrdenadorManolo = new OrdenadorBase();
IOrdenador OrdenadorAna = new OrdenadorBase();
IOrdenador OrdenadorLuisa = new OrdenadorBase();
IOrdenador OrdenadorGeronimo = new OrdenadorBase();

//OrdenadorAna(RAMMaximaDecorador);
//OrdenadorLuisa(RAMMaximaDecorador, DiscoSolidoDecorador);
//OrdenadorGeronimo(DiscoSolidoDecorador, AVerSiCuelaDecorador);
