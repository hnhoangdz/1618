using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatAccount
{
    public partial class Bill : Form
    {
        Information[] info = new Information[25];
        string name, phonenumber, email, address;       
        public Bill()
        {
            InitializeComponent();           
            Sender = new SendItems(GetItems);
            Sender2 = new SendPrice(GetTotalPrice);

        }
        public delegate void Send(string inbox);
        public Send Sender3;
        
        public delegate void SendItems(string Message,string total, string price);
        public SendItems Sender;
        public void GetItems(string Message,string total, string price)
        {
            
            lbProductList.Items.Add("Brand: " + Message + ","+ "Amount: " + total + "," + "Price: " + price);           
        }
        public delegate void SendPrice(string totalprice);
        public SendPrice Sender2;
        public void GetTotalPrice(string totalprice)
        {
            lbProductList.Items.Add("Total Price = " + totalprice + "$");
        }
       
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
        private void lbProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbProductList.SelectedIndex;
            
        }
        private void Bill_Load(object sender, EventArgs e)
        {
            tbName.Focus();
            tbPhoneNumber.Focus();
            tbEmail.Focus();
            rtbAddress.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbInformation.Items.Clear();
            tbName.Enabled = true;
            tbPhoneNumber.Enabled = true;
            tbEmail.Enabled = true;
            rtbAddress.Enabled = true;
            rtbMale.Enabled = true;
            rtbFemale.Enabled = true;
            nudHeight.Enabled = true;
            nudWeight.Enabled = true;
        }
        private void button24_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new Login();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lbInformation.Items.Clear();
            tbName.Text = "";
            tbEmail.Text = "";
            tbPhoneNumber.Text = "";
            rtbAddress.Text = "";
            rtbMale.Checked = true;
            rtbFemale.Checked = true;
            nudHeight.Enabled = true;
            nudWeight.Enabled = true;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Shopping shop = new Shopping();
            this.Hide();
            shop.FormClosed += (s, args) => this.Close();
            shop.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            name = tbName.Text;
            phonenumber = tbPhoneNumber.Text;
            email = tbEmail.Text;
            address = rtbAddress.Text;
            if(name=="" || phonenumber=="" || email == "" || address == ""||(rtbMale.Checked==false&&rtbFemale.Checked==false))
            {
                MessageBox.Show("You must input full information");
            }
            else if(check_name(name)==false)
            {
                MessageBox.Show("You must input name by characters");
            }
            else if (check_phonenumber(phonenumber) == false)
            {
                MessageBox.Show("You must input phone number by numbers and length equal to 10");
            }
            else if (check_email(email) == false)
            {
                MessageBox.Show("You must input correct form email");
            }
            else if (check_address(address) == false)
            {
                MessageBox.Show("You must input correct address");
            }
            else
            {
                info[4] = new Information(name, phonenumber, email, address);
                lbInformation.Items.Add("Name: " + name);
                lbInformation.Items.Add("Phone number: " + phonenumber);
                lbInformation.Items.Add("Email: " + email);
                lbInformation.Items.Add("Address: " + address);
                if (rtbMale.Checked == true)
                {
                    lbInformation.Items.Add("Gender: Male");
                    
                }
                else { lbInformation.Items.Add("Gemder: Female"); }
                if(nudHeight.Value >= 160 && nudHeight.Value <=170)
                {
                    if (nudWeight.Value<= 50 &&nudWeight.Value <= 70)
                    {
                        lbInformation.Items.Add("Height: " + "1m" + (nudHeight.Value - 100) + "," + "Weight: " + nudWeight.Value + "kg");
                        lbInformation.Items.Add("Size: L");                      
                    }
                    else if(nudWeight.Value <= 100)
                    {
                        lbInformation.Items.Add("Height: " + "1m" + (nudHeight.Value - 100) + "," + "Weight: " + nudWeight.Value + "kg");
                        lbInformation.Items.Add("Size: XL");
                       
                    }
                    else
                    {
                        lbInformation.Items.Add("Height: " + "1m" + (nudHeight.Value - 100) + "," + "Weight: " + nudWeight.Value + "kg");
                        lbInformation.Items.Add("Size: XXL");
                        
                    }
                }
                else if (nudHeight.Value < 160)
                {
                    if(nudWeight.Value < 50)
                    {
                        lbInformation.Items.Add("Height: " + "1m" + (nudHeight.Value - 100) + "," + "Weight: " + nudWeight.Value + "kg");
                        lbInformation.Items.Add("Size: M");
                        
                    }
                    else
                    {
                        lbInformation.Items.Add("Height: " + "1m" + (nudHeight.Value - 100) + "," + "Weight: " + nudWeight.Value + "kg");
                        lbInformation.Items.Add("Size: L");                       
                    }
                }
                else if(nudHeight.Value > 170){
                    lbInformation.Items.Add("Height: " + "1m" + (nudHeight.Value - 100) + "," + "Weight: " + nudWeight.Value + "kg");
                    lbInformation.Items.Add("Size: XL");
                }
                /*tbName.Text = "";
                tbPhoneNumber.Text = "";
                tbEmail.Text = "";
                rtbAddress.Text = "";*/
                tbName.Enabled = false;
                tbPhoneNumber.Enabled = false;
                tbEmail.Enabled = false;
                rtbAddress.Enabled = false;
                rtbMale.Enabled = false;
                rtbFemale.Enabled = false;
                nudHeight.Enabled = false;
                nudWeight.Enabled = false;
            }
        }
        private void lbInformation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
