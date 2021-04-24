using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IWannaBeKolya
{
    static class Renderer
    {
        public static void Render(Graphics graphics)
        {
            foreach (var gameObject in Game.gameObjects)
            {
                    graphics.DrawImage(gameObject.Sprite.Image, gameObject.Position.ToPoint());

            }

            if (Game.PlayerDead)
            {
                graphics.DrawImage(Images.PlayerDeadMessage, 100, 100);
            }
        }

        public static void CleanAll()
        {

        }
    }
}
