using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvadersVSTowers
{
    public class Harta
    {
        /*
            LEGENDA
        0 LIBER
        1 ZID
        2 INVADER
        3 TURN
        4 STOP

        */

        private int [,]map;

        public Harta()
        {
            map = new int[100, 100];
        }

        public void setValue(int x,int y,int v)
        {
            map[x, y] = v;
        }

        public int retValue(int x,int y)
        {
            return map[x, y];
        }

        public int[,] Map
        {
            get => this.map;
            set => this.map = value;
        }

        public string afisare()
        {
            string text = "";
            for (int i = 0; i <7; i++) { 
                for (int j = 0; j < 10; j++)
                    text += map[i, j];
            text += "\n";
            }
            return text;
        }
    }
}
