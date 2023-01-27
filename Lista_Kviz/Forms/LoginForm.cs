using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Diagnostics;
using System.IO;

namespace Lista_Kviz
{
    public partial class LoginForm : Form
    {
        System.Windows.Media.MediaPlayer player = new System.Windows.Media.MediaPlayer();
        private readonly Timer _timer;
        Manager.DbManager UjDbManager;
        Adatbazis AB = new Adatbazis();
        int mov, movX, movY;
        public LoginForm()
        {
            InitializeComponent();
            _timer = new System.Windows.Forms.Timer();
            _timer.Enabled = false;
            _timer.Interval = 500;
            _timer.Tick += OnStartUpTimer;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle = 0x02000000;
                return handleparam;
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);


            _timer.Start();

        }
        private void OnStartUpTimer(object sender, EventArgs e)
        {
            _timer.Stop();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            Register_Screen log = new Register_Screen();
            this.Hide();
            log.Show();
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Enter)
            {
                button1.PerformClick();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
        private Color Theme()
        {
            Color Theme;
            if (Properties.UserSettings.Default.ThemeColor == "Alap mód")
            {
                Theme = Color.FromArgb(31, 30, 78);
            }
            else
            {
                Theme = Color.FromArgb(40, 40, 40);
            }
            return Theme;
        }
        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbRole.Text == "Admin")
                {
                    string message = "Vendég ranggal felhasználónév és jelszó nélkül is használhatja a programot.";
                    new ToolTip().Show(message, this, Cursor.Position.X - MousePosition.X, Cursor.Position.Y - MousePosition.Y, 3000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void Beir()
        {
            txtfelhasznev.Text = Properties.UserSettings.Default.Username;
            txtjelszo.Text = Properties.UserSettings.Default.Password;
            cmbRole.Text = Properties.UserSettings.Default.Role;
        }

        public void Save()
        {
            Properties.UserSettings.Default.Username = txtfelhasznev.Text;
            Properties.UserSettings.Default.Password = txtjelszo.Text;
            Properties.UserSettings.Default.Role = cmbRole.Text;
            Properties.UserSettings.Default.Save();
        }
        private void iconexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {          
            try
            {
                var list = AB.Felhasznalok.ToList();
                if (txtfelhasznev.Text == "" || txtjelszo.Text == "")
                {
                    MessageBox.Show("A bejelentkezéshez nem hagyhat üresen egy mezőt sem!");
                }
                else
                {
                    if (txtfelhasznev.Text=="Felhasználónév" && txtjelszo.Text=="Jelszó" && cmbRole.Text=="Vendég")
                    {
                        player.Stop();
                        Properties.UserSettings.Default.jelfelhasz = cmbRole.Text;
                        Properties.UserSettings.Default.nezet = "Vendég";
                        Properties.UserSettings.Default.Save();
                        FormLoading_Screen FL = new FormLoading_Screen();
                        this.Hide();
                        FL.Show();
                    }
                    else
                    {
                        int van = list.Count(x => x.Username == txtfelhasznev.Text && x.Password == txtjelszo.Text && x.Role == cmbRole.Text);
                        if (van == 1 && cmbRole.Text == "Admin")
                        {
                            
                            if (adatcheck.Checked && txtfelhasznev.Text != "Felhasználónév" || txtjelszo.Text != "Jelszó")
                            {
                                Save();
                            }
                            else
                            {
                                Properties.UserSettings.Default.Username = "empty";
                            }
                            DialogResult dialogResult = MessageBox.Show("Admin nézetbe szeretne lépni?", "Visszajelzés kérése", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                player.Stop();
                                Properties.UserSettings.Default.jelfelhasz = cmbRole.Text;
                                Properties.UserSettings.Default.nezet = "Admin";
                                Properties.UserSettings.Default.Save();
                                FormLoading_Screen FL = new FormLoading_Screen();
                                this.Hide();
                                FL.Show();
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                player.Stop();
                                Properties.UserSettings.Default.jelfelhasz = cmbRole.Text;
                                Properties.UserSettings.Default.nezet = "Vendég";
                                Properties.UserSettings.Default.Save();
                                FormLoading_Screen FL = new FormLoading_Screen();
                                this.Hide();
                                FL.Show();
                            }
                        }
                        else if (van == 1 && cmbRole.Text == "Vendég")
                        {
                            player.Stop();
                            Properties.UserSettings.Default.jelfelhasz = cmbRole.Text;

                            if (adatcheck.Checked)
                            {
                                Save();
                            }
                            else
                            {
                                Properties.UserSettings.Default.Username = "empty";
                                Properties.UserSettings.Default.Password = "empty";
                                Properties.UserSettings.Default.Role = "empty";
                            }
                            Properties.UserSettings.Default.Save();

                            FormLoading_Screen FL = new FormLoading_Screen();
                            this.Hide();
                            FL.Show();

                        }
                        else
                        {
                            MessageBox.Show("Hibás felhasználónév vagy jelszó!");

                        }
                    }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Register_Screen log = new Register_Screen();
            this.Hide();
            log.Show();
        }
        private void txtjelszo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!txtjelszo.AcceptsReturn)
                {
                    button1.PerformClick();
                }
            }
        }
        private void txtfelhasznev_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!txtfelhasznev.AcceptsReturn)
                {
                    button1.PerformClick();
                }
            }
        }

        private void iconexit_MouseLeave(object sender, EventArgs e)
        {
            iconexit.ForeColor = Color.White;
        }

        private void iconexit_MouseMove(object sender, MouseEventArgs e)
        {
            iconexit.ForeColor = Color.Red;
        }
        private bool md = false;
        private void txtfelhasznev_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtfelhasznev.Text == "Felhasználónév")
            {
                txtfelhasznev.Text = "";
            }
            if (txtjelszo.Text == "")
            {
                txtjelszo.Text = "Jelszó";
            }
            md = true;
        }
        private void txtjelszo_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtjelszo.Text == "Jelszó")
            {
                txtjelszo.Text = "";
            }
            if (txtfelhasznev.Text == "")
            {
                txtfelhasznev.Text = "Felhasználónév";
            }
            md = false;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            player.Volume = Properties.UserSettings.Default.volume;
            string direct = Directory.GetCurrentDirectory() + "\\music.mp4";
            player.Open(new Uri(direct));
            player.Play();
            iconShow.BringToFront();
            if (Properties.UserSettings.Default.Username != "" || Properties.UserSettings.Default.Username != "empty")
            {
                Beir();
                adatcheck.Checked = true;
            }
                Color col = Theme();
                label6.BackColor = col;
                label5.BackColor = col;
                label1.BackColor = col;
                label2.BackColor = col;
                label3.BackColor = col;
                label4.BackColor = col;
                txtfelhasznev.BackColor = col;
                txtjelszo.BackColor = col;
                button1.BackColor = col;
                cmbRole.BackColor = col;
                this.BackColor=col;
                iconexit.BackColor = col;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void iconHide_Click(object sender, EventArgs e)
        {
            txtjelszo.UseSystemPasswordChar = true;
            iconShow.BringToFront();
        }

        private void iconShow_Click(object sender, EventArgs e)
        {
            txtjelszo.UseSystemPasswordChar = false;
            iconHide.BringToFront();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}

