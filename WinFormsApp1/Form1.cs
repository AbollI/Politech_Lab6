using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ILogger logg1 = new Logger();
            logg1.LogError("erorrr1");

            ILogger logg2 = new FileLogger(1,"C:\\Documents");
            logg2.LogError("erorrr2");
        }
    }
}
