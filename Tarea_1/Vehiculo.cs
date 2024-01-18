using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea_1;

namespace Tarea_1
{
    // Clase base que representa un vehículo genérico
    class Vehiculo
    {
        protected string marca;
        protected string modelo;
        protected int año;

        // Propiedades con validaciones para Marca, Modelo y Año
        public string Marca
        {
            get { return marca; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    marca = value;
                }
                else
                {
                    Console.WriteLine("Error: La marca no puede estar vacía");
                }
            }
        }

        public string Modelo
        {
            get { return modelo; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    modelo = value;
                }
                else
                {
                    Console.WriteLine("Error: El modelo no puede estar vacío");
                }
            }
        }

        public int Año
        {
            get { return año; }
            set
            {
                if (value > 0)
                {
                    año = value;
                }
                else
                {
                    Console.WriteLine("Error: El año debe ser mayor que cero");
                }
            }
        }

        // Método para obtener la información del vehículo
        public void GetInformation()
        {
            Console.WriteLine($"Información del Vehículo: Marca: {Marca}, Modelo: {Modelo}, Año: {Año}");
        }

        // Método para realizar una acción genérica del vehículo
        public virtual void RunAction()
        {
            Console.WriteLine("Mensaje genérico del vehículo");
        }
    }
}