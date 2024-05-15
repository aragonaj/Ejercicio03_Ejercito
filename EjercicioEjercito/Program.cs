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

    }
}// fin del while
Console.WriteLine($"Total costo de las divisiones: {coleccion.calcularCostesEjercito()}");
Console.WriteLine($"Total blindaje de la división: {coleccion.calcularBlindajeEjercito()}");
Console.WriteLine($"Total potencia de fuego de la división: {coleccion.calcularPotenciaEjercito()}");
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
    Console.WriteLine("CREACIÓN DE UNA DIVISIÓN: ");
    Console.WriteLine("1. ARTILLERÍA");
    Console.WriteLine("2. CABALLERÍA");
    Console.WriteLine("3. INFANTERÍA");
    Console.WriteLine();
    Console.WriteLine("X Salir");
    return Console.ReadLine();
}
