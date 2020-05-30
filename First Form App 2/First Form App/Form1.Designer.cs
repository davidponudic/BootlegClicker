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
            this.lblFarm = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.btnCookies.Click += new System.EventHandler(this.button1_Click);
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
            this.btnGrandma.Text = "Buy grandma";
            this.btnGrandma.UseVisualStyleBackColor = true;
            this.btnGrandma.Click += new System.EventHandler(this.button2_Click);
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
            this.PesPlant.Location = new System.Drawing.Point(494, 12);
            this.PesPlant.Name = "PesPlant";
            this.PesPlant.Size = new System.Drawing.Size(294, 275);
            this.PesPlant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PesPlant.TabIndex = 4;
            this.PesPlant.TabStop = false;
            this.PesPlant.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PesTable
            // 
            this.PesTable.Image = ((System.Drawing.Image)(resources.GetObject("PesTable.Image")));
            this.PesTable.Location = new System.Drawing.Point(494, 12);
            this.PesTable.Name = "PesTable";
            this.PesTable.Size = new System.Drawing.Size(294, 275);
            this.PesTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PesTable.TabIndex = 5;
            this.PesTable.TabStop = false;
            // 
            // lblFarm
            // 
            this.lblFarm.AutoSize = true;
            this.lblFarm.Location = new System.Drawing.Point(197, 68);
            this.lblFarm.Name = "lblFarm";
            this.lblFarm.Size = new System.Drawing.Size(35, 13);
            this.lblFarm.TabIndex = 6;
            this.lblFarm.Text = "label1";
            this.lblFarm.Click += new System.EventHandler(this.lblFarm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(306, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(306, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(74, 376);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(47, 13);
            this.lblScore.TabIndex = 12;
            this.lblScore.Text = "Score: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFarm);
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
        private System.Windows.Forms.Label lblFarm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblScore;
    }
}

