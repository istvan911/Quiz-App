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
using System.Diagnostics;

namespace Lista_Kviz
{
    public partial class Form4valasz : Form
    {
        Adatbazis AB = new Adatbazis();
        private readonly Timer _timer;
        List<Class4Valasz> Lista=new List<Class4Valasz>();
        int pont = 0;
        int kerdesszam = 0;
        int kerdki = 1;
        string temakor="";
        bool hiba = false;
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(27, 124, 66);
            public static Color color2 = Color.FromArgb(70, 20, 20);
            public static Color color3 = Color.FromArgb(23, 45, 95);
        }
        public Form4valasz()
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
        private void Disable()
        {
            Color col = Theme();
            button1.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            btnIgazhamisvalasz1.ForeColor = Color.White;
            btnIgazhamisvalasz2.ForeColor = Color.White;

            button1.BackColor = col;
            button2.BackColor = col;
            button3.BackColor = col;
            button4.BackColor = col;   
            btnIgazhamisvalasz1.BackColor = col;
            btnIgazhamisvalasz2.BackColor = col;


        }
        private  void checkvalaszevent(object sender, MouseEventArgs e)
        {
            button5.Show();
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            Disable();
            if (buttonTag == Lista[kerdesszam].helyesvalasz)
            {
                pont++;
                if (buttonTag == 1)
                {
                    button1.BackColor = RGBColors.color1;
                    button1.ForeColor = Color.Black;
                }
                if (buttonTag == 2)
                {
                    button2.BackColor = RGBColors.color1;
                    button2.ForeColor = Color.Black;
                }
                if (buttonTag == 3)
                {
                    button3.BackColor = RGBColors.color1;
                    button3.ForeColor = Color.Black;
                }
                if (buttonTag == 4)
                {
                    button4.BackColor = RGBColors.color1;
                    button4.ForeColor = Color.Black;
                }
            }
            lblPontszam.Text = Convert.ToString(pont);
            lblKerdesszam.Text = Convert.ToString(kerdki + "/" + Lista.Count);
            if (buttonTag != Lista[kerdesszam].helyesvalasz)
            {
                if (buttonTag == 1)
                {
                    button1.BackColor = RGBColors.color2;
                    if (Lista[kerdesszam].helyesvalasz == 2)
                    {
                        button2.BackColor = RGBColors.color1;
                    }
                    if (Lista[kerdesszam].helyesvalasz == 3)
                    {
                        button3.BackColor = RGBColors.color1;
                    }
                    if (Lista[kerdesszam].helyesvalasz == 4)
                    {
                        button4.BackColor = RGBColors.color1;
                    }
                }
                if (buttonTag == 2)
                {
                    button2.BackColor = RGBColors.color2;
                    if (Lista[kerdesszam].helyesvalasz == 1)
                    {
                        button1.BackColor = RGBColors.color1;
                    }
                    if (Lista[kerdesszam].helyesvalasz == 3)
                    {
                        button3.BackColor = RGBColors.color1;
                    }
                    if (Lista[kerdesszam].helyesvalasz == 4)
                    {
                        button4.BackColor = RGBColors.color1;
                    }
                }
                if (buttonTag == 3)
                {
                    button3.BackColor = RGBColors.color2;
                    if (Lista[kerdesszam].helyesvalasz == 1)
                    {
                        button1.BackColor = RGBColors.color1;
                    }
                    if (Lista[kerdesszam].helyesvalasz == 2)
                    {
                        button2.BackColor = RGBColors.color1;
                    }
                    if (Lista[kerdesszam].helyesvalasz == 4)
                    {
                        button4.BackColor = RGBColors.color1;
                    }
                }
                if (buttonTag == 4)
                {
                    button4.BackColor = RGBColors.color2;
                    if (Lista[kerdesszam].helyesvalasz == 1)
                    {
                        button1.BackColor = RGBColors.color1;
                    }
                    if (Lista[kerdesszam].helyesvalasz == 2)
                    {
                        button2.BackColor = RGBColors.color1;
                    }
                    if (Lista[kerdesszam].helyesvalasz == 3)
                    {
                        button3.BackColor = RGBColors.color1;
                    }
                }
            }
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }
        private void btnIndit_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader b = new StreamReader("jel.txt");
                temakor = b.ReadLine();
                b.Close();

