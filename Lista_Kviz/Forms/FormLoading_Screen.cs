using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_Kviz
{
    public partial class FormLoading_Screen : Form
    {
        public FormLoading_Screen()
        {
            InitializeComponent();
        }
        int kezdopont;
        private void timer1_Tick(object sender, EventArgs e)
        {
            kezdopont += 4;
            if (kezdopont == 100)
            {
                kezdopont = 0;
                timer1.Stop();
                if (Properties.UserSettings.Default.jelfelhasz == "Vendég")
                {
                    Temavalaszto TV = new Temavalaszto();
                    this.Hide();
                    TV.Show();
                }
                else
                {
                    if (Properties.UserSettings.Default.nezet == "Vendég")
                    {
                        Temavalaszto log = new Temavalaszto();
                        this.Hide();
                        log.Show();
                    }
                    else
                    {
                        Kerdesszerkeszto log2 = new Kerdesszerkeszto();
                        this.Hide();
                        log2.Show();
                    }
                }
            }
        }
        private void FormLoading_Screen_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }
    }
}
