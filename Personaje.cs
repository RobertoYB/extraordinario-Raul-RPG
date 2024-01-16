using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Raul
{
    public class Personaje : IPersonaje
    {
        public string nombre;
        private int nivel;
        private int ataque;
        private int defensa;
        private int vidaMaxima;
        private int vidaActual;
        private int manaMaximo;
        private int manaActual;

        public void SubirNivel()
        {
            nivel = nivel + 1;
            Console.WriteLine($"¡{nombre} ha subido al nivel {nivel}!");    
        }

        public void ObtenerHabilidadAprendida()
        {

        }
        
        public void ObtenerHabilidadEquipada()
        {

        }
        
        public void EquiparHabilidad()
        {

        }
        
        public void DesequiparHabilidad()
        {

        }
        
        public void LanzarHabilidad()
        {

        }
        
        public void Examinar()
        {

        }
        
        private void Morir()
        {
            Console.WriteLine($"El viaje de {nombre} ha llegado a su fin. Fin del juego.");
        }
        
        public void CreacionDePersonaje()
        {
            this.nombre = Console.ReadLine();
            this.nivel = 1;

            if (ClasePersonaje = ClasePersonaje.Guerrero)
            {
                this.ataque = 15;
                this.defensa = 20;
                this.vidaMaxima = 20;
                this.manaMaximo = 30;
            } 
            else if (ClasePersonaje = ClasePersonaje.Mago)
            {
                this.ataque = 20;
                this.defensa = 10;
                this.vidaMaxima = 20;
                this.manaMaximo = 30;
            } 
            else    //En este caso serian los datos del ladron
            {
                this.ataque = 10; 
                this.defensa = 20;
                this.vidaMaxima = 20;
                this.manaMaximo = 15;
            }
        }
    }
}