using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spravochnik
{
    public partial class CarForm : Form
    {
        public CarForm(string name)
        {
            InitializeComponent();
            Text = name;
            label1.Text = name;
            pictureBox1.Load("../../Pictures/" + name + ".jpg");
        }
    }
}
