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
    public partial class FormTemakorszerkeszto : Form
    {
        Manager.DbManager UjDbManager;
        Adatbazis AB = new Adatbazis();

        private readonly System.Windows.Forms.Timer _timer;
        //List<Temakor> Temakorok = new List<Temakor>();
        public FormTemakorszerkeszto()
        {

            InitializeComponent();
            _timer = new System.Windows.Forms.Timer();
            _timer.Enabled = false;
            _timer.Interval = 1500;
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

        private void FormTemakorszerkeszto_Load(object sender, EventArgs e)
        {
            txtszerk.Enabled = false;
            txttemakor.Show();
            cmbSzerk.Show();

            var kell = AB.Temakorok.Where(x => x.Tantargy.Equals(cmbTantargy.Text)).ToList();
            DTGTemakor.DataSource = kell;
            var kell1 = AB.Temakorok.Where(x => x.Tantargy.Equals(cmbTantargy.Text)).Select(x => x.Temkorok);
            foreach (var item in kell1)
            {
                cmbSzerk.Items.Add(item);
            }
            cmbSzerk.SelectedIndex = 0;

            DTGTemakor.Columns[0].HeaderText = "ID";
            DTGTemakor.Columns[1].HeaderText = "Tantárgy";
            DTGTemakor.Columns[2].HeaderText = "Témakör";
            DTGTemakor.Columns[0].Width = 40;
            DTGTemakor.Columns[1].Width = 250;
            DTGTemakor.Columns[2].Width = 500;

            /*String sor;
            StreamReader b = new StreamReader("Temakorok.txt");
            while ((sor = b.ReadLine()) != null) 
            {
                Temakor Ujadat = new Temakor();
                String[] Elem = sor.Split(':');
                Ujadat.Tantargy = Elem[0];
                Ujadat.Temkorok = Elem[1];
                Temakorok.Add(Ujadat);
            }*/

            Color col = Theme();

            this.BackColor = col;
            lbl1.BackColor = col;
            lbl3.BackColor = col;
            label1.BackColor = col;
            txtszerk.BackColor = col;
            txttemakor.BackColor = col;
            cmb.BackColor = col;
            cmbSzerk.BackColor = col;
            cmbTantargy.BackColor = col;
            btnAdatokbeolvasasa.BackColor = col;
            btnListahozAdas.BackColor = col;
            btnMezoktorlese.BackColor = col;
            btnSzerkeszt.BackColor = col;
            btnTorles.BackColor = col;
        }

        private void Mezotorlo()
        {
            txttemakor.Text = "";
        }
        private void btnMezoktorlese_Click(object sender, EventArgs e)
        {
            Mezotorlo();
        }

        private void cmbTantargy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSzerk.Items.Clear();
            var kell = AB.Temakorok.Where(x => x.Tantargy.Equals(cmbTantargy.Text)).ToList();
            DTGTemakor.DataSource = kell;
            var kell1 = AB.Temakorok.Where(x => x.Tantargy.Equals(cmbTantargy.Text)).Select(x => x.Temkorok);
            foreach (var item in kell1)
            {
                cmbSzerk.Items.Add(item);
            }
            cmbSzerk.SelectedIndex = 0;
        }

        private void btnSzerkeszt_Click(object sender, EventArgs e)
        {
            foreach (var item in AB.Temakorok)
            {
                if (item.Temkorok==cmbSzerk.Text)
                {
                    item.Temkorok = txtszerk.Text;
                }
            }

            AB.SaveChanges();
            DTG_Frissit();
        }

        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb.Text == "Új hozzáadása")
            {
                txttemakor.Show();
                btnListahozAdas.Show();
                btnSzerkeszt.Hide();
                cmbSzerk.Hide();
                txtszerk.Hide();
                btnTorles.Hide();
            }
            else
            {
                txttemakor.Hide();
                btnListahozAdas.Hide();
                btnSzerkeszt.Show();
                cmbSzerk.Show();
                txtszerk.Show();
                cmbSzerk.SelectedIndex = 0;
                btnTorles.Show();
            }
        }
        private void btnListahozAdas_Click(object sender, EventArgs e)
        {
            bool van = false;
            foreach (var item in AB.Temakorok)
            {
                if (item.Tantargy.Equals(cmbTantargy.Text)&&item.Temkorok.Equals(txttemakor.Text))
                {
                    van = true;
                }
            }
            if (van)
            {
                MessageBox.Show("A témakörök között már szerepel egy ilyen elem!");
            }
            else
            {
                Temakor Ujadat = new Temakor();
                Ujadat.Temkorok = txttemakor.Text;
                Ujadat.Tantargy = cmbTantargy.Text;
                AB.Temakorok.Add(Ujadat);
                AB.SaveChanges();
            }
            DTG_Frissit();
        }
        
        private void DTG_Frissit()
        {
            DTGTemakor.DataSource = AB.Temakorok.ToList();
        }
        private void btnTorles_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztosan törölni szeretné a témakört?",
            "Visszajelzés kérése", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            string temakor = Convert.ToString(DTGTemakor.Rows[DTGTemakor.CurrentCell.RowIndex].Cells[3].Value);
            var remove = AB.Temakorok.SingleOrDefault(x => x.Temkorok.Equals(temakor));
            if (remove != null)
            {
                AB.Temakorok.Remove(remove);
                AB.SaveChanges();
            }
            DTG_Frissit();
        }

        private void btnAdatokbeolvasasa_Click(object sender, EventArgs e)
        { 
            String s;
            StreamReader b = new StreamReader("Temakorok.txt");
            while ((s=b.ReadLine())!= null)
            {
                Temakor u = new Temakor();
                String[]elem = s.Split(':');
                u.Tantargy = elem[0];
                u.Temkorok = elem[1];
                AB.Temakorok.Add(u);
                
            }
            AB.SaveChanges();
        }
    }
}
