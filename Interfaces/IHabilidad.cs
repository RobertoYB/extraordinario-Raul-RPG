using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Raul
{
    public interface IHabilidad
    {
        //Configuración de getters y setters
        string id { get; }
        string nombre { get; }
        int nivelRequerido { get; }
        int clase { get; }
        int claseDelPersonajeAsociado { get; }
    }

    public enum ClaseActivoPasivo   //Enumerador de clase activa/pasiva de habilidad
    {
        Activa,
        Pasiva
    }
}
