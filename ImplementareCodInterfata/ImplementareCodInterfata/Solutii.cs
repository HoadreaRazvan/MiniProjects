using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImplementareCodInterfata
{
    class Solutii
    {
        Probleme functii = new Probleme();
        public void soluti1()
        {      
            int numar = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduceti un numar","Contor cifre","",200,200));
            MessageBox.Show($"Numarul are {functii.contorCifre(numar)} cifre");
        }

        public void soluti2()
        {
            int numar1 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduceti primul numar", "Gasire", "", 200, 200));
            int numar2 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduceti al doilea numar", "Gasire", "", 200, 200));
            if(functii.verfCifraN(numar1,numar2)==true)
                MessageBox.Show($"Numarul {numar2} se gaseste in {numar1}");
            else
                MessageBox.Show($"Numarul {numar2} nu se gaseste in {numar1}");
        }

        public void soluti3()
        {
            int numar = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduceti un numar", "Identice", "", 200, 200));
            if (functii.cifreIdentice(numar) == true)
                MessageBox.Show("Cifrele sunt identice");
            else
                MessageBox.Show("Cifrele nu sunt identice");
        }

        public void soluti4()
        {
            int numar = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduceti un numar", "Maxim si minim", "", 200, 200));
            MessageBox.Show($"Cifra maxim din numar este : {functii.cifraMaxim(numar)}");
            MessageBox.Show($"Cifra minim din numar este : {functii.cifraMinim(numar)}");
        }

        public void soluti5()
        {
            int numar = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduceti un numar", "Maxim si minim par", "", 200, 200));
            MessageBox.Show($"Cifra maxima para din numar este : {functii.cifraMaximPara(numar)}");
            MessageBox.Show($"Cifra minima para din numar este : {functii.cifraMinimPara(numar)}");
        }

        public void soluti6()
        {
            int numar = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduceti un numar", "Sufixe", "", 200, 200));
            functii.sufixeNumar(numar);
        }

        public void soluti7()
        {
            int numar = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduceti un numar", "Prefixe", "", 200, 200));
            functii.prefixeNumar(numar);
        }

        public void soluti8()
        {
            int numar1 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduceti un numar", "Rang k", "", 200, 200));
            int numar2 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduceti rangul", "Rang k", "", 200, 200));
            MessageBox.Show($"Cifra de rang {numar2} a numarului {numar1} este {functii.rangNumar(numar1, numar2)}");
        }

        public void soluti9()
        {
            int numar1 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduceti un numar", "Rang k", "", 200, 200));
            int numar2 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduceti rangul", "Rang k", "", 200, 200));
            MessageBox.Show($"Numarul dupa stergerea cifrei de rang {numar2} este {functii.stergereRangNumar(numar1, numar2)}");
        }

        public void soluti10()
        {
            int numar = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduceti un numar", "Eliminare prima si ultima cifra", "", 200, 200));
            MessageBox.Show($"Numarul dupa stergerea primului si ultimului element este :{functii.stergerePsiU(numar)}");
        }

        public void soluti11()
        {
            int numar = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduceti un numar", "Palindrom", "", 200, 200));
            if (functii.verfPalindrom(numar) == true)
                MessageBox.Show($"Numarul {numar} este palindrom");
            else
                MessageBox.Show($"Numarul {numar} nu este palindrom");
        }

        public void soluti12()
        {
            int numar = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduceti un numar", "Crescator", "", 200, 200));
            if (functii.verfCresc(numar) == true)
                MessageBox.Show($"Numarul {numar} are cifrele in ordine crescatoare");
            else
                MessageBox.Show($"Numarul {numar} nu are cifrele in ordine crescatoare");
        }

        public void soluti13()
        {
            int numar = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduceti un numar", "Descrescator", "", 200, 200));
            if (functii.verfDesc(numar) == true)
                MessageBox.Show($"Numarul {numar} are cifrele in ordine descrescatoare");
            else
                MessageBox.Show($"Numarul {numar} nu are cifrele in ordine descrescatoare");
        }


        //Form2

        public void soluti14()
        {
            int numar = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduceti un numar", "Oscilare", "", 200, 200));
            if (functii.verfOsc(numar) == true)
                MessageBox.Show($"Numarul {numar} oscileaza");
            else
                MessageBox.Show($"Numarul {numar} nu oscileaza");
        }

        public void soluti15()
        {
            int numar = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduceti un numar", "Fierastrau", "", 200, 200));
            if (functii.verfFier(numar) == true)
                MessageBox.Show($"Numarul {numar} are aspect de fierastrau");
            else
                MessageBox.Show($"Numarul {numar} nu are aspect de fierastrau");
        }

        public void soluti16()
        {
            int numar = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduceti un numar", "Cifra Control", "", 200, 200));
            MessageBox.Show($"Cifra de control a numarului {numar} este {functii.cifraControl(numar)}");
        }

        public void soluti17()
        {
            int numar1 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduceti primul numar", "Cautat", "", 200, 200));
            int numar2 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduceti al doilea numar", "Parcurs", "", 200, 200));
            if (functii.verfNumar1inNumar2(numar1, numar2) == true)
                 MessageBox.Show($"Numarul {numar1} se regaseste in {numar2}");
            else
                 MessageBox.Show($"Numarul {numar1} nu se regaseste in {numar2}");
        }

        public void soluti18()
        {
            int numar = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduceti un numar", "Stanga", "", 200, 200));
            MessageBox.Show($"Numarul {numar} dupa permutarea circulara spre stanga este {functii.permCircS(numar)}");
        }

        public void soluti19()
        {
            int numar = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduceti un numar", "Permutare Dreapta", "", 200, 200));
            MessageBox.Show($"Numarul {numar} dupa permutarea circulara spre dreapta este {functii.permCircD(numar)}");
        }

        public void soluti20()
        {
            int numar1 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduceti o cifra", "De cate ori se gaseste cifra un urmatoarele numere", "", 200, 200));
            int numar2 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduceti un numar si terminati cu 0", "Cifra x", "", 200, 200));
            int k = 0;
            while(numar2!=0)
            {
                while(numar2!=0)
                {
                    if (numar2 % 10 == numar1)
                        k++;
                    numar2 = numar2 / 10;
                }
                numar2 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduceti un numar si terminati cu 0", "Cifra x", "", 200, 200));       
            }
            MessageBox.Show($"Cifra {numar1} s-a repetat de {k} ori.");
        }

        public void soluti21()
        {
            int numar1 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduceti un numar si terminati cu 0", "Suma prima cifra", "", 200, 200));
            int s = 0;
            while(numar1!=0)
            {
                while((numar1/10)!=0)                      
                    numar1 = numar1 / 10;
                s += numar1;
                numar1 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Introduceti un numar si terminati cu 0", "Cifra x", "", 200, 200));
            }
            MessageBox.Show($"Suma primei cifre din numar este {s}.");
        }
    }
}
