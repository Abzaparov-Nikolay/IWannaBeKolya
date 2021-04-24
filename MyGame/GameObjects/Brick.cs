using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWannaBeKolya
{
    class Brick : GameObject
    {
        public Brick(double x, double y)
        {
            Sprite = new Sprite(Images.BrickSprite);
            Position = new Vector(x, y);
            Size = new Vector(16, 16);
        }
        public override void Update()
        {
            base.Update();
        }
    }
}
