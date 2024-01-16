using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Raul.Interfaces
{
    public interface IPersonaje
    {
        string nombre { get; set; }
        int nivel { set; }
        int ataque { set; }
        int defensa { set; }
        int vidaMaxima { set; }
        int vidaActual { get; set; }
        int manaMaximo { set; }
        int manaActual { get; set; }
    }
}