                foreach (var item in AB.Kerdesek)
                {
                    if (item.Temakor == temakor)
                    {
                        Class4Valasz Ujadat = new Class4Valasz();
                        if (item.tipus == "4valasz")
                        {
                            Ujadat.tipus = item.tipus;
                            Ujadat.kerdes = item.kerdes;
                            Ujadat.valasz1 = item.valasz1;
                            Ujadat.valasz2 = item.valasz2;
                            Ujadat.valasz3 = item.valasz3;
                            Ujadat.valasz4 = item.valasz4;
                            Ujadat.helyesvalasz = Convert.ToInt32(item.helyesvalasz);
                            Lista.Add(Ujadat);
                        }
                        else
                        {
                            Ujadat.tipus = item.tipus;
                            Ujadat.kerdes = item.kerdes;
                            Ujadat.valasz1 = item.valasz1;
                            Ujadat.valasz2 = item.valasz2;
                            Ujadat.helyesvalasz = Convert.ToInt32(item.helyesvalasz);
                            Lista.Add(Ujadat);
                        }
                    }
                }
                    lblKerdesszam.Text = kerdki + "/" + Lista.Count;
                if (Lista[kerdesszam].tipus == "4valasz")
                {
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button1.ForeColor = Color.White;
                    button2.ForeColor = Color.White;
                    button3.ForeColor = Color.White;
                    button4.ForeColor = Color.White;

                    lblTemakor.Text = temakor;
                    lblKerdes.Text = Lista[kerdesszam].kerdes;
                    button1.Text = Lista[kerdesszam].valasz1;
                    button2.Text = Lista[kerdesszam].valasz2;
                    button3.Text = Lista[kerdesszam].valasz3;
                    button4.Text = Lista[kerdesszam].valasz4;
                    button1.Show();
                    button2.Show();
                    button3.Show();
                    button4.Show();
                    lblKerdes.Show();
                    label1.Show();
                    label2.Show();
                    lblKerdesszam.Show();
                    lblPontszam.Show();
                    lblTemakor.Show();
                    label4.Show();
                    btnIndit.Hide();
                    button5.Hide();
                    btnIgazhamisvalasz1.Hide();
                    btnIgazhamisvalasz2.Hide();
                    label3.Show();
                }
                else if (Lista[kerdesszam].tipus == "igazhamis")
                {
                    btnIgazhamisvalasz1.Enabled = true;
                    btnIgazhamisvalasz2.Enabled = true;
                    btnIgazhamisvalasz1.ForeColor = Color.White;
                    btnIgazhamisvalasz2.ForeColor = Color.White;
                    lblKerdes.Text = Lista[kerdesszam].kerdes;
                    btnIgazhamisvalasz1.Text = Lista[kerdesszam].valasz1;
                    btnIgazhamisvalasz2.Text = Lista[kerdesszam].valasz2;
                    lblTemakor.Text = temakor;
                    btnIgazhamisvalasz1.Show();
                    btnIgazhamisvalasz2.Show();
                    button1.Hide();
                    button2.Hide();
                    button3.Hide();
                    button4.Hide();
                    btnIndit.Hide();
                    button5.Hide();
                    label1.Show();
                    label2.Show();
                    lblKerdes.Show();
                    lblKerdesszam.Show();
                    lblPontszam.Show();
                    lblTemakor.Show();
                    label4.Show();
                    label3.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A jelenlegi témakörhöz nincs még megoldható feladat! Kérem válasszon másik témakört!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (kerdesszam == Lista.Count - 1)
                {
                    lblPontszam.Text = Convert.ToString(pont);
                    MessageBox.Show(
                        "Kvíz vége!" + Environment.NewLine +
                        "Megválaszoltál " + pont + " kérdést helyesen!" + Environment.NewLine +
                        "Ha szeretnél kipróbálni egy új kvízt, akkor" + Environment.NewLine +
                        "kattints a menüsorban egy tantárgyra!" + Environment.NewLine +
                        "Kellemes időtöltést kívánok! :)"
                        );
                    lblPontszam.Text = Convert.ToString(pont);
                    button1.Hide();
                    button2.Hide();
                    button3.Hide();
                    button4.Hide();
                    button5.Hide();
                    lblKerdes.Hide();
                    lblKerdesszam.Hide();
                    lblPontszam.Hide();
                    lblTemakor.Hide();
                    label1.Hide();
                    label2.Hide();
                    label4.Hide();
                    label3.Hide();
                    btnIndit.Hide();
                    btnIgazhamisvalasz1.Hide();
                    btnIgazhamisvalasz2.Hide();
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    btnIgazhamisvalasz1.Enabled = false;
                    btnIgazhamisvalasz2.Enabled = false;
                    this.Hide();
                }

                else
                {
                    kerdesszam++;
                    kerdki++;
                    Disable();
                    if (Lista[kerdesszam].tipus == "4valasz")
                    {
                        button5.Hide();
                        btnIgazhamisvalasz1.Hide();
                        btnIgazhamisvalasz2.Hide();
                        lblKerdes.Text = Lista[kerdesszam].kerdes;
                        button1.Text = Lista[kerdesszam].valasz1;
                        button2.Text = Lista[kerdesszam].valasz2;
                        button3.Text = Lista[kerdesszam].valasz3;
                        button4.Text = Lista[kerdesszam].valasz4;

                        button1.Show();
                        button2.Show();
                        button3.Show();
                        button4.Show();
                        button1.Enabled = true;
                        button2.Enabled = true;
                        button3.Enabled = true;
                        button4.Enabled = true;
                    }
                    else if (Lista[kerdesszam].tipus == "igazhamis")
                    {
                        button5.Hide();
                        button1.Hide();
                        button2.Hide();
                        button3.Hide();
                        button4.Hide();
                        btnIgazhamisvalasz1.Show();
                        btnIgazhamisvalasz2.Show();
                        lblKerdes.Text = Lista[kerdesszam].kerdes;
                        btnIgazhamisvalasz1.Text = Lista[kerdesszam].valasz1;
                        btnIgazhamisvalasz2.Text = Lista[kerdesszam].valasz2;
                        btnIgazhamisvalasz1.Enabled = true;
                        btnIgazhamisvalasz2.Enabled = true;
                    }
                    lblPontszam.Text = Convert.ToString(pont);
                    lblKerdesszam.Text = Convert.ToString(kerdki + "/" + Lista.Count);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void IgazHamischeck(object sender, MouseEventArgs e)
        {
            try
            {
                button5.Show();
                var senderObject = (Button)sender;

                int buttonTag = Convert.ToInt32(senderObject.Tag);

                Disable();
                if (buttonTag == Lista[kerdesszam].helyesvalasz)
                {
                    pont++;
                    if (buttonTag == 1)
                    {
                        btnIgazhamisvalasz1.BackColor = RGBColors.color1;
                        btnIgazhamisvalasz1.ForeColor = Color.White;
                    }
                    if (buttonTag == 2)
                    {
                        btnIgazhamisvalasz2.BackColor = RGBColors.color1;
                        btnIgazhamisvalasz2.ForeColor = Color.White;
                    }
                }
                lblKerdesszam.Text = Convert.ToString(kerdki + "/" + Lista.Count);
                lblPontszam.Text = Convert.ToString(pont);

                if (buttonTag != Lista[kerdesszam].helyesvalasz)
                {
                    if (buttonTag == 1)
                    {
                        btnIgazhamisvalasz1.BackColor = RGBColors.color2;
                        if (Lista[kerdesszam].helyesvalasz == 2)
                        {
                            btnIgazhamisvalasz2.BackColor = RGBColors.color1;
                        }
                    }
                    if (buttonTag == 2)
                    {
                        btnIgazhamisvalasz2.BackColor = RGBColors.color2;
                        if (Lista[kerdesszam].helyesvalasz == 1)
                        {
                            btnIgazhamisvalasz1.BackColor = RGBColors.color1;
                        }
                    }
                }
                btnIgazhamisvalasz1.Enabled = false;
                btnIgazhamisvalasz2.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            try
            {
                Process myProcess = new Process();
                myProcess.StartInfo.UseShellExecute = true;

                if (temakor == ("A Közel-Kelet főbb civilizációi"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/tortenelem_9_nat2020/lecke_01_001";
                else if (temakor == ("A görög civilizáció és politika az ókori Hellászban"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/tortenelem_9_nat2020/lecke_01_002";
                else if (temakor == ("A római civilizáció és politika"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/tortenelem_9_nat2020/lecke_01_004";
                else if (temakor == ("Vallások az ókorban"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/tortenelem_9_nat2020/lecke_02_006";
                else if (temakor == ("A Római Birodalom bukása"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/tortenelem_9_nat2020/lecke_03_008";
                else if (temakor == ("Az iszlám és az Arab Birodalom"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/tortenelem_9_nat2020/lecke_03_009";
                else if (temakor == ("A parasztség világa és a nemesi rend"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/tortenelem_9_nat2020/lecke_04_010";
                else if (temakor == ("Az egyházi rend"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/tortenelem_9_nat2020/lecke_04_011";
                else if (temakor == ("A középkor művelődése"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/tortenelem_9_nat2020/lecke_04_012";
                else if (temakor == ("A polgárok világa"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/tortenelem_9_nat2020/lecke_04_014";
                else if (temakor == ("A magyar őstörténet és honfoglalás"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/tortenelem_9_nat2020/lecke_05_015";
                else if (temakor == ("A keresztény magyar államalapítás és megszilárdulása"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/tortenelem_9_nat2020/lecke_05_016";
                else if (temakor == ("A Magyar Királyság a 13. században"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/tortenelem_9_nat2020/lecke_05_018";
                else if (temakor == ("Magyarország az Anjouk korában"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/tortenelem_9_nat2020/lecke_06_019";
                else if (temakor == ("A török fenyegetés árnyékában"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/tortenelem_9_nat2020/lecke_06_020";
                else if (temakor == ("Hunyadi Mátyás uralkodása"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/tortenelem_9_nat2020/lecke_06_021";
                else if (temakor == ("A magyar középkor kulturális hagyatéka"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/tortenelem_9_nat2020/lecke_06_022";
                else if (temakor == ("A földrajzi felfedezések"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/tortenelem_10_nat2020/lecke_01_001";
                else if (temakor == ("A korai kapitalizmus"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/tortenelem_10_nat2020/lecke_01_002";
                else if (temakor == ("Reformáció Európában és Magyarországon"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/tortenelem_10_nat2020/lecke_01_003";
                else if (temakor == ("Az ország három részre szakadása"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/tortenelem_10_nat2020/lecke_02_005";
                else if (temakor == ("A Magyar Királyság és az Erdélyi Fejedelemség a 16-17. században"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/tortenelem_10_nat2020/lecke_02_006";
                else if (temakor == ("A török kiűzése és a török kor mérlege"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/tortenelem_10_nat2020/lecke_02_008";
                else if (temakor == ("A felvilágosodás"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/tortenelem_10_nat2020/lecke_03_009";
                else if (temakor == ("A Brit Alkotmányos Monarchia és az Amerikai Köztársaság működése"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/tortenelem_10_nat2020/lecke_03_010";
                else if (temakor == ("A francia forradalom és hatása"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/tortenelem_10_nat2020/lecke_03_011";
                else if (temakor == ("A Rákóczi-szabadságharc"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/tortenelem_10_nat2020/lecke_04_012";
                else if (temakor == ("Magyarország újranépesülése"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/tortenelem_10_nat2020/lecke_04_013";
                else if (temakor == ("A felvilágosult abszolutizmus reformjai"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/tortenelem_10_nat2020/lecke_04_014";
                else if (temakor == ("Liberalizmus, nacionalizmus és konzervatizmus"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/tortenelem_10_nat2020/lecke_05_015";
                else if (temakor == ("Bevezetés az irodalomba"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/irodalom_9_nat2020/lecke_01_001";
                else if (temakor == ("Az ősi magyar hitvilág"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/irodalom_9_nat2020/lecke_02_001";
                else if (temakor == ("Babiloni teremtésmítosz, görög mitológia, trójai mondakör"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/irodalom_9_nat2020/lecke_02_004";
                else if (temakor == ("Homéroszi eposzok"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/irodalom_9_nat2020/lecke_03_001";
                else if (temakor == ("A görög líra"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/irodalom_9_nat2020/lecke_03_005";
                else if (temakor == ("A thébai mondakör"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/irodalom_9_nat2020/lecke_03_009";
                else if (temakor == ("Római irodalom"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/irodalom_9_nat2020/lecke_04_001";
                else if (temakor == ("A biblia, mint kulturális kód"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/irodalom_9_nat2020/lecke_05_001";
                else if (temakor == ("A középkor irodalma"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/irodalom_9_nat2020/lecke_06_001";
                else if (temakor == ("Hallotti beszéd és könyörgés, Ómagyar Mária-siralom"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/irodalom_9_nat2020/lecke_06_003";
                else if (temakor == ("A lovagi epika és líra"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/irodalom_9_nat2020/lecke_06_006";
                else if (temakor == ("Dante Alighieri és Francois Villon"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/irodalom_9_nat2020/lecke_06_008";
                else if (temakor == ("A reneszánsz és Francesco Petrarca"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/irodalom_9_nat2020/lecke_07_001";
                else if (temakor == ("Janus Pannonius"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/irodalom_9_nat2020/lecke_07_003";
                else if (temakor == ("Giovanni Boccaccio"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/irodalom_9_nat2020/lecke_07_007";
                else if (temakor == ("A magyar reformáció vallásos irodalma"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/irodalom_10_nat2020/lecke_01_001";
                else if (temakor == ("A regény születése"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/irodalom_10_nat2020/lecke_01_005";
                else if (temakor == ("Balassi Bálint"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/irodalom_10_nat2020/lecke_01_006";
                else if (temakor == ("William Shakespeare"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/irodalom_10_nat2020/lecke_01_010";
                else if (temakor == ("Barokk és Pázmány Péter"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/irodalom_10_nat2020/lecke_02_015";
                else if (temakor == ("Zrínyi Miklós"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/irodalom_10_nat2020/lecke_02_017";
                else if (temakor == ("Mikes Kelemen és Apáczai Csere János"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/irodalom_10_nat2020/lecke_02_020";
                else if (temakor == ("A kuruc kor világi lírája"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/irodalom_10_nat2020/lecke_02_023";
                else if (temakor == ("Az európai klasszicizmus és a Francia klasszicista dráma"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/irodalom_10_nat2020/lecke_03_025";
                else if (temakor == ("Az európai felvilágosodás"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/irodalom_10_nat2020/lecke_03_028";
                else if (temakor == ("Bessenyei és Kármán"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/irodalom_10_nat2020/lecke_04_034";
                else if (temakor == ("Kazinczy Ferenc és a nyelvújítás"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/irodalom_10_nat2020/lecke_04_035";
                else if (temakor == ("Csokonai Vitéz Mihály"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/irodalom_10_nat2020/lecke_04_036";
                else if (temakor == ("Berzsenyi Dániel"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/irodalom_10_nat2020/lecke_05_042";
                else if (temakor == ("Kölcsey Ferenc"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/irodalom_10_nat2020/lecke_05_046";
                else if (temakor == ("A modern magyar színjátszás kezdetei"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/irodalom_10_nat2020/lecke_05_050";
                else if (temakor == ("A kommunikáció"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/magyar_nyelv_9_nat2020/lecke_01_001";
                else if (temakor == ("A tömegkommunikáció"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/magyar_nyelv_9_nat2020/lecke_01_004";
                else if (temakor == ("Médiaműfajok"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/magyar_nyelv_9_nat2020/lecke_01_006";
                else if (temakor == ("Internet és kommunikáció"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/magyar_nyelv_9_nat2020/lecke_01_007";
                else if (temakor == ("Kapcsolódás a beszédhelyzethez"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/magyar_nyelv_10_nat2020/lecke_01_003";
                else if (temakor == ("A jelentésbeli kapcsolóelemek a szövegben"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/magyar_nyelv_10_nat2020/lecke_01_004";
                else if (temakor == ("A nyelvtani kapcsolóelemek a szövegben"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/magyar_nyelv_10_nat2020/lecke_01_005";
                else if (temakor == ("Az intertextualitás"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/magyar_nyelv_10_nat2020/lecke_01_006";
                else if (temakor == ("A szövegtípusok csoportosítása"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/magyar_nyelv_10_nat2020/lecke_01_007";
                else if (temakor == ("Helyesírásunk alapelvei"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/magyar_nyelv_10_nat2020/lecke_03_025";
                else if (temakor == ("Külön, egybe, vagy kötőjellel?"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/magyar_nyelv_10_nat2020/lecke_03_026";
                else if (temakor == ("A kezdőbetű"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/magyar_nyelv_10_nat2020/lecke_03_027";
                else if (temakor == ("Az idegen szavak és nevek helyesírása"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/magyar_nyelv_10_nat2020/lecke_03_028";
                else if (temakor == ("Írásjelek és az elválasztás"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/magyar_nyelv_10_nat2020/lecke_03_029";
                else if (temakor == ("A rövidítések, jelek, mozaikszók és a számok helyesírása"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/magyar_nyelv_10_nat2020/lecke_03_030";
                else if (temakor == ("Nyelv és gondolkodás"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/magyar_nyelv_11/lecke_01_002";
                else if (temakor == ("Nyelvtípusok"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/magyar_nyelv_11/lecke_01_003";
                else if (temakor == ("Nyelvi identitás"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/magyar_nyelv_11/lecke_01_004";
                else if (temakor == ("Beszédhelyzetek"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/magyar_nyelv_11/lecke_02_001";
                else if (temakor == ("Kommunikáció és média"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/magyar_nyelv_11/lecke_03_001";
                else if (temakor == ("Manipulációs szándékok és reklámok a médiában"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/magyar_nyelv_11/lecke_03_003";
                else if (temakor == ("A beszéd megszerkesztése és részei"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/magyar_nyelv_11/lecke_03_007";
                else if (temakor == ("Az érv mibenléte, felépítése, logikája"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/magyar_nyelv_11/lecke_03_008";
                else if (temakor == ("A vita és a cáfolat"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/magyar_nyelv_11/lecke_03_009";
                else if (temakor == ("A szónoki beszéd"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/magyar_nyelv_11/lecke_03_013";
                else if (temakor == ("A magyar nyelv eredete"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/magyar_nyelv_12/lecke_01_003";
                else if (temakor == ("A magyar nyelv szókincsének változásai"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/magyar_nyelv_12/lecke_01_006";
                else if (temakor == ("A magyar nyev egységesülése és sztenderdizációja"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/magyar_nyelv_12/lecke_01_007";
                else if (temakor == ("A nyelv és társadalom viszonya"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/magyar_nyelv_12/lecke_02_009";
                else if (temakor == ("A csoportnyelvek"))
                    myProcess.StartInfo.FileName = "https://www.nkp.hu/tankonyv/magyar_nyelv_12/lecke_02_012";

                myProcess.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Hiba a link betöltése közben! Kérem próbálja újra később!");
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

        private void Form4valasz_Load(object sender, EventArgs e)
        {
            Color col = Theme();
            btnIgazhamisvalasz1.BackColor = col;
            btnIgazhamisvalasz2.BackColor = col;
            btnIndit.BackColor = col;
            button1.BackColor = col;
            button2.BackColor = col;
            button3.BackColor = col;
            button4.BackColor = col;
            button5.BackColor = col;
            lblKerdes.BackColor = col;
            lblKerdesszam.BackColor = col;
            lblPontszam.BackColor = col;
            lblTemakor.BackColor = col;
            label1.BackColor = col;
            label2.BackColor = col;
            label3.BackColor = col;
            label4.BackColor = col;
            this.BackColor = col;
        }
    }
}
