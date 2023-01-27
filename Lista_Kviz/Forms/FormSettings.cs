using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lista_Kviz
{
    public partial class FormSettings : Form
    {
        private string username="", password="", role="", themecolor="";
        private double volume = 0, changedvolume = 0;
        private readonly Timer _timer;
        public FormSettings()
        {
            InitializeComponent();
            _timer = new System.Windows.Forms.Timer();
            _timer.Enabled = false;
            _timer.Interval = 500;
            _timer.Tick += OnStartUpTimer;

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
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle = 0x02000000;
                return handleparam;
            }
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

        private void FormSettings_Load(object sender, EventArgs e)
        {
            
            cmbVOL.Items.Clear();
            for (int i = 0; i < 101; i++)
            {
                cmbVOL.Items.Add(i);
            }
            cmbVOL.Text = (Properties.UserSettings.Default.volume * 100).ToString();
            username = Properties.UserSettings.Default.Username;
            password = Properties.UserSettings.Default.Password;
            role = Properties.UserSettings.Default.Role;
            themecolor = Properties.UserSettings.Default.ThemeColor;
            volume = Properties.UserSettings.Default.volume;
            Color col = Theme();

            Properties.UserSettings.Default.Valtozas = false;
            Properties.UserSettings.Default.Save();

            this.BackColor = col;
            lblmodosit.BackColor = col;
            lbl5.BackColor = col;

            if (Properties.UserSettings.Default.ThemeColor == "Alap mód")
            {
                lblmodosit.Text = "Alap mód";
            }
            else
            {
                lblmodosit.Text = "Sötét mód";
            }
        }

        private void FormSettings_TextChanged(object sender, EventArgs e)
        {
            changedvolume = Convert.ToDouble(cmbVOL.Text) / 100;
            Properties.UserSettings.Default.volume = changedvolume;
            Properties.UserSettings.Default.Valtozas = false;
            Properties.UserSettings.Default.Save();

        }

        private void btnValtelvetes_Click(object sender, EventArgs e)
        {
            Properties.UserSettings.Default.Username = username;
            Properties.UserSettings.Default.Password = password;
            Properties.UserSettings.Default.Role = role;
            Properties.UserSettings.Default.ThemeColor = themecolor;
            Properties.UserSettings.Default.Valtozas = false;
            Properties.UserSettings.Default.volume = volume;
            Properties.UserSettings.Default.Save();
        }

        private void btnAlapertelmezett_Click(object sender, EventArgs e)
        {
            Properties.UserSettings.Default.Username = "Felhasználónév";
            Properties.UserSettings.Default.Password = "Jelszó";
            Properties.UserSettings.Default.Role = "Vendég";
            Properties.UserSettings.Default.ThemeColor = "Alap mód";
            Properties.UserSettings.Default.Valtozas = true;
            Properties.UserSettings.Default.volume = 0.1;
            Properties.UserSettings.Default.Save();
        }
        private void lblmodosit_Click(object sender, EventArgs e)
        {
            if (lblmodosit.Text == "Sötét mód")
            {
                lblmodosit.Text = "Alap mód";
                Properties.UserSettings.Default.ThemeColor = lblmodosit.Text;
            }
            else
            {
                lblmodosit.Text = "Sötét mód";
                Properties.UserSettings.Default.ThemeColor = lblmodosit.Text;
            }
            if (Properties.UserSettings.Default.ThemeColor != themecolor || Properties.UserSettings.Default.Username != username)
            {
                Properties.UserSettings.Default.Valtozas = true;
            }
            else
            {
                Properties.UserSettings.Default.Valtozas = false;
            }
            Properties.UserSettings.Default.Save();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Bekapcsolva")
            {
                label2.Text = "Kikapcsolva";
                Properties.UserSettings.Default.Username = "empty";
                Properties.UserSettings.Default.Password = "empty";
                Properties.UserSettings.Default.Role = "empty";
            }
            else
            {
                label2.Text = "Bekapcsolva";
                Properties.UserSettings.Default.Username = username;
                Properties.UserSettings.Default.Password = password;
                Properties.UserSettings.Default.Role = role;
            }
            if (username != Properties.UserSettings.Default.Username || themecolor != Properties.UserSettings.Default.ThemeColor)
            {
                Properties.UserSettings.Default.Valtozas = true;
            }
            else
            {
                Properties.UserSettings.Default.Valtozas = false;

            }
            Properties.UserSettings.Default.Save();
        }
    }

   
}
