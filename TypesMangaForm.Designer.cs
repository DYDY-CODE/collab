namespace TypesManga
{
    partial class TypesMangaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypesMangaForm));
            this.logoMangaPictureBox = new System.Windows.Forms.PictureBox();
            this.mangaPictureBox = new System.Windows.Forms.PictureBox();
            this.TitreLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.classificationLabel = new System.Windows.Forms.Label();
            this.typesMangaListBox = new System.Windows.Forms.ListBox();
            this.impressionGroupBox = new System.Windows.Forms.GroupBox();
            this.imprimerButton = new System.Windows.Forms.Button();
            this.imageRadioButton = new System.Windows.Forms.RadioButton();
            this.logoRadioButton = new System.Windows.Forms.RadioButton();
            this.fermerButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.programmeurLabel = new System.Windows.Forms.Label();
            this.liensListBox = new System.Windows.Forms.ListBox();
            this.typeMangaPrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.typeMangaPrintDocument = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.logoMangaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mangaPictureBox)).BeginInit();
            this.impressionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoMangaPictureBox
            // 
            this.logoMangaPictureBox.Image = global::TypesManga.Properties.Resources.Logo_mangaschaine2022;
            this.logoMangaPictureBox.Location = new System.Drawing.Point(260, 30);
            this.logoMangaPictureBox.Name = "logoMangaPictureBox";
            this.logoMangaPictureBox.Size = new System.Drawing.Size(171, 69);
            this.logoMangaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoMangaPictureBox.TabIndex = 0;
            this.logoMangaPictureBox.TabStop = false;
            // 
            // mangaPictureBox
            // 
            this.mangaPictureBox.Image = global::TypesManga.Properties.Resources.mha_com;
            this.mangaPictureBox.Location = new System.Drawing.Point(43, 340);
            this.mangaPictureBox.Name = "mangaPictureBox";
            this.mangaPictureBox.Size = new System.Drawing.Size(260, 214);
            this.mangaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mangaPictureBox.TabIndex = 1;
            this.mangaPictureBox.TabStop = false;
            // 
            // TitreLabel
            // 
            this.TitreLabel.AutoSize = true;
            this.TitreLabel.Font = new System.Drawing.Font("Pristina", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.TitreLabel.Location = new System.Drawing.Point(454, 41);
            this.TitreLabel.Name = "TitreLabel";
            this.TitreLabel.Size = new System.Drawing.Size(266, 57);
            this.TitreLabel.TabIndex = 2;
            this.TitreLabel.Text = "Types de manga";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(330, 340);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(376, 112);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = resources.GetString("descriptionLabel.Text");
            // 
            // classificationLabel
            // 
            this.classificationLabel.AutoSize = true;
            this.classificationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classificationLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.classificationLabel.Location = new System.Drawing.Point(39, 139);
            this.classificationLabel.Name = "classificationLabel";
            this.classificationLabel.Size = new System.Drawing.Size(130, 20);
            this.classificationLabel.TabIndex = 5;
            this.classificationLabel.Text = "Classification:";
            // 
            // typesMangaListBox
            // 
            this.typesMangaListBox.FormattingEnabled = true;
            this.typesMangaListBox.ItemHeight = 16;
            this.typesMangaListBox.Items.AddRange(new object[] {
            "Il existe plusieurs types de manga:",
            "- Shonen Manga",
            "- Shojo Manga",
            "- Seinen Manga",
            "- Josei Manga",
            "- Yaoi Manga",
            "- Yuri Manga"});
            this.typesMangaListBox.Location = new System.Drawing.Point(41, 187);
            this.typesMangaListBox.Name = "typesMangaListBox";
            this.typesMangaListBox.Size = new System.Drawing.Size(665, 132);
            this.typesMangaListBox.TabIndex = 8;
            // 
            // impressionGroupBox
            // 
            this.impressionGroupBox.Controls.Add(this.imprimerButton);
            this.impressionGroupBox.Controls.Add(this.imageRadioButton);
            this.impressionGroupBox.Controls.Add(this.logoRadioButton);
            this.impressionGroupBox.Location = new System.Drawing.Point(753, 340);
            this.impressionGroupBox.Name = "impressionGroupBox";
            this.impressionGroupBox.Size = new System.Drawing.Size(178, 194);
            this.impressionGroupBox.TabIndex = 9;
            this.impressionGroupBox.TabStop = false;
            this.impressionGroupBox.Text = "Impression";
            // 
            // imprimerButton
            // 
            this.imprimerButton.Location = new System.Drawing.Point(30, 135);
            this.imprimerButton.Name = "imprimerButton";
            this.imprimerButton.Size = new System.Drawing.Size(114, 38);
            this.imprimerButton.TabIndex = 2;
            this.imprimerButton.Text = "&Imprimer";
            this.imprimerButton.UseVisualStyleBackColor = true;
            this.imprimerButton.Click += new System.EventHandler(this.imprimerButton_Click);
            // 
            // imageRadioButton
            // 
            this.imageRadioButton.AutoSize = true;
            this.imageRadioButton.Location = new System.Drawing.Point(30, 86);
            this.imageRadioButton.Name = "imageRadioButton";
            this.imageRadioButton.Size = new System.Drawing.Size(66, 20);
            this.imageRadioButton.TabIndex = 1;
            this.imageRadioButton.TabStop = true;
            this.imageRadioButton.Text = "Image";
            this.imageRadioButton.UseVisualStyleBackColor = true;
            // 
            // logoRadioButton
            // 
            this.logoRadioButton.AutoSize = true;
            this.logoRadioButton.Checked = true;
            this.logoRadioButton.Location = new System.Drawing.Point(30, 44);
            this.logoRadioButton.Name = "logoRadioButton";
            this.logoRadioButton.Size = new System.Drawing.Size(59, 20);
            this.logoRadioButton.TabIndex = 0;
            this.logoRadioButton.TabStop = true;
            this.logoRadioButton.Text = "Logo";
            this.logoRadioButton.UseVisualStyleBackColor = true;
            // 
            // fermerButton
            // 
            this.fermerButton.Location = new System.Drawing.Point(817, 749);
            this.fermerButton.Name = "fermerButton";
            this.fermerButton.Size = new System.Drawing.Size(114, 38);
            this.fermerButton.TabIndex = 3;
            this.fermerButton.Text = "Fermer";
            this.fermerButton.UseVisualStyleBackColor = true;
            this.fermerButton.Click += new System.EventHandler(this.fermerButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(39, 586);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sites relies aux mangas:";
            // 
            // programmeurLabel
            // 
            this.programmeurLabel.AutoSize = true;
            this.programmeurLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programmeurLabel.ForeColor = System.Drawing.Color.Green;
            this.programmeurLabel.Location = new System.Drawing.Point(39, 757);
            this.programmeurLabel.Name = "programmeurLabel";
            this.programmeurLabel.Size = new System.Drawing.Size(419, 20);
            this.programmeurLabel.TabIndex = 11;
            this.programmeurLabel.Text = "Programmeur: Andreas, Cedric, Dylane, Manuela";
            // 
            // liensListBox
            // 
            this.liensListBox.FormattingEnabled = true;
            this.liensListBox.ItemHeight = 16;
            this.liensListBox.Items.AddRange(new object[] {
            "https://harajuku-store.com/blogs/harajuku-blog/type-de-manga",
            "https://www.manga-news.com/",
            "https://v5.voiranime.com/",
            "https://mangadex.org/"});
            this.liensListBox.Location = new System.Drawing.Point(43, 629);
            this.liensListBox.Name = "liensListBox";
            this.liensListBox.Size = new System.Drawing.Size(888, 84);
            this.liensListBox.TabIndex = 12;
            // 
            // typeMangaPrintPreviewDialog
            // 
            this.typeMangaPrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.typeMangaPrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.typeMangaPrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.typeMangaPrintPreviewDialog.Document = this.typeMangaPrintDocument;
            this.typeMangaPrintPreviewDialog.Enabled = true;
            this.typeMangaPrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("typeMangaPrintPreviewDialog.Icon")));
            this.typeMangaPrintPreviewDialog.Name = "typesMangaPrintPreviewDialog";
            this.typeMangaPrintPreviewDialog.Visible = false;
            // 
            // typeMangaPrintDocument
            // 
            this.typeMangaPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.typeMangaPrintDocument_PrintPage);
            // 
            // TypesMangaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 817);
            this.Controls.Add(this.liensListBox);
            this.Controls.Add(this.programmeurLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fermerButton);
            this.Controls.Add(this.impressionGroupBox);
            this.Controls.Add(this.typesMangaListBox);
            this.Controls.Add(this.classificationLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.TitreLabel);
            this.Controls.Add(this.mangaPictureBox);
            this.Controls.Add(this.logoMangaPictureBox);
            this.Name = "TypesMangaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Types de manga";
            ((System.ComponentModel.ISupportInitialize)(this.logoMangaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mangaPictureBox)).EndInit();
            this.impressionGroupBox.ResumeLayout(false);
            this.impressionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoMangaPictureBox;
        private System.Windows.Forms.PictureBox mangaPictureBox;
        private System.Windows.Forms.Label TitreLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label classificationLabel;
        private System.Windows.Forms.ListBox typesMangaListBox;
        private System.Windows.Forms.GroupBox impressionGroupBox;
        private System.Windows.Forms.Button imprimerButton;
        private System.Windows.Forms.RadioButton imageRadioButton;
        private System.Windows.Forms.RadioButton logoRadioButton;
        private System.Windows.Forms.Button fermerButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label programmeurLabel;
        private System.Windows.Forms.ListBox liensListBox;
        private System.Windows.Forms.PrintPreviewDialog typeMangaPrintPreviewDialog;
        private System.Drawing.Printing.PrintDocument typeMangaPrintDocument;
    }
}

