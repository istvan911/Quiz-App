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
using FontAwesome.Sharp;

namespace Lista_Kviz
{
    public partial class Kerdesszerkeszto : Form
    {
        Manager.DbManager UjDbManager;
        Adatbazis AB = new Adatbazis();
        private readonly Timer _timer;
        List<string> Tori = new List<string>();
        List<string> Matek = new List<string>();
        List<string> Irodalom = new List<string>();
        List<string> Nyelvtan = new List<string>();
        List<string> Angol = new List<string>();
        List<string> Nemet = new List<string>();
        List<string> OsszTemakor = new List<string>();
        Form currentChildForm;
        int jel = 0;
        private IconButton currentBtn;
        public Kerdesszerkeszto()
        {
            InitializeComponent();
            _timer = new System.Windows.Forms.Timer();
            _timer.Enabled = false;
            _timer.Interval = 500;
            _timer.Tick += OnStartUpTimer;
        }
        public delegate void ABmentesDelegate(string tablanev);
        public event ABmentesDelegate MentesEsemeny;
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(43, 0, 255);
            public static Color color2 = Color.FromArgb(141, 37, 185);
            public static Color color3 = Color.FromArgb(255, 242, 43);
            public static Color color4 = Color.FromArgb(78, 255, 43);
            public static Color color5 = Color.FromArgb(166, 41, 112);
            public static Color color6 = Color.FromArgb(220, 88, 55);
            public static Color color7 = Color.FromArgb(181, 15, 15);
            public static Color color8 = Color.FromArgb(15, 142, 181);
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

        private void Atszinez()
        {
            Color col = Theme();
            this.BackColor = col;
            lstKI.BackColor = col;
            lbl1.BackColor = col;
            lbl2.BackColor = col;
            lbl3.BackColor = col;
            lbl4.BackColor = col;
            lbl5.BackColor = col;
            lblID.BackColor = col;
            lblIdo.BackColor = col;
            lblKerdes.BackColor = col;
            lblKerdesszam.BackColor = col;
            lblTitleChildForm.BackColor = col;
            txtavalasz.BackColor = col;
            txtbvalasz.BackColor = col;
            txtcvalasz.BackColor = col;
            txtdvalasz.BackColor = col;
            txtKerdes.BackColor = col;
            cmbavalasz.BackColor = col;
            cmbbvalasz.BackColor = col;
            cmbhelyes.BackColor = col;
            cmbTemakor.BackColor = col;
            button1.BackColor = col;
            button3.BackColor = col;
            btnHome.BackColor = col;
            btnMentes.BackColor = col;
            btnTorles.BackColor = col;
            btnSzerkeszt.BackColor = col;
            panel1.BackColor = col;
            panel2.BackColor = col;
            panelDesktop.BackColor = col;
            panelTitleBar.BackColor = col;
            iconmin.BackColor = col;
            iconexit.BackColor = col;
            iconButton1.BackColor = col;
            iconButton2.BackColor = col;
            iconButton3.BackColor = col;
            iconButton4.BackColor = col;
            iconButton5.BackColor = col;
            iconButton6.BackColor = col;
            iconButton7.BackColor = col;
            iconButton8.BackColor = col;
            iconButton9.BackColor = col;
            comboBox1.BackColor = col;
            comboBox2.BackColor = col;
            cmbID.BackColor = col;
        }

