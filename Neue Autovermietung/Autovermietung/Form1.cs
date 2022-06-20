using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Autovermietung
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")] //Statischer Einstiegspunkt verfügbar machen
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
       );

        bool mouseclickedh = true;   //Home
        bool mouseclickedl = false;   //Buch
        bool mouseclickedb = false;   //Auto löschen
        bool mouseclickeda = false;   //Auto hinzufügen
        bool mouseclickedc = false;   //Kunnden anlegen
        public Form1()
        {

            InitializeComponent();
            //abgerundete Ecken
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        //----------------------------------------------------------------------------------------//
        //                                  Home Bildschirm
        //----------------------------------------------------------------------------------------//
        private void homebtn_Click(object sender, EventArgs e)
        {
            Home.BringToFront();
            abdeckung.BringToFront();
            homebtn.BackColor = Color.DimGray;
            homebtn.ForeColor = Color.Black;
            mouseclickedh = true;
            mouseclickedl = false;
            mouseclickeda = false;
            mouseclickedb = false;
            mouseclickedc = false;
        }
        //Backcolor wenn der Mauszeiger auf dem Button ist
        private void homebtn_MouseEnter(object sender, EventArgs e)
        {
            homebtn.BackColor = Color.DimGray;
            homebtn.ForeColor = Color.Black;
        }

        private void homebtn_Leave(object sender, EventArgs e)
        {
            homebtn.BackColor = Color.Transparent;
            homebtn.ForeColor = Color.White;

        }
        private void homebtn_MouseLeave(object sender, EventArgs e)
        {
            if (mouseclickedh == true)
            {
                // mouseclickedh = false;

                return;
            }
            // else if (mouseclickedl == true || mouseclickeda == true || mouseclickedb == true || mouseclickedc == true)
            else
            {
                //mouseclickedl = false;
                //mouseclickeda = false;
                //mouseclickedb = false;
                //mouseclickedc = false;

                homebtn.BackColor = Color.Transparent;
                homebtn.ForeColor = Color.White;
            }
        }

        //----------------------------------------------------------------------------------------//
        //                                  Buchung anlegen
        //----------------------------------------------------------------------------------------//
        private void Autoübersicht_Click(object sender, EventArgs e)
        {
            BuchAnl.BringToFront();
            // buchpnl.BackColor = Color.DimGray;
            //buchpnl.ForeColor = Color.Black;
            mouseclickedl = true;
            mouseclickedh = false;
            mouseclickeda = false;
            mouseclickedb = false;
            mouseclickedc = false;
            homebtn.BackColor = Color.Transparent;
            homebtn.ForeColor = Color.White;
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
              int AutoIDEingabe = Convert.ToInt32(AutoIDbuch.Text);
        }
        private void kundenidbuch_TextChanged(object sender, EventArgs e)
        {

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
        private void showcars_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hallo");
            DatenAbfragen(AutoIDbuch.Text, kundenidbuch.Text, dateTimePicker1.Value, dateTimePicker2.Value);
        }
        public void DatenAbfragen(string AutoID, string KundeID, DateTime StartDatum, DateTime Enddatum)
        {


            try
            {
                string query = "INSERT INTO buchung(AutoID, KundeID, StartDatum, Enddatum) VALUES (@AutoID, @KundeID, @StartDatum, @Enddatum)";

                string MySqlConnectionString = "Datasource=127.0.0.1;port=3306;username=root;password=;database=autovermietung";
                MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString);
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);

                databaseConnection.Open();
                cmd.Parameters.Add("@AutoID", MySqlDbType.Int32).Value = AutoID;
                cmd.Parameters.Add("@KundeID", MySqlDbType.Int32).Value = KundeID;
                cmd.Parameters.Add("@StartDatum", MySqlDbType.Date).Value = StartDatum;
                cmd.Parameters.Add("@Enddatum", MySqlDbType.Date).Value = Enddatum;

                MySqlDataReader dr = cmd.ExecuteReader();

                MessageBox.Show("Buchung angelegt ");
            }



            catch (Exception ex)
            {
                MessageBox.Show("Es ist ein Datenbank-Fehler aufgetreten bitte wenden Sie sich an den Support."
                    + "                                                                                                                                                                        "


                + ex.ToString());
            }


        }

        //Backcolor wenn der Mauszeiger auf dem Button ist
        private void buchpnl_MouseEnter(object sender, EventArgs e)
        {
            buchpnl.BackColor = Color.DimGray;
            buchpnl.ForeColor = Color.Black;
        }
        private void buchpnl_Leave(object sender, EventArgs e)
        {
            buchpnl.BackColor = Color.Transparent;
            buchpnl.ForeColor = Color.White;
        }

        private void buchpnl_MouseLeave(object sender, EventArgs e)
        { if (mouseclickedl == true)
            {
                // mouseclickedl = false;              

                return;
            }
            //else if (mouseclickedh == true || mouseclickeda == true || mouseclickedb == true || mouseclickedc == true)
            else
            {
                buchpnl.BackColor = Color.Transparent;
                buchpnl.ForeColor = Color.White;
            }
        }

        //----------------------------------------------------------------------------------------//
        //                                  Autos hinzufügen
        //----------------------------------------------------------------------------------------//
        public void InsertDataMySQL(string anzahlPS, string farbe, string marke, string modell, string tagesmietpreis)
        {

            string query = @"INSERT INTO auto (AnzahlPS, Farbe, Marke, Modell, Tagesmietpreis) VALUES (@AnzahlPS, @Farbe, @Marke, @Modell, @Tagesmietpreis)";

            string MySqlConnectionString = "Datasource=127.0.0.1;port=3306;username=root;password=;database=autovermietung";
            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);

            try
            {
                databaseConnection.Open();
                cmd.Parameters.Add("@AnzahlPS", MySqlDbType.Int32).Value = anzahlPS;
                cmd.Parameters.Add("@Farbe", MySqlDbType.VarChar).Value = farbe;
                cmd.Parameters.Add("@Marke", MySqlDbType.VarChar).Value = marke;
                cmd.Parameters.Add("@Modell", MySqlDbType.VarChar).Value = modell;
                cmd.Parameters.Add("@Tagesmietpreis", MySqlDbType.Int32).Value = tagesmietpreis;

                MySqlDataReader myReader = cmd.ExecuteReader();
                MessageBox.Show("Das Auto wurde hinzugefügt");
            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "  Fehler");
            }


        }
        private void anzahlps_TextChanged(object sender, EventArgs e)
        {

        }

        private void farbeaddcar_TextChanged(object sender, EventArgs e)
        {

        }

        private void markeadd_TextChanged(object sender, EventArgs e)
        {

        }

        private void modelladd_TextChanged(object sender, EventArgs e)
        {

        }

        private void priceadd_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCarbtn_Click(object sender, EventArgs e)
        {

            InsertDataMySQL(anzahlps.Text, farbeaddcar.Text, markeadd.Text, modelladd.Text, priceadd.Text);
            anzahlps.Clear();
            farbeaddcar.Clear();
            markeadd.Clear();
            modelladd.Clear();
            priceadd.Clear();
            anzahlps.Focus();

        }
        //weiterer Code fürs Design
        private void NeuesAutopnl_Click(object sender, EventArgs e)
        {
            AutoHinzufügen.BringToFront();
            mouseclickeda = true;
            mouseclickedl = false;
            mouseclickedh = false;
            mouseclickedb = false;
            mouseclickedc = false;
            homebtn.BackColor = Color.Transparent;
            homebtn.ForeColor = Color.White;
        }
        //Backcolor wenn der Mauszeiger auf dem Button ist
        private void neuesautopnl_MouseEnter(object sender, EventArgs e)
        {
            neuesautopnl.BackColor = Color.DimGray;
            neuesautopnl.ForeColor = Color.Black;
        }

        private void neuesautopnl_Leave(object sender, EventArgs e)
        {
            neuesautopnl.BackColor = Color.Transparent;
            neuesautopnl.ForeColor = Color.White;
        }

        private void neuesautopnl_MouseLeave(object sender, EventArgs e)
        { if (mouseclickeda == true)
            {
                // mouseclickeda = false;

                return;

            }
            //else if (mouseclickedl == true || mouseclickedh == true || mouseclickedb == true || mouseclickedc == true)
            else
            {
                neuesautopnl.BackColor = Color.Transparent;
                neuesautopnl.ForeColor = Color.White;
            }
        }

        //----------------------------------------------------------------------------------------//
        //                                  Autos Löschen
        //----------------------------------------------------------------------------------------//
        private void Löschpnl_Click(object sender, EventArgs e)
        {
            Löschen.BringToFront();
            löschpnl.BackColor = Color.DimGray;
            löschpnl.ForeColor = Color.Black;
            mouseclickedb = true;
            mouseclickedl = false;
            mouseclickeda = false;
            mouseclickedh = false;
            mouseclickedc = false;
            homebtn.BackColor = Color.Transparent;
            homebtn.ForeColor = Color.White;
        }
        private void delbtn_Click(object sender, EventArgs e)
        {
            if (PinDel.Text == "1234")
            {
                DeleteDataMySql(AutoIDdel.Text);
            }
            else
            {
                MessageBox.Show("Falsche Pin");
            }

        }
        public void DeleteDataMySql(string autoID)
        {

            string query = @"DELETE FROM auto WHERE AutoID = @AutoID";

            string MySqlConnectionString = "Datasource=127.0.0.1;port=3306;username=root;password=;database=autovermietung";
            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);

            try
            {
                databaseConnection.Open();
                cmd.Parameters.Add("@AutoID", MySqlDbType.Int64).Value = autoID;


                MySqlDataReader myReader = cmd.ExecuteReader();
                MessageBox.Show("Das Auto wurde gelöscht!");
            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "  Fehler");
            }
        }

        //ID
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Pin
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        //Backcolor wenn der Mauszeiger auf dem Button ist
        private void löschpnl_MouseEnter(object sender, EventArgs e)
        {
            löschpnl.BackColor = Color.DimGray;
            löschpnl.ForeColor = Color.Black;
        }
        private void löschpnl_Leave(object sender, EventArgs e)
        {
            löschpnl.BackColor = Color.Transparent;
            löschpnl.ForeColor = Color.White;
        }
        private void löschpnl_MouseLeave(object sender, EventArgs e)
        { if (mouseclickedb == true)
            {
                //mouseclickedb = false;

                return;
            }
            //else if (mouseclickedl == true || mouseclickeda == true || mouseclickedh == true || mouseclickedc == true)
            else
            {
                löschpnl.BackColor = Color.Transparent;
                löschpnl.ForeColor = Color.White;
            }

        }

        //----------------------------------------------------------------------------------------//
        //                                  KLunden anlegen
        //----------------------------------------------------------------------------------------//
        private void kundepnl_Click(object sender, EventArgs e)
        {
            KundAnleg.BringToFront();
            kundepnl.BackColor = Color.DimGray;
            kundepnl.ForeColor = Color.Black;
            mouseclickedc = true;
            mouseclickedl = false;
            mouseclickeda = false;
            mouseclickedb = false;
            mouseclickedh = false;
            homebtn.BackColor = Color.Transparent;
            homebtn.ForeColor = Color.White;
        }
        private void kundadd_Click(object sender, EventArgs e)
        {
            InsertDataMySQL2(vornameKund.Text, nachnameKund.Text, bdayKund.Text, adresseKund.Text, plzKund.Text);
        }

        private void vornameKund_TextChanged(object sender, EventArgs e)
        {

        }

        private void nachnameKund_TextChanged(object sender, EventArgs e)
        {

        }

        private void bdayKund_ValueChanged(object sender, EventArgs e)
        {

        }

        private void adresseKund_TextChanged(object sender, EventArgs e)
        {

        }

        private void plzKund_TextChanged(object sender, EventArgs e)
        {

        }
        public void InsertDataMySQL2(string Vorname, string Nachname, string Geburtstag, string Adresse, string PLZ)
        {
            // string query = "UPDATE auto SET Tagesmietpreis = 225 WHERE AutoID = ";
            string query = @"INSERT INTO kunde (Vorname, Nachname, Geburtstag, Adresse, PLZ) VALUES ( @Vorname , @Nachname, @Geburtstag, @Adresse, @PLZ)";
            // Funktionierende Query: INSERT INTO kunde (KundeID, Vorname, Nachname, Geburtstag, Adresse, PLZ, ZID) VALUES (4, 'Peter' , 'Mayer', 1998-10-10, 'Domstraße 7', 61234, 4)

            string MySqlConnectionString = "Datasource=127.0.0.1;port=3306;username=root;password=;database=autovermietung";
            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);

            try
            {
                databaseConnection.Open();
                cmd.Parameters.Add("@Vorname", MySqlDbType.VarChar).Value = Vorname;
                cmd.Parameters.Add("@Nachname", MySqlDbType.VarChar).Value = Nachname;
                cmd.Parameters.Add("@Geburtstag", MySqlDbType.DateTime).Value = Geburtstag;
                cmd.Parameters.Add("@Adresse", MySqlDbType.VarChar).Value = Adresse;
                cmd.Parameters.Add("@PLZ", MySqlDbType.Int32).Value = PLZ;

                MySqlDataReader myReader = cmd.ExecuteReader();
                MessageBox.Show("Der Kunde wurde hinzugefügt");
            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "  Fehler");
            }


      

    
        }

             //Backcolor wenn der Mauszeiger auf dem Button ist
             private void kundepnl_MouseEnter(object sender, EventArgs e)
        {
            kundepnl.BackColor = Color.DimGray;
            kundepnl.ForeColor = Color.Black;
        }
        private void kundepnl_MouseLeave(object sender, EventArgs e)
        {
            if (mouseclickedc == true)
            {
                //mouseclickedc = false;
              
                return;
            }
            //else if (mouseclickedl == true || mouseclickeda == true || mouseclickedb == true || mouseclickedh == true)
            else
            {
                kundepnl.BackColor = Color.Transparent;
                kundepnl.ForeColor = Color.White;
            }
        }

        private void kundepnl_Leave(object sender, EventArgs e)
        {
            kundepnl.BackColor = Color.Transparent;
            kundepnl.ForeColor = Color.White;
        }

        //----------------------------------------------------------------------------------------//
        //                                  Programm schließen
        //----------------------------------------------------------------------------------------//
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Backcolor wenn der Mauszeiger auf dem Button ist
        private void closeallbtn_MouseEnter(object sender, EventArgs e)
        {
            closeallbtn.BackColor = Color.DimGray;
            closeallbtn.ForeColor = Color.Black;
        }

        private void closeallbtn_MouseLeave(object sender, EventArgs e)
        {
            closeallbtn.BackColor = Color.Transparent;
            closeallbtn.ForeColor = Color.White;
        }

        


        //_________________________________________________________________________
    }
}
