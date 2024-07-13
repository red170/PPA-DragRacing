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
    public partial class Menu1 : Form
    {
        public static int rival;
        public static int b1 = 1;
        public Menu1()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.apr_audi_r8_race_car_1600x900;
            Random rnd = new Random();
            rival = rnd.Next(1, 5);
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SeleccionAutos sa = new SeleccionAutos();
            sa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (b1) 
            {
                case 1:
                    Facil.Visible = true;
                    Medio.Visible = true;
                    Dificil.Visible = true;
                    b1 = 2;
                    break;
                case 2:
                    Facil.Visible = false;
                    Medio.Visible = false;
                    Dificil.Visible = false;
                    b1 = 1;
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
            Carrera.max = 6600;
            Carrera cr = new Carrera();
            cr.Show();
            this.Hide();
        }

       
    }
}
