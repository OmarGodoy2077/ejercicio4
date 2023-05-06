using ejercicio4_interfaces.MisInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4_interfaces.MisClases
{
    internal class ClsPersona : IPersona
    {
        public string Nombre { get; set; }

        public int Edad { get; set; }

        string IPersona.Edad => throw new NotImplementedException();

    

        public void CumplirAños()
        {
            Console.WriteLine("Hoy es mi cumpleaños");
            Edad++;
        }

        public void DecirMiNombre()
        {
            Console.WriteLine($"Mi nombre es Omar. ");
        }
    }
}
