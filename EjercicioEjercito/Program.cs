using EjercicioEjercito.Ejercito;
using EjercicioEjercito.Ejercito.Blindaje;
using EjercicioEjercito.Ejercito.Movilidad;

IValidador validador = new Validador01();
IFabrica fabrica = new Fabrica();
IDivision division = new Division();
IMenu menu = new Menu();
fabrica.validador = validador;
var entrada = "";
var entradaBlindaje = "";
var entradaMovilidad = "";

while (entrada.ToUpper() != "X")
{
    entrada = menu.mostrarOpciones();
    switch (entrada)
    {
        case "1":
            introducir(
            introducirBlindaje(),
            introducirMovilidad(),
            introducirCapacidadDestruccion(),
            introducirCapacidadMovimiento(),
            introducirPotenciaFuego(),
            introducirPrecio(),
            introducirVelocidad());
            break;
    }// fin del switch
}// fin del while
void introducir(
    IBlindaje blindaje,
    IMovilidad movilidad,
    double capacidadDestruccion,
    double capacidadMovimiento, 
    double potenciaFuego, 
    double precio, 
    double velocidad)
{
    IUnidad unidad = fabrica.ingresarUnidad(
        blindaje,
        movilidad,
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
string introducirBlindaje()
{
    entradaBlindaje = menu.mostrarBlindajes();
    IContextBlindaje contextBlindaje = new ContextBlindaje();
    
    IBlindaje noBlindado = new NoBlindado();
    IBlindaje blindajeLigero = new BlindajeLigero();
    IBlindaje blindajePesado = new BlindajePesado();
    IBlindaje blindajeContrachapado = new BlindajeContrachapado();

    switch (entradaBlindaje)
    {
        case "1":
            contextBlindaje.EstablecerBlindaje(noBlindado);
            return contextBlindaje.Ejecutar();
            break;
        case "2":
            contextBlindaje.EstablecerBlindaje(blindajeLigero);
            return contextBlindaje.Ejecutar();
            break;
        case "3":
            contextBlindaje.EstablecerBlindaje(blindajePesado);
            return contextBlindaje.Ejecutar();
            break;
        case "4":
            contextBlindaje.EstablecerBlindaje(blindajeContrachapado);
            return contextBlindaje.Ejecutar();
            break;
        default: return null;
    }// fin del switch
}
string introducirMovilidad()
{
    IMovilidad enReposo = new EnReposo();
    IMovilidad aPie = new APie();
    IMovilidad aTraccionOruga = new ATraccionOruga();
    IMovilidad conRuedas = new ConRuedas();
    IContextMovilidad contextMovilidad = new ContextMovilidad();
    entradaMovilidad = menu.mostrarMovilidad();
    switch (entradaMovilidad)
    {
        case "1":
            contextMovilidad.EstablecerMovilidad(enReposo);
            return contextMovilidad.Ejecutar();
            break;
        case "2":
            contextMovilidad.EstablecerMovilidad(aPie);
            return contextMovilidad.Ejecutar();
            break;
        case "3":
            contextMovilidad.EstablecerMovilidad(aTraccionOruga);
            return contextMovilidad.Ejecutar();
            break;
        case "4":
            contextMovilidad.EstablecerMovilidad(conRuedas);
            return contextMovilidad.Ejecutar();
            break;
        default: return null;
    }// fin del switch
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

