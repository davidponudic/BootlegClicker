﻿using System;
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
        public int debugcookies, debuggrandmas, debuggrandpas, debugmothers, debugfathers, debugbrothers, debugsisters;
        public int grandmas, grandpas, mothers, fathers, brothers, sisters;
        public int cookieCPS, grandmaCPS, grandpaCPS;
        public int cookiemultiplier = 1, grandmamultiplier = 1;
        public int grandmavalue = 20, grandpavalue = 1000, mothervalue, fathervalue, brothervalue, sistervalue;
        public int level = 1;

        private int timerinterval = 1000;
        private bool corgibool = true;
        private bool boolinterval = false;

        public int jeba;
        public int jeba3;

        //Cookie button
        private void btnCookies_Click(object sender, EventArgs e)
        {
            cookieCPS = cookiemultiplier;

            cookies += cookieCPS;
            Score++;
            CookieUpdate();
            TimerStart();
            
        }

        //-----------FAMILY BUTTONS-----------//

        //Sets how fast family prices grow
        public double multiplier = 1.03;

        //Grandma button
        private void btnGrandma_Click(object sender, EventArgs e)
        {
            if (cookies >= grandmavalue)
            {
                cookies -= grandmavalue;
                grandmas++;
                grandmavalue = Convert.ToInt32(grandmavalue * (Math.Pow(multiplier, grandmas)));
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
            FamilyUpdate();
            ScoreUpdate();
            PictureChange();
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

        //DEBUG Add cookies
        private void btnCookieDebug_Click(object sender, EventArgs e)
        {
            cookies += debugcookies;
            CookieUpdate();
        }

        //DEBUG Convert cookies input to int
        private void textboxCookieDebug_TextChanged(object sender, EventArgs e)
        {
            debugcookies = Convert.ToInt32(textboxCookieDebug.Text);
        }

        //DEBUG Add grandmas
        private void btnGrandmaDebug_Click(object sender, EventArgs e)
        {
            grandmas += debuggrandmas;
            FamilyUpdate();
        }

        //DEBUG Convert grandmas input to int
        private void textboxGrandmaDebug_TextChanged(object sender, EventArgs e)
        {
            debuggrandmas = Convert.ToInt32(textboxGrandmaDebug.Text);
        }

        private void btnGrandpaDebug_Click(object sender, EventArgs e)
        {
            grandpas += debuggrandpas;
            FamilyUpdate();
        }

        private void textboxGrandpaDebug_TextChanged(object sender, EventArgs e)
        {
            debuggrandpas = Convert.ToInt32(textboxGrandpaDebug.Text);
        }

        private void btnMotherDebug_Click(object sender, EventArgs e)
        {
            mothers += debugmothers;
            FamilyUpdate();
        }

        private void textboxMotherDebug_TextChanged(object sender, EventArgs e)
        {
            debugmothers = Convert.ToInt32(textboxMotherDebug.Text);
        }

        private void btnFatherDebug_Click(object sender, EventArgs e)
        {
            fathers += debugfathers;
            FamilyUpdate();
        }

        private void textboxFatherDebug_TextChanged(object sender, EventArgs e)
        {
            debugfathers = Convert.ToInt32(textboxFatherDebug.Text);
        }

        private void btnBrotherDebug_Click(object sender, EventArgs e)
        {
            brothers += debugbrothers;
            FamilyUpdate();
        }

        private void textboxBrotherDebug_TextChanged(object sender, EventArgs e)
        {
            debugbrothers = Convert.ToInt32(textboxBrotherDebug.Text);
        }

        private void btnSisterDebug_Click(object sender, EventArgs e)
        {
            sisters += debugsisters;
            FamilyUpdate();
        }

        private void textboxSisterDebug_TextChanged(object sender, EventArgs e)
        {
            debugsisters = Convert.ToInt32(textboxSisterDebug.Text);
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
            grandmaCPS = Convert.ToInt32(grandmas * grandmamultiplier);

            cookies += grandmaCPS;
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
            lblGrandmaCPS.Text = "CPS: " + grandmaCPS;
            lblGrandmaCost.Text = "Cost: " + grandmavalue;

            lblGrandpas.Text = "Grandpa level: " + grandpas;
            lblGrandpaCPS.Text = "Bonus grandma CPS: " + grandpaCPS;
            lblGrandpaCost.Text = "Cost: " + grandpavalue;

            lblMothers.Text = "Mother level: " + mothers;            
            lblMotherCost.Text = "Cost: " + mothervalue;

            lblFathers.Text = "Father level: " + fathers;            
            lblFatherCost.Text = "Cost: " + fathervalue;

            lblBrothers.Text = "Brother level: " + brothers;            
            lblBrotherCost.Text = "Cost: " + brothervalue;

            lblSisters.Text = "Sister level: " + sisters;           
            lblSisterCost.Text = "Cost: " + sistervalue;
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
                if (corgibool == true)
                {
                    PesTable.Visible = false;
                    PesPlant.Visible = true;
                    corgibool = false;
                }
                else if (corgibool == false)
                {
                    PesTable.Visible = true;
                    PesPlant.Visible = false;
                    corgibool = true;
                }
            }
        }
    }
}