using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace PacMan
{
    public class Map
    {
 /*
            Legenda: 
        1 => zid;
        2 => player
        3 => inamic
        4 => final
        5 => scor
        0 => liber;
 */
        private int[,] map;
        private int w, h;

        public Map(int w,int h)
        {
            this.w = w;
            this.h = h;
            this.map = new int[w, h];
        }

        public void setValue(int d1, int d2, int v)
        {
            this.map[d1, d2] = v;
        }

        public int isOk(int d1, int d2) => map[d1, d2];     
        
        public bool verfPlayer()
        {
            for (int i = 0; i < this.h - 2; i++)
                for (int j = 0; j < this.w - 2; j++)
                    if (map[i, j] == 2)
                        return true;
            return false;
        }
    }
}
