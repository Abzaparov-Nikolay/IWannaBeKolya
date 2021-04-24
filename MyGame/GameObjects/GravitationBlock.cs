using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace IWannaBeKolya
{
    public class GravitationBlock : GameObject
    {
        private static int GravitationRadius = 250;
        private static int GravitationPower = 1;
        public GravitationBlock(double x, double y)
        {
            Sprite = new Sprite(Images.GravitationBlockSprite);
            Position = new Vector(x, y);
            Size = new Vector(16, 16);
        }

        public override void Update()
        {
            
        }

        public Vector GetGravitation(Vector location)
        {
            if ((location.X - Position.X) * (location.X - Position.X)
                + (location.Y - Position.Y) * (location.Y - Position.Y)
                < GravitationRadius * GravitationRadius)
                return (Position - location).Normalize() * GravitationPower;
            return Vector.Zero;
        }
    }
}
