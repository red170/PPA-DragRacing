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
    public partial class SeleccionAutos : Form
    {
        public static int coche=1;
        int x=0;
        int a = 1;
        public SeleccionAutos()
        {
            InitializeComponent();
            pictureBox1.Controls.Add(pictureBox2);
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;

            pictureBox2.Controls.Add(pictureBox3);
            pictureBox3.Location = new Point(63, 76);

            pictureBox2.Controls.Add(pictureBox4);
            pictureBox4.Location = new Point(221, 76);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu1 mn = new Menu1();
            mn.Show();
            this.Hide();
        }

        private void SeleccionAutos_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.igpddmsculw158;
        }

        private void button3_Click(object sender, EventArgs e)
        {           
            timer2.Start();
            switch (coche) 
            {
                case 1:
                    timer1.Start();
                    break;
                case 2:
                    timer1.Start();
                    break;
                case 3:
                    timer1.Start();
                    break;
                case 4:
                    timer1.Start();
                    break;
            }
            coche = coche + 1;
            if(coche >4)
            {
                coche =1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(pictureBox2.Left + 10, pictureBox2.Top + 0);
            x = pictureBox2.Left;          
            if (x>1000) 
            {
                pictureBox2.Location = new Point(-300, 222);            
            }
            if (x == -290) 
            {
                switch (coche)
                {
                    case 1:
                        pictureBox2.Image = Properties.Resources.Car1_Orange;
                        pictureBox4.Location = new Point(221, 76);
                        pictureBox3.Location = new Point(63, 76);
                        break;
                    case 2:
                        pictureBox2.Image = Properties.Resources.Car1_Red1;
                        pictureBox4.Location = new Point(228, 76);
                        pictureBox3.Location = new Point(63, 76);
                        break;
                    case 3:
                        pictureBox2.Image = Properties.Resources.Car1_Black;
                        pictureBox3.Location = new Point(80, 86);
                        pictureBox4.Location = new Point(224, 86);
                        break;
                    case 4:
                        pictureBox2.Image = Properties.Resources.Car1_Blue;
                        pictureBox4.Location = new Point(228, 76);
                        pictureBox3.Location = new Point(63, 76);
                        break;
                }
            }
            if (x == 180)
            {
                timer1.Stop();
                timer2.Stop();
            }
        }

        private void SeleccionAutos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            a = a + 1;
            switch (a)
            {
                case 1:
                    pictureBox3.Image = Properties.Resources.R1;
                    pictureBox4.Image = Properties.Resources.R1;      
                    break;
                case 2:
                    pictureBox3.Image = Properties.Resources.R2;
                    pictureBox4.Image = Properties.Resources.R2;           
                    break;
                case 3:
                    pictureBox3.Image = Properties.Resources.R3;
                    pictureBox4.Image = Properties.Resources.R3;
                    break;
            }
            if (a > 3)
            {
                a = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (Menu1.b1)
            {
                case 1:
                    Facil.Visible = true;
                    Medio.Visible = true;
                    Dificil.Visible = true;
                    Menu1.b1 = 2;
                    break;
                case 2:
                    Facil.Visible = false;
                    Medio.Visible = false;
                    Dificil.Visible = false;
                    Menu1.b1 = 1;
                    break;
            }
        }

        private void Facil_Click(object sender, EventArgs e)
        {
            Carrera.dificultad = 1;
            Carrera.min = 6500;
            Carrera.max = 7100;
            Carrera cr = new Carrera();
            cr.Show();
            this.Hide();
        }

        private void Medio_Click(object sender, EventArgs e)
        {
            Carrera.dificultad = 2;
            Carrera.min = 6500;
            Carrera.max = 6700;
            Carrera cr = new Carrera();
            cr.Show();
            this.Hide();
        }

        private void Dificil_Click(object sender, EventArgs e)
        {
            Carrera.dificultad = 3;
            Carrera.min = 6500;
            Carrera.max = 6650;
            Carrera cr = new Carrera();
            cr.Show();
            this.Hide();
        }
    }
}
