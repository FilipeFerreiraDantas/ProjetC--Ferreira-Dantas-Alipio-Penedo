using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameCardGenerator;

namespace Pyramid
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(MyPaint);

            List<PictureBox> pictureBoxes = new List<PictureBox>();
            Control parentControl = this.Parent;

            for(int i=0;i<=28;i++)
            {
                pictureBoxes.Add(parentControl["pictureBox" + i.ToString()]);
            }

        }

        

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void MyPaint(object sender, PaintEventArgs e)
        {
            for (int i = 1; i <= 28; i++)
            {
                Bitmap bitmap1 = new Bitmap(CarteGenerator.getRandomCarte(0.5));
                imgCarte1.Image = bitmap1;

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }
    }
}
