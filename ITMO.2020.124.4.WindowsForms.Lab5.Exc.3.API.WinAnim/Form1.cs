using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using AnimatedWindow;

namespace ITMO._2020._124._4.WindowsForms.Lab5.Exc._3.API.WinAnim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAW_BLEND_Click(object sender, EventArgs e)
        {
            this.Hide();

            WinAPIClass.AnimatedWindow(this, 3000,
                                        WinAPIClass.AnimatedWindowFlags.AW_ACTIVATE
                                      | WinAPIClass.AnimatedWindowFlags.AW_BLEND);

            this.btnAW_BLEND.Invalidate();
            this.btnHOR_AW_SLIDE.Invalidate();
            this.btnCender_AW_SLIDE.Invalidate();
        }

        private void btnHOR_AW_SLIDE_Click(object sender, EventArgs e)
        {
            this.Hide();

            WinAPIClass.AnimatedWindow(this, 3000,
                                        WinAPIClass.AnimatedWindowFlags.AW_HOR_POSITIVE
                                      | WinAPIClass.AnimatedWindowFlags.AW_SLIDE);

            this.btnAW_BLEND.Invalidate();
            this.btnHOR_AW_SLIDE.Invalidate();
            this.btnCender_AW_SLIDE.Invalidate();
        }

        private void btnCender_AW_SLIDE_Click(object sender, EventArgs e)
        {
            this.Hide();

            WinAPIClass.AnimatedWindow(this, 3000,
                                        WinAPIClass.AnimatedWindowFlags.AW_CENTR
                                      | WinAPIClass.AnimatedWindowFlags.AW_SLIDE);

            this.btnAW_BLEND.Invalidate();
            this.btnHOR_AW_SLIDE.Invalidate();
            this.btnCender_AW_SLIDE.Invalidate();
        }
    }
    
}