        private void ActivateButton(object senderBtn, Color color)
        {

            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Theme();
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //iconmin.IconColor= color;
                //iconexit.IconColor= color;

                /*leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();*/

                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                lblTitleChildForm.Text = currentBtn.Text + " kérdésszerkesztő";
                lblTitleChildForm.ForeColor = color;
                panelShadow.BackColor = color;
                panelShadow2.BackColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Theme();
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void iconexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Kerdesszerkeszto_Load(object sender, EventArgs e)
        {


            String sor = "";
            StreamReader be = new StreamReader("Temakorok.txt");
            while ((sor = be.ReadLine()) != null)
            {
                String[] elem = sor.Split(':');
                OsszTemakor.Add(elem[1]);
                if (elem[0] == "történelem")
                {
                    Tori.Add(elem[1]);
                }
                else if (elem[0] == "matematika")
                {
                    Matek.Add(elem[1]);
                }
                else if (elem[0] == "irodalom")
                {
                    Irodalom.Add(elem[1]);
                }
                else if (elem[0] == "nyelvtan")
                {
                    Nyelvtan.Add(elem[1]);
                }
                else if (elem[0] == "angol")
                {
                    Angol.Add(elem[1]);
                }
                else if (elem[0] == "német")
                {
                    Nemet.Add(elem[1]);
                }
            }
            be.Close();

            /*StreamReader b = new StreamReader("Kerdesek.txt");
            while ((sor = b.ReadLine()) != null)
            {
                Class4Valasz Ujadat = new Class4Valasz();
                String[] Elem = sor.Split(':');
                if (Elem[2] == "4valasz")
                {
                    Ujadat.ID = Convert.ToInt32(Elem[0]);
                    Ujadat.Temakor = Elem[1];
                    Ujadat.tipus = Elem[2];
                    Ujadat.kerdes = Elem[3];
                    Ujadat.valasz1 = Elem[4];
                    Ujadat.valasz2 = Elem[5];
                    Ujadat.valasz3 = Elem[6];
                    Ujadat.valasz4 = Elem[7];
                    Ujadat.helyesvalasz = Convert.ToInt32(Elem[8]);
                    Lista.Add(Ujadat);
                }
                else
                {
                    Ujadat.ID = Convert.ToInt32(Elem[0]);
                    Ujadat.Temakor = Elem[1];
                    Ujadat.tipus = Elem[2];
                    Ujadat.kerdes = Elem[3];
                    Ujadat.valasz1 = Elem[4];
                    Ujadat.valasz2 = Elem[5];
                    Ujadat.helyesvalasz = Convert.ToInt32(Elem[6]);
                    Lista.Add(Ujadat);
                }
            }
            b.Close();*/
            Atszinez();
            Timer1.Enabled = true;
            Timer1.Interval = 1000;
            lblIdo.Text = DateTime.Now.ToString("HH:mm:ss");
            cmbavalasz.Hide();
            cmbbvalasz.Hide();
            lblKerdesszam.Hide();
            btnSzerkeszt.Hide();
            lblID.Hide();
            cmbID.Hide();
            comboBox2.Hide();
            btnDisable();
        }
        private void iconmin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            //Történelem
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                comboBox2.Visible = true;
            }
            comboBox1.Text = "1 kérdés, 4 válasz";
            cmbTemakor.Text = "A Közel-Kelet főbb civilizációi";
            ActivateButton(sender, RGBColors.color1);
            btnEnable();
            cmbTemakor.Items.Clear();
            foreach (var item in Tori)
            {
                cmbTemakor.Items.Add(item);
            }
            lstKI.Items.Clear();
            foreach (var item in AB.Kerdesek)
            {
                for (int i = 0; i < Tori.Count; i++)
                {
                    if (item.Temakor == Tori[i])
                    {
                        jel++;
                        break;
                    }
                }
                if (jel > 0)
                {
                    if (item.tipus == "4valasz" && item.Temakor == cmbTemakor.Text)
                    {
                        lstKI.Items.Add(item.ID + " " + item.Temakor + " " + item.tipus + " " + item.kerdes + " " + item.valasz1 + " " + item.valasz2 + " " + item.valasz3 + " " + item.valasz4 + " " + item.helyesvalasz);
                    }
                    else if (item.tipus == "igazhamis" && item.Temakor == cmbTemakor.Text)
                    {
                        lstKI.Items.Add(item.ID + " " + item.Temakor + " " + item.tipus + " " + item.kerdes + " " + item.valasz1 + " " + item.valasz2 + " " + item.helyesvalasz);
                    }
                    jel = 0;

                }
            }
            lblKerdesszam.Text = "Jelenleg " + AB.Kerdesek.Count(x => x.Temakor.Equals(cmbTemakor.Text)) + " kérdés van ebben a témakörben!";
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            //Matematika
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                comboBox2.Visible = true;
            }
            comboBox1.Text = "1 kérdés, 4 válasz";
            cmbTemakor.Text = "";
            ActivateButton(sender, RGBColors.color2);
            btnEnable();
            cmbTemakor.Items.Clear();
            foreach (var item in Matek)
            {
                cmbTemakor.Items.Add(item);
            }
            lstKI.Items.Clear();
            foreach (var item in AB.Kerdesek)
            {
                for (int i = 0; i < Matek.Count; i++)
                {
                    if (item.Temakor == Matek[i])
                    {
                        jel++;
                        break;
                    }
                }
                if (jel > 0)
                {
                    if (item.tipus == "4valasz" && item.Temakor == cmbTemakor.Text)
                    {
                        lstKI.Items.Add(item.ID + " " + item.Temakor + " " + item.tipus + " " + item.kerdes + " " + item.valasz1 + " " + item.valasz2 + " " + item.valasz3 + " " + item.valasz4 + " " + item.helyesvalasz);
                    }
                    else if (item.tipus == "igazhamis" && item.Temakor == cmbTemakor.Text)
                    {
                        lstKI.Items.Add(item.ID + " " + item.Temakor + " " + item.tipus + " " + item.kerdes + " " + item.valasz1 + " " + item.valasz2 + " " + item.helyesvalasz);
                    }
                    jel = 0;

                }
            }
            lblKerdesszam.Text = "Jelenleg " + AB.Kerdesek.Count(x => x.Temakor.Equals(cmbTemakor.Text)) + " kérdés van ebben a témakörben!";
        }
        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            comboBox1.Text = "1 kérdés, 4 válasz";
            cmbTemakor.Text = "Bevezetés az irodalomba";
            //Irodalom
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                comboBox2.Visible = true;
            }
            ActivateButton(sender, RGBColors.color3);
            btnEnable();
            cmbTemakor.Items.Clear();
            foreach (var item in Irodalom)
            {
                cmbTemakor.Items.Add(item);
            }
            lstKI.Items.Clear();
            foreach (var item in AB.Kerdesek)
            {
                for (int i = 0; i < Irodalom.Count; i++)
                {
                    if (item.Temakor == Irodalom[i])
                    {
                        jel++;
                        break;
                    }
                }
                if (jel > 0)
                {
                    if (item.tipus == "4valasz" && item.Temakor == cmbTemakor.Text)
                    {
                        lstKI.Items.Add(item.ID + " " + item.Temakor + " " + item.tipus + " " + item.kerdes + " " + item.valasz1 + " " + item.valasz2 + " " + item.valasz3 + " " + item.valasz4 + " " + item.helyesvalasz);
                    }
                    else if (item.tipus == "igazhamis" && item.Temakor == cmbTemakor.Text)
                    {
                        lstKI.Items.Add(item.ID + " " + item.Temakor + " " + item.tipus + " " + item.kerdes + " " + item.valasz1 + " " + item.valasz2 + " " + item.helyesvalasz);
                    }
                    jel = 0;

                }
            }
            lblKerdesszam.Text = "Jelenleg " + AB.Kerdesek.Count(x => x.Temakor.Equals(cmbTemakor.Text)) + " kérdés van ebben a témakörben!";
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            //Nyelvtan
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                comboBox2.Visible = true;
            }
            comboBox1.Text = "1 kérdés, 4 válasz";
            cmbTemakor.Text = "A kommunikáció";
            ActivateButton(sender, RGBColors.color4);
            btnEnable();
            cmbTemakor.Items.Clear();
            foreach (var item in Nyelvtan)
            {
                cmbTemakor.Items.Add(item);
            }
            lstKI.Items.Clear();
            foreach (var item in AB.Kerdesek)
            {
                for (int i = 0; i < Nyelvtan.Count; i++)
                {
                    if (item.Temakor == Nyelvtan[i])
                    {
                        jel++;
                        break;
                    }
                }
                if (jel > 0)
                {
                    if (item.tipus == "4valasz" && item.Temakor == cmbTemakor.Text)
                    {
                        lstKI.Items.Add(item.ID + " " + item.Temakor + " " + item.tipus + " " + item.kerdes + " " + item.valasz1 + " " + item.valasz2 + " " + item.valasz3 + " " + item.valasz4 + " " + item.helyesvalasz);
                    }
                    else if (item.tipus == "igazhamis" && item.Temakor == cmbTemakor.Text)
                    {
                        lstKI.Items.Add(item.ID + " " + item.Temakor + " " + item.tipus + " " + item.kerdes + " " + item.valasz1 + " " + item.valasz2 + " " + item.helyesvalasz);
                    }
                    jel = 0;

                }
            }
            lblKerdesszam.Text = "Jelenleg " + AB.Kerdesek.Count(x => x.Temakor.Equals(cmbTemakor.Text)) + " kérdés van ebben a témakörben!";
        }

        private void iconButton5_Click_1(object sender, EventArgs e)
        {
            //Angol
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                comboBox2.Visible = true;
            }
            comboBox1.Text = "1 kérdés, 4 válasz";
            cmbTemakor.Text = "";
            ActivateButton(sender, RGBColors.color5);
            btnEnable();
            cmbTemakor.Items.Clear();
            foreach (var item in Angol)
            {
                cmbTemakor.Items.Add(item);
            }
            lstKI.Items.Clear();
            foreach (var item in AB.Kerdesek)
            {
                for (int i = 0; i < Angol.Count; i++)
                {
                    if (item.Temakor == Angol[i])
                    {
                        jel++;
                        break;
                    }
                }
                if (jel > 0)
                {
                    if (item.tipus == "4valasz" && item.Temakor == cmbTemakor.Text)
                    {
                        lstKI.Items.Add(item.ID + " " + item.Temakor + " " + item.tipus + " " + item.kerdes + " " + item.valasz1 + " " + item.valasz2 + " " + item.valasz3 + " " + item.valasz4 + " " + item.helyesvalasz);
                    }
                    else if (item.tipus == "igazhamis" && item.Temakor == cmbTemakor.Text)
                    {
                        lstKI.Items.Add(item.ID + " " + item.Temakor + " " + item.tipus + " " + item.kerdes + " " + item.valasz1 + " " + item.valasz2 + " " + item.helyesvalasz);
                    }
                    jel = 0;

                }
            }
            lblKerdesszam.Text = "Jelenleg " + AB.Kerdesek.Count(x => x.Temakor.Equals(cmbTemakor.Text)) + " kérdés van ebben a témakörben!";
        }

        private void iconButton6_Click_1(object sender, EventArgs e)
        {
            //Német
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                comboBox2.Visible = true;
            }
            comboBox1.Text = "1 kérdés, 4 válasz";
            cmbTemakor.Text = "";
            ActivateButton(sender, RGBColors.color6);
            btnEnable();
            cmbTemakor.Items.Clear();
            foreach (var item in Nemet)
            {
                cmbTemakor.Items.Add(item);
            }

            lstKI.Items.Clear();
            foreach (var item in AB.Kerdesek)
            {
                for (int i = 0; i < Nemet.Count; i++)
                {
                    if (item.Temakor == Nemet[i])
                    {
                        jel++;
                        break;
                    }
                }
                if (jel > 0)
                {
                    if (item.tipus == "4valasz" && item.Temakor == cmbTemakor.Text)
                    {
                        lstKI.Items.Add(item.ID + " " + item.Temakor + " " + item.tipus + " " + item.kerdes + " " + item.valasz1 + " " + item.valasz2 + " " + item.valasz3 + " " + item.valasz4 + " " + item.helyesvalasz);
                    }
                    else if (item.tipus == "igazhamis" && item.Temakor == cmbTemakor.Text)
                    {
                        lstKI.Items.Add(item.ID + " " + item.Temakor + " " + item.tipus + " " + item.kerdes + " " + item.valasz1 + " " + item.valasz2 + " " + item.helyesvalasz);
                    }
                    jel = 0;

                }
            }
            lblKerdesszam.Text = "Jelenleg " + AB.Kerdesek.Count(x => x.Temakor.Equals(cmbTemakor.Text)) + " kérdés van ebben a témakörben!";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
            btnDisable();
        }
        private void Reset()
        {
            DisableButton();
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.DeepSkyBlue;
            panelShadow.BackColor = Color.DeepSkyBlue;
            panelShadow2.BackColor = Color.DeepSkyBlue;
            lblTitleChildForm.Text = "Kezdőlap";
            lblTitleChildForm.ForeColor = Color.DeepSkyBlue;
        }
        private void btnEnable()
        {
            try
            {
                button1.Show();
                //button2.Show();
                button3.Show();
                btnSzerkeszt.Hide();
                //btnTorles.Show();
                btnMentes.Show();
                lbl1.Show();
                lbl2.Show();
                lbl3.Show();
                lbl4.Show();
                lbl5.Show();
                lblKerdes.Show();
                lblKerdesszam.Show();
                cmbTemakor.Show();
                comboBox1.Show();
                comboBox2.Show();
                cmbID.Hide();
                lblID.Hide();
                txtavalasz.Show();
                txtbvalasz.Show();
                txtbvalasz.Show();
                txtcvalasz.Show();
                txtdvalasz.Show();
                txtKerdes.Show();
                cmbhelyes.Show();
                cmbavalasz.Hide();
                cmbbvalasz.Hide();
                lstKI.Show();
                txtKerdes.Text = "";
                txtavalasz.Text = "";
                txtbvalasz.Text = "";
                txtcvalasz.Text = "";
                txtdvalasz.Text = "";
                cmbavalasz.Text = "Igaz";
                cmbbvalasz.Text = "Hamis";
                cmbhelyes.Text = "1";
                comboBox2.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnDisable()
        {
            try
            {
                button1.Hide();
                button3.Hide();
                btnTorles.Hide();
                btnMentes.Hide();
                btnSzerkeszt.Hide();
                lbl1.Hide();
                lbl2.Hide();
                lbl3.Hide();
                lbl4.Hide();
                lbl5.Hide();
                lblKerdes.Hide();
                lblKerdesszam.Hide();
                lblID.Hide();
                cmbID.Hide();
                cmbTemakor.Hide();
                comboBox1.Hide();
                comboBox2.Hide();
                cmbavalasz.Hide();
                cmbbvalasz.Hide();
                txtKerdes.Hide();
                txtavalasz.Hide();
                txtbvalasz.Hide();
                txtcvalasz.Hide();
                txtdvalasz.Hide();
                cmbhelyes.Hide();
                lstKI.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void ListBox_Frissit()
        {
            lstKI.Items.Clear();
            var kell = AB.Kerdesek.Where(x => x.Temakor.Equals(cmbTemakor.Text));
            foreach (var item in AB.Kerdesek)
            {
                if (item.tipus == "4valasz" && item.Temakor == cmbTemakor.Text)
                {
                    lstKI.Items.Add(item.ID + " " + item.Temakor + " " + item.tipus + " " + item.kerdes + " " + item.valasz1 + " " + item.valasz2 + " " + item.valasz3 + " " + item.valasz4 + " " + item.helyesvalasz);
                }
                else if (item.tipus == "igazhamis" && item.Temakor == cmbTemakor.Text)
                {
                    lstKI.Items.Add(item.ID + " " + item.Temakor + " " + item.tipus + " " + item.kerdes + " " + item.valasz1 + " " + item.valasz2 + " " + item.helyesvalasz);
                }
            }
            lblKerdesszam.Text = "Jelenleg " + AB.Kerdesek.Count(x => x.Temakor.Equals(cmbTemakor.Text)) + " kérdés van ebben a témakörben!";
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            //Adatok hozzáadása a listához
            try
            {

                int tm = 0;
                foreach (var item in OsszTemakor)
                {
                    if (cmbTemakor.Text == item)
                    {
                        tm++;
                    }
                }
                if (tm == 0)
                {
                    MessageBox.Show("Válasszon témakört a listából!");
                }
                else
                {
                    if (txtKerdes.Text.Length < 20 || txtKerdes.Text.Length > 255)
                    {
                        MessageBox.Show("A kérdés hossza 20 és 255 karakter között lehet!");
                    }
                    else
                    {
                        if (comboBox1.Text == "1 kérdés, 4 válasz")
                        {
                            if (txtavalasz.Text.Length == 0 || txtbvalasz.Text.Length == 0 || txtcvalasz.Text.Length == 0 || txtdvalasz.Text.Length == 0)
                            {
                                MessageBox.Show("Minden válaszmező kitöltése kötelező!");
                            }
                            else
                            {
                                if (txtavalasz.Text.Length > 55 || txtbvalasz.Text.Length > 55 || txtcvalasz.Text.Length > 55 || txtdvalasz.Text.Length > 55)
                                {
                                    MessageBox.Show("A válaszok hossza nem lehet 55 karakternél hosszabb!");
                                }
                                else
                                {
                                    if (Convert.ToInt32(cmbhelyes.Text) == 1 || Convert.ToInt32(cmbhelyes.Text) == 2 || Convert.ToInt32(cmbhelyes.Text) == 3 || Convert.ToInt32(cmbhelyes.Text) == 4 || cmbhelyes.Text.Length != 0)
                                    {
                                        Class4Valasz Ujadat = new Class4Valasz();
                                        Ujadat.ID = Convert.ToInt32(AB.Kerdesek.Count() + 1);
                                        Ujadat.Temakor = cmbTemakor.Text;
                                        Ujadat.tipus = "4valasz";
                                        Ujadat.kerdes = txtKerdes.Text;
                                        Ujadat.valasz1 = txtavalasz.Text;
                                        Ujadat.valasz2 = txtbvalasz.Text;
                                        Ujadat.valasz3 = txtcvalasz.Text;
                                        Ujadat.valasz4 = txtdvalasz.Text;
                                        Ujadat.helyesvalasz = Convert.ToInt32(cmbhelyes.Text);
                                        AB.Kerdesek.Add(Ujadat);
                                        AB.SaveChanges();
                                        lstKI.Items.Clear();

                                        ListBox_Frissit();
                                    }
                                    else
                                    {
                                        MessageBox.Show("A helyes válasz sorszáma csak 1,2,3 és 4 lehet!");
                                    }
                                }
                            }
                        }
                        else if (comboBox1.Text == "Igaz/Hamis")
                        {
                            if (cmbavalasz.Text == "Hamis" && cmbbvalasz.Text == "Hamis" || cmbavalasz.Text == "Igaz" && cmbbvalasz.Text == "Igaz")
                            {
                                MessageBox.Show("Az 1. és 2. válasznak különböznie kell!");
                            }
                            else
                            {
                                if (Convert.ToInt32(cmbhelyes.Text) == 1 || Convert.ToInt32(cmbhelyes.Text) == 2 || cmbhelyes.Text.Length != 0)
                                {
                                    Class4Valasz Ujadat = new Class4Valasz();
                                    Ujadat.ID = (AB.Kerdesek.Count() + 1);
                                    Ujadat.Temakor = cmbTemakor.Text;
                                    Ujadat.tipus = "igazhamis";
                                    Ujadat.kerdes = txtKerdes.Text;
                                    Ujadat.valasz1 = cmbavalasz.Text;
                                    Ujadat.valasz2 = cmbbvalasz.Text;
                                    Ujadat.helyesvalasz = Convert.ToInt32(cmbhelyes.Text);
                                    AB.Kerdesek.Add(Ujadat);
                                    AB.SaveChanges();
                                    lstKI.Items.Clear();

                                    ListBox_Frissit();
                                }
                                else
                                {
                                    MessageBox.Show("A helyes válasz sorszáma csak 1 és 2 lehet!");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Válasszon megfelelő típust a listából");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTorles_Click_1(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(cmbID.Text);
            var remove = AB.Kerdesek.SingleOrDefault(x => x.ID == id);
            if (remove != null)
            {
                AB.Kerdesek.Remove(remove);
                AB.SaveChanges();
                ListBox_Frissit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                txtKerdes.Text = null;
                txtavalasz.Text = null;
                txtbvalasz.Text = null;
                txtcvalasz.Text = null;
                txtdvalasz.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "1 kérdés, 4 válasz")
                {
                    lblKerdes.BringToFront();
                    lbl1.BringToFront();
                    lbl2.BringToFront();
                    lbl3.BringToFront();
                    lbl4.BringToFront();
                    txtKerdes.BringToFront();
                    txtavalasz.BringToFront();
                    txtbvalasz.BringToFront();
                    txtcvalasz.BringToFront();
                    txtdvalasz.BringToFront();
                    lbl3.Show();
                    lbl4.Show();
                    txtavalasz.Show();
                    txtbvalasz.Show();
                    txtcvalasz.Show();
                    txtdvalasz.Show();
                    cmbavalasz.Hide();
                    cmbbvalasz.Hide();
                    cmbhelyes.Items.Clear();
                    cmbhelyes.Items.Add(1);
                    cmbhelyes.Items.Add(2);
                    cmbhelyes.Items.Add(3);
                    cmbhelyes.Items.Add(4);
                }
                if (comboBox1.Text == "Igaz/Hamis")
                {
                    lbl3.Hide();
                    lbl4.Hide();
                    cmbavalasz.BringToFront();
                    cmbbvalasz.BringToFront();
                    cmbavalasz.Show();
                    cmbbvalasz.Show();
                    txtavalasz.Hide();
                    txtbvalasz.Hide();
                    txtcvalasz.Hide();
                    txtdvalasz.Hide();
                    cmbhelyes.Items.Clear();
                    cmbhelyes.Items.Add(1);
                    cmbhelyes.Items.Add(2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbTemakor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lstKI.Items.Clear();
                ListBox_Frissit();
                if (comboBox2.Text.Equals("Meglévő kérdés szerkesztése"))
                {
                    cmbID.Items.Clear();
                    foreach (var item in AB.Kerdesek)
                    {
                        if (item.Temakor == cmbTemakor.Text)
                        {
                            cmbID.Items.Add(item.ID);
                        }
                    }
                    cmbID.SelectedIndex = 0;
                }
                lblKerdesszam.Text = "Jelenleg " + AB.Kerdesek.Count(x => x.Temakor.Equals(cmbTemakor.Text)) + " kérdés van ebben a témakörben!";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.Text == "Új kérdés hozzáadása")
                {
                    btnDisable();
                    btnEnable();
                    comboBox1.SelectedIndex = 0;
                    btnTorles.Hide();
                }

                else if (comboBox2.Text == "Meglévő kérdés szerkesztése")
                {
                    if (AB.Kerdesek.Count(x => x.Temakor.Equals(cmbTemakor.Text)) == 0)
                    {
                        MessageBox.Show("Az adott témakörhöz nem tartozik egyetlen kérdés sem! A meglévő kérdés szerkesztése opció csak akkor válik elérhetővé, ha legalább 1 kérdés tartozik a kijelölt témakörhöz!");
                        comboBox2.Text = "Új kérdés hozzáadása";

                    }
                    else
                    {
                        btnTorles.Show();
                        cmbID.Items.Clear();
                        lblID.Show();
                        cmbID.Show();
                        button1.Hide();
                        btnSzerkeszt.Show();
                        var szurt = AB.Kerdesek.Where(x => x.Temakor == cmbTemakor.Text);

                        foreach (var item in szurt)
                        {
                            cmbID.Items.Add(item.ID);
                        }
                        cmbID.SelectedIndex = 0;
                        var adat = AB.Kerdesek.FirstOrDefault(x => x.Temakor == cmbTemakor.Text);
                        foreach (var item in AB.Kerdesek)
                        {
                            if (item.ID == adat.ID && item.tipus == "4valasz")
                            {
                                txtKerdes.Text = item.kerdes;
                                txtavalasz.Text = item.valasz1;
                                txtbvalasz.Text = item.valasz2;
                                txtcvalasz.Text = item.valasz3;
                                txtdvalasz.Text = item.valasz4;
                                cmbhelyes.Text = Convert.ToString(item.helyesvalasz);
                                cmbavalasz.Hide();
                                cmbbvalasz.Hide();
                                txtavalasz.Show();
                                txtbvalasz.Show();
                                txtcvalasz.Show();
                                txtdvalasz.Show();
                                comboBox1.SelectedIndex = 0;
                            }
                            else if (item.ID == adat.ID && item.tipus == "igazhamis")
                            {
                                txtKerdes.Text = item.kerdes;
                                cmbavalasz.Text = item.valasz1;
                                cmbbvalasz.Text = item.valasz2;
                                cmbhelyes.Text = Convert.ToString(item.helyesvalasz);
                                comboBox1.SelectedIndex = 1;
                                txtavalasz.Hide();
                                txtbvalasz.Hide();
                                txtcvalasz.Hide();
                                txtdvalasz.Hide();
                                cmbavalasz.Show();
                                cmbbvalasz.Show();
                            }
                            // Dereference of a possibly null reference.
                        }
                        /*if (Lista[adat.ID].tipus == "4valasz")
                        {
                           
                        }
                        else if (Lista[adat.ID].tipus == "igazhamis")
                        {

                        }*/
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSzerkeszt_Click(object sender, EventArgs e)
        {
            //Mentett kérdések szerkesztése
            try
            {
                int id = Convert.ToInt32(cmbID.Text);
                if (id <= 0)
                {
                    MessageBox.Show("A kérdés szerkesztéséhez szükség van egy id-re is!");
                }
                else
                {
                    int tm = 0;
                    foreach (var item in OsszTemakor)
                    {
                        if (cmbTemakor.Text == item)
                        {
                            tm++;
                        }
                    }
                    if (tm == 0)
                    {
                        MessageBox.Show("Válasszon témakört a listából!");
                    }
                    else
                    {
                        if (txtKerdes.Text.Length < 20 || txtKerdes.Text.Length > 255)
                        {
                            MessageBox.Show("A kérdés hossza 20 és 255 karakter között lehet!");
                        }
                        else
                        {
                            if (comboBox1.Text == "1 kérdés, 4 válasz")
                            {
                                if (txtavalasz.Text.Length == 0 || txtbvalasz.Text.Length == 0 || txtcvalasz.Text.Length == 0 || txtdvalasz.Text.Length == 0)
                                {
                                    MessageBox.Show("Minden válaszmező kitöltése kötelező!");
                                }
                                else
                                {
                                    if (txtavalasz.Text.Length > 55 || txtbvalasz.Text.Length > 55 || txtcvalasz.Text.Length > 55 || txtdvalasz.Text.Length > 55)
                                    {
                                        MessageBox.Show("A válaszok hossza nem lehet 55 karakternél hosszabb!");
                                    }
                                    else
                                    {
                                        if (Convert.ToInt32(cmbhelyes.Text) == 1 || Convert.ToInt32(cmbhelyes.Text) == 2 || Convert.ToInt32(cmbhelyes.Text) == 3 || Convert.ToInt32(cmbhelyes.Text) == 4 || cmbhelyes.Text.Length != 0)
                                        {
                                            foreach (var item in AB.Kerdesek)
                                            {
                                                if (item.ID == id)
                                                {
                                                    item.Temakor = cmbTemakor.Text;
                                                    item.tipus = "4valasz";
                                                    item.kerdes = txtKerdes.Text;
                                                    item.valasz1 = txtavalasz.Text;
                                                    item.valasz2 = txtbvalasz.Text;
                                                    item.valasz3 = txtcvalasz.Text;
                                                    item.valasz4 = txtdvalasz.Text;
                                                    item.helyesvalasz = Convert.ToInt32(cmbhelyes.Text);
                                                }
                                            }
                                            AB.SaveChanges();
                                            lstKI.Items.Clear();
                                            ListBox_Frissit();
                                        }
                                        else
                                        {
                                            MessageBox.Show("A helyes válasz sorszáma csak 1,2,3 és 4 lehet!");
                                        }
                                    }
                                }
                            }
                            else if (comboBox1.Text == "Igaz/Hamis")
                            {
                                if (cmbavalasz.Text == "Hamis" && cmbbvalasz.Text == "Hamis" || cmbavalasz.Text == "Igaz" && cmbbvalasz.Text == "Igaz")
                                {
                                    MessageBox.Show("Az 1. és 2. válasznak különböznie kell!");
                                }
                                else
                                {
                                    if (Convert.ToInt32(cmbhelyes.Text) == 1 || Convert.ToInt32(cmbhelyes.Text) == 2 || cmbhelyes.Text.Length != 0)
                                    {
                                        foreach (var item in AB.Kerdesek)
                                        {
                                            if (item.ID == id)
                                            {
                                                item.Temakor = cmbTemakor.Text;
                                                item.tipus = "igazhamis";
                                                item.kerdes = txtKerdes.Text;
                                                item.valasz1 = cmbavalasz.Text;
                                                item.valasz2 = cmbbvalasz.Text;
                                                item.helyesvalasz = Convert.ToInt32(cmbhelyes.Text);
                                            }
                                        }
                                        lstKI.Items.Clear();
                                        AB.SaveChanges();
                                        ListBox_Frissit();
                                    }
                                    else
                                    {
                                        MessageBox.Show("A helyes válasz sorszáma csak 1 és 2 lehet!");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Válasszon megfelelő típust a listából");
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cmbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(cmbID.Text);
                foreach (var item in AB.Kerdesek)
                {
                    if (item.tipus == "4valasz" && item.ID == id)
                    {
                        txtKerdes.Text = item.kerdes;
                        txtavalasz.Text = item.valasz1;
                        txtbvalasz.Text = item.valasz2;
                        txtcvalasz.Text = item.valasz3;
                        txtdvalasz.Text = item.valasz4;
                        cmbhelyes.Text = Convert.ToString(item.helyesvalasz);
                        txtavalasz.Show();
                        txtbvalasz.Show();
                        txtcvalasz.Show();
                        txtdvalasz.Show();
                        cmbavalasz.Hide();
                        cmbbvalasz.Hide();
                    }
                    else if (item.tipus == "igazhamis" && item.ID == id)
                    {
                        txtKerdes.Text = item.kerdes;
                        cmbavalasz.Text = item.valasz1;
                        cmbbvalasz.Text = item.valasz2;
                        cmbhelyes.Text = Convert.ToString(item.helyesvalasz);
                        comboBox1.SelectedIndex = 1;
                        cmbavalasz.Show();
                        cmbbvalasz.Show();
                        txtavalasz.Hide();
                        txtbvalasz.Hide();
                        txtcvalasz.Hide();
                        txtdvalasz.Hide();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbavalasz_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbavalasz.SelectedIndex == 0)
                cmbbvalasz.SelectedIndex = 0;
            else
                cmbbvalasz.SelectedIndex = 1;
        }

        private void cmbbvalasz_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbvalasz.SelectedIndex == 0)
                cmbavalasz.SelectedIndex = 0;
            else
                cmbavalasz.SelectedIndex = 1;
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void iconButton7_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            btnEnable();
            OpenChildForm(new FormFelhasznalok());
            comboBox2.Visible = false;
            lblTitleChildForm.Text = "Felhasználók kezelése";
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            btnEnable();
            OpenChildForm(new FormTemakorszerkeszto());
            comboBox2.Visible = false;
            lblTitleChildForm.Text = "Témakörök szerkesztése";
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblIdo.Text = DateTime.Now.ToString("HH:mm:ss");
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

        private void button4_Click(object sender, EventArgs e)
        {
            String sor;
            StreamReader b = new StreamReader("Kerdesek.txt");
            while ((sor = b.ReadLine()) != null)
            {
                Class4Valasz Ujadat = new Class4Valasz();
                String[] Elem = sor.Split(':');
                if (Elem[2] == "4valasz")
                {
                    Ujadat.Temakor = Elem[1];
                    Ujadat.tipus = Elem[2];
                    Ujadat.kerdes = Elem[3];
                    Ujadat.valasz1 = Elem[4];
                    Ujadat.valasz2 = Elem[5];
                    Ujadat.valasz3 = Elem[6];
                    Ujadat.valasz4 = Elem[7];
                    Ujadat.helyesvalasz = Convert.ToInt32(Elem[8]);
                    AB.Kerdesek.Add(Ujadat);
                    AB.SaveChanges();
                }
                else
                {
                    Ujadat.Temakor = Elem[1];
                    Ujadat.tipus = Elem[2];
                    Ujadat.kerdes = Elem[3];
                    Ujadat.valasz1 = Elem[4];
                    Ujadat.valasz2 = Elem[5];
                    Ujadat.helyesvalasz = Convert.ToInt32(Elem[6]);
                    AB.Kerdesek.Add(Ujadat);
                    AB.SaveChanges();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Properties.UserSettings.Default.nezet = "Vendég";
            Properties.UserSettings.Default.Save();
            this.Hide();
            FormLoading_Screen FL = new FormLoading_Screen();
            this.Hide();
            FL.Show();
        }

        private void KeyDownSupress(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}
