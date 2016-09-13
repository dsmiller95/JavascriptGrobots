using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace Sweebies.Actors
{
    abstract class Actor
    {
        protected Point position;

        protected Actor(Point pos)
        {
            position = pos;
        }

        public void drawOn(Graphics graphics, Boolean extras)
        {
            Matrix tmpTransform = graphics.Transform;
            graphics.TranslateTransform(position.X, position.Y);
            if (extras)
                drawExtras(graphics);
            else
                draw(graphics);
            graphics.Transform = tmpTransform;
        }

        protected abstract void draw(Graphics graphics);

        protected abstract void drawExtras(Graphics graphics);

        public abstract void update(Int16[][] feild);
    }
}
