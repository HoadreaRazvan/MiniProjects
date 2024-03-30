using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvadersVSTowers
{
    public class CreareLista
    {
        static private List<Invader> invaders = new List<Invader>();
        static private List<Tower> towers = new List<Tower>();

        public CreareLista(int a)
        {
            if (a == 2)
                towerAdd();
            if (a == 1)
                invadersAdd();
        }

        public void invadersAdd()
        {
            invaders.Add(new Invader(10, 100));
        }

        public void towerAdd()
        {
            towers.Add(new Tower(4, 10));
        }
    }
}
