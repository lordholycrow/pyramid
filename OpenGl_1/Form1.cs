using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl; 
using Tao.Platform.Windows;


namespace OpenGl_1
{
    public partial class Form1 : Form
    {
        float alfa = 0;
        float alfaupside = 0;
        public Form1()
        {

            InitializeComponent();
            OpenGlControl.InitializeContexts();
          
            Gl.glClearColor(0.0f, 0.5f, 0.5f, 0.0f);//silme rengi
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity(); // Projection matrisini sıfırla
            Gl.glOrtho(0,0,0,0,1,0); // kamera kullanarak projection ver
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
     

          

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MyPaint(object sender, PaintEventArgs e)
        {
       
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glShadeModel(Gl.GL_SMOOTH);
            Gl.glPushMatrix();//
            Gl.glTranslatef(0f, 0f, 1.0f); 
            Gl.glRotatef(alfa, 0, 1, 0); 
            Gl.glRotatef(alfaupside, 1, 1, 1); 



            Gl.glBegin(Gl.GL_TRIANGLES);

            Gl.glColor3f(1.0f, 0.0f, 0.0f);
            Gl.glVertex3f(0.0f, 1.0f, 0.0f);

            Gl.glColor3f(0.0f, 1.0f, 0.0f);
            Gl.glVertex3f(-1.0f, -1.0f, 1.0f);

            Gl.glColor3f(0.0f, 0.0f, 1.0f);
            Gl.glVertex3f(1.0f, -1.0f, 1.0f);

    
            Gl.glColor3f(1.0f, 0.0f, 0.0f);
            Gl.glVertex3f(0.0f, 1.0f, 0.0f);

            Gl.glColor3f(0.0f, 1.0f, 0.0f);
            Gl.glVertex3f(1.0f, -1.0f, 1.0f);

            Gl.glColor3f(0.0f, 0.0f, 1.0f);
            Gl.glVertex3f(1.0f, -1.0f, -1.0f);

     
            Gl.glColor3f(1.0f, 0.0f, 0.0f);
            Gl.glVertex3f(0.0f, 1.0f, 0.0f);

            Gl.glColor3f(0.0f, 1.0f, 0.0f);
            Gl.glVertex3f(1.0f, -1.0f, -1.0f);

            Gl.glColor3f(0.0f, 0.0f, 1.0f);
            Gl.glVertex3f(-1.0f, -1.0f, -1.0f);

       
            Gl.glColor3f(1.0f, 0.0f, 0.0f);
            Gl.glVertex3f(0.0f, 1.0f, 0.0f);

            Gl.glColor3f(0.0f, 1.0f, 0.0f);
            Gl.glVertex3f(-1.0f, -1.0f, -1.0f);

            Gl.glColor3f(0.0f, 0.0f, 1.0f);
            Gl.glVertex3f(-1.0f, -1.0f, 1.0f);

  
            Gl.glColor3f(1.0f, 0.0f, 0.0f);
            Gl.glVertex3f(-1.0f, -1.0f, 1.0f);

            Gl.glColor3f(0.0f, 1.0f, 0.0f);
            Gl.glVertex3f(1.0f, -1.0f, 1.0f);

            Gl.glColor3f(0.0f, 0.0f, 1.0f);
            Gl.glVertex3f(-1.0f, -1.0f, -1.0f);

  
            Gl.glColor3f(1.0f, 0.0f, 0.0f);
            Gl.glVertex3f(-1.0f, -1.0f, -1.0f);      

            Gl.glColor3f(0.0f, 1.0f, 0.0f);
            Gl.glVertex3f(1.0f, -1.0f, -1.0f);

            Gl.glColor3f(0.0f, 0.0f, 1.0f);
            Gl.glVertex3f(1.0f, -1.0f, 1.0f);

            Gl.glEnd();

            Gl.glPopMatrix();
        }

        private void buttonDondur_Click(object sender, EventArgs e)
        {          
            alfa = (alfa+10) % 360; 
            OpenGlControl.Refresh(); 
        }

        private void MyKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M) //Muhammed Ali = M
                alfa = (alfa + 5) % 360;
            if (e.KeyCode == Keys.S) //Sarimese = S
                alfa = (alfa - 5) % 360;

            OpenGlControl.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i< 200; i++)
            { 
            alfa = (alfa + 1) % 360; 
                System.Threading.Thread.Sleep(50);
                OpenGlControl.Refresh(); 
              
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                alfaupside = (alfaupside + 1) % 360; 
                OpenGlControl.Refresh(); 

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            alfa = 0;
            alfaupside = 0;
            OpenGlControl.Refresh();
        }
    }
}
