// See https://aka.ms/new-console-template for more information

/*
string cadena = "Esto es una cadena";
Console.WriteLine(cadena);

cadena = string.Empty;
Console.WriteLine(cadena);


Console.WriteLine("Escriba su nombre por consola");

string tuNombre = Console.ReadLine()!;

Console.WriteLine("Tu nombre es: " + tuNombre);

Console.WriteLine("Escribe tu edad");
string entradaEdad = Console.ReadLine()!;
int edad = Convert.ToInt32(entradaEdad);
Console.WriteLine("Tu edad es : " + edad + 
" y tu nombre es: " + tuNombre);

//Diferentes tipos de concatenación con string
string nombre = "Edgar";
string apellido = "Juárez";


Console.WriteLine(nombre +" "+ apellido);
Console.WriteLine($"Nombre: {nombre}, apellido: {apellido}");
Console.WriteLine("Nombre {0}, apellido {1}", nombre, apellido);

*/

Console.WriteLine("------Números-------");

int numero1= 23;
int numero2 = 10;
int resultado = numero1 + numero2;


Console.WriteLine(resultado);
Console.WriteLine("resultado: " + Convert.ToInt32(numero1 + numero2));

Console.WriteLine(numero1 - numero2);
Console.WriteLine(numero1 / numero2);
Console.WriteLine(numero1 * numero2);

Console.WriteLine("**********Decimales****");

float f = 1f /3f; 

//ejejmplo a los float hay que ponerles una f al final
 float sueldo = 1220.50f;
 Console.WriteLine(sueldo);
