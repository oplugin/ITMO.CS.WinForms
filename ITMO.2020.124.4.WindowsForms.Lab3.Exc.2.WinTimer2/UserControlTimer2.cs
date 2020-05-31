using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO._2020._124._4.WindowsForms.Lab3.Exc._2.WinTimer2
{
    public partial class UserControlTimer2 : Control
    {
        public UserControlTimer2()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;
            g.FillRectangle(Brushes.Blue, 0, 0, this.Width, this.Height);

            pe.Graphics.DrawString(DateTime.Now.ToLongTimeString(), this.Font, new SolidBrush(this.ForeColor), 0, 0);
        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
