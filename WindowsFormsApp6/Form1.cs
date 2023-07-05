using Disconnected_Environment1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6;

namespace Disconnected_Environment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponen();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void dataProdiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
            this.Close();
        }

        private void dataMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form3();
            form.ShowDialog();
            this.Close();
        }

        private void dataStatusMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.ShowDialog();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                    
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}