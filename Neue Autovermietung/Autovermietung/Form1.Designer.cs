namespace Autovermietung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Home = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.TextBox();
            this.closeallbtn = new System.Windows.Forms.Button();
            this.homebtn = new System.Windows.Forms.Button();
            this.kundepnl = new System.Windows.Forms.Button();
            this.buchpnl = new System.Windows.Forms.Button();
            this.neuesautopnl = new System.Windows.Forms.Button();
            this.löschpnl = new System.Windows.Forms.Button();
            this.KundAnleg = new System.Windows.Forms.Panel();
            this.kundadd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.vornameKund = new System.Windows.Forms.TextBox();
            this.nachnameKund = new System.Windows.Forms.TextBox();
            this.Vorname = new System.Windows.Forms.Label();
            this.adresseKund = new System.Windows.Forms.TextBox();
            this.plzKund = new System.Windows.Forms.TextBox();
            this.bdayKund = new System.Windows.Forms.DateTimePicker();
            this.Löschen = new System.Windows.Forms.Panel();
            this.delbtn = new System.Windows.Forms.Button();
            this.PinDel = new System.Windows.Forms.TextBox();
            this.Pin = new System.Windows.Forms.Label();
            this.AutoID = new System.Windows.Forms.Label();
            this.AutoIDdel = new System.Windows.Forms.TextBox();
            this.BuchAnl = new System.Windows.Forms.Panel();
            this.kundenidbuch = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.showcars = new System.Windows.Forms.Button();
            this.AutoIDbuch = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AutoHinzufügen = new System.Windows.Forms.Panel();
            this.AddCarbtn = new System.Windows.Forms.Button();
            this.farbeaddcar = new System.Windows.Forms.TextBox();
            this.markeadd = new System.Windows.Forms.TextBox();
            this.modelladd = new System.Windows.Forms.TextBox();
            this.priceadd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.anzahlps = new System.Windows.Forms.TextBox();
            this.abdeckung = new System.Windows.Forms.Panel();
            this.Home.SuspendLayout();
            this.KundAnleg.SuspendLayout();
            this.Löschen.SuspendLayout();
            this.BuchAnl.SuspendLayout();
            this.AutoHinzufügen.SuspendLayout();
            this.abdeckung.SuspendLayout();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Black;
            this.Home.Controls.Add(this.Logo);
            this.Home.Controls.Add(this.closeallbtn);
            this.Home.Controls.Add(this.homebtn);
            this.Home.Controls.Add(this.kundepnl);
            this.Home.Controls.Add(this.buchpnl);
            this.Home.Controls.Add(this.neuesautopnl);
            this.Home.Controls.Add(this.löschpnl);
            this.Home.Location = new System.Drawing.Point(0, 0);
            this.Home.Margin = new System.Windows.Forms.Padding(2);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(152, 647);
            this.Home.TabIndex = 0;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.DimGray;
            this.Logo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo.Location = new System.Drawing.Point(0, 463);
            this.Logo.Margin = new System.Windows.Forms.Padding(2);
            this.Logo.Name = "Logo";
            this.Logo.ReadOnly = true;
            this.Logo.Size = new System.Drawing.Size(152, 73);
            this.Logo.TabIndex = 0;
            this.Logo.Text = "ECR";
            // 
            // closeallbtn
            // 
            this.closeallbtn.FlatAppearance.BorderSize = 0;
            this.closeallbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeallbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeallbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeallbtn.Location = new System.Drawing.Point(9, 10);
            this.closeallbtn.Margin = new System.Windows.Forms.Padding(2);
            this.closeallbtn.Name = "closeallbtn";
            this.closeallbtn.Size = new System.Drawing.Size(56, 26);
            this.closeallbtn.TabIndex = 11;
            this.closeallbtn.Text = "X";
            this.closeallbtn.UseVisualStyleBackColor = true;
            this.closeallbtn.Click += new System.EventHandler(this.button1_Click);
            this.closeallbtn.MouseEnter += new System.EventHandler(this.closeallbtn_MouseEnter);
            this.closeallbtn.MouseLeave += new System.EventHandler(this.closeallbtn_MouseLeave);
            // 
            // homebtn
            // 
            this.homebtn.BackColor = System.Drawing.Color.DimGray;
            this.homebtn.FlatAppearance.BorderSize = 0;
            this.homebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homebtn.ForeColor = System.Drawing.Color.Black;
            this.homebtn.Location = new System.Drawing.Point(2, 86);
            this.homebtn.Margin = new System.Windows.Forms.Padding(2);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(152, 47);
            this.homebtn.TabIndex = 9;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = false;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            this.homebtn.Leave += new System.EventHandler(this.homebtn_Leave);
            this.homebtn.MouseEnter += new System.EventHandler(this.homebtn_MouseEnter);
            this.homebtn.MouseLeave += new System.EventHandler(this.homebtn_MouseLeave);
            // 
            // kundepnl
            // 
            this.kundepnl.FlatAppearance.BorderSize = 0;
            this.kundepnl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kundepnl.ForeColor = System.Drawing.Color.White;
            this.kundepnl.Location = new System.Drawing.Point(0, 133);
            this.kundepnl.Margin = new System.Windows.Forms.Padding(2);
            this.kundepnl.Name = "kundepnl";
            this.kundepnl.Size = new System.Drawing.Size(152, 47);
            this.kundepnl.TabIndex = 10;
            this.kundepnl.Text = "Kunde anlegen";
            this.kundepnl.UseVisualStyleBackColor = true;
            this.kundepnl.Click += new System.EventHandler(this.kundepnl_Click);
            this.kundepnl.Leave += new System.EventHandler(this.kundepnl_Leave);
            this.kundepnl.MouseEnter += new System.EventHandler(this.kundepnl_MouseEnter);
            this.kundepnl.MouseLeave += new System.EventHandler(this.kundepnl_MouseLeave);
            // 
            // buchpnl
            // 
            this.buchpnl.FlatAppearance.BorderSize = 0;
            this.buchpnl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buchpnl.ForeColor = System.Drawing.Color.White;
            this.buchpnl.Location = new System.Drawing.Point(0, 180);
            this.buchpnl.Margin = new System.Windows.Forms.Padding(2);
            this.buchpnl.Name = "buchpnl";
            this.buchpnl.Size = new System.Drawing.Size(152, 47);
            this.buchpnl.TabIndex = 8;
            this.buchpnl.Text = "Buchung anlegen";
            this.buchpnl.UseVisualStyleBackColor = true;
            this.buchpnl.Click += new System.EventHandler(this.Autoübersicht_Click);
            this.buchpnl.Leave += new System.EventHandler(this.buchpnl_Leave);
            this.buchpnl.MouseEnter += new System.EventHandler(this.buchpnl_MouseEnter);
            this.buchpnl.MouseLeave += new System.EventHandler(this.buchpnl_MouseLeave);
            // 
            // neuesautopnl
            // 
            this.neuesautopnl.FlatAppearance.BorderSize = 0;
            this.neuesautopnl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.neuesautopnl.ForeColor = System.Drawing.Color.White;
            this.neuesautopnl.Location = new System.Drawing.Point(0, 226);
            this.neuesautopnl.Margin = new System.Windows.Forms.Padding(2);
            this.neuesautopnl.Name = "neuesautopnl";
            this.neuesautopnl.Size = new System.Drawing.Size(152, 47);
            this.neuesautopnl.TabIndex = 7;
            this.neuesautopnl.Text = "Neues Auto";
            this.neuesautopnl.UseVisualStyleBackColor = true;
            this.neuesautopnl.Click += new System.EventHandler(this.NeuesAutopnl_Click);
            this.neuesautopnl.Leave += new System.EventHandler(this.neuesautopnl_Leave);
            this.neuesautopnl.MouseEnter += new System.EventHandler(this.neuesautopnl_MouseEnter);
            this.neuesautopnl.MouseLeave += new System.EventHandler(this.neuesautopnl_MouseLeave);
            // 
            // löschpnl
            // 
            this.löschpnl.BackColor = System.Drawing.Color.Transparent;
            this.löschpnl.FlatAppearance.BorderSize = 0;
            this.löschpnl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.löschpnl.ForeColor = System.Drawing.Color.White;
            this.löschpnl.Location = new System.Drawing.Point(0, 270);
            this.löschpnl.Margin = new System.Windows.Forms.Padding(2);
            this.löschpnl.Name = "löschpnl";
            this.löschpnl.Size = new System.Drawing.Size(152, 47);
            this.löschpnl.TabIndex = 6;
            this.löschpnl.Text = "Autos löschen";
            this.löschpnl.UseVisualStyleBackColor = false;
            this.löschpnl.Click += new System.EventHandler(this.Löschpnl_Click);
            this.löschpnl.Leave += new System.EventHandler(this.löschpnl_Leave);
            this.löschpnl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.löschpnl_MouseEnter);
            this.löschpnl.MouseEnter += new System.EventHandler(this.löschpnl_MouseEnter);
            this.löschpnl.MouseLeave += new System.EventHandler(this.löschpnl_MouseLeave);
            // 
            // KundAnleg
            // 
            this.KundAnleg.BackColor = System.Drawing.Color.Transparent;
            this.KundAnleg.Controls.Add(this.kundadd);
            this.KundAnleg.Controls.Add(this.label1);
            this.KundAnleg.Controls.Add(this.label5);
            this.KundAnleg.Controls.Add(this.label7);
            this.KundAnleg.Controls.Add(this.label6);
            this.KundAnleg.Controls.Add(this.vornameKund);
            this.KundAnleg.Controls.Add(this.nachnameKund);
            this.KundAnleg.Controls.Add(this.Vorname);
            this.KundAnleg.Controls.Add(this.adresseKund);
            this.KundAnleg.Controls.Add(this.plzKund);
            this.KundAnleg.Controls.Add(this.bdayKund);
            this.KundAnleg.Location = new System.Drawing.Point(148, -1);
            this.KundAnleg.Margin = new System.Windows.Forms.Padding(2);
            this.KundAnleg.Name = "KundAnleg";
            this.KundAnleg.Size = new System.Drawing.Size(1184, 647);
            this.KundAnleg.TabIndex = 5;
            // 
            // kundadd
            // 
            this.kundadd.Location = new System.Drawing.Point(337, 403);
            this.kundadd.Name = "kundadd";
            this.kundadd.Size = new System.Drawing.Size(75, 23);
            this.kundadd.TabIndex = 12;
            this.kundadd.Text = "Hinzufügen";
            this.kundadd.UseVisualStyleBackColor = true;
            this.kundadd.Click += new System.EventHandler(this.kundadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 350);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Postleitzahl";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 305);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Adresse";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 210);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Nachname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 256);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Geburtstag";
            // 
            // vornameKund
            // 
            this.vornameKund.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.vornameKund.Location = new System.Drawing.Point(230, 151);
            this.vornameKund.Margin = new System.Windows.Forms.Padding(2);
            this.vornameKund.Name = "vornameKund";
            this.vornameKund.Size = new System.Drawing.Size(183, 20);
            this.vornameKund.TabIndex = 5;
            this.vornameKund.TextChanged += new System.EventHandler(this.vornameKund_TextChanged);
            // 
            // nachnameKund
            // 
            this.nachnameKund.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nachnameKund.Location = new System.Drawing.Point(230, 209);
            this.nachnameKund.Margin = new System.Windows.Forms.Padding(2);
            this.nachnameKund.Name = "nachnameKund";
            this.nachnameKund.Size = new System.Drawing.Size(183, 20);
            this.nachnameKund.TabIndex = 6;
            this.nachnameKund.TextChanged += new System.EventHandler(this.nachnameKund_TextChanged);
            // 
            // Vorname
            // 
            this.Vorname.AutoSize = true;
            this.Vorname.Location = new System.Drawing.Point(154, 154);
            this.Vorname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Vorname.Name = "Vorname";
            this.Vorname.Size = new System.Drawing.Size(49, 13);
            this.Vorname.TabIndex = 0;
            this.Vorname.Text = "Vorname";
            // 
            // adresseKund
            // 
            this.adresseKund.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.adresseKund.Location = new System.Drawing.Point(230, 303);
            this.adresseKund.Margin = new System.Windows.Forms.Padding(2);
            this.adresseKund.Name = "adresseKund";
            this.adresseKund.Size = new System.Drawing.Size(183, 20);
            this.adresseKund.TabIndex = 7;
            this.adresseKund.TextChanged += new System.EventHandler(this.adresseKund_TextChanged);
            // 
            // plzKund
            // 
            this.plzKund.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.plzKund.Location = new System.Drawing.Point(230, 350);
            this.plzKund.Margin = new System.Windows.Forms.Padding(2);
            this.plzKund.Name = "plzKund";
            this.plzKund.Size = new System.Drawing.Size(183, 20);
            this.plzKund.TabIndex = 8;
            this.plzKund.TextChanged += new System.EventHandler(this.plzKund_TextChanged);
            // 
            // bdayKund
            // 
            this.bdayKund.Location = new System.Drawing.Point(230, 252);
            this.bdayKund.Margin = new System.Windows.Forms.Padding(2);
            this.bdayKund.Name = "bdayKund";
            this.bdayKund.Size = new System.Drawing.Size(185, 20);
            this.bdayKund.TabIndex = 10;
            this.bdayKund.ValueChanged += new System.EventHandler(this.bdayKund_ValueChanged);
            // 
            // Löschen
            // 
            this.Löschen.BackColor = System.Drawing.Color.Transparent;
            this.Löschen.Controls.Add(this.delbtn);
            this.Löschen.Controls.Add(this.PinDel);
            this.Löschen.Controls.Add(this.Pin);
            this.Löschen.Controls.Add(this.AutoID);
            this.Löschen.Controls.Add(this.AutoIDdel);
            this.Löschen.Location = new System.Drawing.Point(148, -1);
            this.Löschen.Margin = new System.Windows.Forms.Padding(2);
            this.Löschen.Name = "Löschen";
            this.Löschen.Size = new System.Drawing.Size(1184, 647);
            this.Löschen.TabIndex = 2;
            this.Löschen.LocationChanged += new System.EventHandler(this.löschpnl_MouseLeave);
            this.Löschen.VisibleChanged += new System.EventHandler(this.löschpnl_MouseLeave);
            // 
            // delbtn
            // 
            this.delbtn.Location = new System.Drawing.Point(316, 303);
            this.delbtn.Margin = new System.Windows.Forms.Padding(2);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(56, 19);
            this.delbtn.TabIndex = 5;
            this.delbtn.Text = "Löschen";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // PinDel
            // 
            this.PinDel.Location = new System.Drawing.Point(275, 252);
            this.PinDel.Margin = new System.Windows.Forms.Padding(2);
            this.PinDel.Name = "PinDel";
            this.PinDel.Size = new System.Drawing.Size(153, 20);
            this.PinDel.TabIndex = 3;
            this.PinDel.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Pin
            // 
            this.Pin.AutoSize = true;
            this.Pin.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin.ForeColor = System.Drawing.Color.White;
            this.Pin.Location = new System.Drawing.Point(200, 252);
            this.Pin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Pin.Name = "Pin";
            this.Pin.Size = new System.Drawing.Size(26, 15);
            this.Pin.TabIndex = 2;
            this.Pin.Text = "Pin";
            // 
            // AutoID
            // 
            this.AutoID.AutoSize = true;
            this.AutoID.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoID.ForeColor = System.Drawing.Color.White;
            this.AutoID.Location = new System.Drawing.Point(200, 213);
            this.AutoID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AutoID.Name = "AutoID";
            this.AutoID.Size = new System.Drawing.Size(48, 15);
            this.AutoID.TabIndex = 1;
            this.AutoID.Text = "AutoID";
            // 
            // AutoIDdel
            // 
            this.AutoIDdel.Location = new System.Drawing.Point(275, 210);
            this.AutoIDdel.Margin = new System.Windows.Forms.Padding(2);
            this.AutoIDdel.Name = "AutoIDdel";
            this.AutoIDdel.Size = new System.Drawing.Size(153, 20);
            this.AutoIDdel.TabIndex = 0;
            this.AutoIDdel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BuchAnl
            // 
            this.BuchAnl.BackColor = System.Drawing.Color.Transparent;
            this.BuchAnl.Controls.Add(this.kundenidbuch);
            this.BuchAnl.Controls.Add(this.label13);
            this.BuchAnl.Controls.Add(this.showcars);
            this.BuchAnl.Controls.Add(this.AutoIDbuch);
            this.BuchAnl.Controls.Add(this.dateTimePicker2);
            this.BuchAnl.Controls.Add(this.dateTimePicker1);
            this.BuchAnl.Controls.Add(this.label4);
            this.BuchAnl.Controls.Add(this.label3);
            this.BuchAnl.Controls.Add(this.label2);
            this.BuchAnl.Location = new System.Drawing.Point(148, -1);
            this.BuchAnl.Margin = new System.Windows.Forms.Padding(2);
            this.BuchAnl.Name = "BuchAnl";
            this.BuchAnl.Size = new System.Drawing.Size(1184, 647);
            this.BuchAnl.TabIndex = 3;
            // 
            // kundenidbuch
            // 
            this.kundenidbuch.Location = new System.Drawing.Point(478, 148);
            this.kundenidbuch.Margin = new System.Windows.Forms.Padding(2);
            this.kundenidbuch.Name = "kundenidbuch";
            this.kundenidbuch.Size = new System.Drawing.Size(185, 20);
            this.kundenidbuch.TabIndex = 12;
            this.kundenidbuch.TextChanged += new System.EventHandler(this.kundenidbuch_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(314, 153);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 15);
            this.label13.TabIndex = 11;
            this.label13.Text = "Kunden ID";
            // 
            // showcars
            // 
            this.showcars.Location = new System.Drawing.Point(478, 338);
            this.showcars.Name = "showcars";
            this.showcars.Size = new System.Drawing.Size(185, 23);
            this.showcars.TabIndex = 10;
            this.showcars.Text = "Verfügbare Autos anzeigen";
            this.showcars.UseVisualStyleBackColor = true;
            this.showcars.Click += new System.EventHandler(this.showcars_Click);
            // 
            // AutoIDbuch
            // 
            this.AutoIDbuch.Location = new System.Drawing.Point(478, 186);
            this.AutoIDbuch.Margin = new System.Windows.Forms.Padding(2);
            this.AutoIDbuch.Name = "AutoIDbuch";
            this.AutoIDbuch.Size = new System.Drawing.Size(185, 20);
            this.AutoIDbuch.TabIndex = 9;
            this.AutoIDbuch.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(478, 289);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(185, 20);
            this.dateTimePicker2.TabIndex = 8;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(478, 240);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(185, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(314, 292);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Letzer Buchungstag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(314, 243);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Erster Buchungstag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(314, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Auto ID";
            // 
            // AutoHinzufügen
            // 
            this.AutoHinzufügen.BackColor = System.Drawing.Color.Transparent;
            this.AutoHinzufügen.Controls.Add(this.AddCarbtn);
            this.AutoHinzufügen.Controls.Add(this.farbeaddcar);
            this.AutoHinzufügen.Controls.Add(this.markeadd);
            this.AutoHinzufügen.Controls.Add(this.modelladd);
            this.AutoHinzufügen.Controls.Add(this.priceadd);
            this.AutoHinzufügen.Controls.Add(this.label12);
            this.AutoHinzufügen.Controls.Add(this.label11);
            this.AutoHinzufügen.Controls.Add(this.label10);
            this.AutoHinzufügen.Controls.Add(this.label9);
            this.AutoHinzufügen.Controls.Add(this.label8);
            this.AutoHinzufügen.Controls.Add(this.anzahlps);
            this.AutoHinzufügen.Location = new System.Drawing.Point(148, -1);
            this.AutoHinzufügen.Margin = new System.Windows.Forms.Padding(2);
            this.AutoHinzufügen.Name = "AutoHinzufügen";
            this.AutoHinzufügen.Size = new System.Drawing.Size(1184, 647);
            this.AutoHinzufügen.TabIndex = 4;
            // 
            // AddCarbtn
            // 
            this.AddCarbtn.Location = new System.Drawing.Point(378, 404);
            this.AddCarbtn.Name = "AddCarbtn";
            this.AddCarbtn.Size = new System.Drawing.Size(75, 23);
            this.AddCarbtn.TabIndex = 12;
            this.AddCarbtn.Text = "Auto hinzufügen";
            this.AddCarbtn.UseVisualStyleBackColor = true;
            this.AddCarbtn.Click += new System.EventHandler(this.AddCarbtn_Click);
            // 
            // farbeaddcar
            // 
            this.farbeaddcar.Location = new System.Drawing.Point(355, 184);
            this.farbeaddcar.Margin = new System.Windows.Forms.Padding(2);
            this.farbeaddcar.Name = "farbeaddcar";
            this.farbeaddcar.Size = new System.Drawing.Size(141, 20);
            this.farbeaddcar.TabIndex = 11;
            this.farbeaddcar.TextChanged += new System.EventHandler(this.farbeaddcar_TextChanged);
            // 
            // markeadd
            // 
            this.markeadd.Location = new System.Drawing.Point(355, 237);
            this.markeadd.Margin = new System.Windows.Forms.Padding(2);
            this.markeadd.Name = "markeadd";
            this.markeadd.Size = new System.Drawing.Size(141, 20);
            this.markeadd.TabIndex = 10;
            this.markeadd.TextChanged += new System.EventHandler(this.markeadd_TextChanged);
            // 
            // modelladd
            // 
            this.modelladd.Location = new System.Drawing.Point(355, 282);
            this.modelladd.Margin = new System.Windows.Forms.Padding(2);
            this.modelladd.Name = "modelladd";
            this.modelladd.Size = new System.Drawing.Size(141, 20);
            this.modelladd.TabIndex = 9;
            this.modelladd.TextChanged += new System.EventHandler(this.modelladd_TextChanged);
            // 
            // priceadd
            // 
            this.priceadd.Location = new System.Drawing.Point(355, 332);
            this.priceadd.Margin = new System.Windows.Forms.Padding(2);
            this.priceadd.Name = "priceadd";
            this.priceadd.Size = new System.Drawing.Size(141, 20);
            this.priceadd.TabIndex = 8;
            this.priceadd.TextChanged += new System.EventHandler(this.priceadd_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(208, 239);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 15);
            this.label12.TabIndex = 7;
            this.label12.Text = "Marke";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(208, 150);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "Anzahl der PS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(208, 190);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "Farbe";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(208, 287);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Modell";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(208, 337);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tagesmietpreis";
            // 
            // anzahlps
            // 
            this.anzahlps.Location = new System.Drawing.Point(355, 145);
            this.anzahlps.Margin = new System.Windows.Forms.Padding(2);
            this.anzahlps.Name = "anzahlps";
            this.anzahlps.Size = new System.Drawing.Size(141, 20);
            this.anzahlps.TabIndex = 1;
            this.anzahlps.TextChanged += new System.EventHandler(this.anzahlps_TextChanged);
            // 
            // abdeckung
            // 
            this.abdeckung.Controls.Add(this.Home);
            this.abdeckung.Location = new System.Drawing.Point(0, 0);
            this.abdeckung.Margin = new System.Windows.Forms.Padding(2);
            this.abdeckung.Name = "abdeckung";
            this.abdeckung.Size = new System.Drawing.Size(1330, 647);
            this.abdeckung.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1330, 645);
            this.Controls.Add(this.abdeckung);
            this.Controls.Add(this.BuchAnl);
            this.Controls.Add(this.KundAnleg);
            this.Controls.Add(this.Löschen);
            this.Controls.Add(this.AutoHinzufügen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            this.KundAnleg.ResumeLayout(false);
            this.KundAnleg.PerformLayout();
            this.Löschen.ResumeLayout(false);
            this.Löschen.PerformLayout();
            this.BuchAnl.ResumeLayout(false);
            this.BuchAnl.PerformLayout();
            this.AutoHinzufügen.ResumeLayout(false);
            this.AutoHinzufügen.PerformLayout();
            this.abdeckung.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Home;
        private System.Windows.Forms.Button buchpnl;
        private System.Windows.Forms.Panel AutoHinzufügen;
        private System.Windows.Forms.Button neuesautopnl;
        private System.Windows.Forms.Panel BuchAnl;
        private System.Windows.Forms.Button löschpnl;
        private System.Windows.Forms.Panel Löschen;
        private System.Windows.Forms.Panel KundAnleg;
        private System.Windows.Forms.TextBox AutoIDdel;
        private System.Windows.Forms.TextBox anzahlps;
        private System.Windows.Forms.TextBox Logo;
        private System.Windows.Forms.Label Pin;
        private System.Windows.Forms.Label AutoID;
        private System.Windows.Forms.TextBox PinDel;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button kundepnl;
        private System.Windows.Forms.Button closeallbtn;
        private System.Windows.Forms.Panel abdeckung;
        private System.Windows.Forms.TextBox AutoIDbuch;
        private System.Windows.Forms.TextBox plzKund;
        private System.Windows.Forms.TextBox adresseKund;
        private System.Windows.Forms.TextBox nachnameKund;
        private System.Windows.Forms.TextBox vornameKund;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Vorname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker bdayKund;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddCarbtn;
        private System.Windows.Forms.TextBox farbeaddcar;
        private System.Windows.Forms.TextBox markeadd;
        private System.Windows.Forms.TextBox modelladd;
        private System.Windows.Forms.TextBox priceadd;
        private System.Windows.Forms.Button showcars;
        private System.Windows.Forms.Button kundadd;
        private System.Windows.Forms.TextBox kundenidbuch;
        private System.Windows.Forms.Label label13;
    }
}

