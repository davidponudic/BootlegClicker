namespace First_Form_App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCookies = new System.Windows.Forms.Button();
            this.lblCookies = new System.Windows.Forms.Label();
            this.btnGrandma = new System.Windows.Forms.Button();
            this.lblGrandmas = new System.Windows.Forms.Label();
            this.CookieTimer = new System.Windows.Forms.Timer(this.components);
            this.PesPlant = new System.Windows.Forms.PictureBox();
            this.PesTable = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.barLove = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnXP_1 = new System.Windows.Forms.Button();
            this.btnXP_10 = new System.Windows.Forms.Button();
            this.btnXP_100 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGrandma = new System.Windows.Forms.TabPage();
            this.lblGrandmaCPS = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabGrandpa = new System.Windows.Forms.TabPage();
            this.tabMother = new System.Windows.Forms.TabPage();
            this.tabFather = new System.Windows.Forms.TabPage();
            this.lblBrother = new System.Windows.Forms.TabPage();
            this.lblSister = new System.Windows.Forms.TabPage();
            this.tooltip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblLoveValue = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCookieDebug = new System.Windows.Forms.Button();
            this.textboxCookieDebug = new System.Windows.Forms.TextBox();
            this.btnBuyLootBox = new System.Windows.Forms.Button();
            this.lblLootBoxCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PesPlant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PesTable)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabGrandma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCookies
            // 
            this.btnCookies.AccessibleName = "btnClickThis";
            this.btnCookies.Location = new System.Drawing.Point(31, 123);
            this.btnCookies.Name = "btnCookies";
            this.btnCookies.Size = new System.Drawing.Size(137, 61);
            this.btnCookies.TabIndex = 0;
            this.btnCookies.Text = "Click here";
            this.btnCookies.UseVisualStyleBackColor = true;
            this.btnCookies.Click += new System.EventHandler(this.btnCookies_Click);
            // 
            // lblCookies
            // 
            this.lblCookies.AccessibleName = "lblHelloWorld";
            this.lblCookies.AutoSize = true;
            this.lblCookies.Location = new System.Drawing.Point(71, 63);
            this.lblCookies.Name = "lblCookies";
            this.lblCookies.Size = new System.Drawing.Size(57, 13);
            this.lblCookies.TabIndex = 1;
            this.lblCookies.Text = "Cookies: 0";
            // 
            // btnGrandma
            // 
            this.btnGrandma.Location = new System.Drawing.Point(188, 135);
            this.btnGrandma.Name = "btnGrandma";
            this.btnGrandma.Size = new System.Drawing.Size(123, 23);
            this.btnGrandma.TabIndex = 2;
            this.btnGrandma.Text = "Call grandma";
            this.tooltip1.SetToolTip(this.btnGrandma, "Grandma gives +1 CPS");
            this.btnGrandma.UseVisualStyleBackColor = true;
            this.btnGrandma.Click += new System.EventHandler(this.btnGrandma_Click);
            // 
            // lblGrandmas
            // 
            this.lblGrandmas.AutoSize = true;
            this.lblGrandmas.Location = new System.Drawing.Point(188, 13);
            this.lblGrandmas.Name = "lblGrandmas";
            this.lblGrandmas.Size = new System.Drawing.Size(92, 13);
            this.lblGrandmas.TabIndex = 3;
            this.lblGrandmas.Text = "Grandmas level: 0";
            // 
            // CookieTimer
            // 
            this.CookieTimer.Tick += new System.EventHandler(this.CookieTimer_Tick);
            // 
            // PesPlant
            // 
            this.PesPlant.Image = ((System.Drawing.Image)(resources.GetObject("PesPlant.Image")));
            this.PesPlant.Location = new System.Drawing.Point(549, 12);
            this.PesPlant.Name = "PesPlant";
            this.PesPlant.Size = new System.Drawing.Size(239, 275);
            this.PesPlant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PesPlant.TabIndex = 4;
            this.PesPlant.TabStop = false;
            // 
            // PesTable
            // 
            this.PesTable.Image = ((System.Drawing.Image)(resources.GetObject("PesTable.Image")));
            this.PesTable.Location = new System.Drawing.Point(549, 12);
            this.PesTable.Name = "PesTable";
            this.PesTable.Size = new System.Drawing.Size(239, 275);
            this.PesTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PesTable.TabIndex = 5;
            this.PesTable.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cost: 20";
            // 
            // barLove
            // 
            this.barLove.Location = new System.Drawing.Point(31, 244);
            this.barLove.Maximum = 400;
            this.barLove.Name = "barLove";
            this.barLove.Size = new System.Drawing.Size(453, 23);
            this.barLove.Step = 1;
            this.barLove.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Love";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(13, 12);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(47, 13);
            this.lblScore.TabIndex = 18;
            this.lblScore.Text = "Score: 0";
            // 
            // btnXP_1
            // 
            this.btnXP_1.Location = new System.Drawing.Point(31, 274);
            this.btnXP_1.Name = "btnXP_1";
            this.btnXP_1.Size = new System.Drawing.Size(75, 23);
            this.btnXP_1.TabIndex = 19;
            this.btnXP_1.Text = "btnXP_1";
            this.btnXP_1.UseVisualStyleBackColor = true;
            this.btnXP_1.Click += new System.EventHandler(this.btnXP_1_Click);
            // 
            // btnXP_10
            // 
            this.btnXP_10.Location = new System.Drawing.Point(124, 274);
            this.btnXP_10.Name = "btnXP_10";
            this.btnXP_10.Size = new System.Drawing.Size(75, 23);
            this.btnXP_10.TabIndex = 20;
            this.btnXP_10.Text = "btnXP_10";
            this.btnXP_10.UseVisualStyleBackColor = true;
            this.btnXP_10.Click += new System.EventHandler(this.btnXP_10_Click);
            // 
            // btnXP_100
            // 
            this.btnXP_100.Location = new System.Drawing.Point(214, 274);
            this.btnXP_100.Name = "btnXP_100";
            this.btnXP_100.Size = new System.Drawing.Size(75, 23);
            this.btnXP_100.TabIndex = 21;
            this.btnXP_100.Text = "btnXP_100";
            this.btnXP_100.UseVisualStyleBackColor = true;
            this.btnXP_100.Click += new System.EventHandler(this.btnXP_100_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGrandma);
            this.tabControl1.Controls.Add(this.tabGrandpa);
            this.tabControl1.Controls.Add(this.tabMother);
            this.tabControl1.Controls.Add(this.tabFather);
            this.tabControl1.Controls.Add(this.lblBrother);
            this.tabControl1.Controls.Add(this.lblSister);
            this.tabControl1.Location = new System.Drawing.Point(200, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(325, 187);
            this.tabControl1.TabIndex = 22;
            // 
            // tabGrandma
            // 
            this.tabGrandma.Controls.Add(this.lblGrandmaCPS);
            this.tabGrandma.Controls.Add(this.pictureBox1);
            this.tabGrandma.Controls.Add(this.lblGrandmas);
            this.tabGrandma.Controls.Add(this.btnGrandma);
            this.tabGrandma.Controls.Add(this.label1);
            this.tabGrandma.Location = new System.Drawing.Point(4, 22);
            this.tabGrandma.Name = "tabGrandma";
            this.tabGrandma.Padding = new System.Windows.Forms.Padding(3);
            this.tabGrandma.Size = new System.Drawing.Size(317, 161);
            this.tabGrandma.TabIndex = 0;
            this.tabGrandma.Text = "Grandma";
            this.tabGrandma.UseVisualStyleBackColor = true;
            // 
            // lblGrandmaCPS
            // 
            this.lblGrandmaCPS.AutoSize = true;
            this.lblGrandmaCPS.Location = new System.Drawing.Point(188, 30);
            this.lblGrandmaCPS.Name = "lblGrandmaCPS";
            this.lblGrandmaCPS.Size = new System.Drawing.Size(40, 13);
            this.lblGrandmaCPS.TabIndex = 14;
            this.lblGrandmaCPS.Text = "CPS: 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // tabGrandpa
            // 
            this.tabGrandpa.Location = new System.Drawing.Point(4, 22);
            this.tabGrandpa.Name = "tabGrandpa";
            this.tabGrandpa.Padding = new System.Windows.Forms.Padding(3);
            this.tabGrandpa.Size = new System.Drawing.Size(317, 161);
            this.tabGrandpa.TabIndex = 1;
            this.tabGrandpa.Text = "Grandpa";
            this.tabGrandpa.UseVisualStyleBackColor = true;
            // 
            // tabMother
            // 
            this.tabMother.Location = new System.Drawing.Point(4, 22);
            this.tabMother.Name = "tabMother";
            this.tabMother.Size = new System.Drawing.Size(317, 161);
            this.tabMother.TabIndex = 2;
            this.tabMother.Text = "Mother";
            this.tabMother.UseVisualStyleBackColor = true;
            // 
            // tabFather
            // 
            this.tabFather.Location = new System.Drawing.Point(4, 22);
            this.tabFather.Name = "tabFather";
            this.tabFather.Size = new System.Drawing.Size(317, 161);
            this.tabFather.TabIndex = 3;
            this.tabFather.Text = "Father";
            this.tabFather.UseVisualStyleBackColor = true;
            // 
            // lblBrother
            // 
            this.lblBrother.Location = new System.Drawing.Point(4, 22);
            this.lblBrother.Name = "lblBrother";
            this.lblBrother.Size = new System.Drawing.Size(317, 161);
            this.lblBrother.TabIndex = 4;
            this.lblBrother.Text = "Brother";
            this.lblBrother.UseVisualStyleBackColor = true;
            // 
            // lblSister
            // 
            this.lblSister.Location = new System.Drawing.Point(4, 22);
            this.lblSister.Name = "lblSister";
            this.lblSister.Size = new System.Drawing.Size(317, 161);
            this.lblSister.TabIndex = 5;
            this.lblSister.Text = "Sister";
            this.lblSister.UseVisualStyleBackColor = true;
            // 
            // tooltip1
            // 
            this.tooltip1.AutoPopDelay = 5000;
            this.tooltip1.InitialDelay = 200;
            this.tooltip1.ReshowDelay = 100;
            this.tooltip1.Tag = "Test123";
            // 
            // lblLoveValue
            // 
            this.lblLoveValue.AutoSize = true;
            this.lblLoveValue.Location = new System.Drawing.Point(74, 225);
            this.lblLoveValue.Name = "lblLoveValue";
            this.lblLoveValue.Size = new System.Drawing.Size(36, 13);
            this.lblLoveValue.TabIndex = 24;
            this.lblLoveValue.Text = "0/400";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuyLootBox);
            this.groupBox1.Controls.Add(this.btnCookieDebug);
            this.groupBox1.Controls.Add(this.textboxCookieDebug);
            this.groupBox1.Location = new System.Drawing.Point(549, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 133);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Debug menu";
            // 
            // btnCookieDebug
            // 
            this.btnCookieDebug.Location = new System.Drawing.Point(158, 20);
            this.btnCookieDebug.Name = "btnCookieDebug";
            this.btnCookieDebug.Size = new System.Drawing.Size(75, 20);
            this.btnCookieDebug.TabIndex = 1;
            this.btnCookieDebug.Text = "Add cookies";
            this.btnCookieDebug.UseVisualStyleBackColor = true;
            this.btnCookieDebug.Click += new System.EventHandler(this.btnCookieDebug_Click);
            // 
            // textboxCookieDebug
            // 
            this.textboxCookieDebug.Location = new System.Drawing.Point(7, 20);
            this.textboxCookieDebug.Name = "textboxCookieDebug";
            this.textboxCookieDebug.Size = new System.Drawing.Size(145, 20);
            this.textboxCookieDebug.TabIndex = 0;
            this.textboxCookieDebug.TextChanged += new System.EventHandler(this.textboxCookieDebug_TextChanged);
            // 
            // btnBuyLootBox
            // 
            this.btnBuyLootBox.Location = new System.Drawing.Point(158, 47);
            this.btnBuyLootBox.Name = "btnBuyLootBox";
            this.btnBuyLootBox.Size = new System.Drawing.Size(75, 23);
            this.btnBuyLootBox.TabIndex = 2;
            this.btnBuyLootBox.Text = "Buy loot box";
            this.btnBuyLootBox.UseVisualStyleBackColor = true;
            this.btnBuyLootBox.Click += new System.EventHandler(this.btnBuyLootBox_Click);
            // 
            // lblLootBoxCount
            // 
            this.lblLootBoxCount.AutoSize = true;
            this.lblLootBoxCount.Location = new System.Drawing.Point(13, 25);
            this.lblLootBoxCount.Name = "lblLootBoxCount";
            this.lblLootBoxCount.Size = new System.Drawing.Size(90, 13);
            this.lblLootBoxCount.TabIndex = 26;
            this.lblLootBoxCount.Text = "Loot box count: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLootBoxCount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblLoveValue);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnXP_100);
            this.Controls.Add(this.btnXP_10);
            this.Controls.Add(this.btnXP_1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.barLove);
            this.Controls.Add(this.PesTable);
            this.Controls.Add(this.PesPlant);
            this.Controls.Add(this.lblCookies);
            this.Controls.Add(this.btnCookies);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PesPlant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PesTable)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabGrandma.ResumeLayout(false);
            this.tabGrandma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCookies;
        private System.Windows.Forms.Label lblCookies;
        private System.Windows.Forms.Button btnGrandma;
        private System.Windows.Forms.Label lblGrandmas;
        private System.Windows.Forms.Timer CookieTimer;
        private System.Windows.Forms.PictureBox PesPlant;
        private System.Windows.Forms.PictureBox PesTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar barLove;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnXP_1;
        private System.Windows.Forms.Button btnXP_10;
        private System.Windows.Forms.Button btnXP_100;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGrandma;
        private System.Windows.Forms.TabPage tabGrandpa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblGrandmaCPS;
        private System.Windows.Forms.TabPage tabMother;
        private System.Windows.Forms.TabPage tabFather;
        private System.Windows.Forms.TabPage lblBrother;
        private System.Windows.Forms.TabPage lblSister;
        private System.Windows.Forms.ToolTip tooltip1;
        private System.Windows.Forms.Label lblLoveValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCookieDebug;
        private System.Windows.Forms.TextBox textboxCookieDebug;
        private System.Windows.Forms.Button btnBuyLootBox;
        private System.Windows.Forms.Label lblLootBoxCount;
    }
}

