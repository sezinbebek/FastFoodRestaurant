using System.Numerics;
using System;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;

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
            BurgerTb.Enabled = true;
            BurgerTb.BackColor = Color.Transparent;
        }


        //farklý yemekler ve içecekler için birim fiyatlarý tanýmlamasý.
        double BurgerBf = 20, Burger2Bf = 15, Burger3Bf = 25, HotdogBf = 10, FriesBf = 5, SaladBf = 10;
        double CoffeeBf = 6, MilkshBf = 5, Sodabf = 3, ColaBf = 2, CakeBf = 3, PineCakeBf = 12;

        //her bir içecek ve yemek için toplam fiyatý tutacak bir deðiþken tanýmlamasý.

        double BurgerTf, Burger2Tf, Burger3Tf, HotdogTf, FriesTf, SaladTf, CoffeeTf, MilkshTf, SodaTf, ColaTf, CakeTf, PineCakeTf;
        double SubTotal = 0, Tax, GrdTotal;

        private void Closelbl_Click(object sender, EventArgs e)
        {
            Application.Exit();  //uygulama tamamen kapanýr ve çalýþmakta olan tüm iþlemleri sonlandýrýr.
        }

        private void ReceiptTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BurgerTf = BurgerBf * Convert.ToDouble(BurgerTb.Text);
            Burger2Tf = Burger2Bf * Convert.ToDouble(Burger2Tb.Text);
            Burger3Tf = Burger3Bf * Convert.ToDouble(Burger3Tb.Text);
            HotdogTf = HotdogBf * Convert.ToDouble(HotdogTb.Text);
            FriesTf = FriesBf * Convert.ToDouble(FriesTb.Text);
            SaladTf = SaladBf * Convert.ToDouble(SaladTb.Text);
            //Ýçecek ve Tatlý kýsmý

            CoffeeTf = CoffeeBf * Convert.ToDouble(CoffeeTb.Text);
            MilkshTf = MilkshBf * Convert.ToDouble(MilkshTb.Text);
            SodaTf = Sodabf * Convert.ToDouble(SodaTb.Text);
            ColaTf = ColaBf * Convert.ToDouble(ColaTb.Text);
            CakeTf = ColaBf * Convert.ToDouble(CakeTb.Text);
            PineCakeTf = PineCakeBf * Convert.ToDouble(PineCakeTb.Text);
            //þimdi fiþ veya makbuz üzerine ürünleri ekleyelim 

            ReceiptTb.Clear();      //ReceiptTb adlý TextBox kontrolünü temizler, yani içerisindeki tüm metni siler. Bu, yeni bir fiþ yazýlmadan önce önceki içeriklerin temizlenmesini saðlar.
            SubTotal = 0;
            ReceiptTb.AppendText(Environment.NewLine);     //AppendText(string text) metodu,'TextBox','RichTextBox' gibi kontrollerin mevcut içeriðine, belirttiðiniz metni ekler. Environment.NewLine ifadesi, satýr sonu karakteri (\n) veya karakterleri (\r\n) ekler.
            ReceiptTb.AppendText("\t\t\t\t CODESPACE RESTAURANT\t\t\t" + Datelbl.Text + Environment.NewLine);      //AppendText(Environment.NewLine); ifadesi, TextBox içine yeni bir satýr ekler. Mevcut metne dokunmaz, yalnýzca bir satýr boþluðu ekler. Bu genellikle metni düzenlemek, iki satýr arasýnda boþluk býrakmak veya metnin bir sonraki kýsmýný yeni bir satýrdan baþlatmak için kullanýlýr.
            ReceiptTb.AppendText("\t\t\t\t *****************************" + Environment.NewLine);

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



/*e.Graphics.DrawString(...):

Bu metod, bir string ifadesini grafiksel bir yüzeye çizer. e.Graphics, genellikle bir PaintEventArgs veya PrintPageEventArgs nesnesidir ve çizim iþlemleri için kullanýlýr.
ReceiptTb.Text:

Bu, ReceiptTb adlý bir TextBox kontrolündeki metni alýr. Fiþte gösterilecek olan esas metindir.
SubTotal "+ SubTotallbl.Text+" Tax: "+Taxlbl.Text+" Grand Total: "+GrdTotallbl.Text:

Bu kýsým, fiþte görüntülenecek olan ek bilgileri içerir:
SubTotallbl.Text: Ara toplam (SubTotal) bilgisi.
Taxlbl.Text: Vergi miktarý (Tax).
GrdTotallbl.Text: Genel toplam (Grand Total).
Bu metinler, TextBox veya Label gibi kontrollerden alýnýr ve fiþe eklenir.
new Font("Century Gothic",12,FontStyle.Regular):

Bu, yazý tipi (font) ayarlarýný belirtir. Metin, Century Gothic yazý tipiyle, 12 punto büyüklüðünde ve normal (Regular) stilinde yazdýrýlýr.
Brushes.Blue:

Bu, metnin rengini belirtir. Burada metin mavi renkte çizilecektir.
new Point(130):

Bu, metnin çizileceði noktayý belirler. Point(130) ifadesi, (x, y) koordinatlarýný belirtir, burada 130 yalnýzca x koordinatýdýr ve y ekseni varsayýlan olarak sýfýrdýr. Bu, metnin baþlangýç konumunu belirler.*/




/*printPreviewDialog1.ShowDialog():

Bu metot, yazdýrma iþlemi öncesinde kullanýcýya bir yazdýrma önizleme penceresi (print preview dialog) gösterir.
ShowDialog() metodu, bir diyalog kutusu (dialog box) olarak bu önizleme penceresini açar. Bu diyalog kutusu, kullanýcýya belgenin nasýl görüneceðini gösterir ve kullanýcýya yazdýrma iþlemi için bir karar verme imkaný sunar.
== DialogResult.OK:

Kullanýcý, yazdýrma önizleme penceresinde "Yazdýr" veya "Tamam" butonuna týkladýðýnda ShowDialog() metodu DialogResult.OK döndürür. Bu, kullanýcýnýn yazdýrma iþlemini onayladýðý anlamýna gelir.
printDocument1.Print();:

Bu metot, yazdýrma iþlemini baþlatýr. printDocument1, yazdýrýlacak belgeyi temsil eder. Bu belge genellikle PrintPage olayýnda tanýmlanan içerikten oluþur.
Kullanýcý yazdýrma iþlemini onayladýðýnda (DialogResult.OK), bu metot çaðrýlarak yazýcýya gönderilir ve belge yazdýrýlýr.*/
