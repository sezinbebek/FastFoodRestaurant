using System.Numerics;
using System;

namespace FastFoodRestaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }




        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Datelbl_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void CoffeeCb_CheckedChanged(object sender, EventArgs e)
        {
            if (CoffeeCb.Checked == true)        /*E�er CoffeeCb adl� checkbox i�aretli ise (Checked == true), CoffeeTb adl� text box etkinle�tirilir */
            {
                CoffeeTb.Enabled = true;    /*(Enabled = true). Bu, kullan�c� checkbox'� i�aretledi�inde,text box'�n aktif hale gelmesini sa�lar ve kullan�c� bu alana veri girebilir.*/
            }

            if (CoffeeCb.Checked == false)       /*E�er CoffeeCb adl� checkbox i�aretli de�ilse (Checked == false), */
            {
                CoffeeTb.Enabled = false;   // CoffeeTb adl� text box devre d��� b�rak�l�r (Enabled = false).
                CoffeeTb.Text = "0";        // Ayr�ca, text box'�n i�eri�i s�f�rlan�r ve "0" olarak ayarlan�r (CoffeeTb.Text = "0";).
                                            // Bu, kullan�c� checkbox'� i�aretlemedi�inde, text box'�n aktif olmamas�n� sa�lar ve ayr�ca text box i�indeki de�er s�f�rlan�r.


                /*Enabled = true ifadesi, bir kullan�c� aray�z� ��esinin etkinle�tirilmesini sa�lar. Bu, kullan�c�lar�n bu kontrol� kullanabilece�i anlam�na gelir. �rne�in, bir buton, text box, dropdown list gibi kontrollerin Enabled �zelli�i true olarak ayarland���nda, kullan�c� bu kontrollerle etkile�ime girebilir, yani butona t�klayabilir, text box'a veri girebilir veya listeden bir se�enek se�ebilir.*/
            }

        }

        private void Burger2Cb_CheckedChanged(object sender, EventArgs e)
        {
            if (Burger2Cb.Checked == true)
            {
                Burger2Tb.Enabled = true;
            }

            if (Burger2Cb.Checked == false)
            {
                Burger2Tb.Enabled = false;
                Burger2Tb.Text = "0";
            }
        }

        private void Burger3Cb_CheckedChanged(object sender, EventArgs e)
        {
            if (Burger3Cb.Checked == true)
            {
                Burger3Tb.Enabled = true;
            }

            if (Burger3Cb.Checked == false)
            {
                Burger3Tb.Enabled = false;
                Burger3Tb.Text = "0";
            }
        }

        private void HotdogCb_CheckedChanged(object sender, EventArgs e)
        {
            if (HotdogCb.Checked == true)
            {
                HotdogTb.Enabled = true;
            }

            if (HotdogCb.Checked == false)
            {
                HotdogTb.Enabled = false;
                HotdogTb.Text = "0";
            }
        }

        private void FriesCb_CheckedChanged(object sender, EventArgs e)
        {
            if (FriesCb.Checked == true)
            {
                FriesTb.Enabled = true;
            }

            if (FriesCb.Checked == false)
            {
                FriesTb.Enabled = false;
                FriesTb.Text = "0";
            }
        }

        private void SaladCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SaladCb.Checked == true)
            {
                SaladTb.Enabled = true;
            }

            if (SaladCb.Checked == false)
            {
                SaladTb.Enabled = false;
                SaladTb.Text = "0";
            }
        }

        private void MilkshCb_CheckedChanged(object sender, EventArgs e)
        {
            if (MilkshCb.Checked == true)
            {
                MilkshTb.Enabled = true;
            }

            if (MilkshCb.Checked == false)
            {
                MilkshTb.Enabled = false;
                MilkshTb.Text = "0";
            }
        }

        private void SodaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SodaCb.Checked == true)
            {
                SodaTb.Enabled = true;
            }

            if (SodaCb.Checked == false)
            {
                SodaTb.Enabled = false;
                SodaTb.Text = "0";
            }
        }

        private void ColaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ColaCb.Checked == true)
            {
                ColaTb.Enabled = true;
            }

            if (ColaCb.Checked == false)
            {
                ColaTb.Enabled = false;
                ColaTb.Text = "0";
            }
        }

        private void CakeCb_CheckedChanged(object sender, EventArgs e)
        {
            if (CakeCb.Checked == true)
            {
                CakeTb.Enabled = true;
            }

            if (CakeCb.Checked == false)
            {
                CakeTb.Enabled = false;
                CakeTb.Text = "0";
            }
        }

        private void PineCakeCb_CheckedChanged(object sender, EventArgs e)
        {
            if (PineCakeCb.Checked == true)
            {
                PineCakeTb.Enabled = true;
            }

            if (PineCakeCb.Checked == false)
            {
                PineCakeTb.Enabled = false;
                PineCakeTb.Text = "0";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BurgerTb_TextChanged(object sender, EventArgs e)
        {
            //BurgerTb.Enabled = true;
            //BurgerTb.BackColor = Color.HotPink;
        }

        }

        private void BurgerCb_CheckedChanged_1(object sender, EventArgs e)
        {
            if (BurgerCb.Checked == true)
            {
                ReceiptTb.AppendText("\tBurger:\t" + BurgerTf + "$" + Environment.NewLine);
                SubTotal = SubTotal + BurgerTf;
                SubTotallbl.Text = "" + SubTotal;
            }
            if (Burger2Cb.Checked == true)
            {
                ReceiptTb.AppendText("\tBurger2:\t" + Burger2Tf + "$" + Environment.NewLine);
                SubTotal = SubTotal + Burger2Tf;
                SubTotallbl.Text = "" + SubTotal;
            }
            if (Burger3Cb.Checked == true)
            {
                ReceiptTb.AppendText("\tBurger3:\t" + Burger3Tf + "$" + Environment.NewLine);
                SubTotal = SubTotal + Burger3Tf;
                SubTotallbl.Text = "" + SubTotal;
            }
            if (HotdogCb.Checked == true)
            {
                ReceiptTb.AppendText("\tHotdog:\t" + HotdogTf + "$" + Environment.NewLine);
                SubTotal = SubTotal + HotdogTf;
                SubTotallbl.Text = "" + SubTotal;
            }
            if (FriesCb.Checked == true)
            {
                ReceiptTb.AppendText("\tFries:\t" + FriesTf + "$" + Environment.NewLine);
                SubTotal = SubTotal + FriesTf;
                SubTotallbl.Text = "" + SubTotal;
            }
            if (SaladCb.Checked == true)
            {
                ReceiptTb.AppendText("\tSalad:\t" + SaladTf + "$" + Environment.NewLine);
                SubTotal = SubTotal + SaladTf;
                SubTotallbl.Text = "" + SubTotal;
            }
            //��ecekler ve tatl�lar

            if (CoffeeCb.Checked == true)
            {
                ReceiptTb.AppendText("\tCoffee:\t" + CoffeeTf + "$" + Environment.NewLine);
                SubTotal = SubTotal + CoffeeTf;
                SubTotallbl.Text = "" + SubTotal;
            }
            if (MilkshCb.Checked == true)
            {
                ReceiptTb.AppendText("\tMilksh:\t" + MilkshTf + "$" + Environment.NewLine);
                SubTotal = SubTotal + MilkshTf;
                SubTotallbl.Text = "" + SubTotal;
            }
            if (SodaCb.Checked == true)
            {
                ReceiptTb.AppendText("\tSoda:\t" + SodaTf + "$" + Environment.NewLine);
                SubTotal = SubTotal + SodaTf;
                SubTotallbl.Text = "" + SubTotal;
            }
            if (ColaCb.Checked == true)
            {
                ReceiptTb.AppendText("\tCola:\t" + ColaTf + "$" + Environment.NewLine);
                SubTotal = SubTotal + ColaTf;
                SubTotallbl.Text = "" + SubTotal;
            }
            if (CakeCb.Checked == true)
            {
                ReceiptTb.AppendText("\tCake:\t" + CakeTf + "$" + Environment.NewLine);
                SubTotal = SubTotal + CakeTf;
                SubTotallbl.Text = "" + SubTotal;
            }
            if (PineCakeCb.Checked == true)
            {
                ReceiptTb.AppendText("\tPineCake:\t" + PineCakeTf + "$" + Environment.NewLine);
                SubTotal = SubTotal + PineCakeTf;
                SubTotallbl.Text = "" + SubTotal;
            }
            Tax = SubTotal * 0.15; // Tahmini bir vergi.
            GrdTotal = SubTotal + Tax;
            Taxlbl.Text = "$" + Tax;
            GrdTotallbl.Text = "$" + GrdTotal;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BurgerCb.Checked = false;
            Burger2Cb.Checked = false;
            Burger3Cb.Checked = false;
            HotdogCb.Checked = false;
            FriesCb.Checked = false;
            SaladCb.Checked = false;
            CoffeeCb.Checked = false;
            MilkshCb.Checked = false;
            SodaCb.Checked = false;
            ColaCb.Checked = false;
            CakeCb.Checked = false;
            PineCakeCb.Checked = false;
        }

        private void Taxlbl_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(ReceiptTb.Text + " SubTotal: " + SubTotallbl.Text + " Tax: " + Taxlbl.Text + " Grand Total: " + GrdTotallbl.Text, new Font("Century Gothic", 12, FontStyle.Regular), Brushes.DimGray, new Point(50));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void BurgerCb_CheckedChanged(object sender, EventArgs e)
        {
            if (BurgerCb.Checked == true)
            {
                BurgerTb.Enabled = true;
            }

            if (BurgerCb.Checked == false)
            {
                BurgerTb.Enabled = false;
                BurgerTb.Text = "0";
            }
        }
    }
}
