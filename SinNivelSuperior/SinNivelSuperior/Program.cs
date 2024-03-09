using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("¡Bienvenido!");

        Console.Write("Por favor, ingrese su nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Ahora, ingrese su apellido: ");
        string apellido = Console.ReadLine();

        Console.Write("Ingrese el dominio de correo electrónico (por ejemplo, gmail.com): ");
        string dominio = Console.ReadLine();

        string correoGenerado = GenerarCorreoElectronico(nombre, apellido, dominio);

        Console.WriteLine("El correo electrónico generado es: {0}", correoGenerado);

        Console.ReadLine(); // Para evitar que la consola se cierre inmediatamente
    }

    static string GenerarCorreoElectronico(string nombre, string apellido, string dominio)
    {
        string nombreCorto = nombre.Substring(0, Math.Min(3, nombre.Length)).ToLower();
        string apellidoCorto = apellido.Substring(0, Math.Min(3, apellido.Length)).ToLower();
        return nombreCorto + apellidoCorto + "@" + dominio;
    }
}
