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
using System.Threading;

namespace Lista_Kviz
{
    public partial class FormFelhasznalok : Form
    {
        private readonly System.Windows.Forms.Timer _timer;
        Manager.DbManager UjDbManager;
        Adatbazis AB = new Adatbazis();
        public FormFelhasznalok()
        {
            InitializeComponent();
            _timer = new System.Windows.Forms.Timer();
            _timer.Enabled = false;
            _timer.Interval = 1000;
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
        public delegate void ABmentesDelegate(string tablanev);
        public event ABmentesDelegate MentesEsemeny;
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
        private void FormFelhasznalok_Load(object sender, EventArgs e)
        {
            
            DGFelhasznalo.ReadOnly = false;
            DGFelhasznalo.DataSource = AB.Felhasznalok.ToList();
            DGFelhasznalo.Columns[0].HeaderText = "ID";
            DGFelhasznalo.Columns[1].HeaderText = "Felhasználónév";
            DGFelhasznalo.Columns[2].HeaderText = "Jelszó";
            DGFelhasznalo.Columns[3].HeaderText = "Email";
            DGFelhasznalo.Columns[4].HeaderText = "Rang";

            DGFelhasznalo.Columns[0].Width = 40;
            DGFelhasznalo.Columns[1].Width = 390;
            DGFelhasznalo.Columns[2].Width = 390;
            DGFelhasznalo.Columns[3].Width = 390;
            DGFelhasznalo.Columns[4].Width = 390;           
            Thread.Sleep(100);
            btnEnable();

            Color col = Theme();

            this.BackColor = col;
            label1.BackColor = col;
            label2.BackColor = col;
            label3.BackColor = col;
            txtemail.BackColor = col;
            txtfelhasznalonev.BackColor = col;
            txtjelszo.BackColor = col;
            cmbrang.BackColor = col;
            btnMezotorles.BackColor = col;
            btnTöröl.BackColor = col;
            btnUjhozzaadasa.BackColor = col;
            button4.BackColor = col;
            button5.BackColor = col;
        }

        private void DTG_Frissit()
        {
            DGFelhasznalo.DataSource = AB.Felhasznalok.ToList();
        }
        private void btnUjhozzaadasa_Click(object sender, EventArgs e)
        {
            var list = AB.Felhasznalok.ToList();
            if (txtemail.Text == "" || txtfelhasznalonev.Text == "" || txtjelszo.Text == "")
            {
                MessageBox.Show("A regisztrációhoz minden mező kitöltése szükséges!");
            }
            else
            {
                if (list.Count(x => x.Username == txtfelhasznalonev.Text) != 0)
                {
                    MessageBox.Show("A felhasználónév már foglalt, válasszon másik felhasználónevet!");
                }
                else
                {
                    if (list.Count(x => x.Email == txtemail.Text) != 0)
                    {
                        MessageBox.Show("Az email cím már foglalt, regisztráljon másik email címmel!");
                    }
                    else
                    {
                        
                        Felhasznalo Ujfelhasznalo = new Felhasznalo();
                        Ujfelhasznalo.Username = txtfelhasznalonev.Text;
                        Ujfelhasznalo.Password = txtjelszo.Text;
                        Ujfelhasznalo.Email = txtemail.Text;
                        Ujfelhasznalo.Role = cmbrang.Text;
                        AB.Felhasznalok.Add(Ujfelhasznalo);
                        AB.SaveChanges();
                        DTG_Frissit();


                    }
                }
            }
        }
        private void btnMezotorles_Click(object sender, EventArgs e)
        {
            txtfelhasznalonev.Text = "";
            txtjelszo.Text = "";
            txtemail.Text = "";
            cmbrang.Text = "";
        }
        private void btnTöröl_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztosan törölni szeretné a felhasználót?",
                       "Visszajelzés kérése", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            String felhasznalo = Convert.ToString(DGFelhasznalo.Rows[DGFelhasznalo.CurrentCell.RowIndex].Cells[1].Value);
            var remove = AB.Felhasznalok.SingleOrDefault(x => x.Username.Equals(felhasznalo));
            if (remove != null)
            {
                AB.Felhasznalok.Remove(remove);
                AB.SaveChanges();
            }
            DTG_Frissit();  
        }
        private void btnEnable()
        {
            txtfelhasznalonev.Visible = true;
            txtjelszo.Visible = true;
            txtemail.Visible = true;
            cmbrang.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            lbl3.Visible = true;
            btnMezotorles.Visible = true;
            btnTöröl.Visible = true;
            btnUjhozzaadasa.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            DGFelhasznalo.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
