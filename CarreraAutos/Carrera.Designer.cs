namespace CarreraAutos
{
    partial class Carrera
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
            this.Fondo = new System.Windows.Forms.Timer(this.components);
            this.FondoB = new System.Windows.Forms.Timer(this.components);
            this.GiroRuedas = new System.Windows.Forms.Timer(this.components);
            this.Start = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.RPM = new System.Windows.Forms.Timer(this.components);
            this.Verificar = new System.Windows.Forms.Timer(this.components);
            this.llanta3 = new System.Windows.Forms.PictureBox();
            this.llanta4 = new System.Windows.Forms.PictureBox();
            this.car1 = new System.Windows.Forms.PictureBox();
            this.car2 = new System.Windows.Forms.PictureBox();
            this.cemaforo = new System.Windows.Forms.PictureBox();
            this.Fondo3 = new System.Windows.Forms.PictureBox();
            this.llanta2 = new System.Windows.Forms.PictureBox();
            this.llanta1 = new System.Windows.Forms.PictureBox();
            this.flag = new System.Windows.Forms.PictureBox();
            this.Fondo2 = new System.Windows.Forms.PictureBox();
            this.Fondo1 = new System.Windows.Forms.PictureBox();
            this.Cambio = new System.Windows.Forms.PictureBox();
            this.Indicador = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Rotacion = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.Velocidad = new System.Windows.Forms.Timer(this.components);
            this.VerVel = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Velocidad2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.llanta3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.llanta4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cemaforo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fondo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.llanta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.llanta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fondo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fondo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cambio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Indicador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Fondo
            // 
            this.Fondo.Interval = 1;
            this.Fondo.Tick += new System.EventHandler(this.Fondo_Tick);
            // 
            // FondoB
            // 
            this.FondoB.Interval = 1000;
            this.FondoB.Tick += new System.EventHandler(this.FondoB_Tick);
            // 
            // GiroRuedas
            // 
            this.GiroRuedas.Interval = 1;
            this.GiroRuedas.Tick += new System.EventHandler(this.GiroRuedas_Tick);
            // 
            // Start
            // 
            this.Start.Interval = 1000;
            this.Start.Tick += new System.EventHandler(this.Start_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(300, 523);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RPM
            // 
            this.RPM.Interval = 1;
            this.RPM.Tick += new System.EventHandler(this.RPM_Tick);
            // 
            // Verificar
            // 
            this.Verificar.Tick += new System.EventHandler(this.Verificar_Tick);
            // 
            // llanta3
            // 
            this.llanta3.Image = global::CarreraAutos.Properties.Resources.R1;
            this.llanta3.Location = new System.Drawing.Point(429, 143);
            this.llanta3.Name = "llanta3";
            this.llanta3.Size = new System.Drawing.Size(36, 35);
            this.llanta3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.llanta3.TabIndex = 20;
            this.llanta3.TabStop = false;
            // 
            // llanta4
            // 
            this.llanta4.Image = global::CarreraAutos.Properties.Resources.R1;
            this.llanta4.Location = new System.Drawing.Point(471, 143);
            this.llanta4.Name = "llanta4";
            this.llanta4.Size = new System.Drawing.Size(36, 35);
            this.llanta4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.llanta4.TabIndex = 19;
            this.llanta4.TabStop = false;
            // 
            // car1
            // 
            this.car1.BackColor = System.Drawing.Color.Transparent;
            this.car1.Image = global::CarreraAutos.Properties.Resources.Car1_Orange;
            this.car1.Location = new System.Drawing.Point(0, 231);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(251, 83);
            this.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car1.TabIndex = 3;
            this.car1.TabStop = false;
            // 
            // car2
            // 
            this.car2.BackColor = System.Drawing.Color.Transparent;
            this.car2.Image = global::CarreraAutos.Properties.Resources.Car1_Red1;
            this.car2.Location = new System.Drawing.Point(24, 114);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(215, 79);
            this.car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car2.TabIndex = 4;
            this.car2.TabStop = false;
            // 
            // cemaforo
            // 
            this.cemaforo.BackColor = System.Drawing.Color.Transparent;
            this.cemaforo.Image = global::CarreraAutos.Properties.Resources.Cemaforo_Nada;
            this.cemaforo.Location = new System.Drawing.Point(327, 101);
            this.cemaforo.Name = "cemaforo";
            this.cemaforo.Size = new System.Drawing.Size(73, 123);
            this.cemaforo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cemaforo.TabIndex = 18;
            this.cemaforo.TabStop = false;
            // 
            // Fondo3
            // 
            this.Fondo3.Image = global::CarreraAutos.Properties.Resources.Bg_far1;
            this.Fondo3.Location = new System.Drawing.Point(1364, -63);
            this.Fondo3.Name = "Fondo3";
            this.Fondo3.Size = new System.Drawing.Size(704, 126);
            this.Fondo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fondo3.TabIndex = 17;
            this.Fondo3.TabStop = false;
            // 
            // llanta2
            // 
            this.llanta2.Image = global::CarreraAutos.Properties.Resources.R1;
            this.llanta2.Location = new System.Drawing.Point(339, 256);
            this.llanta2.Name = "llanta2";
            this.llanta2.Size = new System.Drawing.Size(36, 35);
            this.llanta2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.llanta2.TabIndex = 15;
            this.llanta2.TabStop = false;
            // 
            // llanta1
            // 
            this.llanta1.Image = global::CarreraAutos.Properties.Resources.R1;
            this.llanta1.Location = new System.Drawing.Point(381, 256);
            this.llanta1.Name = "llanta1";
            this.llanta1.Size = new System.Drawing.Size(36, 35);
            this.llanta1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.llanta1.TabIndex = 14;
            this.llanta1.TabStop = false;
            // 
            // flag
            // 
            this.flag.Image = global::CarreraAutos.Properties.Resources.Start;
            this.flag.Location = new System.Drawing.Point(257, 125);
            this.flag.Name = "flag";
            this.flag.Size = new System.Drawing.Size(17, 219);
            this.flag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flag.TabIndex = 7;
            this.flag.TabStop = false;
            // 
            // Fondo2
            // 
            this.Fondo2.Image = global::CarreraAutos.Properties.Resources.Bg_far1;
            this.Fondo2.Location = new System.Drawing.Point(660, -63);
            this.Fondo2.Name = "Fondo2";
            this.Fondo2.Size = new System.Drawing.Size(704, 126);
            this.Fondo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fondo2.TabIndex = 6;
            this.Fondo2.TabStop = false;
            // 
            // Fondo1
            // 
            this.Fondo1.Image = global::CarreraAutos.Properties.Resources.Bg_far1;
            this.Fondo1.Location = new System.Drawing.Point(0, -63);
            this.Fondo1.Name = "Fondo1";
            this.Fondo1.Size = new System.Drawing.Size(704, 126);
            this.Fondo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fondo1.TabIndex = 5;
            this.Fondo1.TabStop = false;
            // 
            // Cambio
            // 
            this.Cambio.BackColor = System.Drawing.Color.Transparent;
            this.Cambio.Enabled = false;
            this.Cambio.Image = global::CarreraAutos.Properties.Resources.Cambio;
            this.Cambio.Location = new System.Drawing.Point(591, 421);
            this.Cambio.Name = "Cambio";
            this.Cambio.Size = new System.Drawing.Size(77, 89);
            this.Cambio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cambio.TabIndex = 2;
            this.Cambio.TabStop = false;
            this.Cambio.Click += new System.EventHandler(this.Cambio_Click);
            // 
            // Indicador
            // 
            this.Indicador.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Indicador.Image = global::CarreraAutos.Properties.Resources.Boton1;
            this.Indicador.Location = new System.Drawing.Point(444, 379);
            this.Indicador.Name = "Indicador";
            this.Indicador.Size = new System.Drawing.Size(66, 63);
            this.Indicador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Indicador.TabIndex = 1;
            this.Indicador.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(163, 297);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 248);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Rotacion
            // 
            this.Rotacion.Interval = 16;
            this.Rotacion.Tick += new System.EventHandler(this.Rotacion_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // Velocidad
            // 
            this.Velocidad.Interval = 50;
            this.Velocidad.Tick += new System.EventHandler(this.Velocidad_Tick);
            // 
            // VerVel
            // 
            this.VerVel.Interval = 1000;
            this.VerVel.Tick += new System.EventHandler(this.VerficarVelocidad_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // Velocidad2
            // 
            this.Velocidad2.Interval = 50;
            this.Velocidad2.Tick += new System.EventHandler(this.Velocidad2_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(800, 114);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(225, 143);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // Carrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarreraAutos.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(731, 545);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.llanta3);
            this.Controls.Add(this.llanta4);
            this.Controls.Add(this.car1);
            this.Controls.Add(this.car2);
            this.Controls.Add(this.cemaforo);
            this.Controls.Add(this.Fondo3);
            this.Controls.Add(this.llanta2);
            this.Controls.Add(this.llanta1);
            this.Controls.Add(this.flag);
            this.Controls.Add(this.Fondo2);
            this.Controls.Add(this.Fondo1);
            this.Controls.Add(this.Cambio);
            this.Controls.Add(this.Indicador);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Carrera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Carrera_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Carrera_FormClosed);
            this.Load += new System.EventHandler(this.Carrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.llanta3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.llanta4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cemaforo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fondo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.llanta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.llanta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fondo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fondo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cambio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Indicador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Indicador;
        private System.Windows.Forms.PictureBox Cambio;
        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.PictureBox car2;
        private System.Windows.Forms.PictureBox Fondo1;
        private System.Windows.Forms.PictureBox Fondo2;
        private System.Windows.Forms.PictureBox flag;
        private System.Windows.Forms.PictureBox llanta1;
        private System.Windows.Forms.PictureBox llanta2;
        private System.Windows.Forms.Timer Fondo;
        private System.Windows.Forms.Timer FondoB;
        private System.Windows.Forms.PictureBox Fondo3;
        private System.Windows.Forms.Timer GiroRuedas;
        private System.Windows.Forms.Timer Start;
        private System.Windows.Forms.PictureBox cemaforo;
        private System.Windows.Forms.PictureBox llanta3;
        private System.Windows.Forms.PictureBox llanta4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer RPM;
        private System.Windows.Forms.Timer Verificar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer Rotacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Velocidad;
        private System.Windows.Forms.Timer VerVel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer Velocidad2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}