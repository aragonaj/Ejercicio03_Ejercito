using Desinsectaciones;
IValidadorTrabajador validadorTrabajador = new ValidadorTrabajador01();
IFabricaTrabajador fabricaTrabajador = new FabricaTrabajador01();
IEquipoTrabajo equipoTrabajo = new EquipoTrabajo();
IEntradaDatosTrabajador menuTrabajadores = new MenuTrabajadores();
fabricaTrabajador.validadorTrabajador = validadorTrabajador;
var entrada = "";
while (entrada.ToUpper() != "X")
{
    entrada = menuTrabajadores.mostrarOpciones();
    switch (entrada)
    {
        case "1":
            introducir(EnumTipoTrabajador.Gerente,
            introducirIngresoServicio()); break;
        case "2":
            introducirJefeEquipo(EnumTipoTrabajador.JefeEquipo,
            introducirIngresoServicio(), introducirNumeroPeones()); break;
        case "3":
            introducir(EnumTipoTrabajador.Peon,
            introducirIngresoServicio()); break;
        case "4": Console.WriteLine($"- Ingresos totales por servicios.........: {equipoTrabajo.calcularTotalIngresosServicios()}"); break;
        case "5": Console.WriteLine($"- Gasto total del equipo.................: {equipoTrabajo.calcularGastoEquipo()}"); break;
    }
}// fin del while
void introducir(EnumTipoTrabajador tipoTrabajador,
    double ingresoServicio)
{
    ITrabajador trabajador = fabricaTrabajador.ingresarTrabajador(tipoTrabajador, ingresoServicio);
    if (trabajador != null)
    {
        equipoTrabajo.Add(trabajador);
        Console.WriteLine($"Creado trabajador..................................: {tipoTrabajador.ToString()}");
    }// fin del if
    else
    {
        Console.WriteLine($"ERROR en la creación del trabajador");
    }// fin del else
}// fin de ingresar
void introducirJefeEquipo(EnumTipoTrabajador tipoTrabajador,
    double ingresoServicio, int numeroPeones)
{
    ITrabajador trabajador = fabricaTrabajador.ingresarTrabajador(tipoTrabajador, ingresoServicio, numeroPeones);
    if (trabajador != null)
    {
        equipoTrabajo.Add(trabajador);
        Console.WriteLine($"Creado trabajador..................................: {tipoTrabajador.ToString()}");
    }// fin del if
    else
    {
        Console.WriteLine($"ERROR en la creación del trabajador");
    }
}// fin de ingresarJefeEquipo
double introducirIngresoServicio()
{
    Console.WriteLine("Introduzca ingreso por el servicio: ");
    return Double.Parse(Console.ReadLine());
}
int introducirNumeroPeones()
{
    Console.WriteLine("Introduzca el número de peones: ");
    return Int32.Parse(Console.ReadLine());
}

