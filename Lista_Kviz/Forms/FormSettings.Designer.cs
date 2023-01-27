namespace Lista_Kviz
{
    partial class FormSettings
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
            this.lbl5 = new System.Windows.Forms.Label();
            this.btnValtelvetes = new System.Windows.Forms.Button();
            this.btnAlapertelmezett = new System.Windows.Forms.Button();
            this.lblmodosit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbVOL = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl5.ForeColor = System.Drawing.Color.White;
            this.lbl5.Location = new System.Drawing.Point(12, 41);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(445, 31);
            this.lbl5.TabIndex = 53;
            this.lbl5.Text = "Válasszon módot az alábbiak közül:";
            // 
            // btnValtelvetes
            // 
            this.btnValtelvetes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnValtelvetes.ForeColor = System.Drawing.Color.White;
            this.btnValtelvetes.Location = new System.Drawing.Point(338, 930);
            this.btnValtelvetes.Name = "btnValtelvetes";
            this.btnValtelvetes.Size = new System.Drawing.Size(291, 57);
            this.btnValtelvetes.TabIndex = 67;
            this.btnValtelvetes.Text = "Változtatások elvetése";
            this.btnValtelvetes.UseVisualStyleBackColor = true;
            this.btnValtelvetes.Click += new System.EventHandler(this.btnValtelvetes_Click);
            // 
            // btnAlapertelmezett
            // 
            this.btnAlapertelmezett.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAlapertelmezett.ForeColor = System.Drawing.Color.White;
            this.btnAlapertelmezett.Location = new System.Drawing.Point(635, 930);
            this.btnAlapertelmezett.Name = "btnAlapertelmezett";
            this.btnAlapertelmezett.Size = new System.Drawing.Size(291, 57);
            this.btnAlapertelmezett.TabIndex = 65;
            this.btnAlapertelmezett.Text = "Alapértelmezett";
            this.btnAlapertelmezett.UseVisualStyleBackColor = true;
            this.btnAlapertelmezett.Click += new System.EventHandler(this.btnAlapertelmezett_Click);
            // 
            // lblmodosit
            // 
            this.lblmodosit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblmodosit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblmodosit.ForeColor = System.Drawing.Color.White;
            this.lblmodosit.Location = new System.Drawing.Point(463, 28);
            this.lblmodosit.Name = "lblmodosit";
            this.lblmodosit.Size = new System.Drawing.Size(445, 57);
            this.lblmodosit.TabIndex = 68;
            this.lblmodosit.Text = "Alap mód";
            this.lblmodosit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblmodosit.Click += new System.EventHandler(this.lblmodosit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 31);
            this.label1.TabIndex = 69;
            this.label1.Text = "Jelszó mentésének ki/be kapcsolása:";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(482, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(426, 57);
            this.label2.TabIndex = 70;
            this.label2.Text = "Bekapcsolva";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 31);
            this.label3.TabIndex = 71;
            this.label3.Text = "Hangerő változtatás:";
            // 
            // cmbVOL
            // 
            this.cmbVOL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.cmbVOL.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbVOL.ForeColor = System.Drawing.Color.White;
            this.cmbVOL.FormattingEnabled = true;
            this.cmbVOL.Location = new System.Drawing.Point(283, 163);
            this.cmbVOL.Name = "cmbVOL";
            this.cmbVOL.Size = new System.Drawing.Size(99, 58);
            this.cmbVOL.TabIndex = 72;
            this.cmbVOL.Text = "10";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(1700, 1005);
            this.Controls.Add(this.cmbVOL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblmodosit);
            this.Controls.Add(this.btnValtelvetes);
            this.Controls.Add(this.btnAlapertelmezett);
            this.Controls.Add(this.lbl5);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSettings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.TextChanged += new System.EventHandler(this.FormSettings_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Button btnValtelvetes;
        private System.Windows.Forms.Button btnAlapertelmezett;
        private System.Windows.Forms.Label lblmodosit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbVOL;
    }
}