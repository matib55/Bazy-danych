namespace Aplikacja_bazowa___klient
{
    partial class Aplikacja_bazodanowa
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.przycisk_filmy = new System.Windows.Forms.Button();
            this.pole_wyszukiwania = new System.Windows.Forms.TextBox();
            this.przycisk_szukaj = new System.Windows.Forms.Button();
            this.przycisk_ocena = new System.Windows.Forms.Button();
            this.pole_oceny = new System.Windows.Forms.RichTextBox();
            this.pole_skali_ocen = new System.Windows.Forms.ComboBox();
            this.przycisk_zarezerwuj_miejsce = new System.Windows.Forms.Button();
            this.pole_imie = new System.Windows.Forms.TextBox();
            this.pole_nazwisko = new System.Windows.Forms.TextBox();
            this.pole_data_urodzenia = new System.Windows.Forms.TextBox();
            this.pole_e_mail = new System.Windows.Forms.TextBox();
            this.pole_numer_telefonu = new System.Windows.Forms.TextBox();
            this.przycisk_wyslij_rezerwacje = new System.Windows.Forms.Button();
            this.przycisk_usun_zarezerwowane_miejsce = new System.Windows.Forms.Button();
            this.przycisk_potwierdz_usuniecie_rezerwacji = new System.Windows.Forms.Button();
            this.pole_data_zgloszenia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(983, 355);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.click_dataGridView1);
            // 
            // przycisk_filmy
            // 
            this.przycisk_filmy.Location = new System.Drawing.Point(40, 43);
            this.przycisk_filmy.Name = "przycisk_filmy";
            this.przycisk_filmy.Size = new System.Drawing.Size(133, 53);
            this.przycisk_filmy.TabIndex = 1;
            this.przycisk_filmy.Text = "Filmy";
            this.przycisk_filmy.UseVisualStyleBackColor = true;
            this.przycisk_filmy.Click += new System.EventHandler(this.click_filmy);
            // 
            // pole_wyszukiwania
            // 
            this.pole_wyszukiwania.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pole_wyszukiwania.Location = new System.Drawing.Point(529, 49);
            this.pole_wyszukiwania.Name = "pole_wyszukiwania";
            this.pole_wyszukiwania.Size = new System.Drawing.Size(357, 26);
            this.pole_wyszukiwania.TabIndex = 2;
            this.pole_wyszukiwania.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // przycisk_szukaj
            // 
            this.przycisk_szukaj.Location = new System.Drawing.Point(904, 43);
            this.przycisk_szukaj.Name = "przycisk_szukaj";
            this.przycisk_szukaj.Size = new System.Drawing.Size(119, 38);
            this.przycisk_szukaj.TabIndex = 3;
            this.przycisk_szukaj.Text = "Szukaj";
            this.przycisk_szukaj.UseVisualStyleBackColor = true;
            this.przycisk_szukaj.Click += new System.EventHandler(this.click_szukaj);
            // 
            // przycisk_ocena
            // 
            this.przycisk_ocena.Location = new System.Drawing.Point(194, 43);
            this.przycisk_ocena.Name = "przycisk_ocena";
            this.przycisk_ocena.Size = new System.Drawing.Size(108, 53);
            this.przycisk_ocena.TabIndex = 4;
            this.przycisk_ocena.Text = "Oceń film";
            this.przycisk_ocena.UseVisualStyleBackColor = true;
            this.przycisk_ocena.Click += new System.EventHandler(this.click_przycisk_ocena);
            // 
            // pole_oceny
            // 
            this.pole_oceny.Location = new System.Drawing.Point(40, 498);
            this.pole_oceny.Name = "pole_oceny";
            this.pole_oceny.Size = new System.Drawing.Size(983, 193);
            this.pole_oceny.TabIndex = 5;
            this.pole_oceny.Text = "";
            // 
            // pole_skali_ocen
            // 
            this.pole_skali_ocen.FormattingEnabled = true;
            this.pole_skali_ocen.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.pole_skali_ocen.Location = new System.Drawing.Point(327, 56);
            this.pole_skali_ocen.Name = "pole_skali_ocen";
            this.pole_skali_ocen.Size = new System.Drawing.Size(132, 28);
            this.pole_skali_ocen.TabIndex = 6;
            this.pole_skali_ocen.Text = "Skala oceny";
            // 
            // przycisk_zarezerwuj_miejsce
            // 
            this.przycisk_zarezerwuj_miejsce.Location = new System.Drawing.Point(1044, 116);
            this.przycisk_zarezerwuj_miejsce.Name = "przycisk_zarezerwuj_miejsce";
            this.przycisk_zarezerwuj_miejsce.Size = new System.Drawing.Size(138, 52);
            this.przycisk_zarezerwuj_miejsce.TabIndex = 7;
            this.przycisk_zarezerwuj_miejsce.Text = "Zarezerwuj miejsce";
            this.przycisk_zarezerwuj_miejsce.UseVisualStyleBackColor = true;
            this.przycisk_zarezerwuj_miejsce.Click += new System.EventHandler(this.click_przycisk_zarezerwuj_miejsce);
            // 
            // pole_imie
            // 
            this.pole_imie.Location = new System.Drawing.Point(71, 519);
            this.pole_imie.Name = "pole_imie";
            this.pole_imie.Size = new System.Drawing.Size(239, 26);
            this.pole_imie.TabIndex = 9;
            this.pole_imie.Text = "Imie";
            this.pole_imie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pole_nazwisko
            // 
            this.pole_nazwisko.Location = new System.Drawing.Point(382, 519);
            this.pole_nazwisko.Name = "pole_nazwisko";
            this.pole_nazwisko.Size = new System.Drawing.Size(239, 26);
            this.pole_nazwisko.TabIndex = 10;
            this.pole_nazwisko.Text = "Nazwisko";
            this.pole_nazwisko.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pole_data_urodzenia
            // 
            this.pole_data_urodzenia.Location = new System.Drawing.Point(684, 519);
            this.pole_data_urodzenia.Name = "pole_data_urodzenia";
            this.pole_data_urodzenia.Size = new System.Drawing.Size(239, 26);
            this.pole_data_urodzenia.TabIndex = 11;
            this.pole_data_urodzenia.Text = "Data urodzenia";
            this.pole_data_urodzenia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pole_e_mail
            // 
            this.pole_e_mail.Location = new System.Drawing.Point(121, 604);
            this.pole_e_mail.Name = "pole_e_mail";
            this.pole_e_mail.Size = new System.Drawing.Size(338, 26);
            this.pole_e_mail.TabIndex = 12;
            this.pole_e_mail.Text = "e-mail";
            this.pole_e_mail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pole_numer_telefonu
            // 
            this.pole_numer_telefonu.Location = new System.Drawing.Point(543, 604);
            this.pole_numer_telefonu.Name = "pole_numer_telefonu";
            this.pole_numer_telefonu.Size = new System.Drawing.Size(358, 26);
            this.pole_numer_telefonu.TabIndex = 13;
            this.pole_numer_telefonu.Text = "Numer telefonu";
            this.pole_numer_telefonu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // przycisk_wyslij_rezerwacje
            // 
            this.przycisk_wyslij_rezerwacje.Location = new System.Drawing.Point(1044, 587);
            this.przycisk_wyslij_rezerwacje.Name = "przycisk_wyslij_rezerwacje";
            this.przycisk_wyslij_rezerwacje.Size = new System.Drawing.Size(138, 60);
            this.przycisk_wyslij_rezerwacje.TabIndex = 14;
            this.przycisk_wyslij_rezerwacje.Text = "Wyślij rezerwacje";
            this.przycisk_wyslij_rezerwacje.UseVisualStyleBackColor = true;
            this.przycisk_wyslij_rezerwacje.Click += new System.EventHandler(this.click_przycisk_wyslij_rezerwacje);
            // 
            // przycisk_usun_zarezerwowane_miejsce
            // 
            this.przycisk_usun_zarezerwowane_miejsce.Location = new System.Drawing.Point(1044, 189);
            this.przycisk_usun_zarezerwowane_miejsce.Name = "przycisk_usun_zarezerwowane_miejsce";
            this.przycisk_usun_zarezerwowane_miejsce.Size = new System.Drawing.Size(138, 83);
            this.przycisk_usun_zarezerwowane_miejsce.TabIndex = 15;
            this.przycisk_usun_zarezerwowane_miejsce.Text = "Usuń zarezerwowane miejsce";
            this.przycisk_usun_zarezerwowane_miejsce.UseVisualStyleBackColor = true;
            this.przycisk_usun_zarezerwowane_miejsce.Click += new System.EventHandler(this.click_usun_zarezerwowane_miejsce);
            // 
            // przycisk_potwierdz_usuniecie_rezerwacji
            // 
            this.przycisk_potwierdz_usuniecie_rezerwacji.Location = new System.Drawing.Point(1044, 501);
            this.przycisk_potwierdz_usuniecie_rezerwacji.Name = "przycisk_potwierdz_usuniecie_rezerwacji";
            this.przycisk_potwierdz_usuniecie_rezerwacji.Size = new System.Drawing.Size(138, 63);
            this.przycisk_potwierdz_usuniecie_rezerwacji.TabIndex = 16;
            this.przycisk_potwierdz_usuniecie_rezerwacji.Text = "Potwierdź usunięcie rezerwacji";
            this.przycisk_potwierdz_usuniecie_rezerwacji.UseVisualStyleBackColor = true;
            this.przycisk_potwierdz_usuniecie_rezerwacji.Click += new System.EventHandler(this.click_potwerdz_usuniecie_rezerwacji);
            // 
            // pole_data_zgloszenia
            // 
            this.pole_data_zgloszenia.Location = new System.Drawing.Point(312, 652);
            this.pole_data_zgloszenia.Name = "pole_data_zgloszenia";
            this.pole_data_zgloszenia.Size = new System.Drawing.Size(389, 26);
            this.pole_data_zgloszenia.TabIndex = 17;
            this.pole_data_zgloszenia.Text = "Data zgłoszenia";
            this.pole_data_zgloszenia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Aplikacja_bazodanowa
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 703);
            this.Controls.Add(this.pole_data_zgloszenia);
            this.Controls.Add(this.przycisk_potwierdz_usuniecie_rezerwacji);
            this.Controls.Add(this.przycisk_usun_zarezerwowane_miejsce);
            this.Controls.Add(this.przycisk_wyslij_rezerwacje);
            this.Controls.Add(this.pole_numer_telefonu);
            this.Controls.Add(this.pole_e_mail);
            this.Controls.Add(this.pole_data_urodzenia);
            this.Controls.Add(this.pole_nazwisko);
            this.Controls.Add(this.pole_imie);
            this.Controls.Add(this.przycisk_zarezerwuj_miejsce);
            this.Controls.Add(this.pole_skali_ocen);
            this.Controls.Add(this.pole_oceny);
            this.Controls.Add(this.przycisk_ocena);
            this.Controls.Add(this.przycisk_szukaj);
            this.Controls.Add(this.pole_wyszukiwania);
            this.Controls.Add(this.przycisk_filmy);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Aplikacja_bazodanowa";
            this.Text = "Aplikacja kinowa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button przycisk_filmy;
        private System.Windows.Forms.TextBox pole_wyszukiwania;
        private System.Windows.Forms.Button przycisk_szukaj;
        private System.Windows.Forms.Button przycisk_ocena;
        private System.Windows.Forms.RichTextBox pole_oceny;
        private System.Windows.Forms.ComboBox pole_skali_ocen;
        private System.Windows.Forms.Button przycisk_zarezerwuj_miejsce;
        private System.Windows.Forms.TextBox pole_imie;
        private System.Windows.Forms.TextBox pole_nazwisko;
        private System.Windows.Forms.TextBox pole_data_urodzenia;
        private System.Windows.Forms.TextBox pole_e_mail;
        private System.Windows.Forms.TextBox pole_numer_telefonu;
        private System.Windows.Forms.Button przycisk_wyslij_rezerwacje;
        private System.Windows.Forms.Button przycisk_usun_zarezerwowane_miejsce;
        private System.Windows.Forms.Button przycisk_potwierdz_usuniecie_rezerwacji;
        private System.Windows.Forms.TextBox pole_data_zgloszenia;
    }
}

