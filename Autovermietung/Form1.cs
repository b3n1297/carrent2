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

namespace Autovermietung
{
    public partial class Form1 : Form
    {
        bool mouseclickedh = true;   //Home
        bool mouseclickedl = false;   //Buch
        bool mouseclickedb = false;   //Auto löschen
        bool mouseclickeda = false;   //Auto hinzufügen
        bool mouseclickedc = false;   //Kunnden anlegen
        public Form1()
        {

            InitializeComponent();   

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
             buchpnl.BackColor = Color.DimGray;
            buchpnl.ForeColor = Color.Black;
            mouseclickedl = true;
            mouseclickedh = false;
            mouseclickeda = false;
            mouseclickedb = false;
            mouseclickedc = false;
            homebtn.BackColor = Color.Transparent;
            homebtn.ForeColor = Color.White;
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
        {if (mouseclickedl == true)
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
        private void NeuesAutopnl_Click(object sender, EventArgs e)
        {
            // BuchAnl.BringToFront();
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
        {if (mouseclickeda == true)
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
        {if (mouseclickedb == true)
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
  
    }
}
