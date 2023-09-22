using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Audio;

namespace juego.Clases
{
    public class Entidad
    {
        public enum Estado
        {
            IDLE = 0,
            MOVIENDOSE = 1,
            SALTANDO = 2,
            COLISION = 3,
        }

        public enum IMG_Direccion
        {
            IZQUIERDA = 0,
            IDLE = 1,
            DERECHA = 2,
            ARRIBA = 3,
            ABAJO = 4,
        }

        protected private float posicion_X = 0;
        protected private float posicion_Y = 0;
        protected private Vector2 posicion;
        protected private int pantallaAlto;
        protected private int pantallaLargo;
        protected private List<Texture2D> listaTextura = new List<Texture2D>();
        protected private SpriteBatch spriteBatch;
        protected private Texture2D imgColision;

        public int X { get; set; }
        public int Y { get; set; }
        public int largo { get; set; }
        public int alto { get; set; }
        public Texture2D imagen { get; set; }
        public Estado estadoEntidad { get; set; }
        public Color colorEntidad { get; set; }

        public Entidad() { }

        public Entidad(int pantallaAlto, int pantallaLargo, ContentManager cm, SpriteBatch sb, Color color) 
        {
            this.estadoEntidad = Estado.IDLE;
            this.spriteBatch = sb;
            this.pantallaLargo = pantallaLargo;
            this.pantallaAlto = pantallaAlto;
            this.listaTextura = new List<Texture2D>();
            this.colorEntidad = color;  
        }

        public virtual void Dibujar() 
        {
            this.spriteBatch.Draw(this.imagen, this.posicion, this.colorEntidad);
        }

        public virtual void Mover(float velocidad_x, float velocidad_y, IMG_Direccion img) 
        {
            if ((this.posicion.X + velocidad_x) >= 0 && ((this.posicion.X + this.largo) + velocidad_x) <= this.pantallaLargo)
            {
                this.posicion_X += velocidad_x;
            }
            
            this.posicion_Y += velocidad_y;
            this.imagen = this.listaTextura[(int)img];
        }

        public virtual void Parar() { }
    }
}
