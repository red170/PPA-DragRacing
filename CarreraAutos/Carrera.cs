using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarreraAutos
{
    public partial class Carrera : Form
    {
        private Bitmap image = null;
        private float angle = 0.0f;
        public int i = 3;
        int intervalo = 50;
        int fondo = 1;
        int a = 1;
        int sec = 0;
        int acelerar = 0;
        int velocidades =1;
        int correctas = 0;
        float Milla = 1609;
        float Milla2 = 1609;
        public static int dificultad = 2;
        public static int max=0;
        public static int min=0;
        float vel1=0;
        float vel2 = 0;
        float velTotal= 0.0f;
        float velTotal2 = 0.0f;
        int move = 1;
        bool [] cambio = new bool[7];
        int ganador = 0;

        public Carrera()
        {
            InitializeComponent();
            
            car1.Controls.Add(llanta1);
            llanta1.BackColor = Color.Transparent;
            car1.Controls.Add(llanta2);
            llanta2.BackColor = Color.Transparent;

            car2.Controls.Add(llanta3);
            llanta3.BackColor = Color.Transparent;
            car2.Controls.Add(llanta4);
            llanta4.BackColor = Color.Transparent;

            llanta3.Location = new Point(160, 43);
            llanta4.Location = new Point(35, 43);

        }

        private void Carrera_FormClosing(object sender, FormClosingEventArgs e)
        {
               
        }

        private void Carrera_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 6; i++)
            {
                cambio[i] = false;
            }
                Start.Start();
            image = new Bitmap(Properties.Resources.Line);
            pictureBox1.Image = (Bitmap)image.Clone();
            RotateImage(pictureBox1, image, angle);
            switch (SeleccionAutos.coche)
            {
                case 1:
                    car1.Image = Properties.Resources.Car1_Orange;
                    car1.Size = new System.Drawing.Size (251, 83);
                    car1.Location = new Point(0, 231);
                    llanta2.Location = new Point(162, 43);
                    llanta1.Location = new Point(35, 43);
                    break;
                case 2:
                    car1.Image = Properties.Resources.Car1_Red1;
                    car1.Size = new System.Drawing.Size(215, 79);
                    car1.Location = new Point(24, 231);
                    llanta2.Location = new Point(148, 39);
                    llanta1.Location = new Point(22, 39);
                    break;
                case 3:                   
                    car1.Image = Properties.Resources.Car1_Black;
                    car1.Size = new System.Drawing.Size(206, 104);
                    car1.Location = new Point(24, 231);
                    llanta2.Location = new Point(146, 63);
                    llanta1.Location = new Point(26, 63);
                    break;
                case 4:
                    car1.Image = Properties.Resources.Car1_Blue;
                    car1.Size = new System.Drawing.Size (251, 83);
                    car1.Location = new Point(0, 231);
                    llanta2.Location = new Point(171, 43);
                    llanta1.Location = new Point(28, 43);
                    break;
            }
            switch (Menu1.rival)
            {
                case 1:
                    car2.Image = Properties.Resources.Car1_Orange;
                    car2.Size = new System.Drawing.Size(251, 83);
                    car2.Location = new Point(0, 114);
                    llanta3.Location = new Point(162, 43);
                    llanta4.Location = new Point(35, 43);
                    break;
                case 2:
                    car2.Image = Properties.Resources.Car1_Red1;
                    car2.Size = new System.Drawing.Size(215, 79);
                    car2.Location = new Point(24, 114);
                    llanta3.Location = new Point(148, 39);
                    llanta4.Location = new Point(22, 39);
                    break;
                case 3:
                    car2.Image = Properties.Resources.Car1_Black;
                    car2.Size = new System.Drawing.Size(206, 104);
                    car2.Location = new Point(24, 114);
                    llanta3.Location = new Point(146, 63);
                    llanta4.Location = new Point(26, 63);
                    break;
                case 4:
                    car2.Image = Properties.Resources.Car1_Blue;
                    car2.Size = new System.Drawing.Size(251, 83);
                    car2.Location = new Point(0, 114);
                    llanta3.Location = new Point(171, 43);
                    llanta4.Location = new Point(28, 43);
                    break;
            }
        }

        private void Fondo_Tick(object sender, EventArgs e)
        {
            Fondo1.Location = new Point(Fondo1.Left - fondo, Fondo1.Top + 0);
            Fondo2.Location = new Point(Fondo2.Left - fondo, Fondo2.Top + 0);
            Fondo3.Location = new Point(Fondo3.Left - fondo, Fondo3.Top + 0);
            flag.Location = new Point(flag.Left - move, flag.Top + 0);            
            if (Fondo1.Left < -650) 
            {               
                Fondo1.Location = new Point(0, -63);
                Fondo2.Location = new Point(660, -63);
                Fondo3.Location = new Point(1364, -63);
            }
            if (flag.Left < -650) 
            {
                flag.Visible = false;
            }
        }

        private void FondoB_Tick(object sender, EventArgs e)
        {
            fondo = fondo + 1;
            move = move + 1;
            if (fondo > 8)
            {
                FondoB.Stop();
                fondo = 8;
            }            
        }



        private void GiroRuedas_Tick(object sender, EventArgs e)
        {
            a = a + 1;
            switch (a)
            {
                case 1:
                    llanta1.Image = Properties.Resources.R1;
                    llanta2.Image = Properties.Resources.R1; 
                    llanta3.Image = Properties.Resources.R1;
                    llanta4.Image = Properties.Resources.R1;
                    break;
                case 2:
                   llanta1.Image = Properties.Resources.R2;
                    llanta2.Image = Properties.Resources.R2; 
                    llanta3.Image = Properties.Resources.R2;
                    llanta4.Image = Properties.Resources.R2; 
                    break;
                case 3:
                    llanta1.Image = Properties.Resources.R3;
                    llanta2.Image = Properties.Resources.R3;       
                    llanta3.Image = Properties.Resources.R3;
                    llanta4.Image = Properties.Resources.R3;
                    break;
            }
            if (a > 3)
            {
                a = 0;
            }
            velTotal = vel1 * 0.27f;
            velTotal2 = vel2 * 0.27f;
        }

        private void Start_Tick(object sender, EventArgs e)
        {
            sec = sec + 1;
            switch (sec) 
            {
                case 1:
                    cemaforo.Image = Properties.Resources.Cemaforo_Red;
                    break;
                case 2:
                    cemaforo.Image = Properties.Resources.Cemaforo_Yellow;
                    break;
                case 3:
                    cemaforo.Image = Properties.Resources.Cemaforo_Green;
                    break;
            }
            if (sec > 4) 
            {
                cemaforo.Visible = false;
                Start.Stop();
                RPM.Start();
                Rotacion.Start();
                VerVel.Start();
                Cambio.Enabled = true;        
            }
        }

        private void RotateImage(PictureBox pb, Image img, float angle)
        {
            if (img == null || pb.Image == null)
                return;
         
            Image oldImage = pb.Image;          
            pb.Image = RotatePictureBox.Utilities.RotateImage(img, angle);
            if (oldImage != null)
            {
                oldImage.Dispose();
            }
        }

        private void RPM_Tick(object sender, EventArgs e)
        {          
            i = i + intervalo;
            switch (velocidades)
            {
                case 1:
                    if (i > min && i < max)
                    {
                        intervalo = 10;
                        Indicador.Image = Properties.Resources.Boton3;
                    }
                    if (i > max)
                    {
                        intervalo = 10;
                        Indicador.Image = Properties.Resources.Boton2;
                    }
                   
                    break;
                case 2:
                    if (i > min && i < max)
                    {
                        intervalo = 8;
                        Indicador.Image = Properties.Resources.Boton3;
                    }
                    if (i > max)
                    {
                        intervalo = 8;
                        Indicador.Image = Properties.Resources.Boton2;
                    }
                    break;
                case 3:
                    if (i > min && i < max)
                    {
                        intervalo = 6;
                        Indicador.Image = Properties.Resources.Boton3;
                    }
                    if (i > max)
                    {
                        intervalo = 6;
                        Indicador.Image = Properties.Resources.Boton2;
                    }
                    break;
                case 4:
                    if (i > min && i < max)
                    {
                        intervalo = 4;
                        Indicador.Image = Properties.Resources.Boton3;
                    }
                    if (i > max)
                    {
                        intervalo = 4;
                        Indicador.Image = Properties.Resources.Boton2;
                    }
                    break;
                case 5:
                    if (i > min && i < max)
                    {
                        intervalo = 2;
                        Indicador.Image = Properties.Resources.Boton3;
                    }
                    if (i > max)
                    {
                        intervalo = 2;
                        Indicador.Image = Properties.Resources.Boton2;
                    }
                    break;
                case 6:
                    if (i > min && i < max)
                    {
                        intervalo = 2;
                        Indicador.Image = Properties.Resources.Boton3;
                    }
                    if (i > max)
                    {
                        intervalo = 2;
                        Indicador.Image = Properties.Resources.Boton2;
                    }
                    break;
            }

           
        }

        private void Cambio_Click(object sender, EventArgs e)
        {
            switch (velocidades) 
            {
                case 1:
                Fondo.Start();              
                FondoB.Start();
                GiroRuedas.Start();
                Velocidad.Start();
                Velocidad2.Start();

                    Cambio.Location = new Point(516, 372);
                    angle = 100;
                    Rotacion.Interval = 49;
                    cambio[1] = true;
                    break;
                case 2:
                    Cambio.Location = new Point(516, 472);
                    angle = 100;
                    Rotacion.Interval = 55;
                    cambio[2] = true;
                    break;
                case 3:
                    Cambio.Location = new Point(591, 372);
                    angle = 100;
                    Rotacion.Interval = 70;
                    cambio[3] = true;
                    break;
                case 4:
                    Cambio.Location = new Point(591, 472);
                    angle = 100;
                    Rotacion.Interval = 140;
                    cambio[4] = true;
                    break;
                case 5:
                    Cambio.Location = new Point(670, 372);
                    angle = 100;
                    Rotacion.Interval = 230;
                    cambio[5] = true;
                    break;
                case 6:
                    Cambio.Location = new Point(670, 472);
                    angle = 100;
                    Rotacion.Interval = 200;
                    cambio[6] = true;
                    break;

            }
            velocidades++;
            if (i > min && i < max)
            {
                i = 5000;
                Indicador.Image = Properties.Resources.Boton1;
                Verificar.Start();
                correctas = 1;
                acelerar = 2;
            }
            else if (i < min)
            {
                i = 5000;
                Indicador.Image = Properties.Resources.Boton1;
                Verificar.Start();
                correctas = 2;
                acelerar = 4;
            }
            else if (i > max)
            {
                i = 5000;
                Indicador.Image = Properties.Resources.Boton1;
                Verificar.Start();
                correctas = 3;
                acelerar = 2;
            }
        }

        private void Verificar_Tick(object sender, EventArgs e)
        {
            switch (correctas)
            {
                case 1:                 
                    car2.Location = new Point(car2.Left - acelerar, car2.Top + 0);
                    Milla = Milla - 1;
                    break;
                case 2:
                    car2.Location = new Point(car2.Left + acelerar, car2.Top + 0);
                    Milla = Milla + 1;
                    break;
                case 3:            
                    car2.Location = new Point(car2.Left + acelerar, car2.Top + 0);
                    Milla = Milla + 1;
                    break;
            }     
            if(velocidades == 4)
            {
                Verificar.Interval = 200;
            }
            else if (velocidades == 5)
            {
                Verificar.Interval = 300;
            }
        }

        private void Rotacion_Tick(object sender, EventArgs e)
        {
            if (angle > 250)
            {
                angle = 245;
                RotateImage(pictureBox1, image, 250);
            }
            else
            {
                RotateImage(pictureBox1, image, angle);
                angle = angle + 2;
            }           
        }

        private void Velocidad_Tick(object sender, EventArgs e)
        {
            VelocidadCar1();
            if (cambio[1] == true && i < 8000)
            {
                vel1++;
            }
            else if (cambio[2] == true && i < 8000)
            {
                vel1++;
            }
            else if (cambio[3] == true && i < 8000)
            {
                vel1++;
            }
            else if (cambio[4] == true && i < 8000)
            {
                vel1++;
            }
            else if (cambio[5] == true && i < 8000)
            {
                vel1++;
            }
            else if (cambio[6] == true && i < 8000)
            {
                vel1++;
            }
            else if (i > 8500)
            {
                correctas = 0;
                car2.Location = new Point(car2.Left + 4, car2.Top + 0);

            }
            label1.Text = vel1.ToString();
            if (vel1 > 230) 
            {
                Velocidad.Stop();
            }
        }

        private void VerficarVelocidad_Tick(object sender, EventArgs e)
        {
            Milla = Milla - velTotal;
            Milla2 = Milla2 - velTotal2;
            label3.Text = Milla.ToString();
            label4.Text = Milla2.ToString();
            if (Milla < Milla2) 
            {
                if (Milla < 0) 
                {
                    flag.Visible = true;
                    flag.Location = new Point(657, 125);
                    label2.Text = "GANO EL 1";
                    pictureBox2.Image = Properties.Resources.Ganador;
                    pictureBox2.Location = new Point(257, 125);
                    move = 30;
                    VerVel.Stop();
                }               
            }
            else if (Milla2 < Milla)
            {
                if (Milla2 < 0)
                {
                    label2.Text = "GANO EL 2";
                    ganador = 2;
                }
            }
            if (Milla > Milla2)
            {
                if (Milla < 0)
                {
                    if (ganador == 2)
                    {
                        pictureBox2.Image = Properties.Resources.Perdedor;
                        pictureBox2.Location = new Point(257, 125);
                    }        
                    flag.Visible = true;
                    flag.Location = new Point(657, 125);
                    move = 30;
                    VerVel.Stop();
                }       
            }
        }

        private void Velocidad2_Tick(object sender, EventArgs e)
        {
            VelocidadCar2();
            vel2++;
            if (vel2 > 230)
            {
                Velocidad2.Stop();
            }
        }

        public void VelocidadCar2() 
        {
            if (vel2 > 40 && vel2 < 60)
                Velocidad2.Interval = 40;
            else if (vel2 > 60 && vel2 < 80)
                Velocidad2.Interval = 60;
            else if (vel2 > 80 && vel2 < 100)
                Velocidad2.Interval = 80;
            else if (vel2 > 100 && vel2 < 120)
                Velocidad2.Interval = 100;
            else if (vel2 > 120 && vel2 < 140)
                Velocidad2.Interval = 150;
            else if (vel2 > 200)
                Velocidad2.Interval = 500;
            else if (vel2 > 215)
                Velocidad2.Interval = 2000;
        }

        public void VelocidadCar1()
        {
            if (vel1 > 40 && vel1 < 60)
                Velocidad.Interval = 40;
            else if (vel1 > 60 && vel1 < 80)
                Velocidad.Interval = 60;
            else if (vel1 > 80 && vel1 < 100)
                Velocidad.Interval = 80;
            else if (vel1 > 100 && vel1 < 120)
                Velocidad.Interval = 100;
            else if (vel1 > 120 && vel1 < 140)
                Velocidad.Interval = 150;
            else if (vel1 > 200)
                Velocidad.Interval = 500;
            else if (vel1 > 215)
                Velocidad.Interval = 2000;  
        }

        private void Carrera_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu1 mn = new Menu1();
            mn.Show();
            this.Hide();            
        }
    }
}
