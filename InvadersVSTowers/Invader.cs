using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvadersVSTowers
{
    public class Invader
    {
        private int speed;
        private int life;

        public Invader(int speed,int life)
        {
            this.speed = speed;
            this.life = life;
        }

        public void viata(int viata)
        {
            this.life -= viata;
        }

        public void viteza(int viteza)
        {
            this.speed -= viteza;
        }

        public int Speed
        {
            get => this.speed;
            set => this.speed = value;
        }

        public int Life
        {
            get => this.life;
            set => this.life = value;
        }
    }
}
