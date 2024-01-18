using Tarea_1;

// Clase Ejecutable
class Program
{
    static void Main()
    {
        // Ejemplo de uso
        Automovil automovil = new Automovil();
        automovil.Marca = "Toyota";
        automovil.Modelo = "Corolla";
        automovil.Año = 2022;
        automovil.Puertas = 4;

        Camioneta camioneta = new Camioneta();
        camioneta.Marca = "Ford";
        camioneta.Modelo = "Ranger";
        camioneta.Año = 2021;
        camioneta.CapacidadCarga = 1.5;

        // Muestra la información y realiza la acción para cada tipo de vehículo
        automovil.GetInformation();
        automovil.RunAction(); // Mensaje genérico más Conducir automóvil.

        Console.WriteLine();

        camioneta.GetInformation();
        camioneta.RunAction(); // Mensaje genérico más Cargar camioneta.
    }
}