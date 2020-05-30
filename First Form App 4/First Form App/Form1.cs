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

        private int cookies, grandmas, cookiesprev, Score;
        private int grandmavalue = 20;
        private int level = 1;
        private int timerinterval = 1000;
        private bool buttonbool = true;
        private bool boolinterval = false;
        
        //Cookie button
        private void btnCookies_Click(object sender, EventArgs e)
        {
            cookies++;
            Score++;
            CookieUpdate();
            TimerStart();
            
            barLove.PerformStep();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        //Grandma button
        private void btnGrandma_Click(object sender, EventArgs e)
        {
           
            if (cookies >= grandmavalue)
            {
                cookies -= grandmavalue;
                grandmas++;
                CookieUpdate();
                FamilyUpdate();
            }
        }

        //Main timer
        private void CookieTimer_Tick(object sender, EventArgs e)
        {
            CookieTimer.Interval = timerinterval;

            cookiesprev = cookies;

            CookieAddition();

            Score += (cookies - cookiesprev);
            
            CookieUpdate();
            PictureChange();
            ScoreUpdate();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblGrandpa_Click(object sender, EventArgs e)
        {

        }

        private void lblGrandmas_Click(object sender, EventArgs e)
        {

        }

        //Changes corgi picture
        private void PictureChange()
        {
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
        }

        //Updates cookies
        private void CookieUpdate()
        {
            lblCookies.Text = "Cookies: " + cookies;
        }

        //Updates all family
        private void FamilyUpdate()
        {
            lblGrandmas.Text = "Grandma level: " + grandmas;
        }

        //Adds all cookie sources to cookies
        private void CookieAddition()
        {
            cookies += grandmas;
        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        //Starts timer when button is first clicked
        private void TimerStart()
        {
            if (boolinterval == false)
            {
                CookieTimer.Start();
                boolinterval = true;
            }
        }

        //Updates love xp bar

        private void LoveUpdate()
        {

        }

        private void ScoreUpdate()
        {
            lblScore.Text = "Score: " + Score.ToString();
        }

    }
}
