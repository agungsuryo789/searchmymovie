using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Formloading : Form
    {
        Timer tmr;
        public Formloading()
        {
            InitializeComponent();
        }

        private void Formloading_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();
            
            tmr.Interval = 4700;
            
            tmr.Start();
            tmr.Tick += tmr_Tick;

        }
        
        void tmr_Tick(object sender, EventArgs e)
        {
            
            tmr.Stop();
           
            Form1 mf = new Form1();
            mf.Show();
            
            this.Hide();
        }
    }
}
