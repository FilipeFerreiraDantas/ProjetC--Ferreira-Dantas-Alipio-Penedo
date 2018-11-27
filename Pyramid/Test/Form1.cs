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

        public string GetRandomSorte()
        {
            Array valuesSorte = Enum.GetValues(typeof(CarteGenerator.SorteCarte));
            Array valuesNumCarte = Enum.GetValues(typeof(CarteGenerator.ValeurCarte));

            var rnd = new Random();
            int indexSorte = rnd.Next(0, valuesSorte.Length);
            int indexNumCarte = rnd.Next(0, valuesNumCarte.Length);

            var resultSorte = valuesSorte.GetValue(indexSorte);
            return resultSorte.ToString();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void MyPaint(object sender, PaintEventArgs e)
        {
           // string rndmSorteCarte = ;
           // string rndmNumCarte = ;

            Bitmap bitmap = new Bitmap(CarteGenerator.getCarte(CarteGenerator.SorteCarte.Pique, CarteGenerator.ValeurCarte.Cinq, 0.5));
            Bitmap bitmap1 = new Bitmap(CarteGenerator.getCarte(CarteGenerator.SorteCarte.Coeur, CarteGenerator.ValeurCarte.Sept, 0.5));
            Bitmap bitmap2 = new Bitmap(CarteGenerator.getCarte(CarteGenerator.SorteCarte.Carreau, CarteGenerator.ValeurCarte.Huit, 0.5));
            imgCarte1.Image = bitmap;
            imgCarte2.Image = bitmap1;
            imgCarte3.Image = bitmap2;

            for(int i = 1; i<=28; i++)
            {
               // Bitmap bitmap = new Bitmap(CarteGenerator.getCarte(CarteGenerator.SorteCarte.))
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine(GetRandomSorte());
        }
    }
}
