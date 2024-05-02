using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImplementareCodInterfata
{
    class Probleme
    {
        public int contorCifre(int numar)
        {
            int i, p, c = 0;
            while (numar != 0)
            {
                c++;

                numar = numar / 10;

            }


            return c;

        }

        public bool verfCifraN(int numar, int x)
        {
            while (numar != 0)
            {
                if (numar % 10 == x)
                    return true;
                numar = numar / 10;
            }
            return false;
        }

        public bool cifreIdentice(int numar)
        {
            int ok = numar % 10;
            while (numar != 0)
            {
                if (numar % 10 != ok)
                    return false;
                numar = numar / 10;
            }
            return true;
        }

        public int cifraMaxim(int numar)
        {
            int mare = 0;
            while (numar != 0)
            {
                if (numar % 10 > mare)
                    mare = numar % 10;
                numar = numar / 10;
            }
            return mare;
        }

        public int cifraMinim(int numar)
        {
            int mic = 10;
            while (numar != 0)
            {
                if (numar % 10 < mic)
                    mic = numar % 10;
                numar = numar / 10;
            }
            return mic;
        }

        public int cifraMaximPara(int numar)
        {
            int mare = 0;
            while (numar != 0)
            {
                if ((numar % 10) % 2 == 0)
                    if (numar % 10 > mare)
                        mare = numar % 10;
                numar = numar / 10;
            }
            return mare;
        }

        public int cifraMinimPara(int numar)
        {
            int mic = 10;
            while (numar != 0)
            {
                if ((numar % 10) % 2 == 0)
                    if (numar % 10 < mic)
                        mic = numar % 10;
                numar = numar / 10;
            }
            return mic;
        }

        public void sufixeNumar(int numar)
        {
            int save = numar,nou=0,p=1;
            while(save!=0)
            {
                nou += (save % 10) * p;
                p *= 10;
                MessageBox.Show($"{nou}");
                save = save / 10;
            }        
        }

        public int inversNumar(int numar)
        {
            int nou = 0;
            while (numar != 0)
            {
                nou = (nou * 10) + (numar % 10);
                numar = numar / 10;
            }
            return nou;
        }

        public void prefixeNumar(int save)
        {
            int  nou = 0, p = 1;
            save = inversNumar(save);
            while (save != 0)
            {
                nou += (save % 10) * p;
                p *= 10;
                MessageBox.Show($"{inversNumar(nou)}");
                save = save / 10;
            }
        }

        public int rangNumar(int numar1,int numar2)
        {
            int k = 0;
            while(numar1!=0)
            {
                if (k == numar2)
                    return numar1 % 10;
                numar1 = numar1 / 10;
                k++;
            }
            return 0;
        }

        public int stergereRangNumar(int numar1,int numar2)
        {
            int k = 0,nou=0,p=1;
            while (numar1 != 0)
            {
                if (k != numar2)
                {
                    nou += (numar1 % 10) * p;
                    p *= 10;
                }
                numar1 = numar1 / 10;
                k++;
            }
            return nou;
        }

        public int stergerePsiU(int numar)
        {
            int nou = 0, p = 1;
            numar = numar / 10;
            while(numar!=0)
            {
                if((numar/10)!=0)
                {
                    nou +=(numar % 10) * p;
                    p *= 10;
                }
                numar = numar / 10;
            }
            return nou;
        }

        public bool verfPalindrom(int numar)
        {
            int numar2 = inversNumar(numar);
            if (numar2 == numar)
                return true;
            else
                return false;
        }

        public bool verfCresc(int numar)
        {
            while((numar/10)!=0)
            {
                if (numar % 10 < (numar / 10) % 10)
                    return false;
                numar = numar / 10;
            }
            return true;
        }

        public bool verfDesc(int numar)
        {
            while ((numar / 10) != 0)
            {
                if (numar % 10 > (numar / 10) % 10)
                    return false;
                numar = numar / 10;
            }
            return true;
        }

        public bool verfOsc(int numar)
        {
            int save = numar % 10;
            numar = numar / 10;      
            while((numar/10)!=0)
            {
                if (((numar / 10) % 10 > numar % 10 && numar % 10 < save) == false)               
                    if (((numar / 10) % 10 < numar % 10 && numar % 10 > save)==false)               
                         return false;              
                save = numar % 10;
                numar = numar/10;
            }
            return true;
        }

        public bool verfFier(int numar)
        {
            int save1 = numar % 10, save2 =(numar / 10)% 10,ok=1;
            numar = (numar / 10)/10;
            while (numar != 0)
            {
                if (numar % 10 == save1 && ok == 1)
                    ok = 0;
                else
                    if (numar % 10 == save2 && ok == 0)
                         ok = 1;
                    else
                         return false; 
                numar = numar / 10;
            }
            return true;
        }

        public int cifraControl(int numar)
        {
            int s = 10;
            while(s>9)
            {
                s = 0;
                while(numar!=0)
                {
                    s += numar % 10;
                    numar = numar / 10;
                }
                numar = s;
            }
            return s;
        }

        public bool verfNumar1inNumar2(int numar1, int numar2)
        {
            int s1 = numar1, s2 = numar2,ok;
            while(numar2 != 0)
            {
                if(numar2%10==numar1%10)
                {
                    ok = 1;
                    s1 = numar1;
                    s2 = numar2;
                    while(s1!=0)
                    {
                        if (s1 % 10 != s2 % 10)
                            ok = 0;
                        s2 = s2 / 10;
                        s1 = s1 / 10;
                    }
                    if (ok == 1)
                        return true;
                }
                numar2 = numar2 / 10;
            }
            return false;
        }

        public int permCircS(int numar)
        {
            int nou=0,p=1;
            while((numar/10)!=0)
            {
                nou += p * (numar % 10);
                p *= 10;             
                numar/= 10;
            }
            nou = nou*10 + numar;
            return nou;           
        }

        public int permCircD(int numar)
        {
            int nou=0,p = 1,s =(numar % 10);
            numar /= 10;      
            while(numar!=0)
            {
                nou += p * (numar % 10);
                p *= 10;
                numar /= 10;
            }
            nou = s*p+nou;
            return nou;
        }

    }
}
