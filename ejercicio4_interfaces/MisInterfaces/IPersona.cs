using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4_interfaces.MisInterfaces
{
    internal interface IPersona
    {
        string Nombre { get;  }
        string Edad { get; }
        void DecirMiNombre();
        void CumplirAños();


    }
}
