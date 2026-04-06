// See https://aka.ms/new-console-template for more information
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
Console.WriteLine("Tu edad es : " + entradaEdad + 
" y tu nombre es: " + tuNombre);