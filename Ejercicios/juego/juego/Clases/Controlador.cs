using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace juego.Clases
{
    public class Controlador
    {
        private int pantallaLargo;
        private int pantallaAlto;
        private SpriteBatch spriteBatch;
        private ContentManager context;
        private float velocidad_X = 0;
        private float velocidad_Y = 0;
        private int cantidadBalas;
        private int ciclo;
        private Personaje personaje;

        private List<Entidad> Entidades { get; set; }

        public Controlador() {}

        public Controlador(int pantallaLargo, int pantallaAlto, ContentManager cm, SpriteBatch sb) 
        {
            this.pantallaLargo = pantallaLargo;
            this.pantallaAlto = pantallaAlto;
            this.spriteBatch = sb;
            this.context = cm;
            this.cantidadBalas = 50;
            this.ciclo = 0;
            this.Entidades = new List<Entidad>();
            this.personaje = new Personaje(this.pantallaAlto, this.pantallaLargo, this.context, this.spriteBatch, Color.White);
        }

        public void borrarEntidad() { }

        public void actualizar() 
        {
            this.leerTeclas();
            this.personaje.Mover(velocidad_X, velocidad_Y, 0);
            this.velocidad_X = 0;
            this.velocidad_Y = 0;
        }

        private void leerTeclas() 
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                this.velocidad_X = -1f;
            }
            else
            {
                if (Keyboard.GetState().IsKeyDown(Keys.Right))
                {
                    this.velocidad_X = 1f;
                }
            }
        }

        public void dibujar() 
        {
            this.personaje.Dibujar();
        }

        private void agregarEntidad() { }
    }
}
