using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweebies.Actors
{
    class Rock : Actor
    {
        int size;

        public Rock(Point pos, int size) : base(pos)
        {
            this.size = size;
        }

        override protected void draw(Graphics graphics)
        {
            graphics.FillEllipse(Brushes.DarkGray, -size / 2, -size / 2, size, size);
        }

        override public void update(short[][] feild)
        {
            throw new NotImplementedException();
        }

        protected override void drawExtras(Graphics graphics)
        {
            throw new NotImplementedException();
        }
    }
}
