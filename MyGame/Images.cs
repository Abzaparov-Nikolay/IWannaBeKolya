using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace IWannaBeKolya
{
    public static class Images
    {
        public static Dictionary<string, string> ObjectsSprites = new Dictionary<string, string>();

        static Images()
        {
            ObjectsSprites.Add("Player", @"./Res/Images/PlayerSprite.png");
            ObjectsSprites.Add("Brick", @"./Res/Images/SmallBrick.png");
            ObjectsSprites.Add("DeadlyBrick", @"./Res/Images/DeadlyBrickSprite.png");
            ObjectsSprites.Add("PlayerDeadMessage", @"./Res/Images/PlayerDeadMessage.png");
        }

        public static readonly Bitmap PlayerSprite = (Bitmap)Image.FromFile(@"./Res/Images/PlayerSprite.png");
        public static readonly Bitmap BrickSprite = (Bitmap)Image.FromFile(@"./Res/Images/SmallBrick.png");
        public static readonly Bitmap DeadlyBrickSprite = (Bitmap)Image.FromFile(@"./Res/Images/DeadlyBrickSprite.png");
        public static readonly Bitmap PlayerDeadMessage = (Bitmap)Image.FromFile(@"./Res/Images/PlayerDeadMessage.png");
        public static readonly Bitmap GravitationBlockSprite = (Bitmap)Image.FromFile(@"./Res/Images/GravitationBlockSprite.png");
    }
}
