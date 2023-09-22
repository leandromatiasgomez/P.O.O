using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace juego
{
    public class Avion : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Clases.Controlador controlador;
        private ContentManager context;
        const int pantallaAlto = 1000;
        const int pantallaLargo = 1000;

        public Avion()
        {
            _graphics = new GraphicsDeviceManager(this);
            _graphics.PreferredBackBufferWidth = pantallaLargo;
            _graphics.PreferredBackBufferHeight = pantallaAlto;
            _graphics.IsFullScreen = false;
            Window.Title = "Avión";
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            this._spriteBatch = new SpriteBatch(GraphicsDevice);
            this.context = Content;
            controlador = new Clases.Controlador(pantallaAlto, pantallaLargo, context, _spriteBatch);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            this.controlador.actualizar();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            this.controlador.dibujar();
            _spriteBatch.End();
            base.Draw(gameTime);
        }

        protected override void UnloadContent()
        {
            base.UnloadContent();
        }
    }
}