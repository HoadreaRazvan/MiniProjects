using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Manicure
{
    public class AccountControl
    {

        public List<Account> accounts;

        public AccountControl()
        {
            accounts = new List<Account>();
            read();
        }

        public void read()
        {
            String path = Application.StartupPath + @"/accounts.txt";
            StreamReader fis = new StreamReader(path);
            string line = fis.ReadLine(); ;
            while(line.Equals("stop")!=true){          
                String[] vec = line.Split(',');
                accounts.Add(new Account(vec[0], vec[1], vec[2],vec[3]));
                line = fis.ReadLine();
            }
            fis.Close();
        }

        public void write()
        {
            String path = Application.StartupPath + @"/accounts.txt";
            StreamWriter write = new StreamWriter(path);
            string text = "";
            foreach (Account acc in accounts)
                text += acc.username+ "," +acc.password + "," + acc.email + "," + acc.admin + Environment.NewLine;
            write.WriteLine(text + "stop");
            write.Close();
        }

        public bool login(TextBox username,TextBox password)
        {
            foreach (Account acc in accounts)
                if (acc.username == username.Text && acc.password == password.Text)
                    return true;
            return false;
        }

        public void signUp(TextBox username,TextBox pass,TextBox email)
        {
            accounts.Add(new Account(username.Text, pass.Text, email.Text, "0"));
            write();
        }
        public string verfAdmin(TextBox username, TextBox password)
        {
            foreach (Account acc in accounts)
                if (acc.username == username.Text && acc.password == password.Text)
                    return acc.admin;
            return "0";
        }

        public string getEmail(TextBox username, TextBox password)
        {
            foreach (Account acc in accounts)
                if (acc.username == username.Text && acc.password == password.Text)
                    return acc.email;
            return "Not email found";
        }

        public List<Account> getMenuAcc(TextBox TxtUsername,TextBox TxtPass,string email,string admin)
        {
            Account ac = new Account(TxtUsername.Text, TxtPass.Text, email, admin);
            List<Account> nou = new List<Account>();
            nou.Add(ac);
            return nou;
        }

    }
}
