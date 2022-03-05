namespace pelet
{
    partial class Glavna_forma
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glavna_forma));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.meniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podešavanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.izlazIzAplikacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_Podaci = new System.Windows.Forms.GroupBox();
            this.lbl_potrošnja_dan = new System.Windows.Forms.Label();
            this.potrosnja_dan = new System.Windows.Forms.Label();
            this.lbl_potrošnja_sat = new System.Windows.Forms.Label();
            this.potrosnja = new System.Windows.Forms.Label();
            this.lbl_snaga_kW = new System.Windows.Forms.Label();
            this.snaga = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_DateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtbox_BrojSati = new System.Windows.Forms.TextBox();
            this.btn_Izračunaj = new System.Windows.Forms.Button();
            this.lbl_Snaga = new System.Windows.Forms.Label();
            this.lbl_SatiRada = new System.Windows.Forms.Label();
            this.comboBox_Snaga = new System.Windows.Forms.ComboBox();
            this.menuStrip.SuspendLayout();
            this.groupBox_Podaci.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(420, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // meniToolStripMenuItem
            // 
            this.meniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podešavanjaToolStripMenuItem,
            this.toolStripSeparator1,
            this.izlazIzAplikacijeToolStripMenuItem});
            this.meniToolStripMenuItem.Name = "meniToolStripMenuItem";
            this.meniToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.meniToolStripMenuItem.Text = "Meni";
            // 
            // podešavanjaToolStripMenuItem
            // 
            this.podešavanjaToolStripMenuItem.Image = global::pelet.Properties.Resources.MeniPodesavanja;
            this.podešavanjaToolStripMenuItem.Name = "podešavanjaToolStripMenuItem";
            this.podešavanjaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.podešavanjaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.podešavanjaToolStripMenuItem.Text = "Podešavanja";
            this.podešavanjaToolStripMenuItem.ToolTipText = "Podesite parametre";
            this.podešavanjaToolStripMenuItem.Click += new System.EventHandler(this.podešavanjaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // izlazIzAplikacijeToolStripMenuItem
            // 
            this.izlazIzAplikacijeToolStripMenuItem.Image = global::pelet.Properties.Resources.MeniIzlaz;
            this.izlazIzAplikacijeToolStripMenuItem.Name = "izlazIzAplikacijeToolStripMenuItem";
            this.izlazIzAplikacijeToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.izlazIzAplikacijeToolStripMenuItem.Text = "Izlaz iz aplikacije";
            this.izlazIzAplikacijeToolStripMenuItem.Click += new System.EventHandler(this.izlazIzAplikacijeToolStripMenuItem_Click);
            // 
            // groupBox_Podaci
            // 
            this.groupBox_Podaci.Controls.Add(this.lbl_potrošnja_dan);
            this.groupBox_Podaci.Controls.Add(this.potrosnja_dan);
            this.groupBox_Podaci.Controls.Add(this.lbl_potrošnja_sat);
            this.groupBox_Podaci.Controls.Add(this.potrosnja);
            this.groupBox_Podaci.Controls.Add(this.lbl_snaga_kW);
            this.groupBox_Podaci.Controls.Add(this.snaga);
            this.groupBox_Podaci.Location = new System.Drawing.Point(0, 135);
            this.groupBox_Podaci.Name = "groupBox_Podaci";
            this.groupBox_Podaci.Size = new System.Drawing.Size(413, 139);
            this.groupBox_Podaci.TabIndex = 1;
            this.groupBox_Podaci.TabStop = false;
            this.groupBox_Podaci.Text = "Podaci o snazi i potrošnji";
            // 
            // lbl_potrošnja_dan
            // 
            this.lbl_potrošnja_dan.AutoSize = true;
            this.lbl_potrošnja_dan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_potrošnja_dan.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_potrošnja_dan.Location = new System.Drawing.Point(158, 109);
            this.lbl_potrošnja_dan.Name = "lbl_potrošnja_dan";
            this.lbl_potrošnja_dan.Size = new System.Drawing.Size(0, 17);
            this.lbl_potrošnja_dan.TabIndex = 5;
            // 
            // potrosnja_dan
            // 
            this.potrosnja_dan.AutoSize = true;
            this.potrosnja_dan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potrosnja_dan.ForeColor = System.Drawing.Color.DarkRed;
            this.potrosnja_dan.Location = new System.Drawing.Point(6, 109);
            this.potrosnja_dan.Name = "potrosnja_dan";
            this.potrosnja_dan.Size = new System.Drawing.Size(115, 17);
            this.potrosnja_dan.TabIndex = 4;
            this.potrosnja_dan.Text = "Potrošnja kg/dan";
            // 
            // lbl_potrošnja_sat
            // 
            this.lbl_potrošnja_sat.AutoSize = true;
            this.lbl_potrošnja_sat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_potrošnja_sat.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_potrošnja_sat.Location = new System.Drawing.Point(158, 69);
            this.lbl_potrošnja_sat.Name = "lbl_potrošnja_sat";
            this.lbl_potrošnja_sat.Size = new System.Drawing.Size(0, 17);
            this.lbl_potrošnja_sat.TabIndex = 3;
            // 
            // potrosnja
            // 
            this.potrosnja.AutoSize = true;
            this.potrosnja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potrosnja.ForeColor = System.Drawing.Color.DarkRed;
            this.potrosnja.Location = new System.Drawing.Point(22, 69);
            this.potrosnja.Name = "potrosnja";
            this.potrosnja.Size = new System.Drawing.Size(99, 17);
            this.potrosnja.TabIndex = 2;
            this.potrosnja.Text = "Potrošnja kg/h";
            // 
            // lbl_snaga_kW
            // 
            this.lbl_snaga_kW.AutoSize = true;
            this.lbl_snaga_kW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_snaga_kW.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_snaga_kW.Location = new System.Drawing.Point(158, 33);
            this.lbl_snaga_kW.Name = "lbl_snaga_kW";
            this.lbl_snaga_kW.Size = new System.Drawing.Size(0, 17);
            this.lbl_snaga_kW.TabIndex = 1;
            // 
            // snaga
            // 
            this.snaga.AutoSize = true;
            this.snaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snaga.ForeColor = System.Drawing.Color.DarkRed;
            this.snaga.Location = new System.Drawing.Point(36, 33);
            this.snaga.Name = "snaga";
            this.snaga.Size = new System.Drawing.Size(85, 17);
            this.snaga.TabIndex = 0;
            this.snaga.Text = "Snaga kW/h";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_DateTime});
            this.statusStrip.Location = new System.Drawing.Point(0, 277);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(420, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_DateTime
            // 
            this.toolStripStatusLabel_DateTime.Name = "toolStripStatusLabel_DateTime";
            this.toolStripStatusLabel_DateTime.Size = new System.Drawing.Size(90, 17);
            this.toolStripStatusLabel_DateTime.Text = "vrijeme i datum";
            this.toolStripStatusLabel_DateTime.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtbox_BrojSati
            // 
            this.txtbox_BrojSati.Location = new System.Drawing.Point(161, 84);
            this.txtbox_BrojSati.Name = "txtbox_BrojSati";
            this.txtbox_BrojSati.Size = new System.Drawing.Size(100, 20);
            this.txtbox_BrojSati.TabIndex = 4;
            // 
            // btn_Izračunaj
            // 
            this.btn_Izračunaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Izračunaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Izračunaj.Location = new System.Drawing.Point(320, 60);
            this.btn_Izračunaj.Name = "btn_Izračunaj";
            this.btn_Izračunaj.Size = new System.Drawing.Size(93, 44);
            this.btn_Izračunaj.TabIndex = 5;
            this.btn_Izračunaj.Text = "Izračunaj";
            this.btn_Izračunaj.UseVisualStyleBackColor = true;
            this.btn_Izračunaj.Click += new System.EventHandler(this.btn_Izračunaj_Click);
            // 
            // lbl_Snaga
            // 
            this.lbl_Snaga.AutoSize = true;
            this.lbl_Snaga.Location = new System.Drawing.Point(12, 60);
            this.lbl_Snaga.Name = "lbl_Snaga";
            this.lbl_Snaga.Size = new System.Drawing.Size(79, 13);
            this.lbl_Snaga.TabIndex = 6;
            this.lbl_Snaga.Text = "Izaberite snagu";
            // 
            // lbl_SatiRada
            // 
            this.lbl_SatiRada.AutoSize = true;
            this.lbl_SatiRada.Location = new System.Drawing.Point(158, 60);
            this.lbl_SatiRada.Name = "lbl_SatiRada";
            this.lbl_SatiRada.Size = new System.Drawing.Size(104, 13);
            this.lbl_SatiRada.TabIndex = 7;
            this.lbl_SatiRada.Text = "Broj sati rada u danu";
            // 
            // comboBox_Snaga
            // 
            this.comboBox_Snaga.FormattingEnabled = true;
            this.comboBox_Snaga.Items.AddRange(new object[] {
            "P1",
            "P2",
            "P3"});
            this.comboBox_Snaga.Location = new System.Drawing.Point(15, 83);
            this.comboBox_Snaga.Name = "comboBox_Snaga";
            this.comboBox_Snaga.Size = new System.Drawing.Size(83, 21);
            this.comboBox_Snaga.TabIndex = 8;
            this.comboBox_Snaga.SelectedIndexChanged += new System.EventHandler(this.comboBox_Snaga_SelectedIndexChanged);
            // 
            // Glavna_forma
            // 
            this.AcceptButton = this.btn_Izračunaj;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 299);
            this.Controls.Add(this.comboBox_Snaga);
            this.Controls.Add(this.lbl_SatiRada);
            this.Controls.Add(this.lbl_Snaga);
            this.Controls.Add(this.btn_Izračunaj);
            this.Controls.Add(this.txtbox_BrojSati);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox_Podaci);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(436, 338);
            this.Name = "Glavna_forma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proračun potrošnje peleta";
            this.Load += new System.EventHandler(this.Glavna_forma_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox_Podaci.ResumeLayout(false);
            this.groupBox_Podaci.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem meniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem podešavanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem izlazIzAplikacijeToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_Podaci;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtbox_BrojSati;
        private System.Windows.Forms.Button btn_Izračunaj;
        private System.Windows.Forms.Label lbl_Snaga;
        private System.Windows.Forms.Label lbl_SatiRada;
        private System.Windows.Forms.ComboBox comboBox_Snaga;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_DateTime;
        private System.Windows.Forms.Label lbl_potrošnja_dan;
        private System.Windows.Forms.Label potrosnja_dan;
        private System.Windows.Forms.Label lbl_potrošnja_sat;
        private System.Windows.Forms.Label potrosnja;
        private System.Windows.Forms.Label lbl_snaga_kW;
        private System.Windows.Forms.Label snaga;
    }
}

