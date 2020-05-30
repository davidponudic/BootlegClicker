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


        public int cookies, cookiesprev, Score, debugcookies;
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

        //---------TIMER--------//

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

        //Starts timer when button is first clicked
        private void TimerStart()
        {
            if (boolinterval == false)
            {
                CookieTimer.Start();
                boolinterval = true;
            }
        }

        //----------DEBUG-----------//

        //Add cookies button
        private void btnCookieDebug_Click(object sender, EventArgs e)
        {
            cookies += debugcookies;
        }

        //Text box where you input needed cookies
        private void textboxCookieDebug_TextChanged(object sender, EventArgs e)
        {
            debugcookies = Convert.ToInt32(textboxCookieDebug.Text);
        }

        //-----------LEVELS---------//

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

        //----------UPDATE----------//


        //Adds all cookies
        public int CookieAddition()
        {
            cookies += grandmas;
            return cookies;
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

        private void ScoreUpdate()
        {
            lblScore.Text = "Score: " + Score.ToString();
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
    }
}
