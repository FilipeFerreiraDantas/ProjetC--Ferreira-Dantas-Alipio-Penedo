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
            
           
        }

        

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void MyPaint(object sender, PaintEventArgs e)
        {
            // string rndmSorteCarte = ;
            // string rndmNumCarte = ;

            Bitmap bitmap;
            Bitmap bitmap1 = new Bitmap(CarteGenerator.getCarte(CarteGenerator.SorteCarte.Coeur, CarteGenerator.ValeurCarte.Sept, 0.5));
            Bitmap bitmap2 = new Bitmap(CarteGenerator.getCarte(CarteGenerator.SorteCarte.Carreau, CarteGenerator.ValeurCarte.Huit, 0.5));

            string valeurSorte = CarteGenerator.GetRandomSorte();


            var Sorte = CarteGenerator.GetRandomSorte();
            for(int i = 1; i<=28; i++)
            {
               bitmap = new Bitmap(CarteGenerator.getCarte(CarteGenerator.SorteCarte.valeurSorte, CarteGenerator.GetRandomNumCard(), 0.5));
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine(GetRandomSorte());
        }
    }
}
