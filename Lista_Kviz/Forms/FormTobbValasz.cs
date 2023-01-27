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
    public partial class FormTobbValasz : Form
    {
        public FormTobbValasz()
        {
            InitializeComponent();
        }

        int mov, movX, movY;
        private void lbl1_MouseDown(object sender, MouseEventArgs e)
        {
            var senderobject = (Label)sender;
            senderobject.Dock = DockStyle.None;
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void lbl1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void lbl1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
