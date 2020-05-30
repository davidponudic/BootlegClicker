using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Form_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int cookies = 0;
        private int grandmas = 0;
        private int cookiesprev;
        private int intinterval = 1000;
        private int CookieScore;
        private bool buttonbool = true;

        private void button1_Click(object sender, EventArgs e)
        {
            cookies++;
            lblCookies.Text = "Cookies: " + cookies;
            if (cookies == 1) CookieTimer.Start();
            CookieScore = cookies;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cookies >= 1)
            {
                cookies -= 1;
                grandmas++;
                lblCookies.Text = "Cookies: " + cookies;
                lblGrandmas.Text = "Grandmas: " + grandmas;
            }
            if (grandmas == 1) CookieTimer.Start();
        }

        private void CookieTimer_Tick(object sender, EventArgs e)
        {
            CookieTimer.Interval = intinterval;
            cookiesprev = cookies;

            cookies += grandmas;
            lblCookies.Text = "Cookies: " + cookies;
            CookieScore = cookies + grandmas;

            if (cookiesprev != cookies)
            {
                if (buttonbool == true)
                {
                    PesTable.Visible = false;
                    PesPlant.Visible = true;
                    buttonbool = false;
                }
                else if (buttonbool == false)
                {
                    PesTable.Visible = true;
                    PesPlant.Visible = false;
                    buttonbool = true;
                }
            }
            ScoreDisplay();
        }

        private void ScoreDisplay()
        {
            lblCookieScore.Text = "Score: " + Convert.ToString(CookieScore);
        }
         
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblStopButton_Click(object sender, EventArgs e)
        {
            intinterval = 1000000000;
        }
    }
}
