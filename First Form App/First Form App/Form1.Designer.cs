using System;

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
            this.button1 = new System.Windows.Forms.Button();
            this.lblCookies = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblGrandmas = new System.Windows.Forms.Label();
            this.CookieTimer = new System.Windows.Forms.Timer(this.components);
            this.PesPlant = new System.Windows.Forms.PictureBox();
            this.PesTable = new System.Windows.Forms.PictureBox();
            this.lblCookieScore = new System.Windows.Forms.Label();
            this.lblStopButton = new System.Windows.Forms.Button();
            this.lblMinusGrandma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PesPlant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AccessibleName = "btnClickThis";
            this.button1.Location = new System.Drawing.Point(58, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Click here";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCookies
            // 
            this.lblCookies.AccessibleName = "lblHelloWorld";
            this.lblCookies.AutoSize = true;
            this.lblCookies.Location = new System.Drawing.Point(103, 63);
            this.lblCookies.Name = "lblCookies";
            this.lblCookies.Size = new System.Drawing.Size(57, 13);
            this.lblCookies.TabIndex = 1;
            this.lblCookies.Text = "Cookies: 0";
            this.lblCookies.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Buy grandma";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblGrandmas
            // 
            this.lblGrandmas.AutoSize = true;
            this.lblGrandmas.Location = new System.Drawing.Point(258, 63);
            this.lblGrandmas.Name = "lblGrandmas";
            this.lblGrandmas.Size = new System.Drawing.Size(67, 13);
            this.lblGrandmas.TabIndex = 3;
            this.lblGrandmas.Text = "Grandmas: 0";
            // 
            // CookieTimer
            // 
            this.CookieTimer.Tick += new System.EventHandler(this.CookieTimer_Tick);
            // 
            // PesPlant
            // 
            this.PesPlant.Image = ((System.Drawing.Image)(resources.GetObject("PesPlant.Image")));
            this.PesPlant.Location = new System.Drawing.Point(422, 12);
            this.PesPlant.Name = "PesPlant";
            this.PesPlant.Size = new System.Drawing.Size(346, 275);
            this.PesPlant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PesPlant.TabIndex = 4;
            this.PesPlant.TabStop = false;
            this.PesPlant.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PesTable
            // 
            this.PesTable.Image = ((System.Drawing.Image)(resources.GetObject("PesTable.Image")));
            this.PesTable.Location = new System.Drawing.Point(422, 12);
            this.PesTable.Name = "PesTable";
            this.PesTable.Size = new System.Drawing.Size(346, 275);
            this.PesTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PesTable.TabIndex = 5;
            this.PesTable.TabStop = false;
            // 
            // lblCookieScore
            // 
            this.lblCookieScore.AutoSize = true;
            this.lblCookieScore.Location = new System.Drawing.Point(72, 380);
            this.lblCookieScore.Name = "lblCookieScore";
            this.lblCookieScore.Size = new System.Drawing.Size(47, 13);
            this.lblCookieScore.TabIndex = 6;
            this.lblCookieScore.Text = "Score: 0";
            this.lblCookieScore.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblStopButton
            // 
            this.lblStopButton.Location = new System.Drawing.Point(659, 369);
            this.lblStopButton.Name = "lblStopButton";
            this.lblStopButton.Size = new System.Drawing.Size(75, 23);
            this.lblStopButton.TabIndex = 7;
            this.lblStopButton.Text = "STOP";
            this.lblStopButton.UseVisualStyleBackColor = true;
            this.lblStopButton.Click += new System.EventHandler(this.lblStopButton_Click);
            // 
            // lblMinusGrandma
            // 
            this.lblMinusGrandma.Location = new System.Drawing.Point(647, 398);
            this.lblMinusGrandma.Name = "lblMinusGrandma";
            this.lblMinusGrandma.Size = new System.Drawing.Size(98, 23);
            this.lblMinusGrandma.TabIndex = 8;
            this.lblMinusGrandma.Text = "Minus Grandma";
            this.lblMinusGrandma.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMinusGrandma);
            this.Controls.Add(this.lblStopButton);
            this.Controls.Add(this.lblCookieScore);
            this.Controls.Add(this.PesTable);
            this.Controls.Add(this.PesPlant);
            this.Controls.Add(this.lblGrandmas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblCookies);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PesPlant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCookies;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblGrandmas;
        private System.Windows.Forms.Timer CookieTimer;
        private System.Windows.Forms.PictureBox PesPlant;
        private System.Windows.Forms.PictureBox PesTable;
        private System.Windows.Forms.Label lblCookieScore;
        private System.Windows.Forms.Button lblStopButton;
        private System.Windows.Forms.Button lblMinusGrandma;
    }
}

