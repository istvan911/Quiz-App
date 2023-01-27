namespace Lista_Kviz
{
    partial class Register_Screen
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtjelszo = new System.Windows.Forms.TextBox();
            this.txtfelhasznev = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.iconmin = new FontAwesome.Sharp.IconPictureBox();
            this.iconexit = new FontAwesome.Sharp.IconPictureBox();
            this.DragPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.iconmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconexit)).BeginInit();
            this.DragPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(31, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 41);
            this.label2.TabIndex = 12;
            this.label2.Text = "Jelszó:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(31, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 41);
            this.label1.TabIndex = 11;
            this.label1.Text = "Felhasználónév:";
            // 
            // txtjelszo
            // 
            this.txtjelszo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtjelszo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtjelszo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtjelszo.ForeColor = System.Drawing.Color.White;
            this.txtjelszo.Location = new System.Drawing.Point(284, 106);
            this.txtjelszo.Name = "txtjelszo";
            this.txtjelszo.Size = new System.Drawing.Size(400, 47);
            this.txtjelszo.TabIndex = 10;
            this.txtjelszo.Text = "Jelszó";
            this.txtjelszo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtjelszo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtjelszo_MouseDown);
            // 
            // txtfelhasznev
            // 
            this.txtfelhasznev.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtfelhasznev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtfelhasznev.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtfelhasznev.ForeColor = System.Drawing.Color.White;
            this.txtfelhasznev.Location = new System.Drawing.Point(284, 46);
            this.txtfelhasznev.Name = "txtfelhasznev";
            this.txtfelhasznev.Size = new System.Drawing.Size(400, 47);
            this.txtfelhasznev.TabIndex = 9;
            this.txtfelhasznev.Text = "Felhasználónév";
            this.txtfelhasznev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtfelhasznev.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtfelhasznev_MouseDown);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(31, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 41);
            this.label4.TabIndex = 14;
            this.label4.Text = "Email cím:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(284, 167);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(400, 47);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.Text = "Email";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtEmail_MouseDown);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(284, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 85);
            this.button1.TabIndex = 16;
            this.button1.Text = "Regisztrálás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iconmin
            // 
            this.iconmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.iconmin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconmin.IconColor = System.Drawing.Color.White;
            this.iconmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconmin.IconSize = 40;
            this.iconmin.Location = new System.Drawing.Point(601, 0);
            this.iconmin.Name = "iconmin";
            this.iconmin.Size = new System.Drawing.Size(40, 40);
            this.iconmin.TabIndex = 18;
            this.iconmin.TabStop = false;
            this.iconmin.Click += new System.EventHandler(this.iconmin_Click);
            this.iconmin.MouseLeave += new System.EventHandler(this.iconmin_MouseLeave);
            this.iconmin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.iconmin_MouseMove);
            // 
            // iconexit
            // 
            this.iconexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.iconexit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconexit.IconColor = System.Drawing.Color.White;
            this.iconexit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconexit.IconSize = 40;
            this.iconexit.Location = new System.Drawing.Point(644, 0);
            this.iconexit.Name = "iconexit";
            this.iconexit.Size = new System.Drawing.Size(40, 40);
            this.iconexit.TabIndex = 17;
            this.iconexit.TabStop = false;
            this.iconexit.Click += new System.EventHandler(this.iconexit_Click);
            this.iconexit.MouseLeave += new System.EventHandler(this.iconexit_MouseLeave);
            this.iconexit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.iconexit_MouseMove);
            // 
            // DragPanel
            // 
            this.DragPanel.Controls.Add(this.iconexit);
            this.DragPanel.Controls.Add(this.iconmin);
            this.DragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DragPanel.Location = new System.Drawing.Point(0, 0);
            this.DragPanel.Name = "DragPanel";
            this.DragPanel.Size = new System.Drawing.Size(701, 40);
            this.DragPanel.TabIndex = 19;
            this.DragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.DragPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            this.DragPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseUp);
            // 
            // Register_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(701, 336);
            this.Controls.Add(this.DragPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtjelszo);
            this.Controls.Add(this.txtfelhasznev);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regisztráció";
            this.Load += new System.EventHandler(this.Register_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconexit)).EndInit();
            this.DragPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtjelszo;
        private System.Windows.Forms.TextBox txtfelhasznev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button button1;
        private FontAwesome.Sharp.IconPictureBox iconmin;
        private FontAwesome.Sharp.IconPictureBox iconexit;
        private System.Windows.Forms.Panel DragPanel;
    }
}