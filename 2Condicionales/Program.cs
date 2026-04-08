// Condicionales y operadores

int edadPersona1 = 56;

int  edadPersona2 = 75;



if(edadPersona1 < edadPersona2)
{
    Console.WriteLine("Si es verdad");
}

string sexoPersona1 = "hombre";

if (edadPersona1 > edadPersona2  || sexoPersona1 == "hombre")
{
    Console.WriteLine("Es la onda");
    
}

bool usuarioAlta = true;

if (usuarioAlta)
{
    Console.WriteLine("Si es alta");
}

Console.WriteLine("switch");

string nacionalidad = "español";

if (nacionalidad == "mexicano")
{
    Console.WriteLine("Es mexicano");
}


switch (nacionalidad)
{
    case "uruguayo":
    Console.WriteLine("Es uruguayo");
    break;

    case "mexicano":
    Console.WriteLine("Es mexicano");
    break;
    default:
    Console.WriteLine("Sin nacionalidad");
    break;
}