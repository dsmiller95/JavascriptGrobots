using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweebies.Actors
{
    abstract class Sweebie : Actor
    {

        protected float dir;
        protected float vel;
        protected Sweebie(Point pos, float direction, float velocity) : base(pos) {
            dir = direction;
            vel = velocity;
        }

        override protected void draw(Graphics graphics)
        {
            
        }

        override public void update(short[][] feild)
        {
            position.X += (int)(vel * Math.Cos(dir));
            position.Y += (int)(vel * Math.Sin(dir));

        }

        protected override void drawExtras(Graphics graphics)
        {
            throw new NotImplementedException();
        }
    }
}
