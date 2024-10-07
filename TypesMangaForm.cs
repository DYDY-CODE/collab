using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TypesManga
{
    public partial class TypesMangaForm : Form
    {
        public TypesMangaForm()
        {
            InitializeComponent();
        }
        private void TypesMangaForm_Load(object sender, EventArgs e)
        {
            int largeur = this.ClientSize.Width;
            int hauteur = this.ClientSize.Height;
            int zoom = 1;

        }

        ListBox lstItems; Image imageChoisie;

        private void imprimerButton_Click(object sender, EventArgs e)
        {
            typeMangaPrintPreviewDialog.ShowDialog(this);

        }


        private void typeMangaPrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {

            // Image/logo centré

            if (imageRadioButton.Checked) // Correction de la vérification du bouton radio
            {
                imageChoisie = Properties.Resources.mha_com;
                // Utilise la taille du PictureBox directement pour l'image imprimée
                int imgWidth = mangaPictureBox.Width;   
                int imgHeight = mangaPictureBox.Height; 

                // Calcul des coordonnées pour centrer l'image
                int posX = (int)((e.PageBounds.Width - imgWidth) / 2);
                int posY = 2;

                // Dessine l'image centrée avec les dimensions du PictureBox
                e.Graphics.DrawImage(mangaPictureBox.Image, posX, posY, imgWidth, imgHeight);
            }
            else
            {
                imageChoisie = Properties.Resources.Logo_mangaschaine2022;
                // Utilise la taille du PictureBox directement pour l'image imprimée
                int imgWidth = logoMangaPictureBox.Width;  
                int imgHeight = logoMangaPictureBox.Height; 

                // Calcul des coordonnées pour centrer l'image
                int posX = (int)((e.PageBounds.Width - imgWidth) / 2);
                int posY = 2;

                // Dessine l'image centrée avec les dimensions du PictureBox
                e.Graphics.DrawImage(logoMangaPictureBox.Image, posX, posY, imgWidth, imgHeight);
            }

            // Titre et nom centré
            string titre = "Type manga - Andreas, Cedric, Dylane, Manuela";
            
            Font titreFont = new Font("Arial", 24, FontStyle.Bold);
           
            SizeF titreSize = e.Graphics.MeasureString(titre, titreFont);

            // Calculer la position X pour centrer le texte
            float titrePosX = (e.PageBounds.Width - titreSize.Width) / 2;

            // Position Y pour le titre (reste à 200)
            float titrePosY = 200;

            // Dessiner le texte centré
            e.Graphics.DrawString(titre, titreFont, Brushes.Black, new PointF(titrePosX, titrePosY));
            // Liste des items avec numérotation
            int yPosition = 250;
            for (int i = 0; i < liensListBox.Items.Count; i++)
            {
                string item = $"{i + 1}. {liensListBox.Items[i].ToString()}";
                e.Graphics.DrawString(item, new Font("Arial", 12), Brushes.Black, new Point(100, yPosition));
                yPosition += 30;
            }

            // Signature en bas
            e.Graphics.DrawString($"{programmeurLabel.Text}, {DateTime.Now.ToLongDateString()}",
                new Font("Arial", 12, FontStyle.Italic), Brushes.Green, new Point(100, yPosition + 50));
        }

        private void fermerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}