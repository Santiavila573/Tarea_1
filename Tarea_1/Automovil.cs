using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea_1;

namespace Tarea_1
{
    // Clase que hereda de Vehiculo y representa un automóvil
    class Automovil : Vehiculo
    {
        protected int puertas;

        // Propiedad con validación para la cantidad de puertas
        public int Puertas
        {
            get { return puertas; }
            set
            {
                if (value > 0)
                {
                    puertas = value;
                }
                else
                {
                    Console.WriteLine("Error: La cantidad de puertas debe ser mayor que cero");
                }
            }
        }

        // Método para obtener la información específica del automóvil
        public new void GetInformation()
        {
            base.GetInformation();
            Console.WriteLine($"Cantidad de Puertas: {Puertas}");
        }

        // Método para realizar una acción específica del automóvil

        // Llama al método de la clase base
        public override void RunAction()
        {
            base.RunAction(); 
            Console.WriteLine("Conducir automóvil");
        }
    }
}

