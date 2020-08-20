using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatAccount
{
    class Information
    {
        private string name;
        private string phonenumber;
        private string email;
        private string address;

        
        private bool check_name(string s)
        {
            foreach (var c in s)
            {
                if (char.IsLetter(c)) return true;
            }
            return false;
        }
        private bool check_phonenumber(string s)
        {
            foreach (var c in s)
            {
                if (char.IsDigit(c) && s.Length == 10) return true;
            }
            return false;
        }
        private bool check_email(string s)
        {
            try
            {
                var c = new System.Net.Mail.MailAddress(s);
                return c.Address == s;
            }
            catch
            {
                return false;
            }
        }
        private bool check_address(string s)
        {
            foreach (var c in s)
            {
                if (char.IsLetterOrDigit(c)) return true;
            }
            return false;
        }
        public Information()
        {

        }
        public Information(string n,string p, string e, string a)
        {
            this.name = n;
            this.phonenumber = p;
            this.email = e;
            this.address = a;
        }
        public string Name
        {
            get{ return this.name; }
            set{
                if (check_name(name) == false)
                {
                    MessageBox.Show("You must input correct name by characters");
                }
                else
                {
                    this.name = value;
                } 
            }
        }
        public string PhoneNumber
        {
            get { return this.phonenumber; }
            set
            {
                if (check_phonenumber(name) == false)
                {
                    MessageBox.Show("You must input correct phone number by numbers");
                }
                else
                {
                    this.phonenumber = value;
                }
            }
        }
        public string Email
        {
            get { return this.email; }
            set
            {
                if (check_email(email) == false)
                {
                    MessageBox.Show("You must input correct form email");
                }
                else
                {
                    this.email = value;
                }
            }
        }
        public string Address
        {
            get { return this.address; }
            set
            {
                if (check_address(address) == false)
                {
                    MessageBox.Show("You must input correct your address");
                }
                else
                {
                    this.address = value;
                }
            }
        }
    }
}
