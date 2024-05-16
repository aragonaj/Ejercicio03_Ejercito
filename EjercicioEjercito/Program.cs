using EjercicioEjercito;
using EjercicioEjercito.Ejercito;
IValidador validador = new Validador01();
IFabricaDivisiones fabrica = new FabricaDivisiones01(); 
fabrica.validador = validador;
IColeccionDivisiones coleccion = new ColeccionDivisiones();
var entrada = "";
while (entrada.ToUpper() != "X")
{
    entrada = MostrarOpciones();
    switch (entrada)
    {
        case "1": introducir(EnumTipoDivision.Artilleria, 
            introducirBlindaje(), introducirCapacidadDestruccion(), introducirCapacidadMovimiento(),
            introducirNombreUnidad(), introducirPotenciaFuego(), introducirPrecio(), introducirVelocidad()); break;
        case "2": introducir(EnumTipoDivision.Caballeria, 
            introducirBlindaje(), introducirCapacidadDestruccion(), introducirCapacidadMovimiento(),
            introducirNombreUnidad(), introducirPotenciaFuego(), introducirPrecio(), introducirVelocidad()); break;
        case "3": introducir(EnumTipoDivision.Infanteria,
            introducirBlindaje(), introducirCapacidadDestruccion(), introducirCapacidadMovimiento(),
            introducirNombreUnidad(), introducirPotenciaFuego(), introducirPrecio(), introducirVelocidad()); break;
        case "4": Console.WriteLine($"Total costo de las divisiones..........: {coleccion.calcularCostesEjercito()}"); break;
        case "5": Console.WriteLine($"Total blindaje de la división..........: {coleccion.calcularBlindajeEjercito()}"); break;
        case "6": Console.WriteLine($"Total potencia de fuego del ejército...: {coleccion.calcularPotenciaEjercito()}"); break;
        case "7": Console.WriteLine($"Total capacidad militar del ejército...: {coleccion.calcularCapacidadMilitarEjercito()}"); break;
        case "8": Console.WriteLine($"Total capacidad movimiento del ejército: {coleccion.calcularCapacidadMovimientoEjercito()}"); break;
        case "9": Console.WriteLine($"Total número de unidades del ejército..: {coleccion.mostrarNumeroUnidades()}"); break;
        case "10": coleccion.listarUnidades(); break;

    }
}// fin del while
void introducir(EnumTipoDivision tipo, double blindaje, double capacidadDestruccion,
    double capacidadMovimiento, string nombreUnidad, double potenciaFuego, 
    double precio, double velocidad)
{
    IDivision division = fabrica.ingresarDivision(tipo, blindaje, capacidadDestruccion, 
        capacidadMovimiento, nombreUnidad, potenciaFuego, precio, velocidad);
    if (division != null)
    {
        coleccion.Add(division);
        Console.WriteLine($"Creada división {tipo.ToString()}");
    }// fin del if
    else
    {
        Console.WriteLine($"ERROR en la creación de la división");
    }// fin del else
}// fin de ingresar
double introducirBlindaje()
{
    Console.WriteLine("Introduzca blindaje: ");
    return Double.Parse(Console.ReadLine());
}
double introducirCapacidadDestruccion()
{
    Console.WriteLine("Introduzca la capacidad de destrucción: ");
    return Double.Parse(Console.ReadLine());
}
double introducirCapacidadMovimiento()
{
    Console.WriteLine("Introduzca la capacidad de movimiento: ");
    return Double.Parse(Console.ReadLine());
}
string introducirNombreUnidad()
{
    Console.WriteLine("Introduzca el nombre de la unidad: ");
    return Console.ReadLine();
}
double introducirPotenciaFuego()
{
    Console.WriteLine("Introduzca la potencia de fuego: ");
    return Double.Parse(Console.ReadLine());
}
double introducirPrecio()
{
    Console.WriteLine("Introduzca el precio de la unidad: ");
    return Double.Parse(Console.ReadLine());
}
double introducirVelocidad()
{
    Console.WriteLine("Introduzca la velocidad: ");
    return Double.Parse(Console.ReadLine());
}
string MostrarOpciones()
{
    Console.WriteLine("----------------------------------");
    Console.WriteLine("CREACIÓN DE UNA DIVISIÓN: ");
    Console.WriteLine("1. ARTILLERÍA....................:");
    Console.WriteLine("2. CABALLERÍA....................:");
    Console.WriteLine("3. INFANTERÍA....................:");
    Console.WriteLine();
    Console.WriteLine("CONSULTA DE ESTADÍSTICAS: ");
    Console.WriteLine("4. COSTO TOTAL DE LAS UNIDADES...:");
    Console.WriteLine("5. BLINDAJE TOTAL................:");
    Console.WriteLine("6. POTENCIA DE FUEGO TOTAL.......:");
    Console.WriteLine("7. CAPACIDAD MILITAR DEL EJÉRCITO:");
    Console.WriteLine("8. CAPACIDAD DE MOVIMIENTO TOTAL:");
    Console.WriteLine("9. NÚMERO TOTAL DE UNIDADES......:");
    Console.WriteLine("10. LISTADO DE UNIDADES..........:");
    Console.WriteLine();
    Console.WriteLine("X Salir");
    Console.WriteLine("----------------------------------");
    return Console.ReadLine();
}
