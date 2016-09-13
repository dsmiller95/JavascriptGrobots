using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sweebies.Actors;

namespace Sweebies
{
    class Environment
    {

        private List<Actor> objects;

        public Environment(int width, int height)
        {
            objects = new List<Actor>();
        }

        public void addActor(Actor a)
        {
            objects.Add(a);
        }

        public Boolean removeActor(Actor a)
        {
            return objects.Remove(a);
        }

        public void drawActorsOn(System.Drawing.Graphics graphics)
        {
            foreach(Actor a in objects)
            {
                a.drawOn(graphics, false);
            }
        }
    }
}
