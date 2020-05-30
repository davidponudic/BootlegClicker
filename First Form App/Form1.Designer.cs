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
            this.lblGrandmaCost = new System.Windows.Forms.Label();
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
            this.btnGrandpa = new System.Windows.Forms.Button();
            this.lblGrandpaCost = new System.Windows.Forms.Label();
            this.lblGrandpaCPS = new System.Windows.Forms.Label();
            this.lblGrandpas = new System.Windows.Forms.Label();
            this.tabMother = new System.Windows.Forms.TabPage();
            this.lblMotherCost = new System.Windows.Forms.Label();
            this.btnMother = new System.Windows.Forms.Button();
            this.lblMothers = new System.Windows.Forms.Label();
            this.tabFather = new System.Windows.Forms.TabPage();
            this.lblFatherCost = new System.Windows.Forms.Label();
            this.btnFather = new System.Windows.Forms.Button();
            this.lblFathers = new System.Windows.Forms.Label();
            this.lblBrother = new System.Windows.Forms.TabPage();
            this.lblBrotherCost = new System.Windows.Forms.Label();
            this.btnBrother = new System.Windows.Forms.Button();
            this.lblBrothers = new System.Windows.Forms.Label();
            this.lblSister = new System.Windows.Forms.TabPage();
            this.lblSisterCost = new System.Windows.Forms.Label();
            this.btnSister = new System.Windows.Forms.Button();
            this.lblSisters = new System.Windows.Forms.Label();
            this.tooltip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblLoveValue = new System.Windows.Forms.Label();
            this.textboxCookieDebug = new System.Windows.Forms.TextBox();
            this.btnCookieDebug = new System.Windows.Forms.Button();
            this.textboxGrandmaDebug = new System.Windows.Forms.TextBox();
            this.btnGrandmaDebug = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabDebugAdd = new System.Windows.Forms.TabPage();
            this.btnSisterDebug = new System.Windows.Forms.Button();
            this.btnBrotherDebug = new System.Windows.Forms.Button();
            this.textboxSisterDebug = new System.Windows.Forms.TextBox();
            this.textboxBrotherDebug = new System.Windows.Forms.TextBox();
            this.btnFatherDebug = new System.Windows.Forms.Button();
            this.btnMotherDebug = new System.Windows.Forms.Button();
            this.btnGrandpaDebug = new System.Windows.Forms.Button();
            this.textboxFatherDebug = new System.Windows.Forms.TextBox();
            this.textboxMotherDebug = new System.Windows.Forms.TextBox();
            this.textboxGrandpaDebug = new System.Windows.Forms.TextBox();
            this.tabDebugInfo = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.PesPlant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PesTable)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabGrandma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabGrandpa.SuspendLayout();
            this.tabMother.SuspendLayout();
            this.tabFather.SuspendLayout();
            this.lblBrother.SuspendLayout();
            this.lblSister.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabDebugAdd.SuspendLayout();
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
            this.btnGrandma.Location = new System.Drawing.Point(183, 230);
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
            this.lblGrandmas.Location = new System.Drawing.Point(188, 12);
            this.lblGrandmas.Name = "lblGrandmas";
            this.lblGrandmas.Size = new System.Drawing.Size(87, 13);
            this.lblGrandmas.TabIndex = 3;
            this.lblGrandmas.Text = "Grandma level: 0";
            // 
            // CookieTimer
            // 
            this.CookieTimer.Tick += new System.EventHandler(this.CookieTimer_Tick);
            // 
            // PesPlant
            // 
            this.PesPlant.Image = ((System.Drawing.Image)(resources.GetObject("PesPlant.Image")));
            this.PesPlant.Location = new System.Drawing.Point(205, 12);
            this.PesPlant.Name = "PesPlant";
            this.PesPlant.Size = new System.Drawing.Size(239, 281);
            this.PesPlant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PesPlant.TabIndex = 4;
            this.PesPlant.TabStop = false;
            // 
            // PesTable
            // 
            this.PesTable.Image = ((System.Drawing.Image)(resources.GetObject("PesTable.Image")));
            this.PesTable.Location = new System.Drawing.Point(205, 12);
            this.PesTable.Name = "PesTable";
            this.PesTable.Size = new System.Drawing.Size(239, 281);
            this.PesTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PesTable.TabIndex = 5;
            this.PesTable.TabStop = false;
            this.PesTable.Click += new System.EventHandler(this.PesTable_Click);
            // 
            // lblGrandmaCost
            // 
            this.lblGrandmaCost.AutoSize = true;
            this.lblGrandmaCost.Location = new System.Drawing.Point(188, 214);
            this.lblGrandmaCost.Name = "lblGrandmaCost";
            this.lblGrandmaCost.Size = new System.Drawing.Size(46, 13);
            this.lblGrandmaCost.TabIndex = 12;
            this.lblGrandmaCost.Text = "Cost: 20";
            // 
            // barLove
            // 
            this.barLove.Location = new System.Drawing.Point(31, 327);
            this.barLove.Maximum = 400;
            this.barLove.Name = "barLove";
            this.barLove.Size = new System.Drawing.Size(453, 23);
            this.barLove.Step = 1;
            this.barLove.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 305);
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
            this.btnXP_1.Location = new System.Drawing.Point(31, 356);
            this.btnXP_1.Name = "btnXP_1";
            this.btnXP_1.Size = new System.Drawing.Size(75, 23);
            this.btnXP_1.TabIndex = 19;
            this.btnXP_1.Text = "btnXP_1";
            this.btnXP_1.UseVisualStyleBackColor = true;
            this.btnXP_1.Click += new System.EventHandler(this.btnXP_1_Click);
            // 
            // btnXP_10
            // 
            this.btnXP_10.Location = new System.Drawing.Point(123, 356);
            this.btnXP_10.Name = "btnXP_10";
            this.btnXP_10.Size = new System.Drawing.Size(75, 23);
            this.btnXP_10.TabIndex = 20;
            this.btnXP_10.Text = "btnXP_10";
            this.btnXP_10.UseVisualStyleBackColor = true;
            this.btnXP_10.Click += new System.EventHandler(this.btnXP_10_Click);
            // 
            // btnXP_100
            // 
            this.btnXP_100.Location = new System.Drawing.Point(218, 356);
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
            this.tabControl1.Location = new System.Drawing.Point(468, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(320, 285);
            this.tabControl1.TabIndex = 22;
            // 
            // tabGrandma
            // 
            this.tabGrandma.Controls.Add(this.lblGrandmaCPS);
            this.tabGrandma.Controls.Add(this.pictureBox1);
            this.tabGrandma.Controls.Add(this.lblGrandmas);
            this.tabGrandma.Controls.Add(this.btnGrandma);
            this.tabGrandma.Controls.Add(this.lblGrandmaCost);
            this.tabGrandma.Location = new System.Drawing.Point(4, 22);
            this.tabGrandma.Name = "tabGrandma";
            this.tabGrandma.Padding = new System.Windows.Forms.Padding(3);
            this.tabGrandma.Size = new System.Drawing.Size(312, 259);
            this.tabGrandma.TabIndex = 0;
            this.tabGrandma.Text = "Grandma";
            this.tabGrandma.UseVisualStyleBackColor = true;
            // 
            // lblGrandmaCPS
            // 
            this.lblGrandmaCPS.AutoSize = true;
            this.lblGrandmaCPS.Location = new System.Drawing.Point(188, 29);
            this.lblGrandmaCPS.Name = "lblGrandmaCPS";
            this.lblGrandmaCPS.Size = new System.Drawing.Size(40, 13);
            this.lblGrandmaCPS.TabIndex = 14;
            this.lblGrandmaCPS.Text = "CPS: 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // tabGrandpa
            // 
            this.tabGrandpa.Controls.Add(this.btnGrandpa);
            this.tabGrandpa.Controls.Add(this.lblGrandpaCost);
            this.tabGrandpa.Controls.Add(this.lblGrandpaCPS);
            this.tabGrandpa.Controls.Add(this.lblGrandpas);
            this.tabGrandpa.Location = new System.Drawing.Point(4, 22);
            this.tabGrandpa.Name = "tabGrandpa";
            this.tabGrandpa.Padding = new System.Windows.Forms.Padding(3);
            this.tabGrandpa.Size = new System.Drawing.Size(312, 259);
            this.tabGrandpa.TabIndex = 1;
            this.tabGrandpa.Text = "Grandpa";
            this.tabGrandpa.UseVisualStyleBackColor = true;
            // 
            // btnGrandpa
            // 
            this.btnGrandpa.Location = new System.Drawing.Point(183, 230);
            this.btnGrandpa.Name = "btnGrandpa";
            this.btnGrandpa.Size = new System.Drawing.Size(123, 23);
            this.btnGrandpa.TabIndex = 3;
            this.btnGrandpa.Text = "Call grandpa";
            this.btnGrandpa.UseVisualStyleBackColor = true;
            // 
            // lblGrandpaCost
            // 
            this.lblGrandpaCost.AutoSize = true;
            this.lblGrandpaCost.Location = new System.Drawing.Point(188, 214);
            this.lblGrandpaCost.Name = "lblGrandpaCost";
            this.lblGrandpaCost.Size = new System.Drawing.Size(58, 13);
            this.lblGrandpaCost.TabIndex = 2;
            this.lblGrandpaCost.Text = "Cost: 1000";
            // 
            // lblGrandpaCPS
            // 
            this.lblGrandpaCPS.AutoSize = true;
            this.lblGrandpaCPS.Location = new System.Drawing.Point(188, 29);
            this.lblGrandpaCPS.Name = "lblGrandpaCPS";
            this.lblGrandpaCPS.Size = new System.Drawing.Size(117, 13);
            this.lblGrandpaCPS.TabIndex = 1;
            this.lblGrandpaCPS.Text = "Bonus grandma CPS: 0";
            // 
            // lblGrandpas
            // 
            this.lblGrandpas.AutoSize = true;
            this.lblGrandpas.Location = new System.Drawing.Point(188, 12);
            this.lblGrandpas.Name = "lblGrandpas";
            this.lblGrandpas.Size = new System.Drawing.Size(85, 13);
            this.lblGrandpas.TabIndex = 0;
            this.lblGrandpas.Text = "Grandpa level: 0";
            // 
            // tabMother
            // 
            this.tabMother.Controls.Add(this.lblMotherCost);
            this.tabMother.Controls.Add(this.btnMother);
            this.tabMother.Controls.Add(this.lblMothers);
            this.tabMother.Location = new System.Drawing.Point(4, 22);
            this.tabMother.Name = "tabMother";
            this.tabMother.Size = new System.Drawing.Size(312, 259);
            this.tabMother.TabIndex = 2;
            this.tabMother.Text = "Mother";
            this.tabMother.UseVisualStyleBackColor = true;
            // 
            // lblMotherCost
            // 
            this.lblMotherCost.AutoSize = true;
            this.lblMotherCost.Location = new System.Drawing.Point(188, 214);
            this.lblMotherCost.Name = "lblMotherCost";
            this.lblMotherCost.Size = new System.Drawing.Size(34, 13);
            this.lblMotherCost.TabIndex = 2;
            this.lblMotherCost.Text = "Cost: ";
            // 
            // btnMother
            // 
            this.btnMother.Location = new System.Drawing.Point(183, 230);
            this.btnMother.Name = "btnMother";
            this.btnMother.Size = new System.Drawing.Size(123, 23);
            this.btnMother.TabIndex = 1;
            this.btnMother.Text = "Call mother";
            this.btnMother.UseVisualStyleBackColor = true;
            // 
            // lblMothers
            // 
            this.lblMothers.AutoSize = true;
            this.lblMothers.Location = new System.Drawing.Point(188, 12);
            this.lblMothers.Name = "lblMothers";
            this.lblMothers.Size = new System.Drawing.Size(77, 13);
            this.lblMothers.TabIndex = 0;
            this.lblMothers.Text = "Mother level: 0";
            // 
            // tabFather
            // 
            this.tabFather.Controls.Add(this.lblFatherCost);
            this.tabFather.Controls.Add(this.btnFather);
            this.tabFather.Controls.Add(this.lblFathers);
            this.tabFather.Location = new System.Drawing.Point(4, 22);
            this.tabFather.Name = "tabFather";
            this.tabFather.Size = new System.Drawing.Size(312, 259);
            this.tabFather.TabIndex = 3;
            this.tabFather.Text = "Father";
            this.tabFather.UseVisualStyleBackColor = true;
            // 
            // lblFatherCost
            // 
            this.lblFatherCost.AutoSize = true;
            this.lblFatherCost.Location = new System.Drawing.Point(188, 214);
            this.lblFatherCost.Name = "lblFatherCost";
            this.lblFatherCost.Size = new System.Drawing.Size(34, 13);
            this.lblFatherCost.TabIndex = 2;
            this.lblFatherCost.Text = "Cost: ";
            // 
            // btnFather
            // 
            this.btnFather.Location = new System.Drawing.Point(183, 230);
            this.btnFather.Name = "btnFather";
            this.btnFather.Size = new System.Drawing.Size(123, 23);
            this.btnFather.TabIndex = 1;
            this.btnFather.Text = "Call father";
            this.btnFather.UseVisualStyleBackColor = true;
            // 
            // lblFathers
            // 
            this.lblFathers.AutoSize = true;
            this.lblFathers.Location = new System.Drawing.Point(188, 12);
            this.lblFathers.Name = "lblFathers";
            this.lblFathers.Size = new System.Drawing.Size(74, 13);
            this.lblFathers.TabIndex = 0;
            this.lblFathers.Text = "Father level: 0";
            // 
            // lblBrother
            // 
            this.lblBrother.Controls.Add(this.lblBrotherCost);
            this.lblBrother.Controls.Add(this.btnBrother);
            this.lblBrother.Controls.Add(this.lblBrothers);
            this.lblBrother.Location = new System.Drawing.Point(4, 22);
            this.lblBrother.Name = "lblBrother";
            this.lblBrother.Size = new System.Drawing.Size(312, 259);
            this.lblBrother.TabIndex = 4;
            this.lblBrother.Text = "Brother";
            this.lblBrother.UseVisualStyleBackColor = true;
            // 
            // lblBrotherCost
            // 
            this.lblBrotherCost.AutoSize = true;
            this.lblBrotherCost.Location = new System.Drawing.Point(188, 214);
            this.lblBrotherCost.Name = "lblBrotherCost";
            this.lblBrotherCost.Size = new System.Drawing.Size(34, 13);
            this.lblBrotherCost.TabIndex = 2;
            this.lblBrotherCost.Text = "Cost: ";
            // 
            // btnBrother
            // 
            this.btnBrother.Location = new System.Drawing.Point(183, 230);
            this.btnBrother.Name = "btnBrother";
            this.btnBrother.Size = new System.Drawing.Size(123, 23);
            this.btnBrother.TabIndex = 1;
            this.btnBrother.Text = "Call brother";
            this.btnBrother.UseVisualStyleBackColor = true;
            // 
            // lblBrothers
            // 
            this.lblBrothers.AutoSize = true;
            this.lblBrothers.Location = new System.Drawing.Point(188, 12);
            this.lblBrothers.Name = "lblBrothers";
            this.lblBrothers.Size = new System.Drawing.Size(78, 13);
            this.lblBrothers.TabIndex = 0;
            this.lblBrothers.Text = "Brother level: 0";
            // 
            // lblSister
            // 
            this.lblSister.Controls.Add(this.lblSisterCost);
            this.lblSister.Controls.Add(this.btnSister);
            this.lblSister.Controls.Add(this.lblSisters);
            this.lblSister.Location = new System.Drawing.Point(4, 22);
            this.lblSister.Name = "lblSister";
            this.lblSister.Size = new System.Drawing.Size(312, 259);
            this.lblSister.TabIndex = 5;
            this.lblSister.Text = "Sister";
            this.lblSister.UseVisualStyleBackColor = true;
            // 
            // lblSisterCost
            // 
            this.lblSisterCost.AutoSize = true;
            this.lblSisterCost.Location = new System.Drawing.Point(188, 214);
            this.lblSisterCost.Name = "lblSisterCost";
            this.lblSisterCost.Size = new System.Drawing.Size(34, 13);
            this.lblSisterCost.TabIndex = 2;
            this.lblSisterCost.Text = "Cost: ";
            // 
            // btnSister
            // 
            this.btnSister.Location = new System.Drawing.Point(183, 230);
            this.btnSister.Name = "btnSister";
            this.btnSister.Size = new System.Drawing.Size(123, 23);
            this.btnSister.TabIndex = 1;
            this.btnSister.Text = "Call sister";
            this.btnSister.UseVisualStyleBackColor = true;
            // 
            // lblSisters
            // 
            this.lblSisters.AutoSize = true;
            this.lblSisters.Location = new System.Drawing.Point(188, 12);
            this.lblSisters.Name = "lblSisters";
            this.lblSisters.Size = new System.Drawing.Size(70, 13);
            this.lblSisters.TabIndex = 0;
            this.lblSisters.Text = "Sister level: 0";
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
            this.lblLoveValue.Location = new System.Drawing.Point(71, 305);
            this.lblLoveValue.Name = "lblLoveValue";
            this.lblLoveValue.Size = new System.Drawing.Size(36, 13);
            this.lblLoveValue.TabIndex = 24;
            this.lblLoveValue.Text = "0/400";
            // 
            // textboxCookieDebug
            // 
            this.textboxCookieDebug.Location = new System.Drawing.Point(3, 6);
            this.textboxCookieDebug.Name = "textboxCookieDebug";
            this.textboxCookieDebug.Size = new System.Drawing.Size(126, 20);
            this.textboxCookieDebug.TabIndex = 0;
            this.textboxCookieDebug.TextChanged += new System.EventHandler(this.textboxCookieDebug_TextChanged);
            // 
            // btnCookieDebug
            // 
            this.btnCookieDebug.Location = new System.Drawing.Point(135, 6);
            this.btnCookieDebug.Name = "btnCookieDebug";
            this.btnCookieDebug.Size = new System.Drawing.Size(94, 20);
            this.btnCookieDebug.TabIndex = 1;
            this.btnCookieDebug.Text = "Add cookies";
            this.btnCookieDebug.UseVisualStyleBackColor = true;
            this.btnCookieDebug.Click += new System.EventHandler(this.btnCookieDebug_Click);
            // 
            // textboxGrandmaDebug
            // 
            this.textboxGrandmaDebug.Location = new System.Drawing.Point(3, 32);
            this.textboxGrandmaDebug.Name = "textboxGrandmaDebug";
            this.textboxGrandmaDebug.Size = new System.Drawing.Size(126, 20);
            this.textboxGrandmaDebug.TabIndex = 2;
            this.textboxGrandmaDebug.TextChanged += new System.EventHandler(this.textboxGrandmaDebug_TextChanged);
            // 
            // btnGrandmaDebug
            // 
            this.btnGrandmaDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrandmaDebug.Location = new System.Drawing.Point(136, 32);
            this.btnGrandmaDebug.Name = "btnGrandmaDebug";
            this.btnGrandmaDebug.Size = new System.Drawing.Size(93, 20);
            this.btnGrandmaDebug.TabIndex = 3;
            this.btnGrandmaDebug.Text = "Add grandmas";
            this.btnGrandmaDebug.UseVisualStyleBackColor = true;
            this.btnGrandmaDebug.Click += new System.EventHandler(this.btnGrandmaDebug_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabDebugAdd);
            this.tabControl2.Controls.Add(this.tabDebugInfo);
            this.tabControl2.Location = new System.Drawing.Point(547, 305);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(241, 284);
            this.tabControl2.TabIndex = 26;
            // 
            // tabDebugAdd
            // 
            this.tabDebugAdd.Controls.Add(this.btnSisterDebug);
            this.tabDebugAdd.Controls.Add(this.btnBrotherDebug);
            this.tabDebugAdd.Controls.Add(this.textboxSisterDebug);
            this.tabDebugAdd.Controls.Add(this.textboxBrotherDebug);
            this.tabDebugAdd.Controls.Add(this.btnFatherDebug);
            this.tabDebugAdd.Controls.Add(this.btnMotherDebug);
            this.tabDebugAdd.Controls.Add(this.btnGrandpaDebug);
            this.tabDebugAdd.Controls.Add(this.textboxFatherDebug);
            this.tabDebugAdd.Controls.Add(this.textboxMotherDebug);
            this.tabDebugAdd.Controls.Add(this.textboxGrandpaDebug);
            this.tabDebugAdd.Controls.Add(this.btnGrandmaDebug);
            this.tabDebugAdd.Controls.Add(this.textboxCookieDebug);
            this.tabDebugAdd.Controls.Add(this.textboxGrandmaDebug);
            this.tabDebugAdd.Controls.Add(this.btnCookieDebug);
            this.tabDebugAdd.Location = new System.Drawing.Point(4, 22);
            this.tabDebugAdd.Name = "tabDebugAdd";
            this.tabDebugAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabDebugAdd.Size = new System.Drawing.Size(233, 258);
            this.tabDebugAdd.TabIndex = 0;
            this.tabDebugAdd.Text = "Add";
            this.tabDebugAdd.UseVisualStyleBackColor = true;
            // 
            // btnSisterDebug
            // 
            this.btnSisterDebug.Location = new System.Drawing.Point(136, 163);
            this.btnSisterDebug.Name = "btnSisterDebug";
            this.btnSisterDebug.Size = new System.Drawing.Size(93, 20);
            this.btnSisterDebug.TabIndex = 13;
            this.btnSisterDebug.Text = "Add sisters";
            this.btnSisterDebug.UseVisualStyleBackColor = true;
            this.btnSisterDebug.Click += new System.EventHandler(this.btnSisterDebug_Click);
            // 
            // btnBrotherDebug
            // 
            this.btnBrotherDebug.Location = new System.Drawing.Point(136, 137);
            this.btnBrotherDebug.Name = "btnBrotherDebug";
            this.btnBrotherDebug.Size = new System.Drawing.Size(93, 20);
            this.btnBrotherDebug.TabIndex = 12;
            this.btnBrotherDebug.Text = "Add brothers";
            this.btnBrotherDebug.UseVisualStyleBackColor = true;
            this.btnBrotherDebug.Click += new System.EventHandler(this.btnBrotherDebug_Click);
            // 
            // textboxSisterDebug
            // 
            this.textboxSisterDebug.Location = new System.Drawing.Point(3, 163);
            this.textboxSisterDebug.Name = "textboxSisterDebug";
            this.textboxSisterDebug.Size = new System.Drawing.Size(126, 20);
            this.textboxSisterDebug.TabIndex = 11;
            this.textboxSisterDebug.TextChanged += new System.EventHandler(this.textboxSisterDebug_TextChanged);
            // 
            // textboxBrotherDebug
            // 
            this.textboxBrotherDebug.Location = new System.Drawing.Point(3, 137);
            this.textboxBrotherDebug.Name = "textboxBrotherDebug";
            this.textboxBrotherDebug.Size = new System.Drawing.Size(126, 20);
            this.textboxBrotherDebug.TabIndex = 10;
            this.textboxBrotherDebug.TextChanged += new System.EventHandler(this.textboxBrotherDebug_TextChanged);
            // 
            // btnFatherDebug
            // 
            this.btnFatherDebug.Location = new System.Drawing.Point(136, 111);
            this.btnFatherDebug.Name = "btnFatherDebug";
            this.btnFatherDebug.Size = new System.Drawing.Size(93, 20);
            this.btnFatherDebug.TabIndex = 9;
            this.btnFatherDebug.Text = "Add fathers";
            this.btnFatherDebug.UseVisualStyleBackColor = true;
            this.btnFatherDebug.Click += new System.EventHandler(this.btnFatherDebug_Click);
            // 
            // btnMotherDebug
            // 
            this.btnMotherDebug.Location = new System.Drawing.Point(136, 85);
            this.btnMotherDebug.Name = "btnMotherDebug";
            this.btnMotherDebug.Size = new System.Drawing.Size(93, 20);
            this.btnMotherDebug.TabIndex = 8;
            this.btnMotherDebug.Text = "Add mothers";
            this.btnMotherDebug.UseVisualStyleBackColor = true;
            this.btnMotherDebug.Click += new System.EventHandler(this.btnMotherDebug_Click);
            // 
            // btnGrandpaDebug
            // 
            this.btnGrandpaDebug.Location = new System.Drawing.Point(136, 59);
            this.btnGrandpaDebug.Name = "btnGrandpaDebug";
            this.btnGrandpaDebug.Size = new System.Drawing.Size(93, 20);
            this.btnGrandpaDebug.TabIndex = 7;
            this.btnGrandpaDebug.Text = "Add grandpas";
            this.btnGrandpaDebug.UseVisualStyleBackColor = true;
            this.btnGrandpaDebug.Click += new System.EventHandler(this.btnGrandpaDebug_Click);
            // 
            // textboxFatherDebug
            // 
            this.textboxFatherDebug.Location = new System.Drawing.Point(3, 111);
            this.textboxFatherDebug.Name = "textboxFatherDebug";
            this.textboxFatherDebug.Size = new System.Drawing.Size(126, 20);
            this.textboxFatherDebug.TabIndex = 6;
            this.textboxFatherDebug.TextChanged += new System.EventHandler(this.textboxFatherDebug_TextChanged);
            // 
            // textboxMotherDebug
            // 
            this.textboxMotherDebug.Location = new System.Drawing.Point(3, 85);
            this.textboxMotherDebug.Name = "textboxMotherDebug";
            this.textboxMotherDebug.Size = new System.Drawing.Size(126, 20);
            this.textboxMotherDebug.TabIndex = 5;
            this.textboxMotherDebug.TextChanged += new System.EventHandler(this.textboxMotherDebug_TextChanged);
            // 
            // textboxGrandpaDebug
            // 
            this.textboxGrandpaDebug.Location = new System.Drawing.Point(3, 59);
            this.textboxGrandpaDebug.Name = "textboxGrandpaDebug";
            this.textboxGrandpaDebug.Size = new System.Drawing.Size(126, 20);
            this.textboxGrandpaDebug.TabIndex = 4;
            this.textboxGrandpaDebug.TextChanged += new System.EventHandler(this.textboxGrandpaDebug_TextChanged);
            // 
            // tabDebugInfo
            // 
            this.tabDebugInfo.Location = new System.Drawing.Point(4, 22);
            this.tabDebugInfo.Name = "tabDebugInfo";
            this.tabDebugInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabDebugInfo.Size = new System.Drawing.Size(233, 258);
            this.tabDebugInfo.TabIndex = 1;
            this.tabDebugInfo.Text = "Info";
            this.tabDebugInfo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 601);
            this.Controls.Add(this.tabControl2);
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
            this.tabGrandpa.ResumeLayout(false);
            this.tabGrandpa.PerformLayout();
            this.tabMother.ResumeLayout(false);
            this.tabMother.PerformLayout();
            this.tabFather.ResumeLayout(false);
            this.tabFather.PerformLayout();
            this.lblBrother.ResumeLayout(false);
            this.lblBrother.PerformLayout();
            this.lblSister.ResumeLayout(false);
            this.lblSister.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabDebugAdd.ResumeLayout(false);
            this.tabDebugAdd.PerformLayout();
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
        private System.Windows.Forms.Label lblGrandmaCost;
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
        private System.Windows.Forms.TextBox textboxCookieDebug;
        private System.Windows.Forms.Button btnCookieDebug;
        private System.Windows.Forms.TextBox textboxGrandmaDebug;
        private System.Windows.Forms.Button btnGrandmaDebug;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabDebugAdd;
        private System.Windows.Forms.Button btnSisterDebug;
        private System.Windows.Forms.Button btnBrotherDebug;
        private System.Windows.Forms.TextBox textboxSisterDebug;
        private System.Windows.Forms.TextBox textboxBrotherDebug;
        private System.Windows.Forms.Button btnFatherDebug;
        private System.Windows.Forms.Button btnMotherDebug;
        private System.Windows.Forms.Button btnGrandpaDebug;
        private System.Windows.Forms.TextBox textboxFatherDebug;
        private System.Windows.Forms.TextBox textboxMotherDebug;
        private System.Windows.Forms.TextBox textboxGrandpaDebug;
        private System.Windows.Forms.TabPage tabDebugInfo;
        private System.Windows.Forms.Button btnGrandpa;
        private System.Windows.Forms.Label lblGrandpaCost;
        private System.Windows.Forms.Label lblGrandpaCPS;
        private System.Windows.Forms.Label lblGrandpas;
        private System.Windows.Forms.Label lblMotherCost;
        private System.Windows.Forms.Button btnMother;
        private System.Windows.Forms.Label lblMothers;
        private System.Windows.Forms.Label lblFatherCost;
        private System.Windows.Forms.Button btnFather;
        private System.Windows.Forms.Label lblFathers;
        private System.Windows.Forms.Label lblBrotherCost;
        private System.Windows.Forms.Button btnBrother;
        private System.Windows.Forms.Label lblBrothers;
        private System.Windows.Forms.Label lblSisterCost;
        private System.Windows.Forms.Button btnSister;
        private System.Windows.Forms.Label lblSisters;
    }
}

