using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using First_Form_App.Family;

namespace First_Form_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public int cookies, cookiesprev, Score;
        public int grandmas;
        public int level = 1;
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
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        //Grandma button
        private void btnGrandma_Click(object sender, EventArgs e)
        {
            if (cookies >= 20)
            {
                cookies -= 20;
                grandmas++;
                CookieUpdate();
                FamilyUpdate();
            }
            else MessageBox.Show("You don't have enough cookies!");
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
            lblGrandmaCPS.Text = "CPS: " + grandmas;
        }

        //Adds all cookie sources to cookies
        public int CookieAddition()
        {
            cookies += grandmas;
            return cookies;
        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
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

        private void btnXP_1_Click(object sender, EventArgs e)
        {
            if (cookies >= 1)
            {
                cookies--;
                CookieUpdate();
                barLove.Increment(1);
                LoveUpdate();
            }

        }

        private void btnXP_10_Click(object sender, EventArgs e)
        {
            if (cookies >= 10)
            {
                cookies = cookies - 10;
                CookieUpdate();
                barLove.Increment(10);
                LoveUpdate();
            }
        }

        private void btnXP_100_Click(object sender, EventArgs e)
        {
            if (cookies >= 100)
            {
                cookies = cookies - 100;
                CookieUpdate();
                barLove.Increment(100);
                LoveUpdate();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblGrandmaCPS_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cookies += 100;
        }

        private void lblLoveValue_Click(object sender, EventArgs e)
        {
            
           
        }

        private void btnBuyLootBox_Click(object sender, EventArgs e)
        {
            if()
            {

            }
        }

        //Updates love xp bar
        private void LoveUpdate()
        {
            if (barLove.Value >= barLove.Maximum){
                level++;
                MessageBox.Show("You leveled up!");
                switch (level)
                {
                    case 1:
                        
                        barLove.Maximum = 400;
                        break;

                    case 2:
                        barLove.Value = 0;
                        barLove.Maximum = 880;
                        break;
                    case 3:
                        barLove.Value = 0;
                        barLove.Maximum = 1440;
                        break;
                    case 4:

                        barLove.Value = 0;
                        barLove.Maximum = 2080;
                        break;
                    case 5:
                        barLove.Value = 0;
                        barLove.Maximum = 2800;
                        break;
                    case 6:
                        barLove.Value = 0;
                        barLove.Maximum = 3600;
                        break;
                    case 7:
                        barLove.Value = 0;
                        barLove.Maximum = 4480;
                        break;
                    case 8:
                        barLove.Value = 0;
                        barLove.Maximum = 5440;
                        break;
                    case 9:
                        barLove.Value= 0;
                        barLove.Maximum = 6480;
                        break;
                    case 10:
                        barLove.Value= 0;
                        barLove.Maximum = 7600;
                        break;
                }


            }

            lblLoveValue.Text = barLove.Value + "/" + barLove.Maximum + " , You are level " + level;
            

        }

        //Outputs Score
        private void ScoreUpdate()
        {
            lblScore.Text = "Score: " + Score.ToString();
        }
    }
}
