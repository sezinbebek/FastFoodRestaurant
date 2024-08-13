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
            if (CoffeeCb.Checked == true)        /*Eðer CoffeeCb adlý checkbox iþaretli ise (Checked == true), CoffeeTb adlý text box etkinleþtirilir */
            {
                CoffeeTb.Enabled = true;    /*(Enabled = true). Bu, kullanýcý checkbox'ý iþaretlediðinde,text box'ýn aktif hale gelmesini saðlar ve kullanýcý bu alana veri girebilir.*/
            }

            if (CoffeeCb.Checked == false)       /*Eðer CoffeeCb adlý checkbox iþaretli deðilse (Checked == false), */
            {
                CoffeeTb.Enabled = false;   // CoffeeTb adlý text box devre dýþý býrakýlýr (Enabled = false).
                CoffeeTb.Text = "0";        // Ayrýca, text box'ýn içeriði sýfýrlanýr ve "0" olarak ayarlanýr (CoffeeTb.Text = "0";).
                                            // Bu, kullanýcý checkbox'ý iþaretlemediðinde, text box'ýn aktif olmamasýný saðlar ve ayrýca text box içindeki deðer sýfýrlanýr.


                /*Enabled = true ifadesi, bir kullanýcý arayüzü öðesinin etkinleþtirilmesini saðlar. Bu, kullanýcýlarýn bu kontrolü kullanabileceði anlamýna gelir. Örneðin, bir buton, text box, dropdown list gibi kontrollerin Enabled özelliði true olarak ayarlandýðýnda, kullanýcý bu kontrollerle etkileþime girebilir, yani butona týklayabilir, text box'a veri girebilir veya listeden bir seçenek seçebilir.*/
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
            //Ýçecekler ve tatlýlar

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
