using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nk_electricals
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

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bottom_line_Paint(object sender, PaintEventArgs e)
        {
           ControlPaint.DrawBorder(e.Graphics, bottom_line.ClientRectangle,
           Color.White, 0, ButtonBorderStyle.Solid, // left
           Color.DimGray, 0, ButtonBorderStyle.Solid, // top
           Color.DimGray, 0, ButtonBorderStyle.Solid, // right
           Color.DimGray, 1, ButtonBorderStyle.Solid);// bottom
        }
    }
}
