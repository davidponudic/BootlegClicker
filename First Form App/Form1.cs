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
        public int debugcookies, debuggrandmas, debuggrandpas, debugmothers, debugfathers, debugbrothers, debugsisters;
        public int grandmas, grandpas, mothers, fathers, brothers, sisters;
        public int cookieCPS, grandmaCPS, grandpaCPS;
        public int cookiemultiplier = 1, grandmamultiplier = 1;
        public int grandmavalue = 20, grandpavalue = 1000, mothervalue, fathervalue, brothervalue, sistervalue;
        public int level = 1;
        public int LootBoxCount = 0;
        public int Ultra = 0, Rare = 0, Common = 0, LootBoxCookies = 0, LootBoxCookiesCost = 0;
       

        private int timerinterval = 1000;
        private bool corgibool = true;
        private bool boolinterval = false;

        Random rnd = new Random();

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
        public double multiplier = 1.04;

        //Grandma button
        private void btnGrandma_Click(object sender, EventArgs e)
        {
            LevelLimits();
        }

        //---------TIMER--------//

        //Main timer
        private void CookieTimer_Tick(object sender, EventArgs e)
        {
            CookieTimer.Interval = timerinterval;

            cookiesprev = cookies;

            CookieAddition();

            Score += (cookies - cookiesprev);
            lblLootBoxCount.Text = "Loot box count: " + LootBoxCount;

            lblCommon.Text = "Common: " + Convert.ToString(Common);
            lblRare.Text = "Rare: " + Convert.ToString(Rare);
            lblUltra.Text = "Ultra Rare: " + Convert.ToString(Ultra);

            lblLootBoxCookies.Text = "Cookies: " + Convert.ToString(LootBoxCookies) + " (" + Convert.ToString(LootBoxCookiesCost) + ")";

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
            Score += debugcookies;
            CookieUpdate();
        }

        //DEBUG Convert cookies input to int
        private void textboxCookieDebug_TextChanged(object sender, EventArgs e)
        {
            debugcookies = Convert.ToInt32(textboxCookieDebug.Text);
        }

        private void btnBuyLootBox_Click(object sender, EventArgs e)
        {
            if(cookies >= 50)
            {
                LootBoxCount++;
                cookies -= 50;
                int Chance = rnd.Next(0, 100);
                lblChance.Text = Convert.ToString(Chance);
                LootBoxCookiesCost += 50;

                if (Chance <= 50)
                {
                    LootBoxCookies += rnd.Next(30, 71);
                    MessageBox.Show("OOF!");
                    cookies += LootBoxCookies;
                    
                }
                else if(Chance <= 94 && Chance > 50)
                {
                    MessageBox.Show("COMMON!");
                    Common++;
                }   
                else if(Chance >= 95 && Chance < 99)
                {
                    MessageBox.Show("RARE!");
                    Rare++;
                }
                else if (Chance >= 99)
                {
                    MessageBox.Show("ULTRA RARE!");
                    Ultra++;
                }
            }
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

        private void btnLevelUpDebug_Click(object sender, EventArgs e)
        {
            barLove.Value = barLove.Maximum;
            LoveUpdate();
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
            lblGrandpaCPS.Text = "XP/s: " + grandpaCPS;
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
                    PesPlant.Visible = true;
                    PesTable.Visible = false;
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

        private void GrandmaBuy()
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

        //Level limits
        private void LevelLimits()
        {
            switch (level)
            {
                case 1:
                    {
                        if (grandmas < 5) GrandmaBuy();
                        else MessageBox.Show("Level up for more upgrades!"); break;
                    }
                case 2:
                    {
                        if (grandmas < 10) GrandmaBuy();
                        else MessageBox.Show("Level up for more upgrades!"); break;
                    }
                case 3:
                    {
                        if (grandmas < 15) GrandmaBuy();
                        else MessageBox.Show("Level up for more upgrades!"); break;
                    }
                case 4:
                    {
                        if (grandmas < 20) GrandmaBuy();
                        else MessageBox.Show("Level up for more upgrades!"); break;
                    }
                case 5:
                    {
                        if (grandmas < 25) GrandmaBuy();
                        else MessageBox.Show("Level up for more upgrades!"); break;
                    }
                case 6:
                    {
                        if (grandmas < 30) GrandmaBuy();
                        else MessageBox.Show("Level up for more upgrades!"); break;
                    }
                case 7:
                    {
                        if (grandmas < 35) GrandmaBuy();
                        else MessageBox.Show("Level up for more upgrades!"); break;
                    }
                case 8:
                    {
                        if (grandmas < 40) GrandmaBuy();
                        else MessageBox.Show("Level up for more upgrades!"); break;
                    }
                case 9:
                    {
                        if (grandmas < 45) GrandmaBuy();
                        else MessageBox.Show("Level up for more upgrades!"); break;
                    }
                case 10:
                    {
                        if (grandmas < 50) GrandmaBuy();
                        else MessageBox.Show("Level up for more upgrades!"); ; break;
                    }

            }
        }
    }
}
