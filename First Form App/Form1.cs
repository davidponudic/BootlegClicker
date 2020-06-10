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
using First_Form_App.Inventory;

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
        public int cookieCPS, grandmaCPS, grandpaXPS;
        public int grandmalimit = 5, grandpalimit = 5, motherlimit = 1, fatherlimit = 1, brotherlimit = 1, sisterlimit = 1;
        public int cookiemultiplier = 1, grandmamultiplier = 1;
        public int grandmavalue = 20, grandpavalue = 1000, mothervalue, fathervalue = 1000, brothervalue, sistervalue;
        public int level = 1;
        public int LootBoxCount = 0;
        public int Ultra = 0, Rare = 0, Common = 0, LootBoxMoney = 0, LootBoxMoneyCost = 0;
       
        public int Money = 0, MoneyIncome = 0;
        public int secondtimer;
        private int timerinterval = 1000;
        private bool corgibool = true;
        private bool boolinterval = false;

        public string NASTJA = "LOVE I LOVE YOU";


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
            GrandmaBuy();
        }

        private void btnGrandpa_Click(object sender, EventArgs e)
        {
            GrandpaBuy();
        }

        //---------TIMER--------//

        //Main timer
        private void CookieTimer_Tick(object sender, EventArgs e)
        {
            CookieTimer.Interval = timerinterval;
            
            cookiesprev = cookies;

            CookieAddition();

            Score += (cookies - cookiesprev);

            barLove.Value += grandpas;

            lblLootBoxCookies.Text = "Cookies: " + Convert.ToString(LootBoxMoney) + " (" + Convert.ToString(LootBoxMoneyCost) + ")";

            LoveUpdate();
            LootboxUpdate();
            CookieUpdate();
            FamilyUpdate();
            ScoreUpdate();
            PictureChange();
            FatherIncome();

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

        private void btnFather_Click(object sender, EventArgs e)
        {
            FatherBuy();
        }

        private void btnBuyLootBox_Click(object sender, EventArgs e)
        {
            if (Money >= 50)
            {
                LootBoxCount++;
                Money -= 50;
                int Chance = rnd.Next(0, 100);
                lblChance.Text = Convert.ToString(Chance);
                LootBoxMoneyCost += 50;

                if (Chance <= 50)
                {
                    LootBoxMoney += rnd.Next(30, 71);
                    MessageBox.Show("OOF!");
                    cookies += LootBoxMoney;

                }
                else if (Chance <= 94 && Chance > 50)
                {
                    MessageBox.Show("COMMON!");
                    Common++;
                }
                else if (Chance >= 95 && Chance < 99)
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
            else
            {
                MessageBox.Show("You don't have enough money!");
            }
        }
        //items 
       

        private void Items()
        {
            Item Plain_cookies = new Item();
            Plain_cookies.Name = "Plain cookies";
            Plain_cookies.Desc = "It's not much, but it's something";
            Plain_cookies.Stats = "Gives you +1 cookie on button press";
            Plain_cookies.Rarity = 1;



            Item Chocolate_chip_cookie = new Item();
            Chocolate_chip_cookie.Name = "Chocolate chip cookie";
            Chocolate_chip_cookie.Desc = "This is the cookie your grandma has been baking this all time.";
            Chocolate_chip_cookie.Stats = "Gives your granma cookie production multiplier +10%";
            Chocolate_chip_cookie.Rarity = 1;

            Item White_chocolate_cookies = new Item();
            White_chocolate_cookies.Name = "White chocolate cookies";
            White_chocolate_cookies.Desc = "I know what you'll say. It's just cocoa butter! It's not real chocolate!Oh please";
            White_chocolate_cookies.Stats = "Gives your granpa exp production multiplier +10%";
            White_chocolate_cookies.Rarity = 1;

            Item Yogurt_cookies = new Item();
            Yogurt_cookies.Name = "Yogurt cookies";
            Yogurt_cookies.Desc = "These cookies have seen things.";
            Yogurt_cookies.Stats = "Gives you lvl up on grandma every 10 s";
            Yogurt_cookies.Rarity = 2;

            Item Macarons = new Item();
            Macarons.Name = "Macarons";
            Macarons.Desc = "It's like spraying perfume into your mouth! *insert lenny face*";
            Macarons.Stats = "Can be traded for 1 lvl";
            Macarons.Rarity = 2;

            Item Double_chip_cookies = new Item();
            Double_chip_cookies.Name = "Double - chip cookies";
            Double_chip_cookies.Desc = "DOUBLE THE CHIPS DOUBLE THE TASTY(double the calories)";
            Double_chip_cookies.Stats = "!!!Double everything!!!";
            Double_chip_cookies.Rarity = 3;
            
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
            
            if (barLove.Value >= barLove.Maximum) {
                switch (level)
                {
                    case 1:
                        barLove.Value = 0;
                        barLove.Maximum = 880;
                        level++;
                        MessageBox.Show("You leveled up!");
                        LevelLimits();
                        break;

                    case 2:
                        barLove.Value = 0;
                        barLove.Maximum = 1440;
                        level++;
                        MessageBox.Show("You leveled up!");
                        LevelLimits();
                        break;
                    case 3:
                        barLove.Value = 0;
                        barLove.Maximum = 2080;
                        level++;
                        MessageBox.Show("You leveled up!");
                        LevelLimits();
                        break;
                    case 4:

                        barLove.Value = 0;
                        barLove.Maximum = 2800;
                        level++;
                        MessageBox.Show("You leveled up!");
                        LevelLimits();
                        break;
                    case 5:
                        barLove.Value = 0;
                        barLove.Maximum = 3600;
                        level++;
                        MessageBox.Show("You leveled up!");
                        LevelLimits();
                        break;
                    case 6:
                        barLove.Value = 0;
                        barLove.Maximum = 4480;
                        level++;
                        MessageBox.Show("You leveled up!");
                        LevelLimits();
                        break;
                    case 7:
                        barLove.Value = 0;
                        barLove.Maximum = 5440;
                        level++;
                        MessageBox.Show("You leveled up!");
                        LevelLimits();
                        break;
                    case 8:
                        barLove.Value = 0;
                        barLove.Maximum = 6480;
                        level++;
                        MessageBox.Show("You leveled up!");
                        LevelLimits();
                        break;
                    case 9:
                        barLove.Value = 0;
                        barLove.Maximum = 7600;
                        level++;
                        MessageBox.Show("You leveled up!");
                        LevelLimits();
                        break;
                    case 10:
                        barLove.Value = 0;
                        barLove.Maximum = 8800;
                        level++;
                        MessageBox.Show("You leveled up!");
                        LevelLimits();
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
            lblGrandpaCPS.Text = "XP/s: " + grandpaXPS;
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

        private void LootboxUpdate()
        {
            lblLootBoxCount.Text = "Loot box count: " + LootBoxCount;

            lblCommon.Text = "Common: " + Convert.ToString(Common);
            lblRare.Text = "Rare: " + Convert.ToString(Rare);
            lblUltra.Text = "Ultra Rare: " + Convert.ToString(Ultra);

            lblLootBoxCookies.Text = "Cookies: " + Convert.ToString(LootBoxMoney) + " (" + Convert.ToString(LootBoxMoneyCost) + ")";
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

        //Father buy function
        private void FatherBuy()
        {
            
            if (cookies >= fathervalue)
            {
                if (fathers < fatherlimit)
                {
                    cookies -= fathervalue;
                    fathers++;
                    fathervalue = Convert.ToInt32(fathervalue * (Math.Pow(multiplier, fathers)));
                    CookieUpdate();
                    FamilyUpdate();
                }
                else MessageBox.Show("Level up to increase build limit!");
            }
            else MessageBox.Show("You don't have enough cookies!");
        }

        
        //Grandma buy function
        private void GrandmaBuy()
        {
            if (cookies >= grandmavalue)
                if (grandmas < grandmalimit)
                {
                    cookies -= grandmavalue;
                    grandmas++;
                    grandmavalue = Convert.ToInt32(grandmavalue * (Math.Pow(multiplier, grandmas)));
                    CookieUpdate();
                    FamilyUpdate();
                }
                else MessageBox.Show("Level up to increase build limit!");
            else MessageBox.Show("You don't have enough cookies!");
        }

        private void GrandpaBuy()
        {
            if (cookies >= grandpavalue)
                if (grandpas < grandpalimit)
                {
                    cookies -= grandpavalue;
                    grandpas++;
                    grandpavalue = Convert.ToInt32(grandmavalue * (Math.Pow(multiplier, grandmas)));
                    CookieUpdate();
                    FamilyUpdate();
                }
                else MessageBox.Show("Level up to increase build limit!");
            else MessageBox.Show("You don't have enough cookies!");
        }
        private void FatherIncome()
        {
            if (fathers != 0)
            {
                if (secondtimer % 5 == 0)
                {
                    Money += Convert.ToInt32(95 * (Math.Pow(1.05, fathers)));
                }
                secondtimer++;
                lblMoney.Text = "Money: " + Convert.ToString(Money);
            }
            else
            {
                lblMoney.Text = "Money: 0";
            }
            
        }

        //Level limits
        private void LevelLimits()
        {
            switch (level)
            {
                case 1:
                    {
                        grandmalimit = 5;
                        grandpalimit = 5;
                        fatherlimit = 1;

                        break;
                    }
                case 2:
                    {
                        grandmalimit = 10;
                        grandpalimit = 10;
                        fatherlimit = 2;

                        break;
                    }
                case 3:
                    {
                        grandmalimit = 15;
                        grandpalimit = 15;
                        fatherlimit = 3;

                        break;
                    }
                case 4:
                    {
                        grandmalimit = 20;
                        grandpalimit = 20;
                        fatherlimit = 4;

                        break;
                    }
                case 5:
                    {
                        grandmalimit = 25;
                        grandpalimit = 25;
                        fatherlimit = 5;

                        break;
                    }
                case 6:
                    {
                        grandmalimit = 30;
                        grandpalimit = 30;
                        fatherlimit = 6;

                        break;
                    }
                case 7:
                    {
                        grandmalimit = 35;
                        grandpalimit = 35;
                        fatherlimit = 7;

                        break;
                    }
                case 8:
                    {
                        grandmalimit = 40;
                        grandpalimit = 40;
                        fatherlimit = 8;

                        break;
                    }
                case 9:
                    {
                        grandmalimit = 45;
                        grandpalimit = 45;
                        fatherlimit = 9;

                        break;
                    }
                case 10:
                    {
                        grandmalimit = 50;
                        grandpalimit = 50;
                        fatherlimit = 10;

                        break;
                    }

            }
        }
    }
}
