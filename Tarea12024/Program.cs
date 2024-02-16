using System;

class Program
{
    static void Main(string[] args)
    {
        // Convertir un numero entero a decimal
        Console.WriteLine("Ingrese un número entero:");
        int numeroEntero = Convert.ToInt32(Console.ReadLine());
        decimal numeroDecimal = Convert.ToDecimal(numeroEntero);
        Console.WriteLine($"El número entero {numeroEntero} convertido a decimal es: {numeroDecimal}");
        Console.ReadLine();

        // Convertir un número decimal a flotante
        Console.WriteLine("Ingrese un número decimal:");
        decimal numeroDecimal2 = Convert.ToDecimal(Console.ReadLine());
        float numeroFlotante = Convert.ToSingle(numeroDecimal2);
        Console.WriteLine($"Número decimal {numeroDecimal2} convertido a flotante: {numeroFlotante}");

        // Convertir un número flotante a entero
        Console.WriteLine("Ingrese un número flotante:");
        float numeroFlotante2 = Convert.ToSingle(Console.ReadLine());
        int numeroEntero2 = Convert.ToInt32(numeroFlotante2);
        Console.WriteLine($"Número flotante {numeroFlotante2} convertido a entero: {numeroEntero2}");

        // Convertir un caracter a entero
        Console.WriteLine("Ingrese un caracter:");
        char caracter = Console.ReadLine()[0];
        int valorCaracter = Convert.ToInt32(caracter);
        Console.WriteLine($"Carácter '{caracter}' convertido a entero: {valorCaracter}");

        // Convertir un entero a caracter
        Console.WriteLine("Ingrese un entero:");
        int numeroEntero3 = Convert.ToInt32(Console.ReadLine());
        char caracter2 = Convert.ToChar(numeroEntero3);
        Console.WriteLine($"Entero {numeroEntero3} convertido a caracter: {caracter2}");

        Console.ReadLine();

        // Calcular la suma de dos números enteros
        Console.WriteLine("Ingrese el primer número entero:");
        int numEntero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número entero:");
        int numEntero2 = Convert.ToInt32(Console.ReadLine());
        int sumaEnteros = numEntero1 + numEntero2;
        Console.WriteLine($"La suma de {numEntero1} y {numEntero2} es: {sumaEnteros}");

        // Calcular la resta de dos números decimales
        Console.WriteLine("Ingrese el primer número decimal:");
        decimal numDecimal1 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número decimal:");
        decimal numDecimal2 = Convert.ToDecimal(Console.ReadLine());
        decimal restaDecimales = numDecimal1 - numDecimal2;
        Console.WriteLine($"La resta de {numDecimal1} y {numDecimal2} es: {restaDecimales}");

        // Calcular la multiplicación de dos números flotantes
        Console.WriteLine("Ingrese el primer número flotante:");
        float numFlotante1 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número flotante:");
        float numFlotante2 = Convert.ToSingle(Console.ReadLine());
        float multiplicacionFlotantes = numFlotante1 * numFlotante2;
        Console.WriteLine($"La multiplicación de {numFlotante1} y {numFlotante2} es: {multiplicacionFlotantes}");

        // Calcular la división de dos números enteros
        Console.WriteLine("Ingrese el dividendo (número entero):");
        int dividendo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el divisor (número entero diferente de 0):");
        int divisor = Convert.ToInt32(Console.ReadLine());
        if (divisor != 0)
        {
            int divisionEnteros = dividendo / divisor;
            Console.WriteLine($"La división de {dividendo} entre {divisor} es: {divisionEnteros}");
        }
        else
        {
            Console.WriteLine("Error: No se puede dividir entre cero.");
        }

        // Calcular el módulo de dos números enteros
        Console.WriteLine("Ingrese el primer número entero:");
        int numEntero3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número entero (diferente de 0):");
        int numEntero4 = Convert.ToInt32(Console.ReadLine());
        if (numEntero4 != 0)
        {
            int moduloEnteros = numEntero3 % numEntero4;
            Console.WriteLine($"El módulo de {numEntero3} entre {numEntero4} es: {moduloEnteros}");
        }
        else
        {
            Console.WriteLine("Error: El segundo número no puede ser cero.");
        }

        Console.ReadLine();

        // Leer una cadena de texto y imprimir en mayúsculas
        Console.WriteLine("Ingrese una cadena de texto:");
        string texto = Console.ReadLine();
        string textoMayusculas = texto.ToUpper();
        Console.WriteLine($"Texto en mayúsculas: {textoMayusculas}");

        // Leer una cadena de texto y imprimir en minúsculas
        Console.WriteLine("Ingrese una cadena de texto:");
        texto = Console.ReadLine();
        string textoMinusculas = texto.ToLower();
        Console.WriteLine($"Texto en minúsculas: {textoMinusculas}");

        // Leer una cadena de texto y imprimir al revés
        Console.WriteLine("Ingrese una cadena de texto:");
        texto = Console.ReadLine();
        char[] caracteres = texto.ToCharArray();
        Array.Reverse(caracteres);
        string textoAlReves = new string(caracteres);
        Console.WriteLine($"Texto al revés: {textoAlReves}");

        // Leer una cadena de texto y buscar una palabra
        Console.WriteLine("Ingrese una cadena de texto:");
        texto = Console.ReadLine();
        Console.WriteLine("Ingrese la palabra que desea buscar:");
        string palabraBuscar = Console.ReadLine();
        bool contienePalabra = texto.Contains(palabraBuscar);
        Console.WriteLine($"El texto {(contienePalabra ? "sí" : "no")} contiene la palabra '{palabraBuscar}'.");

        // Leer una cadena de texto y contar el número de vocales
        Console.WriteLine("Ingrese una cadena de texto:");
        texto = Console.ReadLine();
        int contadorVocales = 0;
        foreach (char caracter1 in texto.ToLower())
        {
            if ("aeiou".Contains(caracter1))
            {
                contadorVocales++;
            }
        }
        Console.WriteLine($"El número de vocales en el texto es: {contadorVocales}");

        Console.ReadLine();

        static void Main(string[] args)
        {
            // Calcular el área de un triángulo
            Console.WriteLine("Ingrese la base del triángulo:");
            double baseTriangulo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del triángulo:");
            double alturaTriangulo = Convert.ToDouble(Console.ReadLine());
            double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
            Console.WriteLine($"El área del triángulo es: {areaTriangulo}");

            // Calcular el volumen de una esfera
            Console.WriteLine("Ingrese el radio de la esfera:");
            double radioEsfera = Convert.ToDouble(Console.ReadLine());
            double volumenEsfera = (4.0 / 3.0) * Math.PI * Math.Pow(radioEsfera, 3);
            Console.WriteLine($"El volumen de la esfera es: {volumenEsfera}");

            // Calcular la distancia entre dos puntos
            Console.WriteLine("Ingrese las coordenadas del primer punto (x1 y y1):");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese las coordenadas del segundo punto (x2 y y2):");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"La distancia entre los dos puntos es: {distancia}");

            // Convertir temperatura de Celsius a Fahrenheit
            Console.WriteLine("Ingrese la temperatura en grados Celsius:");
            double temperaturaCelsius = Convert.ToDouble(Console.ReadLine());
            double temperaturaFahrenheit = (temperaturaCelsius * 9 / 5) + 32;
            Console.WriteLine($"La temperatura {temperaturaCelsius}°C en Fahrenheit es: {temperaturaFahrenheit}°F");

            // Convertir temperatura de Fahrenheit a Celsius
            Console.WriteLine("Ingrese la temperatura en grados Fahrenheit:");
            double temperaturaFahrenheit2 = Convert.ToDouble(Console.ReadLine());
            double temperaturaCelsius2 = (temperaturaFahrenheit2 - 32) * 5 / 9;
            Console.WriteLine($"La temperatura {temperaturaFahrenheit2}°F en Celsius es: {temperaturaCelsius2}°C");

            Console.ReadLine();
        }
    }
}
