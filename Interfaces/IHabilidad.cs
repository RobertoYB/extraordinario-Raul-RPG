using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Raul
{
    public interface IHabilidad
    {
        string id { get; }
        string nombre { get; set; }
        int nivelRequerido { get; set; }
        int clase { get; }
        int claseDelPersonajeAsociado { get; set; }
    }
}
