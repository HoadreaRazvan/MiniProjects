using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Album
{
    public class ControlMasini
    {
        public List<Masina> masini;
        

        public ControlMasini()
        {
            masini = new List<Masina>();
            load();
        }

        public void load()
        {
            String path = Application.StartupPath + @"/masini.txt";
            StreamReader fis = new StreamReader(path);
            string linie = "";
            linie = fis.ReadLine();
            while (linie != "stop") 
            {
                String []propre = linie.Split(',');

                String nume = propre[0];
                int km = int.Parse(propre[1]);
                double pret = double.Parse(propre[2]);
                bool status = int.Parse(propre[3])==1?true:false;
                String numeClient = propre[4];

                masini.Add(new Masina(nume,km,pret,status,numeClient));
                linie = fis.ReadLine();

            }

            fis.Close();

        }

        public void test()
        {
            string text = "";
            foreach(Masina mas in masini)
            {
                Console.WriteLine(mas.desc());
            }
           

        }

        public void show(ListView tabel)
        {
            tabel.Clear();
            tabel.Columns.Add("Marca", 120, HorizontalAlignment.Center);
            tabel.Columns.Add("Kilometri", 120, HorizontalAlignment.Center);
            tabel.Columns.Add("Pret",120, HorizontalAlignment.Center);
            tabel.Columns.Add("Status", 120, HorizontalAlignment.Center);
            tabel.Columns.Add("Client", 120, HorizontalAlignment.Center);
            
            foreach(Masina masina in masini)
            {
                ListViewItem linie = new ListViewItem();

                linie.Text = masina.nume;
                linie.SubItems.Add(masina.km.ToString());
                linie.SubItems.Add(masina.pret.ToString());
                linie.SubItems.Add(masina.inchiriata.ToString());
                linie.SubItems.Add(masina.numeClient.ToString());

                tabel.Items.Add(linie);
             
            }


        }

        //todo functie veridica daca o anumita masina exista duopa nume

        public bool verficNume(string nume)
        {
            foreach (Masina mas in masini)
                if (mas.nume.ToLower() == nume.ToLower())
                    return true;
            return false;
        }

        //todo functie dupa nume ce verifica daca masina este inchiriata

        public bool verfStatus(string nume)
        {
            foreach (Masina masina in masini)
                if (masina.nume.Equals(nume)==true){

                    return masina.inchiriata;
                }


            return false;
        }

        //todo  functie inchirire partea textBox mnume masina
         
        public String toSave()
        {
            String text = "";
            foreach(Masina masina in masini)
            {

                text += masina.toSave() + Environment.NewLine;
            }
            Console.WriteLine(text);
            return text;
        }
        public void verificNume(TextBox input)
        {
            String nume = input.Text;
            if (verficNume(nume) == false && input.Text!="")
            {
                MessageBox.Show("Masina nu exista");
                input.Focus();
            }
            else  if (verfStatus(nume) == true)
            {
                     MessageBox.Show("Masina este inchiriata");
                     input.Focus();
            }      
        }

        //todo functie ce numele masinii si returneaza pozitia din lista a masina

        public int pozMasina(string numeMasina)
        {
          for(int i = 0; i < masini.Count(); i++)
            {
                if (masini[i].nume.ToLower().Equals(numeMasina.ToLower()) == true)
                {
                    return i;
                }
            }

            return -1;
        }

        public void inchiriaza(TextBox numeMasina ,TextBox numeClient)
        {
            Masina masina = masini[pozMasina(numeMasina.Text)];
            masina.inchiriata = true;
            masina.numeClient = numeClient.Text;
            save();         
        }

        public void save()
        {
            String path = Application.StartupPath + @"/masini.txt";
            StreamWriter write = new StreamWriter(path);
            write.WriteLine(toSave()+"stop");
            write.Close();
        }

        public void testSave()
        {
            masini.Add(new Masina("Razvan", 1, 1, true, "Eu"));
            save();


        }

        public void returnareMasina(TextBox numeMasina)
        {
            Masina masina=masini[pozMasina(numeMasina.Text)];
            masina.inchiriata = false;
            masina.numeClient = "not";
            save();
        }

        public void adauga(TextBox marca,TextBox km,TextBox pret)
        {
            masini.Add(new Masina(marca.Text, int.Parse(km.Text), double.Parse(pret.Text),false,"not"));
            save();
        }


    }
}
