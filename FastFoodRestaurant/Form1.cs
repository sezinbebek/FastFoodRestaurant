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

        }

        private void BurgerCb_CheckedChanged_1(object sender, EventArgs e)
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
