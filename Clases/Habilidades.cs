using RPG_Raul.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Raul.Clases
{
    public class Habilidades : IHabilidad
    {
        public string id { get; }
        public string nombre { get; }
        public int nivelRequerido { get; }
        public int clase { get; }
        public int claseDePersonajeAsociado { get; }
        private int CostoDeMana { get; }
        public bool AutoAplicable { get; }
        public int Potencia { get; }
    }
}
