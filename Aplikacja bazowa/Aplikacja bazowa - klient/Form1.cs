using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aplikacja_bazowa___klient
{
    public partial class Aplikacja_bazodanowa : System.Windows.Forms.Form
    {
        int licznik_rezerwajcji = 0; // sluzy do liczenia ilosci klikniec wyboru filmu, daty, miejsc itp., uzywam w if()- ach
        string sczytane_dane;
        string sczytana_nazwa_filmu;
        string sczytana_data_seansu;
        string sczytane_id_seansu;
        string sczytane_id_sali;
        string sczytane_id_klienta;
        string sczytanie_ceny;
        string sczytane_miejsce;
        string sczytany_rzad;
        string sczytane_id_miejsca;
        string sczytane_id_rezerwacji;

        public Aplikacja_bazodanowa()
        {
            InitializeComponent();
            
            pole_oceny.Visible = false;
            przycisk_ocena.Visible = false;
            pole_skali_ocen.Visible = false;
            pole_imie.Visible = false;
            pole_nazwisko.Visible = false;
            pole_data_urodzenia.Visible = false;
            pole_e_mail.Visible = false;
            pole_numer_telefonu.Visible = false;
            przycisk_zarezerwuj_miejsce.Visible = true;
            przycisk_usun_zarezerwowane_miejsce.Visible = true;
            przycisk_potwierdz_usuniecie_rezerwacji.Visible = false;
            przycisk_wyslij_rezerwacje.Visible = false;
            pole_data_zgloszenia.Visible = false;

            
           

        }


        private void click_filmy(object sender, EventArgs e) // przycisk FIlmy
        {
            przycisk_ocena.Visible = false;
            pole_oceny.Visible = false;
            pole_skali_ocen.Visible = false;
            pole_imie.Visible = false;
            pole_nazwisko.Visible = false;
            pole_data_urodzenia.Visible = false;
            pole_e_mail.Visible = false;
            pole_numer_telefonu.Visible = false;
            przycisk_zarezerwuj_miejsce.Visible = true;
            przycisk_usun_zarezerwowane_miejsce.Visible = true;
            przycisk_wyslij_rezerwacje.Visible = false;
            przycisk_potwierdz_usuniecie_rezerwacji.Visible = false;
            licznik_rezerwajcji = 0;

            string sql = "SELECT Tytuł, Nazwa_kategorii, Czas_trwania " +
                         "FROM film " +
                         "INNER JOIN kategoria " +
                         "ON kategoria.Kategoria_ID = film.Kategoria_ID  ";//wykonaj polecenie języka SQL

            przesyłanie_danych(sql);
        }
        private void click_szukaj(object sender, EventArgs e)  // przycisk Szukaj
        {
            przycisk_ocena.Visible = false;
            pole_oceny.Visible = false;
            pole_skali_ocen.Visible = false;
            pole_imie.Visible = false;
            pole_nazwisko.Visible = false;
            pole_data_urodzenia.Visible = false;
            pole_e_mail.Visible = false;
            pole_numer_telefonu.Visible = false;
            przycisk_zarezerwuj_miejsce.Visible = true;
            przycisk_usun_zarezerwowane_miejsce.Visible = true;
            przycisk_wyslij_rezerwacje.Visible = false;
            przycisk_potwierdz_usuniecie_rezerwacji.Visible = false;
            licznik_rezerwajcji = 0;

            string sql = "SELECT Tytuł, Nazwa_kategorii, Czas_trwania, Opis " +
                        "FROM film " +
                        "INNER JOIN kategoria " +
                        "ON kategoria.Kategoria_ID = film.Kategoria_ID " +
                        "WHERE (Tytuł LIKE '%" + pole_wyszukiwania.Text + "%') OR ( Nazwa_kategorii LIKE '%" + pole_wyszukiwania.Text + "%')";//wykonaj polecenie języka SQL

            przesyłanie_danych(sql);
        }

        private void click_dataGridView1(object sender, DataGridViewCellEventArgs e)  // podwojne klikanie na dany film
        {

            

            if ((przycisk_zarezerwuj_miejsce.Visible == false) && (licznik_rezerwajcji == 2))  // jezeli miejsce rezerwacji
            {

                przycisk_ocena.Visible = false;
                pole_oceny.Visible = false;
                pole_skali_ocen.Visible = false;
                pole_imie.Visible = true;
                pole_nazwisko.Visible = true;
                pole_data_urodzenia.Visible = true;
                pole_e_mail.Visible = true;
                pole_numer_telefonu.Visible = true;
                przycisk_wyslij_rezerwacje.Visible = true;
                przycisk_usun_zarezerwowane_miejsce.Visible = false;
                przycisk_potwierdz_usuniecie_rezerwacji.Visible = false;
                licznik_rezerwajcji++;

                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[index];

                sczytane_miejsce = selectedRow.Cells[0].Value.ToString();  
                sczytany_rzad = selectedRow.Cells[1].Value.ToString();

                string sql_do_pobrania = "SELECT Miejsce_ID " +
                                         "FROM miejsce " +
                                         "WHERE(Rząd = '" + sczytany_rzad + "') && " +
                                         "(Fotel = '" + sczytane_miejsce + "') && " +
                                         "(Sala_ID = '" + sczytane_id_sali + "') ";

                pobieranie_danych(sql_do_pobrania, 0);
                sczytane_id_miejsca = sczytane_dane;

            }

            if ((przycisk_zarezerwuj_miejsce.Visible == false) && (licznik_rezerwajcji == 1))  // jezeli wybralem date/numer seansu przy rezerwacji
            {
               
                przycisk_ocena.Visible = false;
                pole_oceny.Visible = false;
                pole_skali_ocen.Visible = false;
                pole_imie.Visible = false;
                pole_nazwisko.Visible = false;
                pole_data_urodzenia.Visible = false;
                pole_e_mail.Visible = false;
                pole_numer_telefonu.Visible = false;
                przycisk_wyslij_rezerwacje.Visible = false;
                przycisk_potwierdz_usuniecie_rezerwacji.Visible = false;
                licznik_rezerwajcji++;

                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                
              
                sczytana_nazwa_filmu = selectedRow.Cells[0].Value.ToString();  // zapisanie nazwy filmu by pozniej zapisac rezerwacje
                sczytana_data_seansu = selectedRow.Cells[1].Value.ToString();  // zapisanie daty seansu by pozniej zapisac rezerwacje
                sczytane_id_sali = selectedRow.Cells[5].Value.ToString();  // zapisanie id_sali/ numer sali by pozniej zapisac rezerwacje
                sczytanie_ceny = selectedRow.Cells[6].Value.ToString();  // zapisanie ceny by pozniej zapisac rezerwacje

              


                //wykonaj polecenie języka SQL
                string sql = "SELECT Rząd, Fotel, Numer_sali " +
                             "FROM miejsce " +
                             "INNER JOIN sala " +
                             "ON miejsce.Sala_ID = sala.Sala_ID " +
                             "WHERE Numer_sali = '" + sczytane_id_sali + "'";

                przesyłanie_danych(sql);

                string sql_do_pobrania = "SELECT Seans_ID " +
                                         "FROM seans " +
                                         "INNER JOIN film " +
                                         "ON seans.Film_ID = film.Film_ID " +
                                         "WHERE" + 
                                         "(Tytuł = '" + sczytana_nazwa_filmu + "') && (Sala_ID = '" + sczytane_id_sali + "') ";
                pobieranie_danych(sql_do_pobrania, 0);
                sczytane_id_seansu = sczytane_dane;
               

            }



            if ((przycisk_zarezerwuj_miejsce.Visible == false) && (licznik_rezerwajcji == 0))  // jezeli kliknalem odpowiedni film
            {
             
                przycisk_ocena.Visible = false;
                pole_oceny.Visible = false;
                pole_skali_ocen.Visible = false;
                pole_imie.Visible = false;
                pole_nazwisko.Visible = false;
                pole_data_urodzenia.Visible = false;
                pole_e_mail.Visible = false;
                pole_numer_telefonu.Visible = false;
                przycisk_wyslij_rezerwacje.Visible = false;
                przycisk_potwierdz_usuniecie_rezerwacji.Visible = false;
                licznik_rezerwajcji++;

                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                string nazwa_filmu = selectedRow.Cells[0].Value.ToString();
                //wykonaj polecenie języka SQL
                string sql = "SELECT Tytuł, Data_seansu, Nazwa_kategorii, Czas_trwania, Data_premiery, Numer_sali,  Cena, Opis " +
                             "FROM film " +
                             "INNER JOIN kategoria " +
                             "ON kategoria.Kategoria_ID = film.Kategoria_ID " +
                             "INNER JOIN seans " +
                             "ON seans.Film_ID = film.Film_ID " +
                             "INNER JOIN sala " +
                             "ON sala.Sala_ID = seans.Sala_ID " +
                             "WHERE Tytuł = '" + nazwa_filmu + "'";

             


                przesyłanie_danych(sql);
                
            }
            
            
            
            if (przycisk_zarezerwuj_miejsce.Visible == true)
            {
                przycisk_ocena.Visible = true;
                pole_oceny.Visible = true;
                pole_skali_ocen.Visible = true;
                pole_imie.Visible = false;
                pole_nazwisko.Visible = false;
                pole_data_urodzenia.Visible = false;
                pole_e_mail.Visible = false;
                pole_numer_telefonu.Visible = false;
                przycisk_zarezerwuj_miejsce.Visible = true;
                przycisk_usun_zarezerwowane_miejsce.Visible = true;
                przycisk_wyslij_rezerwacje.Visible = false;
                przycisk_potwierdz_usuniecie_rezerwacji.Visible = false;
                licznik_rezerwajcji = 0;

                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                string nazwa_filmu = selectedRow.Cells[0].Value.ToString();
                //wykonaj polecenie języka SQL
                string sql = "SELECT Tytuł, Data_seansu, Nazwa_kategorii, Czas_trwania, Data_premiery, Numer_sali, Cena,  Opis " +
                             "FROM film " +
                             "INNER JOIN kategoria " +
                             "ON kategoria.Kategoria_ID = film.Kategoria_ID " +
                             "INNER JOIN seans " +
                             "ON seans.Film_ID = film.Film_ID " +
                             "INNER JOIN sala " +
                             "ON sala.Sala_ID = seans.Sala_ID " +
                             "WHERE Tytuł = '" + nazwa_filmu + "'";


                przesyłanie_danych(sql);

            }
        }
        private void click_przycisk_ocena(object sender, EventArgs e)
        {
            przycisk_ocena.Visible = true;
            pole_oceny.Visible = true;
            pole_skali_ocen.Visible = true;
            pole_imie.Visible = false;
            pole_nazwisko.Visible = false;
            pole_data_urodzenia.Visible = false;
            pole_e_mail.Visible = false;
            pole_numer_telefonu.Visible = false;
            przycisk_zarezerwuj_miejsce.Visible = true;
            przycisk_usun_zarezerwowane_miejsce.Visible = true;
            przycisk_wyslij_rezerwacje.Visible = false;
            przycisk_potwierdz_usuniecie_rezerwacji.Visible = false;
            licznik_rezerwajcji = 0;

            DataGridViewRow selectedRow = dataGridView1.Rows[0];
            string nazwa_filmu = selectedRow.Cells[0].Value.ToString();
            string id_filmu = "SELECT Film_ID FROM film WHERE Tytuł = '" + nazwa_filmu +"'";

            string sql = "INSERT INTO komentarz(Komentarz, Ocena, Klient_ID, Film_ID) " +
                         "VALUES ('" + pole_oceny.Text + "' , '" + pole_skali_ocen.Text + "' , '2' , '3');";
            przesyłanie_danych(sql);

        }

        private void click_przycisk_zarezerwuj_miejsce(object sender, EventArgs e)
        {
            przycisk_ocena.Visible = false;
            pole_oceny.Visible = false;
            pole_skali_ocen.Visible = false;
            pole_imie.Visible = false;
            pole_nazwisko.Visible = false;
            pole_data_urodzenia.Visible = false;
            pole_e_mail.Visible = false;
            pole_numer_telefonu.Visible = false;
            przycisk_zarezerwuj_miejsce.Visible = false;
            przycisk_usun_zarezerwowane_miejsce.Visible = false;
            przycisk_wyslij_rezerwacje.Visible = false;
            przycisk_potwierdz_usuniecie_rezerwacji.Visible = false;
            licznik_rezerwajcji = 0;

            string sql = "SELECT Tytuł, Nazwa_kategorii, Czas_trwania " +
                         "FROM film " +
                         "INNER JOIN kategoria " +
                         "ON kategoria.Kategoria_ID = film.Kategoria_ID  ";//wykonaj polecenie języka SQL

            przesyłanie_danych(sql);
        }

        private void click_przycisk_wyslij_rezerwacje(object sender, EventArgs e)
        {
             // wpisalem dane osobowe i kliknalem wyslij rezerwacje
            

            przycisk_ocena.Visible = false;
            pole_oceny.Visible = false;
            pole_skali_ocen.Visible = false;
            pole_imie.Visible = false;
            pole_nazwisko.Visible = false;
            pole_data_urodzenia.Visible = false;
            pole_e_mail.Visible = false;
            pole_numer_telefonu.Visible = false;
            przycisk_zarezerwuj_miejsce.Visible = true;
            przycisk_wyslij_rezerwacje.Visible = false;
            przycisk_usun_zarezerwowane_miejsce.Visible = true;
            przycisk_potwierdz_usuniecie_rezerwacji.Visible = false;
            licznik_rezerwajcji =0;
            //wykonaj polecenie języka SQL
            string sql = "INSERT INTO klient(Imie, Nazwisko, Data_urodzenia, E_mail , Numer_telefonu) " +
                         "VALUES('" + pole_imie.Text + "', '" + pole_nazwisko.Text + 
                         "', '" + pole_data_urodzenia.Text + "', '" + pole_e_mail.Text + 
                         "', '" + pole_numer_telefonu.Text + "')";
            przesyłanie_danych(sql);

            string sql_pobierz_dane = "SELECT Klient_ID " +
                                      "FROM klient " +
                                      "WHERE (Imie = '" + pole_imie.Text + "') && " +
                                      "(Nazwisko = '" + pole_nazwisko.Text + "') && " +
                                      "(Data_urodzenia = '" + pole_data_urodzenia.Text + "') && " +
                                      "(E_mail = '" + pole_e_mail.Text + "') && " +
                                      "(Numer_telefonu = '" + pole_numer_telefonu.Text + "') ";

            pobieranie_danych(sql_pobierz_dane, 0);
            sczytane_id_klienta = sczytane_dane;
            //MessageBox.Show(sczytane_id_klienta, "Błąd");

            sql = "INSERT INTO rezerwacja (Data_zgłoszenia, Seans_ID, Klient_ID, Cena) " +
                  "VALUES ('1111-11-11' , '" + sczytane_id_seansu + "', '" + sczytane_id_klienta + "', '" + sczytanie_ceny + "') ";

            przesyłanie_danych(sql);

            string sql_pobierz_dane2 = "SELECT Rezerwacja_ID " +
                               "FROM rezerwacja " +
                               "WHERE " +     
                               "(Seans_ID = '" + sczytane_id_seansu + "') && " +
                               "(Klient_ID = '" + sczytane_id_klienta + "') && " +
                               "(Cena = '" + sczytanie_ceny + "') ";

            pobieranie_danych(sql_pobierz_dane2, 0);
            sczytane_id_rezerwacji = sczytane_dane;

            string sql2 = "INSERT INTO miej_rez( Miejsce_ID, Rezerwacja_ID ) " +
                          "VALUES ('" + sczytane_id_miejsca + "', '" + sczytane_id_rezerwacji + "') "; //// BLAD !!!!!!!!!!
            MessageBox.Show(sczytane_id_miejsca, "Błąd");
            MessageBox.Show(sczytane_id_rezerwacji, "Błąd");
            MessageBox.Show(sczytane_id_klienta, "Błąd");
            przesyłanie_danych(sql2);
        }

        private void click_usun_zarezerwowane_miejsce(object sender, EventArgs e)
        {
            przycisk_ocena.Visible = false;
            pole_oceny.Visible = false;
            pole_skali_ocen.Visible = false;
            pole_imie.Visible = true;
            pole_nazwisko.Visible = true;
            pole_data_urodzenia.Visible = true;
            pole_e_mail.Visible = true;
            pole_numer_telefonu.Visible = true;
            pole_data_zgloszenia.Visible = true;
            przycisk_wyslij_rezerwacje.Visible = false;
            przycisk_usun_zarezerwowane_miejsce.Visible = false;
            przycisk_potwierdz_usuniecie_rezerwacji.Visible = true;

        }

        private void click_potwerdz_usuniecie_rezerwacji(object sender, EventArgs e)
        {
            przycisk_ocena.Visible = false;
            pole_oceny.Visible = false;
            pole_skali_ocen.Visible = false;
            pole_imie.Visible = false;
            pole_nazwisko.Visible = false;
            pole_data_urodzenia.Visible = false;
            pole_e_mail.Visible = false;
            pole_numer_telefonu.Visible = false;
            pole_data_zgloszenia.Visible = false;
            przycisk_wyslij_rezerwacje.Visible = false;
            przycisk_usun_zarezerwowane_miejsce.Visible = true;
            przycisk_potwierdz_usuniecie_rezerwacji.Visible = false;

            string sql_pobierz_dane = "SELECT Klient_ID " +
                                      "FROM klient " +
                                      "WHERE(Imie = '" + pole_imie.Text + "') && " +
                                      "(Nazwisko = '" + pole_nazwisko.Text + "') && " +
                                      "(Data_urodzenia = '" + pole_data_urodzenia.Text + "') && " +
                                      "(E_mail = '" + pole_e_mail.Text + "') && " +
                                      "(Numer_telefonu = '" + pole_numer_telefonu.Text + "')";

            pobieranie_danych(sql_pobierz_dane, 0);
            sczytane_id_klienta = sczytane_dane;

            string sql_pobierz_dane2 = "SELECT Rezerwacja_ID " +
                                       "FROM rezerwacja " +
                                       "WHERE (Data_zgłoszenia = '" + pole_data_zgloszenia.Text + "') && " + 
                                       "(Klient_ID = '" + sczytane_id_klienta + "')";

            pobieranie_danych(sql_pobierz_dane2, 0);
            sczytane_id_seansu = sczytane_dane;

            string sql = "DELETE " +
                                      "FROM klient " +
                                      "WHERE(Imie = '" + pole_imie.Text + "') && " +
                                      "(Nazwisko = '" + pole_nazwisko.Text + "') && " +
                                      "(Data_urodzenia = '" + pole_data_urodzenia.Text + "') && " +
                                      "(E_mail = '" + pole_e_mail.Text + "') && " +
                                      "(Numer_telefonu = '" + pole_numer_telefonu.Text + "')";

            przesyłanie_danych(sql);

            string sql3 = "DELETE FROM miej_rez " +
                          "WHERE (Rezerwacja_ID = '" + sczytane_id_rezerwacji + "') ";

            przesyłanie_danych(sql3);

            string sql2 = "DELETE FROM rezerwacja " +
                          "WHERE(Klient_ID = '" + sczytane_id_klienta + "') && " +
                          "(Data_zgłoszenia = '" + pole_data_zgloszenia.Text + "') ";

            przesyłanie_danych(sql2);

            
                          


        }

        public void przesyłanie_danych(string sql)  // przesylanie danych pomiedzy apliakcja a baza MySQL za pomoca komend SQL'owskich
        {
            string mojePolaczenie = "datasource=127.0.0.1;port=3306;username=root;password=;database=kino;";

            
            MySqlConnection polaczenie = new MySqlConnection(mojePolaczenie);


            //blok try-catch przechwytuje błędy
            try
            {
                polaczenie.Open();//otwórz połączenie z bazą danych
                using (MySqlCommand cmdSel = new MySqlCommand(sql, polaczenie))//wykonaj polecenie języka SQL na danych połączeniu
                {
                    DataTable dt = new DataTable();
                 
                    MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);   //Pobierz dane i zapisz w strukturze DataTable
                    da.Fill(dt);
                    

                    dataGridView1.DataSource = dt.DefaultView;        //wpisz dane do kontrolki DATAGRID

                  
                }

            }
         
            catch (MySql.Data.MySqlClient.MySqlException ex)   //Jeżeli wystąpi wyjątek wyrzuć go i pokaż informacje
            {
                MessageBox.Show("Błąd połączenia", "Błąd");
            }
            
            polaczenie.Close(); //Zamknij połączenie po wyświetleniu danych

        }

        public void pobieranie_danych(string sql, int numer_kolumny)  // pobieranie danych z bazy danych MySQL
        {
            string mojePolaczenie = "datasource=127.0.0.1;port=3306;username=root;password=;database=kino;";


            MySqlConnection polaczenie = new MySqlConnection(mojePolaczenie);


            //blok try-catch przechwytuje błędy
            try
            {
                polaczenie.Open();//otwórz połączenie z bazą danych
                using (MySqlCommand cmdSel = new MySqlCommand(sql, polaczenie))//wykonaj polecenie języka SQL na danych połączeniu
                {
                    MySqlDataReader czytnik = cmdSel.ExecuteReader(); // pobieramy dane

                    while (czytnik.Read())     // czytamy wszystkie dane
                    {
                        sczytane_dane = czytnik.GetString(numer_kolumny); //zapisujemy sczytane dane
                      //  Console.WriteLine("{0} {1} {2}", czytnik.GetString(0), czytnik.GetString(1),czytnik.GetString(2));

                    }
                    czytnik.Close();
                }

            }

            catch (MySql.Data.MySqlClient.MySqlException ex)   //Jeżeli wystąpi wyjątek wyrzuć go i pokaż informacje
            {
                MessageBox.Show("Błąd połączenia", "Błąd");
            }

            polaczenie.Close(); //Zamknij połączenie po wyświetleniu danych

        }

        
    }
}



