﻿namespace CarreraAutos
{
    partial class SeleccionAutos
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Dificil = new System.Windows.Forms.Button();
            this.Medio = new System.Windows.Forms.Button();
            this.Facil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(15, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(497, 422);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "CORRER";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(257, 422);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 38);
            this.button3.TabIndex = 10;
            this.button3.Text = "< Cambiar COCHE >";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CarreraAutos.Properties.Resources.R1;
            this.pictureBox3.Location = new System.Drawing.Point(56, 44);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CarreraAutos.Properties.Resources.Car1_Orange;
            this.pictureBox2.Location = new System.Drawing.Point(186, 222);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(351, 149);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CarreraAutos.Properties.Resources.Background2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(731, 472);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CarreraAutos.Properties.Resources.R1;
            this.pictureBox4.Location = new System.Drawing.Point(108, 44);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(46, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Dificil
            // 
            this.Dificil.BackColor = System.Drawing.Color.Black;
            this.Dificil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Dificil.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dificil.ForeColor = System.Drawing.Color.White;
            this.Dificil.Location = new System.Drawing.Point(552, 376);
            this.Dificil.Name = "Dificil";
            this.Dificil.Size = new System.Drawing.Size(167, 41);
            this.Dificil.TabIndex = 16;
            this.Dificil.Text = "DIFICIL";
            this.Dificil.UseVisualStyleBackColor = false;
            this.Dificil.Visible = false;
            this.Dificil.Click += new System.EventHandler(this.Dificil_Click);
            // 
            // Medio
            // 
            this.Medio.BackColor = System.Drawing.Color.Black;
            this.Medio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Medio.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medio.ForeColor = System.Drawing.Color.White;
            this.Medio.Location = new System.Drawing.Point(552, 330);
            this.Medio.Name = "Medio";
            this.Medio.Size = new System.Drawing.Size(167, 41);
            this.Medio.TabIndex = 15;
            this.Medio.Text = "Medio";
            this.Medio.UseVisualStyleBackColor = false;
            this.Medio.Visible = false;
            this.Medio.Click += new System.EventHandler(this.Medio_Click);
            // 
            // Facil
            // 
            this.Facil.BackColor = System.Drawing.Color.Black;
            this.Facil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Facil.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Facil.ForeColor = System.Drawing.Color.White;
            this.Facil.Location = new System.Drawing.Point(552, 286);
            this.Facil.Name = "Facil";
            this.Facil.Size = new System.Drawing.Size(167, 41);
            this.Facil.TabIndex = 14;
            this.Facil.Text = "Facil";
            this.Facil.UseVisualStyleBackColor = false;
            this.Facil.Visible = false;
            this.Facil.Click += new System.EventHandler(this.Facil_Click);
            // 
            // SeleccionAutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 472);
            this.Controls.Add(this.Dificil);
            this.Controls.Add(this.Medio);
            this.Controls.Add(this.Facil);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SeleccionAutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeleccionAutos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SeleccionAutos_FormClosed);
            this.Load += new System.EventHandler(this.SeleccionAutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button Dificil;
        private System.Windows.Forms.Button Medio;
        private System.Windows.Forms.Button Facil;
    }
}