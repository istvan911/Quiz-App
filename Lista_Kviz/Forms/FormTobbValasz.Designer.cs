namespace Lista_Kviz
{
    partial class FormTobbValasz
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PanelValaszok = new System.Windows.Forms.Panel();
            this.LVValasz = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.PanelValaszok.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.PanelValaszok);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(50, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1600, 880);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(1100, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(500, 880);
            this.panel6.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(1050, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(50, 880);
            this.panel5.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(550, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 880);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(500, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(50, 880);
            this.panel4.TabIndex = 2;
            // 
            // PanelValaszok
            // 
            this.PanelValaszok.Controls.Add(this.LVValasz);
            this.PanelValaszok.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelValaszok.Location = new System.Drawing.Point(0, 0);
            this.PanelValaszok.Name = "PanelValaszok";
            this.PanelValaszok.Size = new System.Drawing.Size(500, 880);
            this.PanelValaszok.TabIndex = 0;
            this.PanelValaszok.Tag = "1";
            // 
            // LVValasz
            // 
            this.LVValasz.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.LVValasz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LVValasz.ForeColor = System.Drawing.Color.White;
            this.LVValasz.HideSelection = false;
            this.LVValasz.Location = new System.Drawing.Point(0, 0);
            this.LVValasz.Name = "LVValasz";
            this.LVValasz.Size = new System.Drawing.Size(500, 880);
            this.LVValasz.TabIndex = 0;
            this.LVValasz.UseCompatibleStateImageBehavior = false;
            // 
            // FormTobbValasz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(1700, 1005);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTobbValasz";
            this.Padding = new System.Windows.Forms.Padding(50, 50, 50, 75);
            this.Text = "FormTobbValasz";
            this.panel1.ResumeLayout(false);
            this.PanelValaszok.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel PanelValaszok;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView LVValasz;
    }
}