using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Lista_Kviz
{
    public partial class Temavalaszto : Form
    {
        Adatbazis AB = new Adatbazis();
        Manager.DbManager UjDbManager;
        private readonly Timer _timer;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        System.Windows.Media.MediaPlayer player = new System.Windows.Media.MediaPlayer();
        private double volume = Properties.UserSettings.Default.volume;


        public delegate void ABmentesDelegate(string tablanev);
        public event ABmentesDelegate MentesEsemeny;

        public Temavalaszto()
        {
            InitializeComponent();
            _timer = new System.Windows.Forms.Timer();
            _timer.Enabled = false;
            _timer.Interval = 500;
            _timer.Tick += OnStartUpTimer;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(43, 0, 255);
            public static Color color2 = Color.FromArgb(141, 37, 185);
            public static Color color3 = Color.FromArgb(255, 242, 43);
            public static Color color4 = Color.FromArgb(78, 255, 43);
            public static Color color5 = Color.FromArgb(166, 41, 112);
            public static Color color6 = Color.FromArgb(220, 88, 55);
            public static Color color7 = Color.FromArgb(3, 105, 23);
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

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                lblTitleChildForm.Text = currentBtn.Text;
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
                pictureBox2.Visible = false;

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

        
        private void AtszinezTema()
        {
            Color themecolor = Theme();
            panelDesktop.BackColor = themecolor;
            panelLogo.BackColor = themecolor;
            panelMenu.BackColor = themecolor;
            panelTitleBar.BackColor = themecolor;
            iconButton1.BackColor = themecolor;
            iconButton2.BackColor = themecolor;
            iconButton3.BackColor = themecolor;
            iconButton4.BackColor = themecolor;
            iconButton5.BackColor = themecolor;
            iconButton6.BackColor = themecolor;
            iconButton7.BackColor = themecolor;
            button1.BackColor = themecolor;
            button2.BackColor = themecolor;
            button3.BackColor = themecolor;
            button4.BackColor = themecolor;
            button5.BackColor = themecolor;
            button6.BackColor = themecolor;
            button7.BackColor = themecolor;
            button8.BackColor = themecolor;
            button9.BackColor = themecolor;
            button10.BackColor = themecolor;
            button11.BackColor = themecolor;
            button12.BackColor = themecolor;
            button13.BackColor = themecolor;
            button14.BackColor = themecolor;
            button15.BackColor = themecolor;
            button16.BackColor = themecolor;
            button17.BackColor = themecolor;
            button18.BackColor = themecolor;
            button19.BackColor = themecolor;
            button20.BackColor = themecolor;
            button21.BackColor = themecolor;
            button22.BackColor = themecolor;
            button23.BackColor = themecolor;
            button24.BackColor = themecolor;
            button25.BackColor = themecolor;
            button26.BackColor = themecolor;
            button27.BackColor = themecolor;
            button28.BackColor = themecolor;
            button29.BackColor = themecolor;
            button29.BackColor = themecolor;
            button30.BackColor = themecolor;

           
        }
        private void BTN()
        {
            Color themecolor = Theme();
            button1.BackColor = themecolor;
            button2.BackColor = themecolor;
            button3.BackColor = themecolor;
            button4.BackColor = themecolor;
            button5.BackColor = themecolor;
            button6.BackColor = themecolor;
            button7.BackColor = themecolor;
            button8.BackColor = themecolor;
            button9.BackColor = themecolor;
            button10.BackColor = themecolor;
            button11.BackColor = themecolor;
            button12.BackColor = themecolor;
            button13.BackColor = themecolor;
            button14.BackColor = themecolor;
            button15.BackColor = themecolor;
            button16.BackColor = themecolor;
            button17.BackColor = themecolor;
            button18.BackColor = themecolor;
            button19.BackColor = themecolor;
            button20.BackColor = themecolor;
            button21.BackColor = themecolor;
            button22.BackColor = themecolor;
            button23.BackColor = themecolor;
            button24.BackColor = themecolor;
            button25.BackColor = themecolor;
            button26.BackColor = themecolor;
            button27.BackColor = themecolor;
            button28.BackColor = themecolor;
            button29.BackColor = themecolor;
            button29.BackColor = themecolor;
            button30.BackColor = themecolor;
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            pictureBox2.Visible = false;
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            btnDisable();
            ActivateButton(sender,RGBColors.color1);
            OpenChildForm(new FormTortenelem());
            btn1("A Közel-Kelet főbb civilizációi");
            btn2("A görög civilizáció és politika az ókori Hellászban");
            btn3("A római civilizáció és politika");
            btn4("Vallások az ókorban");
            btn5("A Római Birodalom bukása");
            btn6("Az iszlám és az Arab Birodalom ");
            btn7("A parasztság világa és a nemesi rend");
            btn8("Az egyházi rend");
            btn9("A középkor művelődése");
            btn10("A polgárok világa");
            btn11("A magyar őstörténet és honfoglalás");
            btn12("A keresztény magyar államalapítás és megszilárdulása");
            btn13("A Magyar Királyság a 13. században");
            btn14("Magyarország az Anjouk korában");
            btn15("A török fenyegetés árnyékában");
            btn16("Hunyadi Mátyás uralkodása");
            btn17("A magyar középkor kulturális hagyatéka");
            btn18("A földrajzi felfedezések");
            btn19("A korai kapitalizmus");
            btn20("Reformáció Európában és Magyarországon");
            btn21("Az ország három részre szakadása");
            btn22("A Magyar Királyság és az Erdélyi Fejedelemség a 16-17. században");
            btn23("A török kiűzése és a török kor mérlege");
            btn24("A felvilágosodás");
            btn25("A Brit Alkotmányos Monarchia és az Amerikai Köztársaság működése");
            btn26("A francia forradalom és hatása");
            btn27("A Rákóczi-szabadságharc");
            btn28("Magyarország újranépesülése");
            btn29("A felvilágosult abszolutizmus reformjai");
            btn30("Liberalizmus, nacionalizmus és konzervatizmus");
            BTN();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            btnDisable();
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FormTortenelem());
            //btn1();
            //btn2();
            //btn3();
            //btn4();
            //btn5();
            //btn6();
            //btn7();
            //btn8();
            //btn9();
            //btn10();
            //btn11();
            //btn12();
            //btn13();
            //btn14();
            //btn15();
            //btn16();
            //btn17();
            //btn18();
            //btn19();
            //btn20();
            //btn21();
            //btn22();
            //btn23();
            //btn24();
            //btn25();
            //btn26();
            //btn27();
            //btn28();
            //btn29();
            //btn30();
            BTN();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            btnDisable();
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FormTortenelem());
            btn1("Bevezetés az irodalomba");
            btn2("Az ősi magyar hitvilág");
            btn3("Babiloni teremtésmítosz, görög mitológia, trójai mondakör");
            btn4("Homéroszi eposzok");
            btn5("A görög líra");
            btn6("A thébai mondakör");
            btn7("Római irodalom");
            btn8("A biblia, mint kulturális kód");
            btn9("A középkor irodalma");
            btn10("Hallotti beszéd és könyörgés, Ómagyar Mária-siralom");
            btn11("A lovagi epika és líra");
            btn12("Dante Alighieri és Francois Villon");
            btn13("A reneszánsz és Francesco Petrarca");
            btn14("Janus Pannonius");
            btn15("Giovanni Boccaccio");
            btn16("A magyar reformáció vallásos irodalma");
            btn17("A regény születése");
            btn18("Balassi Bálint");
            btn19("William Shakespeare");
            btn20("Pázmány Péter");
            btn21("Zrínyi Miklós");
            btn22("Mikes Kelemen és Apáczai Csere János");
            btn23("A kuruc kor világi lírája");
            btn24("Az európai klasszicizmus és a Francia klasszicista dráma");
            btn25("Az európai felvilágosodás");
            btn26("Bessenyei és Kármán");
            btn27("Kazinczy Ferenc és a nyelvújítás");
            btn28("Csokonai Vitéz Mihály");
            btn29("Berzsenyi Dániel");
            btn30("Kölcsey Ferenc");
            //A modern magyar színjátszás kezdetei - hiányzó gomb
            BTN();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            btnDisable();
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new FormTortenelem());
            btn1("A kommunikáció");
            btn2("A tömegkommunikáció");
            btn3("Médiaműfajok");
            btn4("Internet és kommunikáció");
            btn5("Kapcsolódás a beszédhelyzethez");
            btn6("A jelentésbeli kapcsolóelemek a szövegben");
            btn7("A nyelvtani kapcsolóelemek a szövegben");
            btn8("Az intertextualitás");
            btn9("A szövegtípusok csoportosítása");
            btn10("Helyesírásunk alapelvei");
            btn11("Külön, egybe, vagy kötőjellel?");
            btn12("A kezdőbetű");
            btn13("Az idegen szavak és nevek helyesírása");
            btn14("Írásjelek és az elválasztás");
            btn15("A rövidítések, jelek, mozaikszók és a számok helyesírása");
            btn16("Nyelv és gondolkodás");
            btn17("Nyelvtípusok");
            btn18("Nyelvi identitás");
            btn19("Beszédhelyzetek");
            btn20("Kommunikáció és média");
            btn21("Manipulációs szándékok és reklámok a médiában");
            btn22("A beszéd megszerkesztése és részei");
            btn23("Az érv mibenléte, felépítése, logikája");
            btn24("A vita és a cáfolat");
            btn25("A szónoki beszéd");
            btn26("A magyar nyelv eredete");
            btn27("A magyar nyelv szókincsének változásai");
            btn28("A magyar nyev egységesülése és sztenderdizációja");
            btn29("A nyelv és társadalom viszonya");
            btn30("A csoportnyelvekq");
            BTN();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            btnDisable();
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FormTortenelem());
            //btn1();
            //btn2();
            //btn3();
            //btn4();
            //btn5();
            //btn6();
            //btn7();
            //btn8();
            //btn9();
            //btn10();
            //btn11();
            //btn12();
            //btn13();
            //btn14();
            //btn15();
            //btn16();
            //btn17();
            //btn18();
            //btn19();
            //btn20();
            //btn21();
            //btn22();
            //btn23();
            //btn24();
            //btn25();
            //btn26();
            //btn27();
            //btn28();
            //btn29();
            //btn30();
            BTN();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            btnDisable();
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new FormTortenelem());
            //btn1();
            //btn2();
            //btn3();
            //btn4();
            //btn5();
            //btn6();
            //btn7();
            //btn8();
            //btn9();
            //btn10();
            //btn11();
            //btn12();
            //btn13();
            //btn14();
            //btn15();
            //btn16();
            //btn17();
            //btn18();
            //btn19();
            //btn20();
            //btn21();
            //btn22();
            //btn23();
            //btn24();
            //btn25();
            //btn26();
            //btn27();
            //btn28();
            //btn29();
            //btn30();
            BTN();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
            btnDisable();

        }

        private void Reset()
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            DisableButton();
            pictureBox2.Visible = true;
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.DeepSkyBlue;
            panelShadow.BackColor = Color.DeepSkyBlue;
            panelShadow2.BackColor = Color.DeepSkyBlue;
            lblTitleChildForm.Text = "Kezdőlap";
            lblTitleChildForm.ForeColor = Color.DeepSkyBlue;
            pictureBox2.Show();
            iconButton1.Enabled = true;
            iconButton2.Enabled = true;
            iconButton3.Enabled = true;
            iconButton4.Enabled = true;
            iconButton5.Enabled = true;
            iconButton6.Enabled = true;
            iconButton7.Enabled = true;
            btnHome.Enabled = true;
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void iconMute_Click(object sender, EventArgs e)
        {
            iconMute.Hide();
            iconPlay.Show();
            player.Pause();
        }

        private void iconPlay_Click(object sender, EventArgs e)
        {
            iconPlay.Hide();
            iconMute.Show();
            player.Play();
        }

        private void btnDisable()
        {
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            button15.Hide();
            button16.Hide();
            button17.Hide();
            button18.Hide();
            button19.Hide();
            button20.Hide();
            button21.Hide();
            button22.Hide();
            button23.Hide();
            button24.Hide();
            button25.Hide();
            button26.Hide();
            button27.Hide();
            button28.Hide();
            button29.Hide();
            button30.Hide();
        }
        public bool HaveQuestion(string temakor)
        {
            bool van = false;
            foreach (var item in AB.Kerdesek)
            {
                if (item.Temakor == temakor)
                    van = true;
            }
            return van;
        }
        private void btn1(string temakor)
        {
            button1.Visible = true;
            button1.Text = temakor;
            button1.BringToFront();
            button1.ForeColor = Color.White;
            button1.BackColor = Color.FromArgb(23, 45, 95);
        }
        private void btn2(string temakor)
        {
            button2.Visible = true;
            button2.Text = temakor;
            button2.BringToFront();
            button2.ForeColor = Color.White;
            button2.BackColor = Color.FromArgb(23, 45, 95);
        }
        private void btn3(string temakor)
        {
            button3.Visible = true;
            button3.Text = temakor;
            button3.BringToFront();
            button3.ForeColor = Color.White;
            button3.BackColor = Color.FromArgb(23, 45, 95);
        }
        private void btn4(string temakor)
        {
            button4.Visible = true;
            button4.Text = temakor;
            button4.BringToFront();
            button4.ForeColor = Color.White;
            button4.BackColor = Color.FromArgb(23, 45, 95);
        }
        private void btn5(string temakor)
        {
            button5.Visible = true;
            button5.Text = temakor;
            button5.BringToFront();
            button5.ForeColor = Color.White;
            button5.BackColor = Color.FromArgb(23, 45, 95);
        }
        private void btn6(string temakor)
        {
            button6.Visible = true;
            button6.Text = temakor;
            button6.BringToFront();
            button6.ForeColor = Color.White;
            button6.BackColor = Color.FromArgb(23, 45, 95);
        }
        private void btn7(string temakor)
        {
            button7.Visible = true;
            button7.Text = temakor;
            button7.BringToFront();
            button7.ForeColor = Color.White;
            button7.BackColor = Color.FromArgb(23, 45, 95);
        }
        private void btn8(string temakor)
        {
            button8.Visible = true;
            button8.Text = temakor;
            button8.BringToFront();
            button8.ForeColor = Color.White;
            button8.BackColor = Color.FromArgb(23, 45, 95);
        }
        private void btn9(string temakor)
        {
            button9.Visible = true;
            button9.Text = temakor;
            button9.BringToFront();
            button9.ForeColor = Color.White;
            button9.BackColor = Color.FromArgb(23, 45, 95);
        }
        private void btn10(string temakor)
        {
            button10.Visible = true;
            button10.Text = temakor;
            button10.BringToFront();
            button10.ForeColor = Color.White;
            button10.BackColor = Color.FromArgb(23, 45, 95);
        }
        private void btn11(string temakor)
        {
            button11.Visible = true;
            button11.Text = temakor;
            button11.BringToFront();
            button11.ForeColor = Color.White;
            button11.BackColor = Color.FromArgb(23, 45, 95);
        }
        private void btn12(string temakor)
        {
            button12.Visible = true;
            button12.Text = temakor;
            button12.BringToFront();
            button12.ForeColor = Color.White;
            button12.BackColor = Color.FromArgb(23, 45, 95);
        }
        private void btn13(string temakor)
        {
            button13.Visible = true;
            button13.Text = temakor;
            button13.BringToFront();
            button13.ForeColor = Color.White;
            button13.BackColor = Color.FromArgb(23, 45, 95);
        }
        private void btn14(string temakor)
        {
            button14.Visible = true;
            button14.Text = temakor;
            button14.BringToFront();
            button14.ForeColor = Color.White;
            button14.BackColor = Color.FromArgb(23, 45, 95);
        }
        private void btn15(string temakor)
        {
            button15.Visible = true;
            button15.Text = temakor;
            button15.BringToFront();
            button15.ForeColor = Color.White;
            button15.BackColor = Color.FromArgb(23, 45, 95);
        }
        private void btn16(string temakor)
        {
            button16.Visible = true;
            button16.Text = temakor;
            button16.BringToFront();
            button16.ForeColor = Color.White;
            button16.BackColor = Color.FromArgb(23, 45, 95);
        }
        private void btn17(string temakor)
        {
            button17.Visible = true;
            button17.Text = temakor;
            button17.BringToFront();
            button17.ForeColor = Color.White;
            button17.BackColor = Color.FromArgb(23, 45, 95);
        }
        private void btn18(string temakor)
        {
            button18.Visible = true;
            button18.Text = temakor;
            button18.BringToFront();
            button18.ForeColor = Color.White;
            button18.BackColor = Color.FromArgb(23, 45, 95);
        }
        private void btn19(string temakor)
        {
            button19.Visible = true;
            button19.Text = temakor;
            button19.BringToFront();
            button19.ForeColor = Color.White;
            button19.BackColor = Color.FromArgb(23, 45, 95);
        }
        private void btn20(string temakor)
        {
            button20.Visible = true;
            button20.Text = temakor;
            button20.BringToFront();
            button20.ForeColor = Color.White;
            button20.BackColor = Color.FromArgb(23, 45, 95);
        }
        private void btn21(string temakor)
        {
            button21.Visible = true;
            button21.Text = temakor;
            button21.BringToFront();
            button21.ForeColor = Color.White;
            button21.BackColor = Color.FromArgb(23, 45, 95);
        }
        private void btn22(string temakor)
        {
            button22.Visible = true;
            button22.Text = temakor;
            button22.BringToFront();
            button22.ForeColor = Color.White;
            button22.BackColor = Color.FromArgb(23, 45, 95);
        }
        private void btn23(string temakor)
        {
            button23.Visible = true;
            button23.Text = temakor;
            button23.BringToFront();
            button23.ForeColor = Color.White;
            button23.BackColor = Color.FromArgb(23, 45, 95);
        }
        private void btn24(string temakor)
        {
            button24.Visible = true;
            button24.Text = temakor;
            button24.BringToFront();
            button24.ForeColor = Color.White;
            button24.BackColor = Color.FromArgb(23, 45, 95);
        }
        private void btn25(string temakor)
        {
            button25.Visible = true;
            button25.Text = temakor;
            button25.BringToFront();
            button25.ForeColor = Color.White;
            button25.BackColor = Color.FromArgb(23, 45, 95);
        }
        private void btn26(string temakor)
        {
            button26.Visible = true;
            button26.Text = temakor;
            button26.BringToFront();
            button26.ForeColor = Color.White;
            button26.BackColor = Color.FromArgb(23, 45, 95);
        }
        private void btn27(string temakor)
        {
            button27.Visible = true;
            button27.Text = temakor;
            button27.BringToFront();
            button27.ForeColor = Color.White;
            button27.BackColor = Color.FromArgb(23, 45, 95);
        }
        private void btn28(string temakor)
        {
            button28.Visible = true;
            button28.Text = temakor;
            button28.BringToFront();
            button28.ForeColor = Color.White;
            button28.BackColor = Color.FromArgb(23, 45, 95);
        }
        private void btn29(string temakor)
        {
            button29.Visible = true;
            button29.Text = temakor;
            button29.BringToFront();
            button29.ForeColor = Color.White;
            button29.BackColor = Color.FromArgb(23, 45, 95);
        }
        private void btn30(string temakor)
        {
            button30.Visible = true;
            button30.Text = temakor;
            button30.BringToFront();
            button30.ForeColor = Color.White;
            button30.BackColor = Color.FromArgb(23, 45, 95);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HaveQuestion(button1.Text) && button1.Text != "Cube Game")
                {
                    MessageBox.Show("A jelenlegi témakörhöz nincs még megoldható feladat! Kérem válasszon másik témakört!");
                }
                else if(button1.Text == "Cube Game")
                {
                    string rootPath = Directory.GetCurrentDirectory();
                    string gameExe = Path.Combine(rootPath, "CubeGame", "Cube Game.exe");
                    ProcessStartInfo startInfo = new ProcessStartInfo(gameExe);
                    startInfo.WorkingDirectory = Path.Combine(rootPath, "CubeGame");
                    Process.Start(startInfo);
                }
                else
                {
                    StreamWriter k = new StreamWriter("jel.txt");
                    k.WriteLine(button1.Text);
                    k.Close();
                    OpenChildForm(new Form4valasz());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HaveQuestion(button2.Text) && button2.Text != "Amőba")
                {
                    MessageBox.Show("A jelenlegi témakörhöz nincs még megoldható feladat! Kérem válasszon másik témakört!");
                }
                else if (button2.Text == "Amőba")
                {
                    string rootPath = Directory.GetCurrentDirectory();
                    string gameExe = Path.Combine(rootPath , "Amőba", "TicTacToe.exe");
                    ProcessStartInfo startInfo = new ProcessStartInfo(gameExe);
                    startInfo.WorkingDirectory = Path.Combine(rootPath, "Amőba");
                    Process.Start(startInfo);
                }
                else
                {
                    StreamWriter k = new StreamWriter("jel.txt");
                    k.WriteLine(button2.Text);
                    k.Close();
                    OpenChildForm(new Form4valasz());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Temavalaszto_Load(object sender, EventArgs e)
        {
            player.Volume = volume;
            iconMute.BringToFront();
            string direct = Directory.GetCurrentDirectory() + "\\music.mp4";
            player.Open(new Uri(direct));
            player.Play();
            pictureBox2.Visible = true;
            Timer.Enabled = true;
            Timer.Interval = 1000;
            lblIdo.Text = DateTime.Now.ToString("HH:mm:ss");
            AtszinezTema();
            iconButton1.Enabled = true;
            iconButton2.Enabled = true;
            iconButton3.Enabled = true;
            iconButton4.Enabled = true;
            iconButton5.Enabled = true;
            iconButton6.Enabled = true;
            iconButton7.Enabled = true;
            btnHome.Enabled = true;
            if (Properties.UserSettings.Default.jelfelhasz.Equals("Admin"))
            {
                btnkerdesszerkeszto.Visible = true;
                btnkerdesszerkeszto.Show();
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HaveQuestion(button3.Text))
                {
                    MessageBox.Show("A jelenlegi témakörhöz nincs még megoldható feladat! Kérem válasszon másik témakört!");
                }
                else
                {
                    StreamWriter k = new StreamWriter("jel.txt");
                    k.WriteLine(button3.Text);
                    k.Close();
                    OpenChildForm(new Form4valasz());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HaveQuestion(button4.Text))
                {
                    MessageBox.Show("A jelenlegi témakörhöz nincs még megoldható feladat! Kérem válasszon másik témakört!");
                }
                else
                {
                    StreamWriter k = new StreamWriter("jel.txt");
                    k.WriteLine(button4.Text);
                    k.Close();
                    OpenChildForm(new Form4valasz());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HaveQuestion(button5.Text))
                {
                    MessageBox.Show("A jelenlegi témakörhöz nincs még megoldható feladat! Kérem válasszon másik témakört!");
                }
                else
                {
                    StreamWriter k = new StreamWriter("jel.txt");
                    k.WriteLine(button5.Text);
                    k.Close();
                    OpenChildForm(new Form4valasz());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HaveQuestion(button6.Text))
                {
                    MessageBox.Show("A jelenlegi témakörhöz nincs még megoldható feladat! Kérem válasszon másik témakört!");
                }
                else
                {
                    StreamWriter k = new StreamWriter("jel.txt");
                    k.WriteLine(button6.Text);
                    k.Close();
                    OpenChildForm(new Form4valasz());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HaveQuestion(button7.Text))
                {
                    MessageBox.Show("A jelenlegi témakörhöz nincs még megoldható feladat! Kérem válasszon másik témakört!");
                }
                else
                {
                    StreamWriter k = new StreamWriter("jel.txt");
                    k.WriteLine(button7.Text);
                    k.Close();
                    OpenChildForm(new Form4valasz());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HaveQuestion(button8.Text))
                {
                    MessageBox.Show("A jelenlegi témakörhöz nincs még megoldható feladat! Kérem válasszon másik témakört!");
                }
                else
                {
                    StreamWriter k = new StreamWriter("jel.txt");
                    k.WriteLine(button8.Text);
                    k.Close();
                    OpenChildForm(new Form4valasz());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HaveQuestion(button9.Text))
                {
                    MessageBox.Show("A jelenlegi témakörhöz nincs még megoldható feladat! Kérem válasszon másik témakört!");
                }
                else
                {
                    StreamWriter k = new StreamWriter("jel.txt");
                    k.WriteLine(button9.Text);
                    k.Close();
                    OpenChildForm(new Form4valasz());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HaveQuestion(button10.Text))
                {
                    MessageBox.Show("A jelenlegi témakörhöz nincs még megoldható feladat! Kérem válasszon másik témakört!");
                }
                else
                {
                    StreamWriter k = new StreamWriter("jel.txt");
                    k.WriteLine(button10.Text);
                    k.Close();
                    OpenChildForm(new Form4valasz());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HaveQuestion(button11.Text))
                {
                    MessageBox.Show("A jelenlegi témakörhöz nincs még megoldható feladat! Kérem válasszon másik témakört!");
                }
                else
                {
                    StreamWriter k = new StreamWriter("jel.txt");
                    k.WriteLine(button11.Text);
                    k.Close();
                    OpenChildForm(new Form4valasz());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HaveQuestion(button12.Text))
                {
                    MessageBox.Show("A jelenlegi témakörhöz nincs még megoldható feladat! Kérem válasszon másik témakört!");
                }
                else
                {
                    StreamWriter k = new StreamWriter("jel.txt");
                    k.WriteLine(button12.Text);
                    k.Close();
                    OpenChildForm(new Form4valasz());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HaveQuestion(button13.Text))
                {
                    MessageBox.Show("A jelenlegi témakörhöz nincs még megoldható feladat! Kérem válasszon másik témakört!");
                }
                else
                {
                    StreamWriter k = new StreamWriter("jel.txt");
                    k.WriteLine(button13.Text);
                    k.Close();
                    OpenChildForm(new Form4valasz());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HaveQuestion(button14.Text))
                {
                    MessageBox.Show("A jelenlegi témakörhöz nincs még megoldható feladat! Kérem válasszon másik témakört!");
                }
                else
                {
                    StreamWriter k = new StreamWriter("jel.txt");
                    k.WriteLine(button14.Text);
                    k.Close();
                    OpenChildForm(new Form4valasz());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HaveQuestion(button15.Text))
                {
                    MessageBox.Show("A jelenlegi témakörhöz nincs még megoldható feladat! Kérem válasszon másik témakört!");
                }
                else
                {
                    StreamWriter k = new StreamWriter("jel.txt");
                    k.WriteLine(button15.Text);
                    k.Close();
                    OpenChildForm(new Form4valasz());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HaveQuestion(button16.Text))
                {
                    MessageBox.Show("A jelenlegi témakörhöz nincs még megoldható feladat! Kérem válasszon másik témakört!");
                }
                else
                {
                    StreamWriter k = new StreamWriter("jel.txt");
                    k.WriteLine(button16.Text);
                    k.Close();
                    OpenChildForm(new Form4valasz());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HaveQuestion(button17.Text))
                {
                    MessageBox.Show("A jelenlegi témakörhöz nincs még megoldható feladat! Kérem válasszon másik témakört!");
                }
                else
                {
                    StreamWriter k = new StreamWriter("jel.txt");
                    k.WriteLine(button17.Text);
                    k.Close();
                    OpenChildForm(new Form4valasz());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HaveQuestion(button18.Text))
                {
                    MessageBox.Show("A jelenlegi témakörhöz nincs még megoldható feladat! Kérem válasszon másik témakört!");
                }
                else
                {
                    StreamWriter k = new StreamWriter("jel.txt");
                    k.WriteLine(button18.Text);
                    k.Close();
                    OpenChildForm(new Form4valasz());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HaveQuestion(button19.Text))
                {
                    MessageBox.Show("A jelenlegi témakörhöz nincs még megoldható feladat! Kérem válasszon másik témakört!");
                }
                else
                {
                    StreamWriter k = new StreamWriter("jel.txt");
                    k.WriteLine(button19.Text);
                    k.Close();
                    OpenChildForm(new Form4valasz());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HaveQuestion(button20.Text))
                {
                    MessageBox.Show("A jelenlegi témakörhöz nincs még megoldható feladat! Kérem válasszon másik témakört!");
                }
                else
                {
                    StreamWriter k = new StreamWriter("jel.txt");
                    k.WriteLine(button20.Text);
                    k.Close();
                    OpenChildForm(new Form4valasz());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HaveQuestion(button21.Text))
                {
                    MessageBox.Show("A jelenlegi témakörhöz nincs még megoldható feladat! Kérem válasszon másik témakört!");
                }
                else
                {
                    StreamWriter k = new StreamWriter("jel.txt");
                    k.WriteLine(button21.Text);
                    k.Close();
                    OpenChildForm(new Form4valasz());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HaveQuestion(button22.Text))
                {
                    MessageBox.Show("A jelenlegi témakörhöz nincs még megoldható feladat! Kérem válasszon másik témakört!");
                }
                else
                {
                    StreamWriter k = new StreamWriter("jel.txt");
                    k.WriteLine(button22.Text);
                    k.Close();
                    OpenChildForm(new Form4valasz());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HaveQuestion(button23.Text))
                {
                    MessageBox.Show("A jelenlegi témakörhöz nincs még megoldható feladat! Kérem válasszon másik témakört!");
                }
                else
                {
                    StreamWriter k = new StreamWriter("jel.txt");
                    k.WriteLine(button23.Text);
                    k.Close();
                    OpenChildForm(new Form4valasz());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HaveQuestion(button24.Text))
                {
                    MessageBox.Show("A jelenlegi témakörhöz nincs még megoldható feladat! Kérem válasszon másik témakört!");
                }
                else
                {
                    StreamWriter k = new StreamWriter("jel.txt");
                    k.WriteLine(button24.Text);
                    k.Close();
                    OpenChildForm(new Form4valasz());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HaveQuestion(button25.Text))
                {
                    MessageBox.Show("A jelenlegi témakörhöz nincs még megoldható feladat! Kérem válasszon másik témakört!");
                }
                else
                {
                    StreamWriter k = new StreamWriter("jel.txt");
                    k.WriteLine(button25.Text);
                    k.Close();
                    OpenChildForm(new Form4valasz());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HaveQuestion(button26.Text))
                {
                    MessageBox.Show("A jelenlegi témakörhöz nincs még megoldható feladat! Kérem válasszon másik témakört!");
                }
                else
                {
                    StreamWriter k = new StreamWriter("jel.txt");
                    k.WriteLine(button26.Text);
                    k.Close();
                    OpenChildForm(new Form4valasz());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HaveQuestion(button27.Text))
                {
                    MessageBox.Show("A jelenlegi témakörhöz nincs még megoldható feladat! Kérem válasszon másik témakört!");
                }
                else
                {
                    StreamWriter k = new StreamWriter("jel.txt");
                    k.WriteLine(button27.Text);
                    k.Close();
                    OpenChildForm(new Form4valasz());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HaveQuestion(button28.Text))
                {
                    MessageBox.Show("A jelenlegi témakörhöz nincs még megoldható feladat! Kérem válasszon másik témakört!");
                }
                else
                {
                    StreamWriter k = new StreamWriter("jel.txt");
                    k.WriteLine(button28.Text);
                    k.Close();
                    OpenChildForm(new Form4valasz());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HaveQuestion(button29.Text))
                {
                    MessageBox.Show("A jelenlegi témakörhöz nincs még megoldható feladat! Kérem válasszon másik témakört!");
                }
                else
                {
                    StreamWriter k = new StreamWriter("jel.txt");
                    k.WriteLine(button29.Text);
                    k.Close();
                    OpenChildForm(new Form4valasz());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HaveQuestion(button30.Text))
                {
                    MessageBox.Show("A jelenlegi témakörhöz nincs még megoldható feladat! Kérem válasszon másik témakört!");
                }
                else
                {
                    StreamWriter k = new StreamWriter("jel.txt");
                    k.WriteLine(button30.Text);
                    k.Close();
                    OpenChildForm(new Form4valasz());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            lblIdo.Text = DateTime.Now.ToString("HH:mm:ss");
            player.Volume = Properties.UserSettings.Default.volume;
            if (player.IsFrozen)
            {
                player.Play();
            }
        }

        private void iconexit_MouseMove(object sender, MouseEventArgs e)
        {
            iconexit.ForeColor = Color.Red;
        }

        private void iconexit_MouseLeave(object sender, EventArgs e)
        {
            iconexit.ForeColor = Color.White;
        }

        private void iconmin_MouseMove(object sender, MouseEventArgs e)
        {
            iconmin.ForeColor = Color.GreenYellow;
        }

        private void iconmin_MouseLeave(object sender, EventArgs e)
        {
            iconmin.ForeColor = Color.White;
        }
        
        private void iconPlay_MouseLeave(object sender, EventArgs e)
        {
            iconPlay.ForeColor = Color.White;
        }

        private void iconPlay_MouseMove(object sender, MouseEventArgs e)
        {
            iconPlay.ForeColor = panelShadow.BackColor;
        }

        private void iconMute_MouseLeave(object sender, EventArgs e)
        {
            iconMute.ForeColor = Color.White;
        }

        private void iconMute_MouseMove(object sender, MouseEventArgs e)
        {
            iconMute.ForeColor = panelShadow.BackColor;
        }

        private void IconCloseSettings_Click(object sender, EventArgs e)
        {
            if (Properties.UserSettings.Default.Valtozas)
            {
                MessageBox.Show("Az alkalmazás beállításai újraindítás után válnak elérhetővé, ezért alkalmazás újraindul!");
                Application.Restart();
            }
            else
            {
                Reset();
                btnDisable();
                iconButton1.Enabled = true;
                iconButton2.Enabled = true;
                iconButton3.Enabled = true;
                iconButton4.Enabled = true;
                iconButton5.Enabled = true;
                iconButton6.Enabled = true;
                iconButton7.Enabled = true;
                iconButton8.Enabled = true;
                btnHome.Enabled = true;
                IconCloseSettings.Visible = false;
                player.Volume = Properties.UserSettings.Default.volume;
            }
        }

        private void btnkerdesszerkeszto_Click(object sender, EventArgs e)
        {
            player.Stop();
            Properties.UserSettings.Default.nezet = "Admin";
            FormLoading_Screen FL = new FormLoading_Screen();   
            this.Hide();
            FL.Show();            

        }

        private void iconButton8_Click(object sender, EventArgs e)
        {   
            btnDisable();
            ActivateButton(sender, RGBColors.color7);
            OpenChildForm(new FormTortenelem());
            btn1("Cube Game");
            //btn2("Amőba");
            //btn3();
            //btn4();
            //btn5();
            //btn6();
            //btn7();
            //btn8();
            //btn9();
            //btn10();
            //btn11();
            //btn12();
            //btn13();
            //btn14();
            //btn15();
            //btn16();
            //btn17();
            //btn18();
            //btn19();
            //btn20();
            //btn21();
            //btn22();
            //btn23();
            //btn24();
            //btn25();
            //btn26();
            //btn27();
            //btn28();
            //btn29();
            //btn30();
            BTN();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            btnDisable();
            ActivateButton(sender, Color.DarkRed);
            OpenChildForm(new FormSettings());
            iconButton1.Enabled = false;
            iconButton2.Enabled = false;
            iconButton3.Enabled = false;
            iconButton4.Enabled = false;
            iconButton5.Enabled = false;
            iconButton6.Enabled = false;
            iconButton7.Enabled = false;
            iconButton8.Enabled = false;
            btnHome.Enabled = false;
            IconCloseSettings.Visible = true;
            IconCloseSettings.BringToFront();
        }
    }
}
