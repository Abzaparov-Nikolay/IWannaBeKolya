using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace IWannaBeKolya
{
    public class DeadlyBrick : GameObject
    {
        public DeadlyBrick(double x, double y)
        {
            Position = new Vector(x, y);
            Size = new Vector(16, 16);
            Sprite = new Sprite(Images.DeadlyBrickSprite);
        }

        public override void Update()
        {

        }
    }
}
