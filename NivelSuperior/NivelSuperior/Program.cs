using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("¡Bienvenido!");

        Console.Write("Ingrese el precio del primer producto en céntimos: ");
        int precioProducto1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el precio del segundo producto en céntimos: ");
        int precioProducto2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el precio del tercer producto en céntimos: ");
        int precioProducto3 = int.Parse(Console.ReadLine());

        int total = precioProducto1 + precioProducto2 + precioProducto3;

        int totalConDescuento = total > 500 ? (int)(total * 0.9) : total;

        Console.WriteLine("El total de los productos es: {0} céntimos", total);
        Console.WriteLine("El total con descuento es: {0} céntimos", totalConDescuento);

        Console.ReadLine(); // Para evitar que la consola se cierre inmediatamente
    }
}
