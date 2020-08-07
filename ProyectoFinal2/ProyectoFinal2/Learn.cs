using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;

namespace ProyectoFinal2
{
    public partial class Learn : Form
    {
        private int indice;
        private int indice1;
        private int indice2;
        private int indice3;
        //Inicio de patron singleton
        private Learn()
        {
            InitializeComponent();
            indice = 0;
            indice1 = 0;
            indice2 = 0;
            indice3 = 0;
            
        }
        private static Learn Instancia = null;
        public static Learn getInstancia()
        {
            if (Instancia == null)
            {
                Instancia = new Learn();
            }

            return Instancia;
        }
        //Finish patron singleton
        private void Learn_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

      

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //SoundPlayer sonido;//wav
        WindowsMediaPlayer sonido;//mp3
        private void audio1() 
        {
            sonido = new WindowsMediaPlayer();
            sonido.URL = @"https://storage.googleapis.com/nfree/betteries1596754581.mp3";
            sonido.controls.play();
        }private void audio2() 
        {
            sonido = new WindowsMediaPlayer();
            sonido.URL = @"https://storage.googleapis.com/nfree/microphone1596750938.mp3";
            sonido.controls.play();
            
        }private void audio3() 
        {
            sonido = new WindowsMediaPlayer();
            sonido.URL = @"https://storage.googleapis.com/nfree/camera1596754675.mp3";
            sonido.controls.play();
        }private void audio4() 
        {
            sonido = new WindowsMediaPlayer();
            sonido.URL = @"https://storage.googleapis.com/nfree/mobile-phone1596762669.mp3";
            sonido.controls.play();
        }private void audio5() 
        {
            sonido = new WindowsMediaPlayer();
            sonido.URL = @"https://storage.googleapis.com/nfree/computer1596754723.mp3";
            sonido.controls.play();
        }private void audio6() 
        {
            sonido = new WindowsMediaPlayer();
            sonido.URL = @"https://storage.googleapis.com/nfree/mouse1596764576.mp3";
            sonido.controls.play();
        }private void audio7() 
        {
            sonido = new WindowsMediaPlayer();
            sonido.URL = @"https://storage.googleapis.com/nfree/computer-game1596754748.mp3";
            sonido.controls.play();
        }private void audio8() 
        {
            sonido = new WindowsMediaPlayer();
            sonido.URL = @"https://storage.googleapis.com/nfree/plug1596764602.mp3";
            
            sonido.controls.play();
        }private void audio9() 
        {
            sonido = new WindowsMediaPlayer();
            sonido.URL = @"https://storage.googleapis.com/nfree/headphones1596754794.mp3";
            sonido.controls.play();
        }
        private void audio10() 
        {
            sonido = new WindowsMediaPlayer();
            sonido.URL = @"https://storage.googleapis.com/nfree/speakers1596764661.mp3";
            sonido.controls.play();
        } private void audio11() 
        {
            sonido = new WindowsMediaPlayer();
            sonido.URL = @"https://storage.googleapis.com/nfree/internet1596764476.mp3";
            sonido.controls.play();
        } private void audio12() 
        {
            sonido = new WindowsMediaPlayer();
            sonido.URL = @"https://storage.googleapis.com/nfree/light-switch1596764700.mp3";
            sonido.controls.play();
        }private void audio13() 
        {
            sonido = new WindowsMediaPlayer();
            sonido.URL = @"https://storage.googleapis.com/nfree/keyboard1596764527.mp3";
            sonido.controls.play();
        }private void audio14() 
        {
            sonido = new WindowsMediaPlayer();
            sonido.URL = @"https://storage.googleapis.com/nfree/tablet1596764732.mp3";
            sonido.controls.play();
        }private void audio15() 
        {
            sonido = new WindowsMediaPlayer();
            sonido.URL = @"https://storage.googleapis.com/nfree/webcam1596750445.mp3";
            sonido.controls.play();
        }private void audio16() 
        {
            sonido = new WindowsMediaPlayer();
            sonido.URL = @"https://storage.googleapis.com/nfree/torch1596764751.mp3";
            sonido.controls.play();
        }
       
        private void btnReproducir1_Click(object sender, EventArgs e)
        {
            try {
                if (sonido == null && indice==0 || sonido != null && indice == 0) 
                {
                    audio1();

                }

                else if (sonido != null && indice1 == 1 || sonido == null && indice == 1)
                {
                    //sonido.controls.stop();
                    audio3();

                }
                else if (sonido != null && indice == 2 || sonido == null && indice == 2)
                {
                    audio5();

                }
                else if (sonido != null && indice == 3 || sonido == null && indice == 3)
                {
                    audio7();

                }
                else if (sonido != null && indice == 4 || sonido == null && indice == 4)
                {
                    audio9();

                }
                else if (sonido != null && indice == 5 || sonido == null && indice == 5)
                {
                    audio11();

                }
                else if (sonido != null && indice == 6 || sonido == null && indice == 6)
                {
                    audio13();

                }
                else if (sonido != null && indice == 7 || sonido == null && indice == 7)
                {
                    audio15();

                }
                else if (sonido != null )
                {
                    sonido.controls.stop();
                    sonido = null;

                }

            }
            catch (Exception error) 
            {
                MessageBox.Show("Error al reproducir el audio"+error);
            }
        }

        private void btnReproducir2_Click(object sender, EventArgs e)
        {
            try
            {
                if (sonido != null && indice1 == 0 || sonido == null && indice1==0)
                {
                    audio2();
                }

                else if (sonido != null && indice == 1|| sonido == null && indice == 1)
                {
                    audio4();

                }
                else if (sonido != null && indice == 2 || sonido == null && indice == 2)
                {
                    audio6();

                }
                else if (sonido != null && indice == 3 || sonido == null && indice == 3)
                {
                    audio8();

                }
                else if (sonido != null && indice == 4 || sonido == null && indice == 4)
                {
                    audio10();

                }
                else if (sonido != null && indice == 5 || sonido == null && indice == 5)
                {
                    audio12();

                }
                else if (sonido != null && indice == 6 || sonido == null && indice == 6)
                {
                    audio14();

                }
                else if (sonido != null && indice == 7 || sonido == null && indice == 7)
                {
                    audio16();

                }


            }
            catch (Exception error)
            {
                MessageBox.Show("Error al reproducir el audio" + error);
            }
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            indice++;
            indice1++;
            indice2++;
            indice3++;


            listimg1.ImageIndex = indice;
            listimg2.ImageIndex = indice1;
            listimg3.ImageIndex = indice2;
            listimg4.ImageIndex = indice3;
            if (indice == 7)
            {
                MessageBox.Show("end of the lesson");
                btnSiguiente.Enabled = false;

            }
            


        }
        private void btnBack_Click(object sender, EventArgs e)
        {

            
            if (indice >= 1)
            {
                indice--;
               
                

            }
            if (indice1 >= 1)
            {
               
                indice1--;
               
                

            }
            if (indice2 >= 1)
            {
                indice2--;
                
                

            }
            if (indice3 >= 1)
            {
                indice3--;
              

            }
            if(indice != 7) { btnSiguiente.Enabled = true; }
            listimg1.ImageIndex = indice;
            listimg2.ImageIndex = indice1;
            listimg3.ImageIndex = indice2;
            listimg4.ImageIndex = indice3;
            
        }

        private void btnModulos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modulos objmodulos = Modulos.GetModulos();
            objmodulos.Show();
            
        }
    }
}
