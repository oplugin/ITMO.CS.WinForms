using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO._2020._124._4.WindowsForms.Lab5.Exc._2.PDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Файлы pdf |*.pdf";
            openFileDialog1.ShowDialog();
            axAcroPDF1.LoadFile(openFileDialog1.FileName);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
