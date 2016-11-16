using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDO_Crafting_Calc
{
    public partial class BDOCCC : Form
    {
        public BDOCCC()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            //Check if Quantity Text Boxes are Empty 
            if (string.IsNullOrWhiteSpace(Qu1.Text))
            {
                Qu1.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(Qu2.Text))
            {
                Qu2.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(Qu3.Text))
            {
                Qu3.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(Qu3.Text))
            {
                Qu3.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(Qu4.Text))
            {
                Qu4.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(Qu5.Text))
            {
                Qu5.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(Qu6.Text))
            {
                Qu6.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(Qu7.Text))
            {
                Qu7.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(Qu8.Text))
            {
                Qu8.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(Qu9.Text))
            {
                Qu9.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(Qu10.Text))
            {
                Qu10.Text = "0";
            }


            //Check if Price Text Boxes are Empty
            if (string.IsNullOrWhiteSpace(Pr1.Text))
            {
                Pr1.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(Pr2.Text))
            {
                Pr2.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(Pr3.Text))
            {
                Pr3.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(Pr4.Text))
            {
                Pr4.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(Pr5.Text))
            {
                Pr5.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(Pr6.Text))
            {
                Pr6.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(Pr7.Text))
            {
                Pr7.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(Pr8.Text))
            {
                Pr8.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(Pr9.Text))
            {
                Pr9.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(Pr10.Text))
            {
                Pr10.Text = "0";
            }


            //Check if Number of Crafts is Empty
            if (string.IsNullOrWhiteSpace(NoC.Text))
            {
                NoC.Text = "0";
            }


            //Quantity Text to Int
            Int32 qa = Convert.ToInt32(Qu1.Text);
            Int32 qb = Convert.ToInt32(Qu2.Text);
            Int32 qc = Convert.ToInt32(Qu3.Text);
            Int32 qd = Convert.ToInt32(Qu4.Text);
            Int32 qe = Convert.ToInt32(Qu5.Text);
            Int32 qf = Convert.ToInt32(Qu6.Text);
            Int32 qg = Convert.ToInt32(Qu7.Text);
            Int32 qh = Convert.ToInt32(Qu8.Text);
            Int32 qi = Convert.ToInt32(Qu9.Text);
            Int32 qj = Convert.ToInt32(Qu10.Text);

            //Price Text to Int
            Int32 pa = Convert.ToInt32(Pr1.Text);
            Int32 pb = Convert.ToInt32(Pr2.Text);
            Int32 pc = Convert.ToInt32(Pr3.Text);
            Int32 pd = Convert.ToInt32(Pr4.Text);
            Int32 pe = Convert.ToInt32(Pr5.Text);
            Int32 pf = Convert.ToInt32(Pr6.Text);
            Int32 pg = Convert.ToInt32(Pr7.Text);
            Int32 ph = Convert.ToInt32(Pr8.Text);
            Int32 pi = Convert.ToInt32(Pr9.Text);
            Int32 pj = Convert.ToInt32(Pr10.Text);

            //Number of Crafts Text to Int
            Int32 NoCVar = Convert.ToInt32(NoC.Text);

            //Calculation of Quantity times Number of Crafts
            Int32 qn1 = qa * NoCVar;
            Int32 qn2 = qb * NoCVar;
            Int32 qn3 = qc * NoCVar;
            Int32 qn4 = qd * NoCVar;
            Int32 qn5 = qe * NoCVar;
            Int32 qn6 = qf * NoCVar;
            Int32 qn7 = qg * NoCVar;
            Int32 qn8 = qh * NoCVar;
            Int32 qn9 = qi * NoCVar;
            Int32 qn10 = qj * NoCVar;
            //Output of Quantity times Numbers of Crafts
            QuNoc1.Text = Convert.ToString(qn1);
            QuNoc2.Text = Convert.ToString(qn2);
            QuNoc3.Text = Convert.ToString(qn3);
            QuNoc4.Text = Convert.ToString(qn4);
            QuNoc5.Text = Convert.ToString(qn5);
            QuNoc6.Text = Convert.ToString(qn6);
            QuNoc7.Text = Convert.ToString(qn7);
            QuNoc8.Text = Convert.ToString(qn8);
            QuNoc9.Text = Convert.ToString(qn9);
            QuNoc10.Text = Convert.ToString(qn10);

            //Calculation of Quantity times Price
            Int32 qp1 = qa * pa;
            Int32 qp2 = qb * pb;
            Int32 qp3 = qc * pc;
            Int32 qp4 = qd * pd;
            Int32 qp5 = qe * pe;
            Int32 qp6 = qf * pf;
            Int32 qp7 = qg * pg;
            Int32 qp8 = qh * ph;
            Int32 qp9 = qi * pi;
            Int32 qp10 = qj * pj;
            //Output of Quantity times Price
            PrQu1.Text = Convert.ToString(qp1);
            PrQu2.Text = Convert.ToString(qp2);
            PrQu3.Text = Convert.ToString(qp3);
            PrQu4.Text = Convert.ToString(qp4);
            PrQu5.Text = Convert.ToString(qp5);
            PrQu6.Text = Convert.ToString(qp6);
            PrQu7.Text = Convert.ToString(qp7);
            PrQu8.Text = Convert.ToString(qp8);
            PrQu9.Text = Convert.ToString(qp9);
            PrQu10.Text = Convert.ToString(qp10);

            //Calculation of Quantity times Price times Number of Calculations
            Int32 qpn1 = qa * pa * NoCVar;
            Int32 qpn2 = qb * pb * NoCVar;
            Int32 qpn3 = qc * pc * NoCVar;
            Int32 qpn4 = qd * pd * NoCVar;
            Int32 qpn5 = qe * pe * NoCVar;
            Int32 qpn6 = qf * pf * NoCVar;
            Int32 qpn7 = qg * pg * NoCVar;
            Int32 qpn8 = qh * ph * NoCVar;
            Int32 qpn9 = qi * pi * NoCVar;
            Int32 qpn10 = qj * pj * NoCVar;
            //Output of Quantity times Price times Number of Calculations
            PrQuNoC1.Text = Convert.ToString(qpn1);
            PrQuNoC2.Text = Convert.ToString(qpn2);
            PrQuNoC3.Text = Convert.ToString(qpn3);
            PrQuNoC4.Text = Convert.ToString(qpn4);
            PrQuNoC5.Text = Convert.ToString(qpn5);
            PrQuNoC6.Text = Convert.ToString(qpn6);
            PrQuNoC7.Text = Convert.ToString(qpn7);
            PrQuNoC8.Text = Convert.ToString(qpn8);
            PrQuNoC9.Text = Convert.ToString(qpn9);
            PrQuNoC10.Text = Convert.ToString(qpn10);

            //Output and Calculation of Maximum Price
            Int32 END = qpn1 + qpn2 + qpn3 + qpn4 + qpn5 + qpn6 + qpn6 + qpn8 + qpn9 + qpn10;
            MoC.Text = Convert.ToString(END);
        }

    }
}
