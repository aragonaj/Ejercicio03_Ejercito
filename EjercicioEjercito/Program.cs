using EjercicioEjercito.Ejercito;

IValidador validador = new Validador01();
IFabrica fabrica = new Fabrica();
IDivision division = new Division();
IMenu menu = new Menu();
fabrica.validador = validador;
var entrada = "";

while (entrada.ToUpper() != "X")
{
    entrada = menu.MostrarOpciones();
    switch (entrada)
    {
        case "1": introducir(
            introducirCapacidadDestruccion(), 
            introducirCapacidadMovimiento(),
            introducirPotenciaFuego(), 
            introducirPrecio(), 
            introducirVelocidad());
            break;
    }// fin del switch
}// fin del while
void introducir(
    double capacidadDestruccion,
    double capacidadMovimiento, 
    double potenciaFuego, 
    double precio, 
    double velocidad)
{
    IUnidad unidad = fabrica.ingresarUnidad(
        capacidadDestruccion, 
        capacidadMovimiento, 
        potenciaFuego, 
        precio, 
        velocidad);
    if (unidad != null)
    {
        division.Add(unidad);
        Console.WriteLine($"La unidad fue creada");
    }// fin del if
    else
    {
        Console.WriteLine($"ERROR en la creación de la unidad");
    }// fin del else
}// fin de ingresar
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

