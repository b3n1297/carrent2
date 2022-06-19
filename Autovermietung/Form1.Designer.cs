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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Vorname = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.Löschen = new System.Windows.Forms.Panel();
            this.delbtn = new System.Windows.Forms.Button();
            this.PinDel = new System.Windows.Forms.TextBox();
            this.Pin = new System.Windows.Forms.Label();
            this.AutoID = new System.Windows.Forms.Label();
            this.AutoIDdel = new System.Windows.Forms.TextBox();
            this.BuchAnl = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kundeanl = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.abdeckung = new System.Windows.Forms.Panel();
            this.Home.SuspendLayout();
            this.KundAnleg.SuspendLayout();
            this.Löschen.SuspendLayout();
            this.BuchAnl.SuspendLayout();
            this.kundeanl.SuspendLayout();
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
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(202, 796);
            this.Home.TabIndex = 0;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.DimGray;
            this.Logo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Logo.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo.Location = new System.Drawing.Point(0, 570);
            this.Logo.Name = "Logo";
            this.Logo.ReadOnly = true;
            this.Logo.Size = new System.Drawing.Size(202, 86);
            this.Logo.TabIndex = 0;
            this.Logo.Text = "ECR";
            // 
            // closeallbtn
            // 
            this.closeallbtn.FlatAppearance.BorderSize = 0;
            this.closeallbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeallbtn.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeallbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeallbtn.Location = new System.Drawing.Point(12, 12);
            this.closeallbtn.Name = "closeallbtn";
            this.closeallbtn.Size = new System.Drawing.Size(75, 32);
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
            this.homebtn.Location = new System.Drawing.Point(3, 106);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(199, 58);
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
            this.kundepnl.Location = new System.Drawing.Point(0, 164);
            this.kundepnl.Name = "kundepnl";
            this.kundepnl.Size = new System.Drawing.Size(199, 58);
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
            this.buchpnl.Location = new System.Drawing.Point(0, 221);
            this.buchpnl.Name = "buchpnl";
            this.buchpnl.Size = new System.Drawing.Size(199, 58);
            this.buchpnl.TabIndex = 8;
            this.buchpnl.Text = "Buchanl";
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
            this.neuesautopnl.Location = new System.Drawing.Point(0, 278);
            this.neuesautopnl.Name = "neuesautopnl";
            this.neuesautopnl.Size = new System.Drawing.Size(199, 58);
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
            this.löschpnl.Location = new System.Drawing.Point(0, 332);
            this.löschpnl.Name = "löschpnl";
            this.löschpnl.Size = new System.Drawing.Size(199, 58);
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
            this.KundAnleg.Controls.Add(this.label1);
            this.KundAnleg.Controls.Add(this.label5);
            this.KundAnleg.Controls.Add(this.label7);
            this.KundAnleg.Controls.Add(this.label6);
            this.KundAnleg.Controls.Add(this.textBox2);
            this.KundAnleg.Controls.Add(this.textBox4);
            this.KundAnleg.Controls.Add(this.Vorname);
            this.KundAnleg.Controls.Add(this.textBox5);
            this.KundAnleg.Controls.Add(this.textBox6);
            this.KundAnleg.Controls.Add(this.dateTimePicker4);
            this.KundAnleg.Location = new System.Drawing.Point(198, -1);
            this.KundAnleg.Name = "KundAnleg";
            this.KundAnleg.Size = new System.Drawing.Size(1578, 796);
            this.KundAnleg.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Postleitzahl";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Adresse";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Nachname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Geburtstag";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Location = new System.Drawing.Point(306, 186);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(243, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox4.Location = new System.Drawing.Point(306, 257);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(243, 22);
            this.textBox4.TabIndex = 6;
            // 
            // Vorname
            // 
            this.Vorname.AutoSize = true;
            this.Vorname.Location = new System.Drawing.Point(206, 189);
            this.Vorname.Name = "Vorname";
            this.Vorname.Size = new System.Drawing.Size(62, 16);
            this.Vorname.TabIndex = 0;
            this.Vorname.Text = "Vorname";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox5.Location = new System.Drawing.Point(306, 373);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(243, 22);
            this.textBox5.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox6.Location = new System.Drawing.Point(306, 431);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(243, 22);
            this.textBox6.TabIndex = 8;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(306, 310);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(245, 22);
            this.dateTimePicker4.TabIndex = 10;
            // 
            // Löschen
            // 
            this.Löschen.BackColor = System.Drawing.Color.Transparent;
            this.Löschen.Controls.Add(this.delbtn);
            this.Löschen.Controls.Add(this.PinDel);
            this.Löschen.Controls.Add(this.Pin);
            this.Löschen.Controls.Add(this.AutoID);
            this.Löschen.Controls.Add(this.AutoIDdel);
            this.Löschen.Location = new System.Drawing.Point(198, -1);
            this.Löschen.Name = "Löschen";
            this.Löschen.Size = new System.Drawing.Size(1578, 796);
            this.Löschen.TabIndex = 2;
            this.Löschen.LocationChanged += new System.EventHandler(this.löschpnl_MouseLeave);
            this.Löschen.VisibleChanged += new System.EventHandler(this.löschpnl_MouseLeave);
            // 
            // delbtn
            // 
            this.delbtn.Location = new System.Drawing.Point(421, 373);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(75, 23);
            this.delbtn.TabIndex = 5;
            this.delbtn.Text = "Löschen";
            this.delbtn.UseVisualStyleBackColor = true;
            // 
            // PinDel
            // 
            this.PinDel.Location = new System.Drawing.Point(367, 310);
            this.PinDel.Name = "PinDel";
            this.PinDel.Size = new System.Drawing.Size(203, 22);
            this.PinDel.TabIndex = 3;
            this.PinDel.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Pin
            // 
            this.Pin.AutoSize = true;
            this.Pin.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin.ForeColor = System.Drawing.Color.White;
            this.Pin.Location = new System.Drawing.Point(267, 310);
            this.Pin.Name = "Pin";
            this.Pin.Size = new System.Drawing.Size(30, 18);
            this.Pin.TabIndex = 2;
            this.Pin.Text = "Pin";
            // 
            // AutoID
            // 
            this.AutoID.AutoSize = true;
            this.AutoID.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoID.ForeColor = System.Drawing.Color.White;
            this.AutoID.Location = new System.Drawing.Point(267, 262);
            this.AutoID.Name = "AutoID";
            this.AutoID.Size = new System.Drawing.Size(57, 18);
            this.AutoID.TabIndex = 1;
            this.AutoID.Text = "AutoID";
            // 
            // AutoIDdel
            // 
            this.AutoIDdel.Location = new System.Drawing.Point(367, 258);
            this.AutoIDdel.Name = "AutoIDdel";
            this.AutoIDdel.Size = new System.Drawing.Size(203, 22);
            this.AutoIDdel.TabIndex = 0;
            this.AutoIDdel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BuchAnl
            // 
            this.BuchAnl.BackColor = System.Drawing.Color.Transparent;
            this.BuchAnl.Controls.Add(this.textBox1);
            this.BuchAnl.Controls.Add(this.dateTimePicker2);
            this.BuchAnl.Controls.Add(this.dateTimePicker1);
            this.BuchAnl.Controls.Add(this.label4);
            this.BuchAnl.Controls.Add(this.label3);
            this.BuchAnl.Controls.Add(this.label2);
            this.BuchAnl.Location = new System.Drawing.Point(198, -1);
            this.BuchAnl.Name = "BuchAnl";
            this.BuchAnl.Size = new System.Drawing.Size(1578, 796);
            this.BuchAnl.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(638, 229);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 22);
            this.textBox1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(638, 356);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(245, 22);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(638, 295);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(245, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(418, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Letzer Buchungstag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(418, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Erster Buchungstag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(418, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "AutoID";
            // 
            // kundeanl
            // 
            this.kundeanl.BackColor = System.Drawing.Color.Transparent;
            this.kundeanl.Controls.Add(this.textBox3);
            this.kundeanl.Location = new System.Drawing.Point(198, -1);
            this.kundeanl.Name = "kundeanl";
            this.kundeanl.Size = new System.Drawing.Size(1578, 796);
            this.kundeanl.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(739, 387);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "Kunde anlegen";
            // 
            // abdeckung
            // 
            this.abdeckung.Location = new System.Drawing.Point(198, -1);
            this.abdeckung.Name = "abdeckung";
            this.abdeckung.Size = new System.Drawing.Size(1570, 796);
            this.abdeckung.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1774, 794);
            this.Controls.Add(this.abdeckung);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.KundAnleg);
            this.Controls.Add(this.BuchAnl);
            this.Controls.Add(this.Löschen);
            this.Controls.Add(this.kundeanl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            this.kundeanl.ResumeLayout(false);
            this.kundeanl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Home;
        private System.Windows.Forms.Button buchpnl;
        private System.Windows.Forms.Panel kundeanl;
        private System.Windows.Forms.Button neuesautopnl;
        private System.Windows.Forms.Panel BuchAnl;
        private System.Windows.Forms.Button löschpnl;
        private System.Windows.Forms.Panel Löschen;
        private System.Windows.Forms.Panel KundAnleg;
        private System.Windows.Forms.TextBox AutoIDdel;
        private System.Windows.Forms.TextBox textBox3;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Vorname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
    }
}

