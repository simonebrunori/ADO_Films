namespace _20171031_Noleggio_Film
{
    partial class frmNoleggioFilm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.noleggiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restituisciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbGenere = new System.Windows.Forms.ComboBox();
            this.dataGridFilm = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpFilm = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNolo = new System.Windows.Forms.TextBox();
            this.dateTimeRest = new System.Windows.Forms.DateTimePicker();
            this.txtRegista = new System.Windows.Forms.TextBox();
            this.txtNazione = new System.Windows.Forms.TextBox();
            this.txtAnno = new System.Windows.Forms.TextBox();
            this.txtGenere1 = new System.Windows.Forms.TextBox();
            this.txtTitolo1 = new System.Windows.Forms.TextBox();
            this.dataGridNoleggi = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFilm)).BeginInit();
            this.grpFilm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNoleggi)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noleggiaToolStripMenuItem,
            this.UserToolStripMenuItem,
            this.restituisciToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(877, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // noleggiaToolStripMenuItem
            // 
            this.noleggiaToolStripMenuItem.Name = "noleggiaToolStripMenuItem";
            this.noleggiaToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.noleggiaToolStripMenuItem.Text = "Noleggia";
            this.noleggiaToolStripMenuItem.Click += new System.EventHandler(this.noleggiaToolStripMenuItem_Click);
            // 
            // UserToolStripMenuItem
            // 
            this.UserToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.UserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.UserToolStripMenuItem.Name = "UserToolStripMenuItem";
            this.UserToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.UserToolStripMenuItem.Text = "USER";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // restituisciToolStripMenuItem
            // 
            this.restituisciToolStripMenuItem.Name = "restituisciToolStripMenuItem";
            this.restituisciToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.restituisciToolStripMenuItem.Text = "Restituisci";
            this.restituisciToolStripMenuItem.Click += new System.EventHandler(this.restituisciToolStripMenuItem_Click);
            // 
            // cmbGenere
            // 
            this.cmbGenere.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGenere.FormattingEnabled = true;
            this.cmbGenere.Location = new System.Drawing.Point(13, 53);
            this.cmbGenere.Name = "cmbGenere";
            this.cmbGenere.Size = new System.Drawing.Size(270, 21);
            this.cmbGenere.TabIndex = 1;
            this.cmbGenere.SelectedIndexChanged += new System.EventHandler(this.cmbGenere_SelectedIndexChanged);
            // 
            // dataGridFilm
            // 
            this.dataGridFilm.AllowUserToAddRows = false;
            this.dataGridFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridFilm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFilm.Location = new System.Drawing.Point(12, 88);
            this.dataGridFilm.Name = "dataGridFilm";
            this.dataGridFilm.Size = new System.Drawing.Size(570, 346);
            this.dataGridFilm.TabIndex = 2;
            this.dataGridFilm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFilm_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Genere";
            // 
            // txtTitolo
            // 
            this.txtTitolo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitolo.Location = new System.Drawing.Point(317, 53);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(265, 20);
            this.txtTitolo.TabIndex = 4;
            this.txtTitolo.TextChanged += new System.EventHandler(this.txtTitolo_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Titolo";
            // 
            // grpFilm
            // 
            this.grpFilm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFilm.Controls.Add(this.label10);
            this.grpFilm.Controls.Add(this.label9);
            this.grpFilm.Controls.Add(this.label8);
            this.grpFilm.Controls.Add(this.label7);
            this.grpFilm.Controls.Add(this.label6);
            this.grpFilm.Controls.Add(this.label5);
            this.grpFilm.Controls.Add(this.label4);
            this.grpFilm.Controls.Add(this.txtNolo);
            this.grpFilm.Controls.Add(this.dateTimeRest);
            this.grpFilm.Controls.Add(this.txtRegista);
            this.grpFilm.Controls.Add(this.txtNazione);
            this.grpFilm.Controls.Add(this.txtAnno);
            this.grpFilm.Controls.Add(this.txtGenere1);
            this.grpFilm.Controls.Add(this.txtTitolo1);
            this.grpFilm.Location = new System.Drawing.Point(589, 88);
            this.grpFilm.Name = "grpFilm";
            this.grpFilm.Size = new System.Drawing.Size(276, 346);
            this.grpFilm.TabIndex = 6;
            this.grpFilm.TabStop = false;
            this.grpFilm.Text = "Film Scelto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Data Restituzione";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Data Nolo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Regista";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nazione";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Anno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Genere";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Titolo";
            // 
            // txtNolo
            // 
            this.txtNolo.Location = new System.Drawing.Point(6, 269);
            this.txtNolo.Name = "txtNolo";
            this.txtNolo.ReadOnly = true;
            this.txtNolo.Size = new System.Drawing.Size(178, 20);
            this.txtNolo.TabIndex = 7;
            // 
            // dateTimeRest
            // 
            this.dateTimeRest.Location = new System.Drawing.Point(6, 320);
            this.dateTimeRest.Name = "dateTimeRest";
            this.dateTimeRest.Size = new System.Drawing.Size(178, 20);
            this.dateTimeRest.TabIndex = 6;
            this.dateTimeRest.ValueChanged += new System.EventHandler(this.dateTimeRest_ValueChanged);
            // 
            // txtRegista
            // 
            this.txtRegista.Location = new System.Drawing.Point(6, 213);
            this.txtRegista.Name = "txtRegista";
            this.txtRegista.ReadOnly = true;
            this.txtRegista.Size = new System.Drawing.Size(264, 20);
            this.txtRegista.TabIndex = 4;
            // 
            // txtNazione
            // 
            this.txtNazione.Location = new System.Drawing.Point(131, 156);
            this.txtNazione.Name = "txtNazione";
            this.txtNazione.ReadOnly = true;
            this.txtNazione.Size = new System.Drawing.Size(139, 20);
            this.txtNazione.TabIndex = 3;
            // 
            // txtAnno
            // 
            this.txtAnno.Location = new System.Drawing.Point(6, 156);
            this.txtAnno.Name = "txtAnno";
            this.txtAnno.ReadOnly = true;
            this.txtAnno.Size = new System.Drawing.Size(84, 20);
            this.txtAnno.TabIndex = 2;
            // 
            // txtGenere1
            // 
            this.txtGenere1.Location = new System.Drawing.Point(6, 102);
            this.txtGenere1.Name = "txtGenere1";
            this.txtGenere1.ReadOnly = true;
            this.txtGenere1.Size = new System.Drawing.Size(264, 20);
            this.txtGenere1.TabIndex = 1;
            // 
            // txtTitolo1
            // 
            this.txtTitolo1.Location = new System.Drawing.Point(6, 46);
            this.txtTitolo1.Name = "txtTitolo1";
            this.txtTitolo1.ReadOnly = true;
            this.txtTitolo1.Size = new System.Drawing.Size(264, 20);
            this.txtTitolo1.TabIndex = 0;
            // 
            // dataGridNoleggi
            // 
            this.dataGridNoleggi.AllowUserToAddRows = false;
            this.dataGridNoleggi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridNoleggi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridNoleggi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNoleggi.Location = new System.Drawing.Point(13, 467);
            this.dataGridNoleggi.Name = "dataGridNoleggi";
            this.dataGridNoleggi.Size = new System.Drawing.Size(852, 234);
            this.dataGridNoleggi.TabIndex = 7;
            this.dataGridNoleggi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridNoleggi_CellClick);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "I miei Noleggi";
            // 
            // frmNoleggioFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 713);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridNoleggi);
            this.Controls.Add(this.grpFilm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitolo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridFilm);
            this.Controls.Add(this.cmbGenere);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmNoleggioFilm";
            this.Text = "Noleggio Film";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmNoleggioFilm_FormClosed);
            this.Load += new System.EventHandler(this.frmNoleggioFilm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFilm)).EndInit();
            this.grpFilm.ResumeLayout(false);
            this.grpFilm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNoleggi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem noleggiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbGenere;
        private System.Windows.Forms.DataGridView dataGridFilm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpFilm;
        private System.Windows.Forms.DataGridView dataGridNoleggi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitolo1;
        private System.Windows.Forms.DateTimePicker dateTimeRest;
        private System.Windows.Forms.TextBox txtRegista;
        private System.Windows.Forms.TextBox txtNazione;
        private System.Windows.Forms.TextBox txtAnno;
        private System.Windows.Forms.TextBox txtGenere1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNolo;
        private System.Windows.Forms.ToolStripMenuItem restituisciToolStripMenuItem;
    }
}