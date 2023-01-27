namespace Lista_Kviz
{
    partial class FormTemakorszerkeszto
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
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txttemakor = new System.Windows.Forms.TextBox();
            this.cmbTantargy = new System.Windows.Forms.ComboBox();
            this.btnSzerkeszt = new System.Windows.Forms.Button();
            this.btnMezoktorlese = new System.Windows.Forms.Button();
            this.btnAdatokbeolvasasa = new System.Windows.Forms.Button();
            this.btnTorles = new System.Windows.Forms.Button();
            this.btnListahozAdas = new System.Windows.Forms.Button();
            this.cmbSzerk = new System.Windows.Forms.ComboBox();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.txtszerk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DTGTemakor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DTGTemakor)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl3.ForeColor = System.Drawing.Color.White;
            this.lbl3.Location = new System.Drawing.Point(1109, 412);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(134, 32);
            this.lbl3.TabIndex = 66;
            this.lbl3.Text = "Tantárgy:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(20, 412);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(133, 32);
            this.lbl1.TabIndex = 65;
            this.lbl1.Text = "Témakör:";
            // 
            // txttemakor
            // 
            this.txttemakor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txttemakor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txttemakor.ForeColor = System.Drawing.Color.White;
            this.txttemakor.Location = new System.Drawing.Point(159, 409);
            this.txttemakor.MaxLength = 32764;
            this.txttemakor.Name = "txttemakor";
            this.txttemakor.Size = new System.Drawing.Size(944, 38);
            this.txttemakor.TabIndex = 63;
            // 
            // cmbTantargy
            // 
            this.cmbTantargy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cmbTantargy.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTantargy.ForeColor = System.Drawing.Color.White;
            this.cmbTantargy.FormattingEnabled = true;
            this.cmbTantargy.Items.AddRange(new object[] {
            "történelem",
            "matematika",
            "irodalom",
            "nyelvtan",
            "angol",
            "német"});
            this.cmbTantargy.Location = new System.Drawing.Point(1249, 405);
            this.cmbTantargy.Name = "cmbTantargy";
            this.cmbTantargy.Size = new System.Drawing.Size(429, 45);
            this.cmbTantargy.TabIndex = 67;
            this.cmbTantargy.Text = "Történelem";
            this.cmbTantargy.SelectedIndexChanged += new System.EventHandler(this.cmbTantargy_SelectedIndexChanged);
            // 
            // btnSzerkeszt
            // 
            this.btnSzerkeszt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSzerkeszt.ForeColor = System.Drawing.Color.White;
            this.btnSzerkeszt.Location = new System.Drawing.Point(20, 568);
            this.btnSzerkeszt.Name = "btnSzerkeszt";
            this.btnSzerkeszt.Size = new System.Drawing.Size(208, 57);
            this.btnSzerkeszt.TabIndex = 72;
            this.btnSzerkeszt.Text = "Szerkesztés";
            this.btnSzerkeszt.UseVisualStyleBackColor = true;
            this.btnSzerkeszt.Click += new System.EventHandler(this.btnSzerkeszt_Click);
            // 
            // btnMezoktorlese
            // 
            this.btnMezoktorlese.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMezoktorlese.ForeColor = System.Drawing.Color.White;
            this.btnMezoktorlese.Location = new System.Drawing.Point(263, 568);
            this.btnMezoktorlese.Name = "btnMezoktorlese";
            this.btnMezoktorlese.Size = new System.Drawing.Size(208, 57);
            this.btnMezoktorlese.TabIndex = 71;
            this.btnMezoktorlese.Text = "Mezők törlése";
            this.btnMezoktorlese.UseVisualStyleBackColor = true;
            this.btnMezoktorlese.Click += new System.EventHandler(this.btnMezoktorlese_Click);
            // 
            // btnAdatokbeolvasasa
            // 
            this.btnAdatokbeolvasasa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdatokbeolvasasa.ForeColor = System.Drawing.Color.White;
            this.btnAdatokbeolvasasa.Location = new System.Drawing.Point(758, 631);
            this.btnAdatokbeolvasasa.Name = "btnAdatokbeolvasasa";
            this.btnAdatokbeolvasasa.Size = new System.Drawing.Size(208, 57);
            this.btnAdatokbeolvasasa.TabIndex = 70;
            this.btnAdatokbeolvasasa.Text = "Adatok beolvasása";
            this.btnAdatokbeolvasasa.UseVisualStyleBackColor = true;
            this.btnAdatokbeolvasasa.Visible = false;
            this.btnAdatokbeolvasasa.Click += new System.EventHandler(this.btnAdatokbeolvasasa_Click);
            // 
            // btnTorles
            // 
            this.btnTorles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTorles.ForeColor = System.Drawing.Color.White;
            this.btnTorles.Location = new System.Drawing.Point(504, 568);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(208, 57);
            this.btnTorles.TabIndex = 69;
            this.btnTorles.Text = "Törlés";
            this.btnTorles.UseVisualStyleBackColor = true;
            this.btnTorles.Visible = false;
            this.btnTorles.Click += new System.EventHandler(this.btnTorles_Click);
            // 
            // btnListahozAdas
            // 
            this.btnListahozAdas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnListahozAdas.ForeColor = System.Drawing.Color.White;
            this.btnListahozAdas.Location = new System.Drawing.Point(20, 568);
            this.btnListahozAdas.Name = "btnListahozAdas";
            this.btnListahozAdas.Size = new System.Drawing.Size(208, 57);
            this.btnListahozAdas.TabIndex = 73;
            this.btnListahozAdas.Text = "Listához adás";
            this.btnListahozAdas.UseVisualStyleBackColor = true;
            this.btnListahozAdas.Click += new System.EventHandler(this.btnListahozAdas_Click);
            // 
            // cmbSzerk
            // 
            this.cmbSzerk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cmbSzerk.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbSzerk.ForeColor = System.Drawing.Color.White;
            this.cmbSzerk.FormattingEnabled = true;
            this.cmbSzerk.Location = new System.Drawing.Point(159, 405);
            this.cmbSzerk.Name = "cmbSzerk";
            this.cmbSzerk.Size = new System.Drawing.Size(944, 45);
            this.cmbSzerk.TabIndex = 74;
            // 
            // cmb
            // 
            this.cmb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cmb.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb.ForeColor = System.Drawing.Color.White;
            this.cmb.FormattingEnabled = true;
            this.cmb.Items.AddRange(new object[] {
            "Szerkesztés",
            "Új hozzáadása"});
            this.cmb.Location = new System.Drawing.Point(1111, 484);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(567, 45);
            this.cmb.TabIndex = 75;
            this.cmb.Text = "Új hozzáadása";
            this.cmb.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectedIndexChanged);
            // 
            // txtszerk
            // 
            this.txtszerk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtszerk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtszerk.ForeColor = System.Drawing.Color.White;
            this.txtszerk.Location = new System.Drawing.Point(202, 488);
            this.txtszerk.MaxLength = 32764;
            this.txtszerk.Name = "txtszerk";
            this.txtszerk.Size = new System.Drawing.Size(901, 38);
            this.txtszerk.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 77;
            this.label1.Text = "Szerkesztés:";
            // 
            // DTGTemakor
            // 
            this.DTGTemakor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGTemakor.Location = new System.Drawing.Point(20, 12);
            this.DTGTemakor.Name = "DTGTemakor";
            this.DTGTemakor.RowHeadersWidth = 51;
            this.DTGTemakor.RowTemplate.Height = 29;
            this.DTGTemakor.Size = new System.Drawing.Size(1658, 360);
            this.DTGTemakor.TabIndex = 78;
            // 
            // FormTemakorszerkeszto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1690, 995);
            this.Controls.Add(this.DTGTemakor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtszerk);
            this.Controls.Add(this.cmb);
            this.Controls.Add(this.cmbSzerk);
            this.Controls.Add(this.btnSzerkeszt);
            this.Controls.Add(this.btnMezoktorlese);
            this.Controls.Add(this.btnAdatokbeolvasasa);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.cmbTantargy);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txttemakor);
            this.Controls.Add(this.btnListahozAdas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTemakorszerkeszto";
            this.Text = "FormTemakorszerkeszto";
            this.Load += new System.EventHandler(this.FormTemakorszerkeszto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGTemakor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txttemakor;
        private System.Windows.Forms.ComboBox cmbTantargy;
        private System.Windows.Forms.Button btnSzerkeszt;
        private System.Windows.Forms.Button btnMezoktorlese;
        private System.Windows.Forms.Button btnAdatokbeolvasasa;
        private System.Windows.Forms.Button btnTorles;
        private System.Windows.Forms.Button btnListahozAdas;
        private System.Windows.Forms.ComboBox cmbSzerk;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.TextBox txtszerk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DTGTemakor;
    }
}