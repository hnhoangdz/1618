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
    public partial class Shopping : Form
    {
        Bill bill = new Bill();
        private static int totalbag1 = 0, totalbag2 = 0, totalbag3 = 0, totalbag4 = 0, totalbag5 = 0 ;
        private static int pricebag1 = 0, pricebag2 = 0, pricebag3 = 0, pricebag4 = 0, pricebag5 = 0 ;
        private static int totalwear1 = 0, totalwear2 = 0, totalwear3 = 0, totalwear4 = 0, totalwear5 = 0;
        private static int pricewear1 = 0, pricewear2 = 0, pricewear3 = 0, pricewear4 = 0, pricewear5 = 0;
        private static int totaljeans1 = 0, totaljeans2 = 0, totaljeans3 = 0, totaljeans4 = 0, totaljeans5 = 0;
        private static int pricejeans1 = 0, pricejeans2 = 0, pricejeans3 = 0, pricejeans4 = 0, pricejeans5 = 0;
        private static int totalshoes1 = 0, totalshoes2 = 0, totalshoes3 = 0, totalshoes4 = 0, totalshoes5 = 0;
        private static int priceshoes1 = 0, priceshoes2 = 0, priceshoes3 = 0, priceshoes4 = 0, priceshoes5 = 0;
        public Shopping()
        {
            InitializeComponent();
           
        }             
        private void chbBag1_CheckedChanged(object sender, EventArgs e)
        {
            if (chbBag1.Checked == true)
            {
                nudBag1.Value = 1;
                
            }
            else
            {
                nudBag1.Value = 0;
            }                       
        }
        private void chBag2_CheckedChanged(object sender, EventArgs e)
        {
            if (chbBag2.Checked == true)
            {
                nudBag2.Value = 1;
                
            }
            else
            {
                nudBag2.Value = 0;
            }            
        }
        private void chbBag3_CheckedChanged(object sender, EventArgs e)
        {
            if (chbBag3.Checked == true)
            {
                nudBag3.Value = 1;
               
            }
            else
            {
                nudBag3.Value = 0;
            }
        }
        private void chbBag4_CheckedChanged(object sender, EventArgs e)
        {
            if (chbBag4.Checked == true)
            {
                nudBag4.Value = 1;
                
            }
            else
            {
                nudBag4.Value = 0;
            }
        }
        private void chbBag5_CheckedChanged(object sender, EventArgs e)
        {
            if (chbBag5.Checked == true)
            {
                nudBag5.Value = 1;
                
            }
            else
            {
                nudBag5.Value = 0;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            nudBag1.Value = 0;
            chbBag1.Checked = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            nudBag2.Value = 0;
            chbBag2.Checked = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            nudBag3.Value = 0;
            chbBag3.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nudBag4.Value = 0;
            chbBag4.Checked = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            nudBag5.Value = 0;
            chbBag5.Checked = false;
        }
        private void chbClothes1_CheckedChanged(object sender, EventArgs e)
        {
            if (chbClothes1.Checked == true)
            {
                nudWear1.Value = 1;

            }
            else nudWear1.Value = 0;
        }
        private void chbClothes2_CheckedChanged(object sender, EventArgs e)
        {
            if (chbClothes2.Checked == true)
            {
                nudWear2.Value = 1;

            }
            else nudWear2.Value = 0;
        }
        private void chbClothes3_CheckedChanged(object sender, EventArgs e)
        {
            if (chbClothes3.Checked == true)
            {
                nudWear3.Value = 1;

            }
            else nudWear3.Value = 0;
        }
       private void chbClothes4_CheckedChanged(object sender, EventArgs e)
        {
            if (chbClothes4.Checked == true)
            {
                nudWear4.Value = 1;

            }
            else nudWear4.Value = 0;
        }

        private void chbClothes5_CheckedChanged(object sender, EventArgs e)
        {
            if (chbClothes5.Checked == true)
            {
                nudWear5.Value = 1;

            }
            else nudWear5.Value = 0;
        }

        private void nudWear1_ValueChanged(object sender, EventArgs e)
        {
            if (chbClothes1.Checked == true)
            {
                totalwear1 = int.Parse(nudWear1.Value.ToString());
                pricewear1 = 590 * totalwear1;
                lblPriceWear1.Text = pricewear1.ToString() + "$";
            }
            else
            {
                nudWear1.Value = 0;
                lblPriceWear1.Text = "0$";
            }
            if (nudWear1.Value == 0) chbClothes1.Checked = false;
        }

        private void nudWear2_ValueChanged(object sender, EventArgs e)
        {
            if (chbClothes2.Checked == true)
            {
                totalwear2 = int.Parse(nudWear2.Value.ToString());
                pricewear2 = 490 * totalwear2;
                lblPriceWear2.Text = pricewear2.ToString() + "$";
            }
            else
            {
                nudWear2.Value = 0;
                lblPriceWear2.Text = "0$";
            }
            if (nudWear2.Value == 0) chbClothes2.Checked = false;
        }

        private void nudWear3_ValueChanged(object sender, EventArgs e)
        {
            if (chbClothes3.Checked == true)
            {
                totalwear3 = int.Parse(nudWear3.Value.ToString());
                pricewear3 = 690 * totalwear3;
                lblPriceWear3.Text = pricewear3.ToString() + "$";
            }
            else
            {
                nudWear3.Value = 0;
                lblPriceWear3.Text = "0$";
            }
            if (nudWear3.Value == 0) chbClothes3.Checked = false;
        }

        private void nudWear4_ValueChanged(object sender, EventArgs e)
        {
            if (chbClothes4.Checked == true)
            {
                totalwear4 = int.Parse(nudWear4.Value.ToString());
                pricewear4 = 890 * totalwear4;
                lblPriceWear4.Text = pricewear4.ToString() + "$";
            }
            else
            {
                nudWear4.Value = 0;
                lblPriceWear4.Text = "0$";
            }
            if (nudWear4.Value == 0) chbClothes4.Checked = false;
        }

        private void nudWear5_ValueChanged(object sender, EventArgs e)
        {
            if (chbClothes5.Checked == true)
            {
                totalwear5 = int.Parse(nudWear5.Value.ToString());
                pricewear5 = 990 * totalwear5;
                lblPriceWear5.Text = pricewear5.ToString() + "$";
            }
            else
            {
                nudWear5.Value = 0;
                lblPriceWear5.Text = "0$";
            }
            if (nudWear5.Value == 0) chbClothes5.Checked = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            nudWear1.Value = 0;
            chbClothes1.Checked = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            nudWear2.Value = 0;
            chbClothes2.Checked = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            nudWear3.Value = 0;
            chbClothes3.Checked = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            nudWear4.Value = 0;
            chbClothes4.Checked = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            nudWear5.Value = 0;
            chbClothes5.Checked = false;
        }

        private void chbJeans1_CheckedChanged(object sender, EventArgs e)
        {
            if (chbJeans1.Checked == true) nudJeans1.Value = 1;
            else
            {
                nudJeans1.Value = 0;
            }
        }

        private void chbJeans2_CheckedChanged(object sender, EventArgs e)
        {

            if (chbJeans2.Checked == true) nudJeans2.Value = 1;
            else
            {
                nudJeans2.Value = 0;
            }
        }

        private void chbJeans3_CheckedChanged(object sender, EventArgs e)
        {
            if (chbJeans3.Checked == true) nudJeans3.Value = 1;
            else
            {
                nudJeans3.Value = 0;
            }
        }

        private void chbJeans4_CheckedChanged(object sender, EventArgs e)
        {
            if (chbJeans4.Checked == true) nudJeans4.Value = 1;
            else
            {
                nudJeans4.Value = 0;
            }
        }

        private void chbJeans5_CheckedChanged(object sender, EventArgs e)
        {
            if (chbJeans5.Checked == true) nudJeans5.Value = 1;
            else
            {
                nudJeans5.Value = 0;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (chbBag1.Checked == false && chbBag2.Checked == false && chbBag3.Checked == false && chbBag4.Checked == false && chbBag5.Checked == false
                && chbClothes1.Checked == false && chbClothes2.Checked == false && chbClothes3.Checked == false && chbClothes4.Checked == false && chbClothes5.Checked == false
                && chbJeans1.Checked == false && chbJeans2.Checked == false && chbJeans3.Checked == false && chbJeans4.Checked == false && chbJeans5.Checked == false
                && chbShoes1.Checked == false && chbShoes2.Checked == false && chbShoes3.Checked == false && chbShoes4.Checked == false && chbShoes5.Checked == false)
            {
                MessageBox.Show("You must choose at least one service");
            }
            else
            {
                try
                {
                    if (chbBag1.Checked == true) bill.Sender(lblBag1.Text, nudBag1.Value.ToString(), lblPriceBag1.Text);
                    if (chbBag2.Checked == true) bill.Sender(lblBag2.Text, nudBag2.Value.ToString(), lblPriceBag2.Text);
                    if (chbBag3.Checked == true) bill.Sender(lblBag3.Text, nudBag3.Value.ToString(), lblPriceBag3.Text);
                    if (chbBag4.Checked == true) bill.Sender(lblBag4.Text, nudBag4.Value.ToString(), lblPriceBag4.Text);
                    if (chbBag5.Checked == true) bill.Sender(lblBag5.Text, nudBag5.Value.ToString(), lblPriceBag5.Text);
                    if (chbClothes1.Checked == true) bill.Sender(lblClothes1.Text, nudWear1.Value.ToString(), lblPriceWear1.Text);
                    if (chbClothes2.Checked == true) bill.Sender(lblClothes2.Text, nudWear2.Value.ToString(), lblPriceWear2.Text);
                    if (chbClothes3.Checked == true) bill.Sender(lblClothes3.Text, nudWear3.Value.ToString(), lblPriceWear3.Text);
                    if (chbClothes4.Checked == true) bill.Sender(lblClothes4.Text, nudWear4.Value.ToString(), lblPriceWear4.Text);
                    if (chbClothes5.Checked == true) bill.Sender(lblClothes5.Text, nudWear5.Value.ToString(), lblPriceWear5.Text);
                    if (chbJeans1.Checked == true) bill.Sender(lblBelt1.Text, nudJeans1.Value.ToString(), lblPriceJeans1.Text);
                    if (chbJeans2.Checked == true) bill.Sender(lblBelt2.Text, nudJeans2.Value.ToString(), lblPriceJeans2.Text);
                    if (chbJeans3.Checked == true) bill.Sender(lblBelt3.Text, nudJeans3.Value.ToString(), lblPriceJeans3.Text);
                    if (chbJeans4.Checked == true) bill.Sender(lblBelt4.Text, nudJeans4.Value.ToString(), lblPriceJeans4.Text);
                    if (chbJeans5.Checked == true) bill.Sender(lblBelt5.Text, nudJeans5.Value.ToString(), lblPriceJeans5.Text);
                    if (chbShoes1.Checked == true) bill.Sender(lblShoes1.Text, nudShoes1.Value.ToString(), lblPriceShoes1.Text);
                    if (chbShoes2.Checked == true) bill.Sender(lblShoes2.Text, nudShoes2.Value.ToString(), lblPriceShoes2.Text);
                    if (chbShoes3.Checked == true) bill.Sender(lblShoes3.Text, nudShoes3.Value.ToString(), lblPriceShoes3.Text);
                    if (chbShoes4.Checked == true) bill.Sender(lblShoes4.Text, nudShoes4.Value.ToString(), lblPriceShoes4.Text);
                    if (chbShoes5.Checked == true) bill.Sender(lblShoes5.Text, nudShoes5.Value.ToString(), lblPriceShoes5.Text);
                }
                catch (FormatException)
                {

                }
            }
            string total_price = (pricebag1 + pricebag2 + pricebag3 + pricebag4 + pricebag5 + pricejeans1 + pricejeans2 + pricejeans3 + pricejeans4 + pricejeans5
                    + priceshoes1 + priceshoes2 + priceshoes3 + priceshoes4 + priceshoes5 + pricewear1 + pricewear2 + pricewear3 + pricewear4 + pricewear5).ToString();
            bill.Sender2(total_price);
            this.Hide();
            bill.Closed += (s, args) => this.Close();
            bill.Show();
        }

        private void Shopping_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new Login();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void nudJeans1_ValueChanged(object sender, EventArgs e)
        {
            if (chbJeans1.Checked == true)
            {
                totaljeans1 = int.Parse(nudJeans1.Value.ToString());
                pricejeans1 = 290 * totaljeans1;
                lblPriceJeans1.Text = pricejeans1.ToString() + "$";
            }
            else
            {
                nudJeans1.Value = 0;
                lblPriceJeans1.Text = "0$";
            }
            if (nudJeans1.Value == 0) chbJeans1.Checked = false;
        }

        private void nudJeans2_ValueChanged(object sender, EventArgs e)
        {
            if (chbJeans2.Checked == true)
            {
                totaljeans2 = int.Parse(nudJeans2.Value.ToString());
                pricejeans2 = 390 * totaljeans2;
                lblPriceJeans2.Text = pricejeans2.ToString() + "$";
            }
            else
            {
                nudJeans2.Value = 0;
                lblPriceJeans2.Text = "0$";
            }
            if (nudJeans2.Value == 0) chbJeans2.Checked = false;
        }

        private void nudJeans3_ValueChanged(object sender, EventArgs e)
        {
            if (chbJeans3.Checked == true)
            {
                totaljeans3 = int.Parse(nudJeans3.Value.ToString());
                pricejeans3 = 490 * totaljeans3;
                lblPriceJeans3.Text = pricejeans3.ToString() + "$";
            }
            else
            {
                nudJeans3.Value = 0;
                lblPriceJeans3.Text = "0$";
            }
            if (nudJeans3.Value == 0) chbJeans3.Checked = false;
        }

        private void nudJeans4_ValueChanged(object sender, EventArgs e)
        {
            if (chbJeans4.Checked == true)
            {
                totaljeans4 = int.Parse(nudJeans4.Value.ToString());
                pricejeans4 = 490 * totaljeans4;
                lblPriceJeans4.Text = pricejeans4.ToString() + "$";
            }
            else
            {
                nudJeans4.Value = 0;
                lblPriceJeans4.Text = "0$";
            }
            if (nudJeans4.Value == 0) chbJeans4.Checked = false;
        }

        private void nudJeans5_ValueChanged(object sender, EventArgs e)
        {
            if (chbJeans5.Checked == true)
            {
                totaljeans5 = int.Parse(nudJeans5.Value.ToString());
                pricejeans5 = 990 * totaljeans5;
                lblPriceJeans5.Text = pricejeans5.ToString() + "$";
            }
            else
            {
                nudJeans5.Value = 0;
                lblPriceJeans5.Text = "0$";
            }
            if (nudJeans5.Value == 0) chbJeans5.Checked = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            nudJeans1.Value = 0;
            chbJeans1.Checked = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            nudJeans2.Value = 0;
            chbJeans2.Checked = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            nudJeans3.Value = 0;
            chbJeans3.Checked = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            nudJeans4.Value = 0;
            chbJeans4.Checked = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            nudJeans5.Value = 0;
            chbJeans5.Checked = false;
        }

        private void chbShoes1_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShoes1.Checked == true) nudShoes1.Value = 1;
            else nudShoes1.Value = 0;
        }

        private void chbShoes2_CheckedChanged(object sender, EventArgs e)
        {

            if (chbShoes2.Checked == true) nudShoes2.Value = 1;
            else nudShoes2.Value = 0;
        }
        private void chbShoes3_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShoes3.Checked == true) nudShoes3.Value = 1;
            else nudShoes3.Value = 0;
        }

        private void chbShoes4_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShoes4.Checked == true) nudShoes4.Value = 1;
            else nudShoes4.Value = 0;
        }

        private void chbShoes5_CheckedChanged(object sender, EventArgs e)
        {

            if (chbShoes5.Checked == true) nudShoes5.Value = 1;
            else nudShoes5.Value = 0;
        }

        private void nudShoes1_ValueChanged(object sender, EventArgs e)
        {
            if (chbShoes1.Checked == true)
            {
                totalshoes1 = int.Parse(nudShoes1.Value.ToString());
                priceshoes1 = 790 * totalshoes1;
                lblPriceShoes1.Text = priceshoes1.ToString() + "$";
            }
            else
            {
                nudShoes1.Value = 0;
                lblPriceShoes1.Text = "0$";
            }
            if (nudShoes1.Value == 0) chbShoes1.Checked = false;
        }

        private void nudShoes2_ValueChanged(object sender, EventArgs e)
        {
            if (chbShoes2.Checked == true)
            {
                totalshoes2 = int.Parse(nudShoes2.Value.ToString());
                priceshoes2 = 990 * totalshoes2;
                lblPriceShoes2.Text = priceshoes2.ToString() + "$";
            }
            else
            {
                nudShoes2.Value = 0;
                lblPriceShoes2.Text = "0$";
            }
            if (nudShoes2.Value == 0) chbShoes2.Checked = false;
        }

        private void nudShoes3_ValueChanged(object sender, EventArgs e)
        {
            if (chbShoes3.Checked == true)
            {
                totalshoes3 = int.Parse(nudShoes3.Value.ToString());
                priceshoes3 = 690 * totalshoes3;
                lblPriceShoes3.Text = priceshoes3.ToString() + "$";
            }
            else
            {
                nudShoes3.Value = 0;
                lblPriceShoes3.Text = "0$";
            }
            if (nudShoes3.Value == 0) chbShoes3.Checked = false;
        }

        private void nudShoes4_ValueChanged(object sender, EventArgs e)
        {
            if (chbShoes4.Checked == true)
            {
                totalshoes4 = int.Parse(nudShoes4.Value.ToString());
                priceshoes4 = 790 * totalshoes4;
                lblPriceShoes4.Text = priceshoes4.ToString() + "$";
            }
            else
            {
                nudShoes4.Value = 0;
                lblPriceShoes4.Text = "0$";
            }
            if (nudShoes4.Value == 0) chbShoes4.Checked = false;
        }

        private void nudShoes5_ValueChanged(object sender, EventArgs e)
        {
            if (chbShoes5.Checked == true)
            {
                totalshoes5 = int.Parse(nudShoes5.Value.ToString());
                priceshoes5 = 1200 * totalshoes5;
                lblPriceShoes5.Text = priceshoes5.ToString() + "$";
            }
            else
            {
                nudShoes5.Value = 0;
                lblPriceShoes5.Text = "0$";
            }
            if (nudShoes5.Value == 0) chbShoes5.Checked = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            nudShoes1.Value = 0;
            chbShoes1.Checked = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            nudShoes2.Value = 0;
            chbShoes2.Checked = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            nudShoes3.Value = 0;
            chbShoes3.Checked = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            nudShoes4.Value = 0;
            chbShoes4.Checked = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            nudShoes5.Value = 0;
            chbShoes5.Checked = false;
        }

       

        private void button7_Click(object sender, EventArgs e)
        {
            chbSelectAll.Checked = false;
            chbBag1.Checked = false; chbClothes1.Checked = false;
            chbBag2.Checked = false; chbClothes1.Checked = false;
            chbBag3.Checked = false; chbClothes1.Checked = false;
            chbBag4.Checked = false; chbClothes1.Checked = false;
            chbBag5.Checked = false; chbClothes1.Checked = false;
            chbJeans1.Checked = false; chbShoes1.Checked = false;
            chbJeans2.Checked = false; chbShoes2.Checked = false;
            chbJeans3.Checked = false; chbShoes3.Checked = false;
            chbJeans4.Checked = false; chbShoes4.Checked = false;
            chbJeans5.Checked = false; chbShoes5.Checked = false;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSelectAll.Checked == true)
            {
                chbBag1.Checked = true; chbClothes1.Checked = true;
                chbBag2.Checked = true; chbClothes2.Checked = true;
                chbBag3.Checked = true; chbClothes3.Checked = true;
                chbBag4.Checked = true; chbClothes4.Checked = true;
                chbBag5.Checked = true; chbClothes5.Checked = true;
                chbJeans1.Checked = true; chbShoes1.Checked = true;
                chbJeans2.Checked = true; chbShoes2.Checked = true; 
                chbJeans3.Checked = true; chbShoes3.Checked = true;
                chbJeans4.Checked = true; chbShoes4.Checked = true;
                chbJeans5.Checked = true; chbShoes5.Checked = true;
            }
            else
            {
                chbBag1.Checked = false; chbClothes1.Checked = false;
                chbBag2.Checked = false; chbClothes2.Checked = false;
                chbBag3.Checked = false; chbClothes3.Checked = false;
                chbBag4.Checked = false; chbClothes4.Checked = false;
                chbBag5.Checked = false; chbClothes5.Checked = false;
                chbJeans1.Checked = false; chbShoes1.Checked = false;
                chbJeans2.Checked = false; chbShoes2.Checked = false;
                chbJeans3.Checked = false; chbShoes3.Checked = false;
                chbJeans4.Checked = false; chbShoes4.Checked = false;
                chbJeans5.Checked = false; chbShoes5.Checked = false;
            }
        }
        private void nudBag1_ValueChanged(object sender, EventArgs e)
        {
            if (chbBag1.Checked == true)
            {
                totalbag1 = int.Parse(nudBag1.Value.ToString());
                pricebag1 = 790 * totalbag1;
                lblPriceBag1.Text = pricebag1.ToString() + "$";
            }
            else
            {
                nudBag1.Value = 0;
                lblPriceBag1.Text = "0$";
            }
            if (nudBag1.Value == 0) chbBag1.Checked = false;
        }       
        private void nudBag2_ValueChanged(object sender, EventArgs e)
        {
            if (chbBag2.Checked == true)
            {
                totalbag2 = int.Parse(nudBag2.Value.ToString());
                pricebag2 = 1000 * totalbag2;
                lblPriceBag2.Text = pricebag2.ToString() + "$";
            }
            else
            {
                nudBag2.Value = 0;
                lblPriceBag2.Text = "0$";
            }
            if (nudBag2.Value == 0) chbBag2.Checked = false;
        }      
        private void nudBag3_ValueChanged(object sender, EventArgs e)
        {
            if (chbBag3.Checked == true)
            {
                totalbag3 = int.Parse(nudBag3.Value.ToString());
                pricebag3 = 1200 * totalbag3;
                lblPriceBag3.Text = pricebag3.ToString() + "$";
            }
            else
            {
                nudBag3.Value = 0;
                lblPriceBag3.Text = "0$";
            }
            if (nudBag3.Value == 0) chbBag3.Checked = false;
        }      
        private void nudBag4_ValueChanged(object sender, EventArgs e)
        {
            if (chbBag4.Checked == true)
            {
                totalbag4 = int.Parse(nudBag4.Value.ToString());
                pricebag4 = 890 * totalbag4;
                lblPriceBag4.Text = pricebag4.ToString() + "$";
            }
            else
            {
                nudBag4.Value = 0;
                lblPriceBag4.Text = "0$";
            }
            if (nudBag4.Value == 0) chbBag4.Checked = false;
        }     
        private void nudBag5_ValueChanged(object sender, EventArgs e)
        {
            if (chbBag5.Checked == true)
            {
                totalbag5 = int.Parse(nudBag5.Value.ToString());
                pricebag5 = 590 * totalbag5;
                lblPriceBag5.Text = pricebag5.ToString() + "$";
            }
            else
            {
                nudBag5.Value = 0;
                lblPriceBag5.Text = "0$";
            }
            if (nudBag5.Value == 0) chbBag5.Checked = false;
        }
        
    }
}
