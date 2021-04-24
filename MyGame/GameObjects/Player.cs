using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Input;

namespace IWannaBeKolya
{
    class Player : GameObject
    {
        private Vector VelocityCap = new Vector(2, 2);
        private List<Gravitation> gravitations;
        
        public static void Die()
        {

        }

        public Player()
        {
            Sprite = new Sprite(Images.PlayerSprite);
            Size = new Vector(64, 64);
            gravitations = new List<Gravitation>();
            foreach (var gameObject in Game.gameObjects)
            {
                if (gameObject.GetType() == typeof(GravitationBlock))
                {
                    gravitations.Add( ((GravitationBlock)gameObject).GetGravitation);
                }
            }
            gravitations.Add( Game.CurrentLevel.GetLevelGravitation());
        }

        public override void Update()
        {
            LastPosition = Position;
            Position += Velocity;

            if (Input.IsActionActive("Down"))
                Position.Y += 5;
            if (Input.IsActionActive("Right"))
                Position.X += 5;
            if (Input.IsActionActive("Left"))
                Position.X -= 5;
            if (Input.IsActionActive("Up"))
            {
                if (Game.gameObjects.Any(go2 => this.StandsOn(go2)))
                {
                    Velocity.Y = -20;
                }
                Position.Y -= 5;
            }


            foreach (var gameObject in Game.gameObjects)
            {
                if (gameObject == this)
                    continue;

                if (this.IsColliding(gameObject))
                {
                    if (gameObject.GetType() == typeof(Brick))
                    {
                        Position -= this.SolveCollision(gameObject);
                        if (this.WasDown(gameObject))
                        {
                            Velocity.Y = 0;
                        }
                    }
                    if (gameObject.GetType() == typeof(DeadlyBrick))
                    {
                        Game.PlayerDead = true;
                    }
                }
            }

            foreach(var gravitation in gravitations)
            {
                Velocity += gravitation(Position);
            }

            NORMALNA();
        }

        private void NORMALNA()
        {
            Velocity.Y = Velocity.Y > VelocityCap.Y ? VelocityCap.Y : Velocity.Y;
            Velocity.Y = Velocity.Y  < - VelocityCap.Y  ? -VelocityCap.Y : Velocity.Y;

            Velocity.X = Velocity.X > VelocityCap.X ? VelocityCap.X : Velocity.X;
            Velocity.X = Velocity.X < -VelocityCap.X ? -VelocityCap.X : Velocity.X;
        }
    }
}
