using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea_1;

// Clase que hereda de Vehiculo y representa una camioneta

class Camioneta : Vehiculo
{
    protected double capacidadCarga;

    // Propiedad con validación para la capacidad de carga
    public double CapacidadCarga
    {
        get { return capacidadCarga; }
        set
        {
            if (value > 0)
            {
                capacidadCarga = value;
            }
            else
            {
                Console.WriteLine("Error: La capacidad de carga debe ser mayor que cero");
            }
        }
    }

    // Sobrescribe el método para obtener la información específica de la camioneta
    public new void GetInformation()
    {
        base.GetInformation();
        Console.WriteLine($"Capacidad de Carga: {CapacidadCarga} toneladas");
    }

    // Método para realizar una acción específica de la camioneta

    // Llama al método de la clase base
    public override void RunAction()
    {
        base.RunAction(); 
        Console.WriteLine("Cargar camioneta");
    }
}
