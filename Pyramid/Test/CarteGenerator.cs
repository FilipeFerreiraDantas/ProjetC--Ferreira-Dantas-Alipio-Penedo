//***   GameCard Generator   ***//
//***   Produit par : Eric   ***//
//*** ericmas001@hotmail.com ***//


/* Comment l'utiliser ???
 * 
 * Facile, int�grez cette classe dans votre projet.
 * 
 * Copiez l'image "Deck.png" dans le dossier de lancement de 
 *	votre application.
 *
 * Lorsque vous voudrez faire afficher une carte, il suffira d'ajouter 
 *	"using GameCardGenerator;" a votre source.
 * 
 * Ensuite, vous pourrez vous servir des 3 m�thodes comme suit d�pendant de vos 
 *	besoins. Le r�sultat sera un Bitmap de 150*[Grosseur] par 200*[Grosseur]
 * 
 * Pour afficher une carte normale (ex: 2 de trefle, Roi de pique, etc.)
 *	CarteGenerator.getCarte( Sorte, Valeur, Grosseur ) o�
 *	Sorte: La sorte de la carte (pique,trefle,coeur,carreau)
 *  Valeur: La valeur de la carte (As, Deux, Dame, Roi, etc.)
 *  Grosseur: Le coefficient apport� a la grandeur de base (150x200)
 * 
 *	ex: CarteGenerator.getCarte( SorteCarte.Coeur, ValeurCarte.Dix, 0.5 )
 *	retournera un 10 de coeur de grosseur 75x100
 * 
 * Pour afficher un joker
 *	CarteGenerator.getJoker( Color�?, Grosseur ) o�
 *  Color�?: Si vous voulez celui en couleur (true,false)
 *  Grosseur: Le coefficient apport� a la grandeur de base (150x200)
 * 
 *	ex: CarteGenerator.getJoker( false, 1 )
 *	retournera un joker, noir et blanc, 150x200
 * 
 * Pour l'envers de la carte
 *	CarteGenerator.getDos( Grosseur ) o�
 *  Grosseur: Le coefficient apport� a la grandeur de base (150x200)
 * 
 *	ex: CarteGenerator.getDos( 2 )
 *	retournera une carte retourn�e, 300x400
 * 
 * Petite source tr�s simple, mais qui pourra sauver du temps a certains
 */
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace GameCardGenerator
{
	public class CarteGenerator
	{

		// Le chemin pour se rendre a l'image.
		// Le chemin par d�faut devrait fonctionner si vous avez suivi les instructions
		// Par d�faut: return Application.StartupPath + "\\deck.png";
		public static string ImagePath
		{
			get
			{
				return Application.StartupPath + "deck.png";
			}
		}

		// Liste des sortes de cartes
		// L'ordre est important pour le d�coupage sur l'image
		public enum SorteCarte
		{
			Coeur,
			Carreau,
			Pique,
			Trefle
		}

		// Liste des valeur de cartes
		// L'ordre est important pour le d�coupage sur l'image
		public enum ValeurCarte
		{
			As,
			Deux,
			Trois,
			Quatre,
			Cinq,
			Six,
			Sept,
			Huit,
			Neuf,
			Dix,
			Valet,
			Dame,
			Roi
		}

		// D�coupe et retourne la carte sur l'image de base
		public static Image getCarteImage( int x, int y, double size )
		{
            // On va chercher l'image de base
            // On va chercher l'image de base
            // On va chercher l'image de base
            Image imgSource = new Bitmap( ImagePath );

			// On cr�e une nouvelle image sur laquel on va dessiner
			Image img = new Bitmap( (int)( 150 * size ), (int)( 200 * size ) );

			// On prends en main notre "crayon" pour dessiner
			Graphics g = Graphics.FromImage( img );

			// On note la position et la grosseur de l'image de la carte
			Rectangle rect = new Rectangle( 1, 1, (int)( 147 * size ), (int)( 197 * size ) );
			
			// On dessine la carte
			g.DrawImage( imgSource, rect, x, y, (int) 150 , (int) 200 , GraphicsUnit.Pixel );
			
			// On rajoute une toute petite bordure autour de la carte
			g.DrawRectangle( new Pen( Brushes.Black ), 0, 0, (int)( 149 * size ), (int)( 199 * size ) );
			
			// On renvoi la carte
			return img;
		}

		public static Image getCarte( SorteCarte sorte, ValeurCarte valeur, double size )
		{
			return getCarteImage( ( (int)valeur ) * 150, ( (int)sorte ) * 200, size );
		}
		public static Image getJoker( bool colored, double size )
		{
			int coef = ( colored ? 0 : 1 );
			return getCarteImage( 1950, 200 * coef, size );
		}
		public static Image getDos( double size )
		{
			return getCarteImage( 1950, 400, size );
		}
	}
}
