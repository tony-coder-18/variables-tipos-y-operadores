// EJERCICIO 1
Console.WriteLine("Ingrese su nombre ");
string nombre = Console.ReadLine();
Console.WriteLine("Ingrese su apellido ");
string apellido = Console.ReadLine();
Console.WriteLine("Ingrese su edad ");
string edad = Console.ReadLine();

string mensaje = "Saludos.";

Console.WriteLine("Hola " + nombre + " " + apellido + ", tienes " + edad + " años. " + mensaje);

// EJERCICIO 2
//Coche
int numDoors = 4;
Console.WriteLine(numDoors);

int numWheels = 4;
Console.WriteLine(numWheels);

string brand = "Audi";
Console.WriteLine(brand);

int itvVigente = 123454321;
Console.WriteLine(itvVigente);

//Mesa
float weight = 23.4f;
Console.WriteLine(weight);

float large = 443.1f;

string material = "Wood";

string colour = "Brown";

// EJERCICIO 3
//a
int numero = 18;

if (numero >= 18)
    Console.WriteLine("El numero es mayor o igual a 18");

//b
char caracter = 'a';
if (caracter == 'a')
    Console.WriteLine("El char es 'a'");

//c
if (caracter == 'a' && numero >= 18)
    Console.WriteLine("Las dos condiciones son verdaderas");

//d
if (caracter == 'a' && numero < 18)
    Console.WriteLine("Las dos condiciones son verdaderas");
else
    Console.WriteLine("Solo una de las dos condiciones es verdadera");