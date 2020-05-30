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
            this.lblGrandpa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.barLove = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PesPlant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PesTable)).BeginInit();
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
            this.lblCookies.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGrandma
            // 
            this.btnGrandma.Location = new System.Drawing.Point(306, 34);
            this.btnGrandma.Name = "btnGrandma";
            this.btnGrandma.Size = new System.Drawing.Size(123, 23);
            this.btnGrandma.TabIndex = 2;
            this.btnGrandma.Text = "Call grandma";
            this.btnGrandma.UseVisualStyleBackColor = true;
            this.btnGrandma.Click += new System.EventHandler(this.btnGrandma_Click);
            // 
            // lblGrandmas
            // 
            this.lblGrandmas.AutoSize = true;
            this.lblGrandmas.Location = new System.Drawing.Point(197, 39);
            this.lblGrandmas.Name = "lblGrandmas";
            this.lblGrandmas.Size = new System.Drawing.Size(92, 13);
            this.lblGrandmas.TabIndex = 3;
            this.lblGrandmas.Text = "Grandmas level: 0";
            this.lblGrandmas.Click += new System.EventHandler(this.lblGrandmas_Click);
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
            this.PesPlant.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // lblGrandpa
            // 
            this.lblGrandpa.AutoSize = true;
            this.lblGrandpa.Location = new System.Drawing.Point(197, 68);
            this.lblGrandpa.Name = "lblGrandpa";
            this.lblGrandpa.Size = new System.Drawing.Size(85, 13);
            this.lblGrandpa.TabIndex = 6;
            this.lblGrandpa.Text = "Grandpa level: 0";
            this.lblGrandpa.Click += new System.EventHandler(this.lblGrandpa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Brother level: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sister level: 0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Call grandpa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(306, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Call brother";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(306, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Call sister";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cost: 20";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cost: 1000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cost: 20000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cost: 100000";
            // 
            // barLove
            // 
            this.barLove.Location = new System.Drawing.Point(31, 244);
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
            this.lblScore.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.barLove);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblGrandpa);
            this.Controls.Add(this.PesTable);
            this.Controls.Add(this.PesPlant);
            this.Controls.Add(this.lblGrandmas);
            this.Controls.Add(this.btnGrandma);
            this.Controls.Add(this.lblCookies);
            this.Controls.Add(this.btnCookies);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PesPlant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PesTable)).EndInit();
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
        private System.Windows.Forms.Label lblGrandpa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar barLove;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblScore;
    }
}

