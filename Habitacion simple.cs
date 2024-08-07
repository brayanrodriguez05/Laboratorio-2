using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    internal class Habitacion_simple : Habitacion
    {
        public Habitacion_simple(int numeroHabitacion, double precioNoche, bool disponibilidad, string cliente, int numeroCama)
        {
            Numero = numeroHabitacion;
            PrecioPorNoche = precioNoche;
            Disponible = disponibilidad;
        }

        public int NumeroCamas { get; set; }

    }
}
