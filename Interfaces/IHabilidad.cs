using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Raul.Interfaces
{
    public interface IHabilidad
    {
        //Configuración de getters y setters
        string id { get; }
        string nombre { get; }
        int nivelRequerido { get; }
        int clase { get; }
        int claseDelPersonajeAsociado { get; }

        //Aqui van las funciones
    }

    public enum ClaseActivoPasivo   //Enumerador de clase activa/pasiva de habilidad
    {
        Activa,
        Pasiva
    }
}
























/*public interface Habilidad {

    String getId();

    String getNombre();

    int getNivelRequerido();

    Habilidad.Clase getClase();

    Habilidad.Clase getClasePersonajeAsociada();

    int getCostoDeMana();

    boolean isAutoAplicable();

    Habilidad.Tipo getTipo();

    int getPotencia();

    void lanzar(Personaje lanzador, Personaje objetivo);

    void aplicarEfecto(Personaje objetivo);

}*/