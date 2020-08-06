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
        public Learn()
        {
            InitializeComponent();
            indice = 0;
        }

        private void Learn_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            indice++;
            indice1++;
            indice2++;
            indice3++;
            if (indice > 10) 
            {
                indice = 0;
                
            }
            if (indice1 > 10) 
            {
                indice1 = 0;
                
            } 
            if (indice2 > 10) 
            {
                indice2 = 0;
                
            }  
            if (indice3 > 10) 
            {
                indice3 = 0;
                
            }
            listimg1.ImageIndex = indice;
            listimg2.ImageIndex = indice1;
            listimg3.ImageIndex = indice2;
            listimg4.ImageIndex = indice3;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //SoundPlayer sonido;//wav
        WindowsMediaPlayer sonido;//mp3
        private void audio1() 
        {
            sonido = new WindowsMediaPlayer();
            sonido.URL = @"https://storage.googleapis.com/nfree/cola1596658003.mp3";
            sonido.controls.play();
        }private void audio2() 
        {
            sonido = new WindowsMediaPlayer();
            sonido.URL = @"https://storage.googleapis.com/nfree/water1596665513.mp3";
            sonido.controls.play();
            
        }private void audio3() 
        {
            sonido = new WindowsMediaPlayer();
            sonido.URL = @"https://storage.googleapis.com/nfree/cola1596658003.mp3";
            sonido.controls.play();
        }private void audio4() 
        {
            sonido = new WindowsMediaPlayer();
            sonido.URL = @"https://storage.googleapis.com/nfree/cola1596658003.mp3";
            sonido.controls.play();
        }private void audio5() 
        {
            sonido = new WindowsMediaPlayer();
            sonido.URL = @"https://storage.googleapis.com/nfree/cola1596658003.mp3";
            sonido.controls.play();
        }private void audio6() 
        {
            sonido = new WindowsMediaPlayer();
            sonido.URL = @"https://storage.googleapis.com/nfree/cola1596658003.mp3";
            sonido.controls.play();
        }private void audio7() 
        {
            sonido = new WindowsMediaPlayer();
            sonido.URL = @"https://storage.googleapis.com/nfree/cola1596658003.mp3";
            sonido.controls.play();
        }private void audio8() 
        {
            sonido = new WindowsMediaPlayer();
            sonido.URL = @"https://storage.googleapis.com/nfree/cola1596658003.mp3";
            sonido.controls.play();
        }private void audio9() 
        {
            sonido = new WindowsMediaPlayer();
            sonido.URL = @"https://storage.googleapis.com/nfree/cola1596658003.mp3";
            sonido.controls.play();
        }
        private void audio10() 
        {
            sonido = new WindowsMediaPlayer();
            sonido.URL = @"https://storage.googleapis.com/nfree/cola1596658003.mp3";
            sonido.controls.play();
        }
        private void btnReproducir1_Click(object sender, EventArgs e)
        {
            try {
                if (sonido == null && indice==0) 
                {
                    audio1();

                }

           // else if (sonido != null && indice == 3)
           // {
           //     audio4();

           // }
           // else if (sonido != null && indice == 4)
           // {
           //     audio5();

           // }
           // else if (sonido != null && indice == 5)
           // {
           //     audio6();

           // }
           // else if (sonido != null && indice == 6)
           // {
           //     audio7();

           // }
           // else if (sonido != null && indice == 7)
           // {
           //     audio8();

           // }
           //else if (sonido != null && indice == 8)
           // {
           //     audio9();

           // }
           //else if (sonido != null && indice == 9)
           // {
           //     audio10();

         //   }
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
                if (sonido != null && indice1 == 0)
                {
                    audio2();
                }

                else if(sonido == null && indice1 == 0) 
                {
                    audio2();
                }
              
                //else if (sonido != null && indice == 2)
                //{
                //    audio3();

                //}
                //else if (sonido != null && indice == 3)
                //{
                //    audio4();

                //}
                //else if (sonido != null && indice == 4)
                //{
                //    audio5();

                //}
                //else if (sonido != null && indice == 5)
                //{
                //    audio6();

                //}
                //else if (sonido != null && indice == 6)
                //{
                //    audio7();

                //}
                //else if (sonido != null && indice == 7)
                //{
                //    audio8();

                //}
                //else if (sonido != null && indice == 8)
                //{
                //    audio9();

                //}
                //else if (sonido != null && indice == 9)
                //{
                //    audio10();

                //}


            }
            catch (Exception error)
            {
                MessageBox.Show("Error al reproducir el audio" + error);
            }
        }
    }
}
