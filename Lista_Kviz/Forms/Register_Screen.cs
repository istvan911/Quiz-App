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

namespace Lista_Kviz
{
    public partial class Register_Screen : Form
    {
        private readonly Timer _timer;
        Manager.DbManager UjDbManager;
        Adatbazis AB = new Adatbazis();
        public Register_Screen()
        {
            InitializeComponent();    
            _timer = new System.Windows.Forms.Timer();
            _timer.Enabled = false;
            _timer.Interval = 500;
            _timer.Tick += OnStartUpTimer;
        }
        public delegate void ABmentesDelegate(string tablanev);
        public event ABmentesDelegate MentesEsemeny;
        private void iconexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        private void iconmin_Click(object sender, EventArgs e)
        {
            WindowState=FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var list = AB.Felhasznalok.ToList();
            if (txtEmail.Text == "" || txtfelhasznev.Text == "" || txtjelszo.Text == "")
            {
                MessageBox.Show("A regisztrációhoz minden mező kitöltése szükséges!");
            }
            else
            {
                if (list.Count(x => x.Username == txtfelhasznev.Text) != 0)
                {
                    MessageBox.Show("A felhasználónév már foglalt, válasszon másik felhasználónevet!");
                }
                else
                {
                    if (list.Count(x => x.Email == txtEmail.Text) != 0)
                    {
                        MessageBox.Show("Az email cím már foglalt, regisztráljon másik email címmel!");
                    }
                    else
                    {
                        Felhasznalo Ujfelhasznalo = new Felhasznalo();
                        Ujfelhasznalo.Username = txtfelhasznev.Text;
                        Ujfelhasznalo.Password = txtjelszo.Text;
                        Ujfelhasznalo.Email = txtEmail.Text;
                        Ujfelhasznalo.Role = "Vendég";
                        AB.Felhasznalok.Add(Ujfelhasznalo);
                        AB.SaveChanges();

                        MessageBox.Show("Sikeres regisztráció!");

                        LoginForm log = new LoginForm();
                        this.Close();
                        log.Show();
                    }
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

        private void iconmin_MouseLeave(object sender, EventArgs e)
        {
            iconmin.ForeColor = Color.White;
        }

        private void iconmin_MouseMove(object sender, MouseEventArgs e)
        {
            iconmin.ForeColor = Color.GreenYellow;
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
        private void Register_Screen_Load(object sender, EventArgs e)
        {
            Color col = Theme();
            this.BackColor = col;
            txtjelszo.BackColor = col;
            txtEmail.BackColor = col;
            txtfelhasznev.BackColor = col;
            label1.BackColor = col;
            label2.BackColor = col;
            label4.BackColor = col;
            button1.BackColor = col;
            iconmin.BackColor = col;
            iconexit.BackColor = col;
        }
        int mov, movX, movY;
        private void DragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void txtfelhasznev_MouseDown(object sender, MouseEventArgs e)
        {
            if(txtfelhasznev.Text =="Felhasználónév")
            {
                txtfelhasznev.Text = "";
            }
            if(txtjelszo.Text == "")
            {
                txtjelszo.Text = "Jelszó";
            }
            if(txtEmail.Text =="")
            {
                txtEmail.Text = "Email";
            }
        }

        private void txtjelszo_MouseDown(object sender, MouseEventArgs e)
        {
            if(txtjelszo.Text == "Jelszó")
            {
                txtjelszo.Text = "";
            }
            if (txtfelhasznev.Text == "")
            {
                txtfelhasznev.Text = "Felhasználónév";
            }
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
            }
        }

        private void txtEmail_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
            }
            if (txtjelszo.Text == "")
            {
                txtjelszo.Text = "Jelszó";
            }
            if (txtfelhasznev.Text == "")
            {
                txtfelhasznev.Text = "Felhasználónév";
            }
        }

        private void DragPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void DragPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
