using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        BindingList<string> ListaHighscore = new BindingList<string>();
        Random rnd = new Random();
        bool pariba;
        bool pabajo;
        bool paderecha;
        bool paizquierda;

        int velocidad = 6;

        int puntaje = 0;
        int fantasma1y = 3;
        
        int fantasma2y = 3;
        string nombre;
       
        public Form1()
        {
            InitializeComponent();
            timer1.Stop();
            pacmanDown.Hide();
            pacmanLeft.Hide();
            pacmanRight.Hide();
            pacmanUp.Hide();
            fantasmaRojo.Hide();
            fantasmaRosado.Hide();
            fantasmaRojo.Top = rnd.Next(20,580 );
            fantasmaRojo.Left = rnd.Next(20, 580);

            fantasmaRosado.Top = rnd.Next(20, 580);
            fantasmaRosado.Left = rnd.Next(20, 580);
            //panel1.Location = new Point(0, 0);
            panel2.Location = new Point(0, 0);
            panel3.Location = new Point(0, 0);
            //panel1.Hide();
            panel2.Hide();
            panel3.Show();

            /*try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Stream miStream = new FileStream("PNTS.bin", FileMode.Open, FileAccess.Read, FileShare.None);
                ListaHighscore = formatter.Deserialize(miStream);
                miStream.Close();
            }
            catch { }*/
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Left)
            {
                paizquierda = true;
                pacmanRight.Hide();
                pacmanUp.Hide();
                pacmanDown.Hide();
                pacmanLeft.Show();

            }
            if (e.KeyCode == Keys.Right)
            {
                paderecha = true;
                
                pacmanUp.Hide();
                pacmanDown.Hide();
                pacmanLeft.Hide();
                pacmanRight.Show();
            }
            if (e.KeyCode == Keys.Up)
            {
                pariba = true;
                pacmanRight.Hide();
                pacmanUp.Show();
                pacmanDown.Hide();
                pacmanLeft.Hide();

            }
            if (e.KeyCode == Keys.Down)
            {
                pabajo = true;
                pacmanRight.Hide();
                pacmanUp.Hide();
                pacmanLeft.Hide();
                pacmanDown.Show();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Puntaje: " + puntaje;

            if (pabajo)
            {
                pacmanDown.Top += velocidad;
                pacmanLeft.Top += velocidad;
                pacmanRight.Top += velocidad;
                pacmanUp.Top += velocidad;
            }
            if (pariba)
            {
                pacmanDown.Top -= velocidad;
                pacmanLeft.Top -= velocidad;
                pacmanRight.Top -= velocidad;
                pacmanUp.Top -= velocidad;
            }
            if (paderecha)
            {
                pacmanDown.Left += velocidad;
                pacmanLeft.Left += velocidad;
                pacmanRight.Left += velocidad;
                pacmanUp.Left += velocidad;
            }
            if (paizquierda)
            {
                pacmanDown.Left -= velocidad;
                pacmanLeft.Left -= velocidad;
                pacmanRight.Left -= velocidad;
                pacmanUp.Left -= velocidad;
            }
            if (pacmanDown.Top > fantasmaRojo.Top && (pacmanDown.Top - fantasmaRojo.Top) > Math.Abs(pacmanDown.Left - fantasmaRojo.Left))
            {
                fantasmaRojo.Top += fantasma1y;
                
            }
            if (pacmanDown.Top < fantasmaRojo.Top && Math.Abs(pacmanDown.Top - fantasmaRojo.Top) > Math.Abs(pacmanDown.Left - fantasmaRojo.Left))
            {
                fantasmaRojo.Top -= fantasma1y;
                
            }
            else if (pacmanDown.Left > fantasmaRojo.Left && Math.Abs(pacmanDown.Top - fantasmaRojo.Top) < Math.Abs(pacmanDown.Left - fantasmaRojo.Left))
            {
                fantasmaRojo.Left += fantasma1y;
                
            }
            else if (pacmanDown.Left < fantasmaRojo.Left && Math.Abs(pacmanDown.Top - fantasmaRojo.Top) < Math.Abs(pacmanDown.Left - fantasmaRojo.Left))
            {
                fantasmaRojo.Left -= fantasma1y;
               
            }

            if (pacmanDown.Top > fantasmaRosado.Top && (pacmanDown.Top - fantasmaRosado.Top) > Math.Abs(pacmanDown.Left - fantasmaRosado.Left))
            {
                fantasmaRosado.Top += fantasma2y;

            }
            if (pacmanDown.Top < fantasmaRosado.Top && Math.Abs(pacmanDown.Top - fantasmaRosado.Top) > Math.Abs(pacmanDown.Left - fantasmaRosado.Left))
            {
                fantasmaRosado.Top -= fantasma2y;

            }
            else if (pacmanDown.Left > fantasmaRosado.Left && Math.Abs(pacmanDown.Top - fantasmaRosado.Top) < Math.Abs(pacmanDown.Left - fantasmaRosado.Left))
            {
                fantasmaRosado.Left += fantasma2y;

            }
            else if (pacmanDown.Left < fantasmaRosado.Left && Math.Abs(pacmanDown.Top - fantasmaRosado.Top) < Math.Abs(pacmanDown.Left - fantasmaRosado.Left))
            {
                fantasmaRosado.Left -= fantasma2y;

            }


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "fantasma")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(pacmanDown.Bounds))
                    {
                        // panel1.Hide();
                        panel2.Show();
                        pacmanDown.Hide();
                        pacmanLeft.Hide();
                        pacmanRight.Hide();
                        pacmanUp.Hide();
                        fantasmaRojo.Hide();
                        fantasmaRosado.Hide();
                        string nombreyP = nombre + ": " + puntaje.ToString();
                        ListaHighscore.Add(nombreyP);
                        listBox1.DataSource = ListaHighscore;
                        listBox1.Refresh();
                        timer1.Stop();
                    }

                }
                if (x is PictureBox && (string)x.Tag == "cherry")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(pacmanDown.Bounds))
                    {
                        x.Top=rnd.Next(20,580);
                        x.Left = rnd.Next(20, 580);
                        puntaje += 10;
                    }
                }
                if (x is PictureBox && (string)x.Tag == "uva")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(pacmanDown.Bounds))
                    {
                        x.Top = rnd.Next(20, 580);
                        x.Left = rnd.Next(20, 580);
                        puntaje += 15;
                    }
                }
            }
        }
        private void keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                paizquierda = false;
                

            }
            if (e.KeyCode == Keys.Right)
            {
                paderecha = false;

               
            }
            if (e.KeyCode == Keys.Up)
            {
                pariba = false;
                

            }
            if (e.KeyCode == Keys.Down)
            {
                pabajo = false;
                
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            nombre = textBox1.Text;
            //panel1.Show();
            pacmanDown.Hide();
            pacmanLeft.Hide();
            pacmanRight.Show();
            pacmanUp.Hide();
            fantasmaRojo.Show();
            fantasmaRosado.Show();
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            puntaje = 0;
            fantasmaRojo.Top = rnd.Next(20, 580);
            fantasmaRojo.Left = rnd.Next(20, 580);
            fantasmaRosado.Top = rnd.Next(20, 580);
            fantasmaRosado.Left = rnd.Next(20, 580);
            pacmanDown.Hide();
            pacmanLeft.Hide();
            pacmanRight.Show();
            pacmanUp.Hide();
            fantasmaRojo.Show();
            fantasmaRosado.Show();
            timer1.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream mistream = new FileStream("PNTS.bin", FileMode.Create, FileAccess.Write);
            formatter.Serialize(mistream, ListaHighscore);
            MessageBox.Show("Se han guardado los Highscores");
                
        }
    }
}
