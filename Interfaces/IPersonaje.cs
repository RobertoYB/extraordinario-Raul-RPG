using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Raul.Interfaces
{
    public interface IPersonaje
    {
        //Configuración de getters y setters
        string nombre { get; }
        int nivel { get; }
        int ataque { get; }
        int defensa { get; }
        int vidaMaxima { get; }
        int vidaActual { get; }
        int manaMaximo { get; }
        int manaActual { get; }


        //Aqui van las funciones
        void SubirNivel();
        void ObtenerHabilidadAprendida();
        void ObtenerHabilidadEquipada();
        void EquiparHabilidad();
        void DesequiparHabilidad();
        void LanzarHabilidad();
        void Examinar(); 
        void Morir();
        void CreacionDePersonaje();
    }

    public enum ClasePersonaje //Enumerador de clase de personaje
    {
        Guerrero,
        Mago,
        Ladron
    }
}
