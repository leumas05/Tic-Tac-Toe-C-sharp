using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_i_rad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string XO = "x";

        public int Xvåg1 = 0;
        public int Xvåg2 = 0;
        public int Xvåg3 = 0;

        public int Xlod1 = 0;
        public int Xlod2 = 0;
        public int Xlod3 = 0;

        public int Xslash = 0;
        public int Xbackslash = 0;


        public int Ovåg1 = 0;
        public int Ovåg2 = 0;
        public int Ovåg3 = 0;

        public int Olod1 = 0;
        public int Olod2 = 0;
        public int Olod3 = 0;

        public int Oslash = 0;
        public int Obackslash = 0;

        public int lika = 0;

        bool tagen1 = false;
        bool tagen2 = false;
        bool tagen3 = false;
        bool tagen4 = false;
        bool tagen5 = false;
        bool tagen6 = false;
        bool tagen7 = false;
        bool tagen8 = false;
        bool tagen9 = false;

        void kod(EventArgs e)
        {
            if (XO == "x")
            {
                XO = "o";
            }
            else if (XO == "o")
            {
                XO = "x";
            }

            //Console.WriteLine(Xvåg1);
            //Console.WriteLine(XO);
        }

        void check(EventArgs e)
        {
            //borde använda swtich men pallar inte.

            if (Xvåg1 == 3)
            {
                btn1_1.Visible = false;
                btn1_2.Visible = false;
                btn1_3.Visible = false;
                btn2_1.Visible = false;
                btn2_2.Visible = false;
                btn2_3.Visible = false;
                btn3_1.Visible = false;
                btn3_2.Visible = false;
                btn3_3.Visible = false;

                lblVinnare.Text = "Spelare\r\n" + "     X\r\n" + "  Vann";
                lblVinnare.Visible = true;
                btnSpelaOm.Visible = true;
            }
            else if(Xvåg2 == 3)
            {
                btn1_1.Visible = false;
                btn1_2.Visible = false;
                btn1_3.Visible = false;
                btn2_1.Visible = false;
                btn2_2.Visible = false;
                btn2_3.Visible = false;
                btn3_1.Visible = false;
                btn3_2.Visible = false;
                btn3_3.Visible = false;

                lblVinnare.Text = "Spelare\r\n" + "     X\r\n" + "  Vann";
                lblVinnare.Visible = true;
                btnSpelaOm.Visible = true;
            }
            else if (Xvåg3 == 3)
            {
                btn1_1.Visible = false;
                btn1_2.Visible = false;
                btn1_3.Visible = false;
                btn2_1.Visible = false;
                btn2_2.Visible = false;
                btn2_3.Visible = false;
                btn3_1.Visible = false;
                btn3_2.Visible = false;
                btn3_3.Visible = false;

                lblVinnare.Text = "Spelare\r\n" + "     X\r\n" + "  Vann";
                lblVinnare.Visible = true;
                btnSpelaOm.Visible = true;
            }
            else if (Xlod1 == 3)
            {
                btn1_1.Visible = false;
                btn1_2.Visible = false;
                btn1_3.Visible = false;
                btn2_1.Visible = false;
                btn2_2.Visible = false;
                btn2_3.Visible = false;
                btn3_1.Visible = false;
                btn3_2.Visible = false;
                btn3_3.Visible = false;

                lblVinnare.Text = "Spelare\r\n" + "     X\r\n" + "  Vann";
                lblVinnare.Visible = true;
                btnSpelaOm.Visible = true;
            }
            else if (Xlod2 == 3)
            {
                btn1_1.Visible = false;
                btn1_2.Visible = false;
                btn1_3.Visible = false;
                btn2_1.Visible = false;
                btn2_2.Visible = false;
                btn2_3.Visible = false;
                btn3_1.Visible = false;
                btn3_2.Visible = false;
                btn3_3.Visible = false;

                lblVinnare.Text = "Spelare\r\n" + "     X\r\n" + "  Vann";
                lblVinnare.Visible = true;
                btnSpelaOm.Visible = true;
            }
            else if (Xlod3 == 3)
            {
                btn1_1.Visible = false;
                btn1_2.Visible = false;
                btn1_3.Visible = false;
                btn2_1.Visible = false;
                btn2_2.Visible = false;
                btn2_3.Visible = false;
                btn3_1.Visible = false;
                btn3_2.Visible = false;
                btn3_3.Visible = false;

                lblVinnare.Text = "Spelare\r\n" + "     X\r\n" + "  Vann";
                lblVinnare.Visible = true;
                btnSpelaOm.Visible = true;
            }
            else if (Xslash == 3)
            {
                btn1_1.Visible = false;
                btn1_2.Visible = false;
                btn1_3.Visible = false;
                btn2_1.Visible = false;
                btn2_2.Visible = false;
                btn2_3.Visible = false;
                btn3_1.Visible = false;
                btn3_2.Visible = false;
                btn3_3.Visible = false;

                lblVinnare.Text = "Spelare\r\n" + "     X\r\n" + "  Vann";
                lblVinnare.Visible = true;
                btnSpelaOm.Visible = true;
            }
            else if (Xbackslash == 3)
            {
                btn1_1.Visible = false;
                btn1_2.Visible = false;
                btn1_3.Visible = false;
                btn2_1.Visible = false;
                btn2_2.Visible = false;
                btn2_3.Visible = false;
                btn3_1.Visible = false;
                btn3_2.Visible = false;
                btn3_3.Visible = false;

                lblVinnare.Text = "Spelare\r\n" + "     X\r\n" + "  Vann";
                lblVinnare.Visible = true;
                btnSpelaOm.Visible = true;
            }
            else if (Ovåg1 == 3)
            {
                btn1_1.Visible = false;
                btn1_2.Visible = false;
                btn1_3.Visible = false;
                btn2_1.Visible = false;
                btn2_2.Visible = false;
                btn2_3.Visible = false;
                btn3_1.Visible = false;
                btn3_2.Visible = false;
                btn3_3.Visible = false;

                lblVinnare.Text = "Spelare\r\n" + "     O\r\n" + "  Vann";
                lblVinnare.Visible = true;
                btnSpelaOm.Visible = true;
            }
            else if (Ovåg2 == 3)
            {
                btn1_1.Visible = false;
                btn1_2.Visible = false;
                btn1_3.Visible = false;
                btn2_1.Visible = false;
                btn2_2.Visible = false;
                btn2_3.Visible = false;
                btn3_1.Visible = false;
                btn3_2.Visible = false;
                btn3_3.Visible = false;

                lblVinnare.Text = "Spelare\r\n" + "     O\r\n" + "  Vann";
                lblVinnare.Visible = true;
                btnSpelaOm.Visible = true;
            }
            else if (Ovåg3 == 3)
            {
                btn1_1.Visible = false;
                btn1_2.Visible = false;
                btn1_3.Visible = false;
                btn2_1.Visible = false;
                btn2_2.Visible = false;
                btn2_3.Visible = false;
                btn3_1.Visible = false;
                btn3_2.Visible = false;
                btn3_3.Visible = false;

                lblVinnare.Text = "Spelare\r\n" + "     O\r\n" + "  Vann";
                lblVinnare.Visible = true;
                btnSpelaOm.Visible = true;
            }
            else if (Olod1 == 3)
            {
                btn1_1.Visible = false;
                btn1_2.Visible = false;
                btn1_3.Visible = false;
                btn2_1.Visible = false;
                btn2_2.Visible = false;
                btn2_3.Visible = false;
                btn3_1.Visible = false;
                btn3_2.Visible = false;
                btn3_3.Visible = false;

                lblVinnare.Text = "Spelare\r\n" + "     O\r\n" + "  Vann";
                lblVinnare.Visible = true;
                btnSpelaOm.Visible = true;
            }
            else if (Olod2 == 3)
            {
                btn1_1.Visible = false;
                btn1_2.Visible = false;
                btn1_3.Visible = false;
                btn2_1.Visible = false;
                btn2_2.Visible = false;
                btn2_3.Visible = false;
                btn3_1.Visible = false;
                btn3_2.Visible = false;
                btn3_3.Visible = false;

                lblVinnare.Text = "Spelare\r\n" + "     O\r\n" + "  Vann";
                lblVinnare.Visible = true;
                btnSpelaOm.Visible = true;
            }
            else if (Olod3 == 3)
            {
                btn1_1.Visible = false;
                btn1_2.Visible = false;
                btn1_3.Visible = false;
                btn2_1.Visible = false;
                btn2_2.Visible = false;
                btn2_3.Visible = false;
                btn3_1.Visible = false;
                btn3_2.Visible = false;
                btn3_3.Visible = false;

                lblVinnare.Text = "Spelare\r\n" + "     O\r\n" + "  Vann";
                lblVinnare.Visible = true;
                btnSpelaOm.Visible = true;
            }
            else if (Oslash == 3)
            {
                btn1_1.Visible = false;
                btn1_2.Visible = false;
                btn1_3.Visible = false;
                btn2_1.Visible = false;
                btn2_2.Visible = false;
                btn2_3.Visible = false;
                btn3_1.Visible = false;
                btn3_2.Visible = false;
                btn3_3.Visible = false;

                lblVinnare.Text = "Spelare\r\n" + "     O\r\n" + "  Vann";
                lblVinnare.Visible = true;
                btnSpelaOm.Visible = true;
            }
            else if (Obackslash == 3)
            {
                btn1_1.Visible = false;
                btn1_2.Visible = false;
                btn1_3.Visible = false;
                btn2_1.Visible = false;
                btn2_2.Visible = false;
                btn2_3.Visible = false;
                btn3_1.Visible = false;
                btn3_2.Visible = false;
                btn3_3.Visible = false;

                lblVinnare.Text = "Spelare\r\n" + "     O\r\n" + "  Vann";
                lblVinnare.Visible = true;
                btnSpelaOm.Visible = true;
            }
            else if (lika == 9)
            {
                btn1_1.Visible = false;
                btn1_2.Visible = false;
                btn1_3.Visible = false;
                btn2_1.Visible = false;
                btn2_2.Visible = false;
                btn2_3.Visible = false;
                btn3_1.Visible = false;
                btn3_2.Visible = false;
                btn3_3.Visible = false;

                lblVinnare.Text = "Det\r\n" + "     Blev\r\n" + "  Lika";
                lblVinnare.Visible = true;
                btnSpelaOm.Visible = true;
            }
        }

        private void btn1_1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(lika);
           if (tagen1 == false)
            {
                if (XO == "x" && tagen1 == false)
                {
                    btn1_1.Text = "X";
                    tagen1 = true;
                    Xlod1 += 1;
                    Xvåg1 += 1;
                    Xbackslash += 1;
                    lika += 1;
                    kod(e);
                    check(e);
                }
                else if (XO == "o" && tagen1 == false)
                {
                    btn1_1.Text = "O";
                    tagen1 = true;
                    Olod1 += 1;
                    Ovåg1 += 1;
                    Obackslash += 1;
                    lika += 1;
                    kod(e);
                    check(e); 
                }
            }
        }

        private void btn1_2_Click(object sender, EventArgs e)
        {
            if (tagen2 == false)
            {
                if (XO == "x")
                {
                    btn1_2.Text = "X";
                    tagen2 = true;
                    Xvåg1 += 1;
                    Xlod2 += 1;
                    lika += 1;
                    kod(e);
                    check(e);
                }
                else if (XO == "o")
                {
                    btn1_2.Text = "O";
                    tagen2 = true;
                    Ovåg1 += 1;
                    Olod2 += 1;
                    lika += 1;
                    kod(e);
                    check(e);
                }
                return;
            }
        }

        private void btn1_3_Click(object sender, EventArgs e)
        {
            if (tagen3 == false)
            {
                if (XO == "x")
                {
                    btn1_3.Text = "X";
                    tagen3 = true;
                    Xvåg1 += 1;
                    Xlod3 += 1;
                    Xslash += 1;
                    lika += 1;
                    kod(e);
                    check(e);
                }
                else if (XO == "o")
                {
                    btn1_3.Text = "O";
                    tagen3 = true;
                    Ovåg1 += 1;
                    Olod3 += 1;
                    Oslash += 1;
                    lika += 1;
                    kod(e);
                    check(e);
                }
                return;
            }
        }

        private void btn2_1_Click(object sender, EventArgs e)
        {
            if (tagen4 == false)
            {
                if (XO == "x")
                {
                    btn2_1.Text = "X";
                    tagen4 = true;
                    Xvåg2 += 1;
                    Xlod1 += 1;
                    lika += 1;
                    kod(e);
                    check(e);
                }
                else if (XO == "o")
                {
                    btn2_1.Text = "O";
                    tagen4 = true;
                    Ovåg2 += 1;
                    Olod1 += 1;
                    lika += 1;
                    kod(e);
                    check(e);
                }
                return;
            }
        }

        private void btn2_2_Click(object sender, EventArgs e)
        {
            if (tagen5 == false)
            {
                if (XO == "x")
                {
                    btn2_2.Text = "X";
                    tagen5 = true;
                    Xvåg2 += 1;
                    Xlod2 += 1;
                    Xslash += 1;
                    Xbackslash += 1;
                    lika += 1;
                    kod(e);
                    check(e);
                }
                else if (XO == "o")
                {
                    btn2_2.Text = "O";
                    tagen5 = true;
                    Ovåg2 += 1;
                    Olod2 += 1;
                    Oslash += 1;
                    Obackslash += 1;
                    lika += 1;
                    kod(e);
                    check(e);
                }
                return;
            }
        }

        private void btn2_3_Click(object sender, EventArgs e)
        {
            if (tagen6 == false)
            {
                if (XO == "x")
                {
                    btn2_3.Text = "X";
                    tagen6 = true;
                    Xvåg2 += 1;
                    Xlod3 += 1;
                    lika += 1;
                    kod(e);
                    check(e);

                }
                else if (XO == "o")
                {
                    btn2_3.Text = "O";
                    tagen6 = true;
                    Ovåg2 += 1;
                    Olod3 += 1;
                    lika += 1;
                    kod(e);
                    check(e);
                }
                return;
            }
        }

        private void btn3_1_Click(object sender, EventArgs e)
        {
            if (tagen7 == false)
            {
                if (XO == "x")
                {
                    btn3_1.Text = "X";
                    tagen7 = true;
                    Xvåg3 += 1;
                    Xlod1 += 1;
                    Xslash += 1;
                    lika += 1;
                    kod(e);
                    check(e);
                }
                else if (XO == "o")
                {
                    btn3_1.Text = "O";
                    tagen7 = true;
                    Ovåg3 += 1;
                    Olod1 += 1;
                    Oslash += 1;
                    lika += 1;
                    kod(e);
                    check(e);
                }
                return;
            }
        }

        private void btn3_2_Click(object sender, EventArgs e)
        {
            if (tagen8 == false)
            {
                if (XO == "x")
                {
                    btn3_2.Text = "X";
                    tagen8 = true;
                    Xvåg3 += 1;
                    Xlod2 += 1;
                    lika += 1;
                    kod(e);
                    check(e);
                }
                else if (XO == "o")
                {
                    btn3_2.Text = "O";
                    tagen8 = true;
                    Ovåg3 += 1;
                    Olod2 += 1;
                    lika += 1;
                    kod(e);
                    check(e);
                }
                return;
            }
        }

        private void btn3_3_Click(object sender, EventArgs e)
        {
            if (tagen9 == false)
            {
                if (XO == "x")
                {
                    btn3_3.Text = "X";
                    tagen9 = true;
                    Xvåg3 += 1;
                    Xlod3 += 1;
                    Xbackslash += 1;
                    lika += 1;
                    kod(e);
                    check(e);
                }
                else if (XO == "o")
                {
                    btn3_3.Text = "O";
                    tagen9 = true;
                    Ovåg3 += 1;
                    Olod3 += 1;
                    Obackslash += 1;
                    lika += 1;
                    kod(e);
                    check(e);
                }
                return;
            }
        }

        private void btnSpelaOm_Click(object sender, EventArgs e)
        {
            XO = "x";

            Xvåg1 = 0;
            Xvåg2 = 0;
            Xvåg3 = 0;

            Xlod1 = 0;
            Xlod2 = 0;
            Xlod3 = 0;

            Xslash = 0;
             Xbackslash = 0;


            Ovåg1 = 0;
            Ovåg2 = 0;
            Ovåg3 = 0;

            Olod1 = 0;
            Olod2 = 0;
            Olod3 = 0;

            Oslash = 0;
            Obackslash = 0;

            lika = 0;

            btnSpelaOm.Visible = false;
            lblVinnare.Visible = false;

            btn1_1.Visible = true;
            btn1_2.Visible = true;
            btn1_3.Visible = true;
            btn2_1.Visible = true;
            btn2_2.Visible = true;
            btn2_3.Visible = true;
            btn3_1.Visible = true;
            btn3_2.Visible = true;
            btn3_3.Visible = true;

            btn1_1.Text = "";
            btn1_2.Text = "";
            btn1_3.Text = "";
            btn2_1.Text = "";
            btn2_2.Text = "";
            btn2_3.Text = "";
            btn3_1.Text = "";
            btn3_2.Text = "";
            btn3_3.Text = "";

            tagen1 = false;
            tagen2 = false;
            tagen3 = false;
            tagen4 = false;
            tagen5 = false;
            tagen6 = false;
            tagen7 = false;
            tagen8 = false;
            tagen9 = false;

        }
    }
}
