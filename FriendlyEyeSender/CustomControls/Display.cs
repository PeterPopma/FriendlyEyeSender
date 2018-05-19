using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using FriendlyEyeSender.Forms;
using System.Threading;
using System.Diagnostics;

namespace FriendlyEyeSender.CustomControls
{
    public class Display : WinFormsGraphicsDevice.GraphicsDeviceControl
    {
        ContentManager contentManager;
        SpriteBatch spriteBatch;
        FormCapture parentForm;

        protected override void Initialize()
        {
            parentForm = (this.Parent as FormCapture);
            contentManager = new ResourceContentManager(Services, Resources.ResourceManager);

            spriteBatch = new SpriteBatch(GraphicsDevice);

        }

        override protected void Draw()
        {
            GraphicsDevice.Clear(Microsoft.Xna.Framework.Color.Black);

            try
            {
                spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend);

                spriteBatch.End();

            }
            catch (System.NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InvalidOperationException e)
            {
                if (e.Message.Equals("Begin cannot be called again until End had been succesfully called."))
                {
                    spriteBatch.End();
                }
            }
        }

        public void UpdateFrame()
        {
        }

    }
}
