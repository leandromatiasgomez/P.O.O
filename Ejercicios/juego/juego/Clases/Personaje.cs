using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juego.Clases
{
    public class Personaje:Entidad
    {
        public Personaje(int pantallaAlto, int pantallaLargo, ContentManager cm, SpriteBatch sb, Color color) : base(pantallaAlto, pantallaLargo, cm, sb, color) 
        {
            this.posicion_X = 0;
            this.posicion_Y = 0;
            this.posicion = new Vector2(300, 300);
            this.pantallaAlto = pantallaAlto;
            this.pantallaLargo = pantallaLargo;
            this.spriteBatch = sb;

            this.Init(cm, this.spriteBatch);

        }

        private void Init(ContentManager cm, SpriteBatch sb)
        {
            this.listaTextura.Add(cm.Load<Texture2D>("Avion1"));
            this.X = (int)this.posicion.X;
            this.Y = (int)this.posicion.Y;
            this.posicion = new Vector2 (this.pantallaLargo/2, this.pantallaLargo-100);
            this.imagen = this.listaTextura[0];
            this.largo = this.imagen.Width;
            this.alto = this.imagen.Height;
        }
    }
}
