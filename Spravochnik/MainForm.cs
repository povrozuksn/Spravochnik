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
    public struct Car
    {
        public string name;
        public string kuzov;
        public int power;
        public int price;
        public Button btn;
        public PictureBox pb;

        public Car(string _name, string _kuzov, int _power, int _price)
        {
            name = _name;
            kuzov = _kuzov;
            power = _power;
            price = _price;

            btn = new Button();
            btn.Text = name;

            pb = new PictureBox();
            pb.Load("../../Pictures/" + name + ".jpg");
        }
    }

    public partial class MainForm : Form
    {
        Car[] cars = new Car[3];
        public MainForm()
        {
            InitializeComponent();            
            Text = "Справочник по автомобилям";
            cars[0] = new Car("Lada Priora", "Седан", 120, 50000);
            cars[1] = new Car("Lada Granta", "Седан", 128, 70000);
            cars[2] = new Car("Lada Vesta", "Хечбэк", 138, 80000);

            int x = 30;
            for(int i=0; i<3; i++)
            {
                cars[i].btn.Location = new Point(x, 180);
                cars[i].btn.Size = new Size(200, 40);
                cars[i].btn.UseVisualStyleBackColor = true;
                cars[i].btn.Click += new EventHandler(CarButton_Click);
                ViewPanel.Controls.Add(cars[i].btn);

                cars[i].pb.Location = new Point(x, 30);
                cars[i].pb.Size = new Size(200, 150);
                cars[i].pb.SizeMode = PictureBoxSizeMode.Zoom;
                ViewPanel.Controls.Add(cars[i].pb);

                x += 230;
            }
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.ShowDialog();
        }

        private void CarButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            CarForm carForm = new CarForm(btn.Text);
            carForm.ShowDialog();
        }
    }
}
