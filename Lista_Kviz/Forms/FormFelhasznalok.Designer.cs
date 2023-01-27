namespace Lista_Kviz
{
    partial class FormFelhasznalok
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
            this.DGFelhasznalo = new System.Windows.Forms.DataGridView();
            this.btnTöröl = new System.Windows.Forms.Button();
            this.btnUjhozzaadasa = new System.Windows.Forms.Button();
            this.btnMezotorles = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtfelhasznalonev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtjelszo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.cmbrang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGFelhasznalo)).BeginInit();
            this.SuspendLayout();
            // 
            // DGFelhasznalo
            // 
            this.DGFelhasznalo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGFelhasznalo.Location = new System.Drawing.Point(18, 12);
            this.DGFelhasznalo.Name = "DGFelhasznalo";
            this.DGFelhasznalo.RowHeadersWidth = 51;
            this.DGFelhasznalo.RowTemplate.Height = 29;
            this.DGFelhasznalo.Size = new System.Drawing.Size(1653, 502);
            this.DGFelhasznalo.TabIndex = 15;
            this.DGFelhasznalo.Visible = false;
            // 
            // btnTöröl
            // 
            this.btnTöröl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTöröl.ForeColor = System.Drawing.Color.White;
            this.btnTöröl.Location = new System.Drawing.Point(232, 681);
            this.btnTöröl.Name = "btnTöröl";
            this.btnTöröl.Size = new System.Drawing.Size(208, 57);
            this.btnTöröl.TabIndex = 57;
            this.btnTöröl.Text = "Felhasználó törlése";
            this.btnTöröl.UseVisualStyleBackColor = true;
            this.btnTöröl.Visible = false;
            this.btnTöröl.Click += new System.EventHandler(this.btnTöröl_Click);
            // 
            // btnUjhozzaadasa
            // 
            this.btnUjhozzaadasa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUjhozzaadasa.ForeColor = System.Drawing.Color.White;
            this.btnUjhozzaadasa.Location = new System.Drawing.Point(18, 681);
            this.btnUjhozzaadasa.Name = "btnUjhozzaadasa";
            this.btnUjhozzaadasa.Size = new System.Drawing.Size(208, 57);
            this.btnUjhozzaadasa.TabIndex = 58;
            this.btnUjhozzaadasa.Text = "Új létrehozása";
            this.btnUjhozzaadasa.UseVisualStyleBackColor = true;
            this.btnUjhozzaadasa.Visible = false;
            this.btnUjhozzaadasa.Click += new System.EventHandler(this.btnUjhozzaadasa_Click);
            // 
            // btnMezotorles
            // 
            this.btnMezotorles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMezotorles.ForeColor = System.Drawing.Color.White;
            this.btnMezotorles.Location = new System.Drawing.Point(446, 681);
            this.btnMezotorles.Name = "btnMezotorles";
            this.btnMezotorles.Size = new System.Drawing.Size(208, 57);
            this.btnMezotorles.TabIndex = 59;
            this.btnMezotorles.Text = "Mezők törlése";
            this.btnMezotorles.UseVisualStyleBackColor = true;
            this.btnMezotorles.Visible = false;
            this.btnMezotorles.Click += new System.EventHandler(this.btnMezotorles_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(660, 681);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(208, 57);
            this.button4.TabIndex = 60;
            this.button4.Text = "Adatok beolvasása";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(874, 681);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(208, 57);
            this.button5.TabIndex = 61;
            this.button5.Text = "Adatok beolvasása";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl3.ForeColor = System.Drawing.Color.White;
            this.lbl3.Location = new System.Drawing.Point(38, 563);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(223, 32);
            this.lbl3.TabIndex = 63;
            this.lbl3.Text = "Felhasználónév:";
            this.lbl3.Visible = false;
            // 
            // txtfelhasznalonev
            // 
            this.txtfelhasznalonev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtfelhasznalonev.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtfelhasznalonev.ForeColor = System.Drawing.Color.White;
            this.txtfelhasznalonev.Location = new System.Drawing.Point(267, 557);
            this.txtfelhasznalonev.MaxLength = 32764;
            this.txtfelhasznalonev.Name = "txtfelhasznalonev";
            this.txtfelhasznalonev.Size = new System.Drawing.Size(372, 38);
            this.txtfelhasznalonev.TabIndex = 62;
            this.txtfelhasznalonev.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(669, 620);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 65;
            this.label1.Text = "Rang:";
            this.label1.Visible = false;
            // 
            // txtjelszo
            // 
            this.txtjelszo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtjelszo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtjelszo.ForeColor = System.Drawing.Color.White;
            this.txtjelszo.Location = new System.Drawing.Point(765, 557);
            this.txtjelszo.MaxLength = 32764;
            this.txtjelszo.Name = "txtjelszo";
            this.txtjelszo.Size = new System.Drawing.Size(372, 38);
            this.txtjelszo.TabIndex = 64;
            this.txtjelszo.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(656, 560);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 32);
            this.label2.TabIndex = 65;
            this.label2.Text = "Jelszó:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(167, 620);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 32);
            this.label3.TabIndex = 67;
            this.label3.Text = "Email:";
            this.label3.Visible = false;
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtemail.ForeColor = System.Drawing.Color.White;
            this.txtemail.Location = new System.Drawing.Point(267, 620);
            this.txtemail.MaxLength = 32764;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(372, 38);
            this.txtemail.TabIndex = 66;
            this.txtemail.Visible = false;
            // 
            // cmbrang
            // 
            this.cmbrang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cmbrang.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbrang.ForeColor = System.Drawing.Color.White;
            this.cmbrang.FormattingEnabled = true;
            this.cmbrang.Items.AddRange(new object[] {
            "Admin",
            "Vendég"});
            this.cmbrang.Location = new System.Drawing.Point(765, 616);
            this.cmbrang.Name = "cmbrang";
            this.cmbrang.Size = new System.Drawing.Size(372, 45);
            this.cmbrang.TabIndex = 69;
            this.cmbrang.Text = "Vendég";
            // 
            // FormFelhasznalok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1690, 995);
            this.Controls.Add(this.cmbrang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtjelszo);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txtfelhasznalonev);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnMezotorles);
            this.Controls.Add(this.btnUjhozzaadasa);
            this.Controls.Add(this.btnTöröl);
            this.Controls.Add(this.DGFelhasznalo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFelhasznalok";
            this.Text = "FormFelhasznalok";
            this.Load += new System.EventHandler(this.FormFelhasznalok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGFelhasznalo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGFelhasznalo;
        private System.Windows.Forms.Button btnTöröl;
        private System.Windows.Forms.Button btnUjhozzaadasa;
        private System.Windows.Forms.Button btnMezotorles;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txtfelhasznalonev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtjelszo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.ComboBox cmbrang;
    }
}