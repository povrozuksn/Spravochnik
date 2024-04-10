using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spravochnik
{
    public partial class CarForm : Form
    {
        public CarForm(Car car)
        {
            InitializeComponent();
            Text = car.name;
            label1.Text = car.name;
            try
            {
                pictureBox1.Load("../../Pictures/" + car.name + ".jpg");
            }
            catch (Exception) { }

            kuzovLbl.Text = car.kuzov;
            kppLbl.Text = car.kpp;
            powerLbl.Text = car.power.ToString();
            priceLbl.Text = car.price.ToString();

            try
            {
                descriptionTextBox.Text = File.ReadAllText("../../Pictures/" + car.name + ".txt");
            }
            catch (Exception) { }
        }
    }
}
