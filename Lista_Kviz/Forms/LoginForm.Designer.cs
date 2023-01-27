namespace Lista_Kviz
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtfelhasznev = new System.Windows.Forms.TextBox();
            this.txtjelszo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.iconexit = new FontAwesome.Sharp.IconPictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.adatcheck = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconShow = new FontAwesome.Sharp.IconPictureBox();
            this.iconHide = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconexit)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHide)).BeginInit();
            this.SuspendLayout();
            // 
            // txtfelhasznev
            // 
            this.txtfelhasznev.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtfelhasznev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtfelhasznev.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtfelhasznev.ForeColor = System.Drawing.Color.White;
            this.txtfelhasznev.Location = new System.Drawing.Point(53, 209);
            this.txtfelhasznev.Name = "txtfelhasznev";
            this.txtfelhasznev.Size = new System.Drawing.Size(400, 47);
            this.txtfelhasznev.TabIndex = 0;
            this.txtfelhasznev.Text = "Felhasználónév";
            this.txtfelhasznev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtfelhasznev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfelhasznev_KeyPress);
            this.txtfelhasznev.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtfelhasznev_MouseDown);
            // 
            // txtjelszo
            // 
            this.txtjelszo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtjelszo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtjelszo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtjelszo.ForeColor = System.Drawing.Color.White;
            this.txtjelszo.Location = new System.Drawing.Point(53, 313);
            this.txtjelszo.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.txtjelszo.Name = "txtjelszo";
            this.txtjelszo.Size = new System.Drawing.Size(353, 47);
            this.txtjelszo.TabIndex = 1;
            this.txtjelszo.Text = "Jelszó";
            this.txtjelszo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtjelszo.UseSystemPasswordChar = true;
            this.txtjelszo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtjelszo_KeyPress);
            this.txtjelszo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtjelszo_MouseDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(53, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Felhasználónév";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(53, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jelszó";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(135, 504);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nincs még felhasználói fiókod?";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(160, 524);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Regisztrálj egyet most!";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cmbRole
            // 
            this.cmbRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cmbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRole.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbRole.ForeColor = System.Drawing.Color.White;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "Vendég"});
            this.cmbRole.Location = new System.Drawing.Point(240, 104);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(211, 39);
            this.cmbRole.TabIndex = 11;
            this.cmbRole.Text = "Vendég";
            this.cmbRole.SelectedIndexChanged += new System.EventHandler(this.cmbRole_SelectedIndexChanged);
            // 
            // iconexit
            // 
            this.iconexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.iconexit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconexit.IconColor = System.Drawing.Color.White;
            this.iconexit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconexit.IconSize = 40;
            this.iconexit.Location = new System.Drawing.Point(462, 1);
            this.iconexit.Name = "iconexit";
            this.iconexit.Size = new System.Drawing.Size(40, 40);
            this.iconexit.TabIndex = 12;
            this.iconexit.TabStop = false;
            this.iconexit.Click += new System.EventHandler(this.iconexit_Click);
            this.iconexit.MouseLeave += new System.EventHandler(this.iconexit_MouseLeave);
            this.iconexit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.iconexit_MouseMove);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(93, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(318, 62);
            this.button1.TabIndex = 15;
            this.button1.Tag = "1";
            this.button1.Text = "Bejelentkezés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(151, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 41);
            this.label3.TabIndex = 16;
            this.label3.Text = "Jelentkezz be!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(281, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Adatok megjegyzése";
            // 
            // adatcheck
            // 
            this.adatcheck.AutoSize = true;
            this.adatcheck.Location = new System.Drawing.Point(435, 389);
            this.adatcheck.Name = "adatcheck";
            this.adatcheck.Size = new System.Drawing.Size(18, 17);
            this.adatcheck.TabIndex = 17;
            this.adatcheck.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconexit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 40);
            this.panel1.TabIndex = 19;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // iconShow
            // 
            this.iconShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconShow.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconShow.IconColor = System.Drawing.Color.White;
            this.iconShow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconShow.IconSize = 43;
            this.iconShow.Location = new System.Drawing.Point(408, 315);
            this.iconShow.Name = "iconShow";
            this.iconShow.Size = new System.Drawing.Size(43, 43);
            this.iconShow.TabIndex = 20;
            this.iconShow.TabStop = false;
            this.iconShow.Click += new System.EventHandler(this.iconShow_Click);
            // 
            // iconHide
            // 
            this.iconHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconHide.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.iconHide.IconColor = System.Drawing.Color.White;
            this.iconHide.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconHide.IconSize = 43;
            this.iconHide.Location = new System.Drawing.Point(408, 317);
            this.iconHide.Name = "iconHide";
            this.iconHide.Size = new System.Drawing.Size(43, 43);
            this.iconHide.TabIndex = 21;
            this.iconHide.TabStop = false;
            this.iconHide.Click += new System.EventHandler(this.iconHide_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.iconHide);
            this.Controls.Add(this.iconShow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adatcheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtjelszo);
            this.Controls.Add(this.txtfelhasznev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconexit)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfelhasznev;
        private System.Windows.Forms.TextBox txtjelszo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbRole;
        private FontAwesome.Sharp.IconPictureBox iconexit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox adatcheck;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconShow;
        private FontAwesome.Sharp.IconPictureBox iconHide;
    }
}
