//CLASE#6
static void saludar(String nomsal)
{
    Console.WriteLine($"un gran saludo a {nomsal}");
}

static int calculo_año_nacimiento(int edad)
{
    int añon = 2023 - edad;
    return añon;
}

//String nombre;
//int edad;

//Console.WriteLine("Como te llamas?");
//nombre = Console.ReadLine();
//saludar(nombre);

//Console.WriteLine($"Hola, gusto de saludarte {nombre}");
//Console.WriteLine("cuantos años tienes?");
//edad = Convert.ToInt32(Console.ReadLine());


//Console.WriteLine($"Bonita edad: {edad} \n naciste en {calculo_año_nacimiento}");

static void marque(String palabra)
{
    int longitud = palabra.Length;
    
    for (int c = longitud-1; c >= 0; c--)
    {
        Console.SetCursorPosition(5+c, 10);
        Console.WriteLine(palabra[c]);
        Thread.Sleep(1000);
    }
}
String palabra;
palabra = "maria";
marque(palabra);
bool esPalindromo = palindromo("Oso");

if (esPalindromo)
{
    Console.WriteLine("Es palindromo");
}
else
{
    Console.WriteLine("nel");
}


static bool palindromo(String palabra)
{
    int longitud = palabra.Length;

    string pal = "";
    for (int c = longitud -1; c >= 0; c--)
    {
        pal = pal + palabra[c].ToString().ToUpper();
    }
    if (palabra.ToUpper().Equals(pal))
    {
        return true;
    }
    return false;
}



