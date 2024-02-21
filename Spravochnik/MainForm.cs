using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spravochnik
{
    public struct Car
    {
        public string name;
        public string kuzov;
        public string kpp;
        public int power;
        public int price;
        public Button btn;
        public PictureBox pb;

        public Car(string _name, string _kuzov, string _kpp, int _power, int _price)
        {
            name = _name;
            kuzov = _kuzov;
            kpp = _kpp;
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
        List<Car> cars = new List<Car>();

        public MainForm()
        {
            InitializeComponent();            
            Text = "Справочник по автомобилям";

            string[] strs = File.ReadAllLines("cars.txt");

            foreach (string str in strs)
            {
                string[] parts = str.Split(new string[] {", "}, StringSplitOptions.None);
                Car car = new Car(parts[0], parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToInt32(parts[4]));
                cars.Add(car);
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            int x = 30;
            int y = 30;
            for (int i = 0; i < cars.Count; i++)
            {
                cars[i].btn.Location = new Point(x, y + 150);
                cars[i].btn.Size = new Size(200, 40);
                cars[i].btn.UseVisualStyleBackColor = true;
                cars[i].btn.Click += new EventHandler(CarButton_Click);
                ViewPanel.Controls.Add(cars[i].btn);

                cars[i].pb.Location = new Point(x, y);
                cars[i].pb.Size = new Size(200, 150);
                cars[i].pb.SizeMode = PictureBoxSizeMode.Zoom;
                ViewPanel.Controls.Add(cars[i].pb);

                x += 230;
                if (x >= ViewPanel.Width - 200)
                {
                    y += 200;
                    x = 30;
                }
            }
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.ShowDialog();
        }

        private void CarButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                if(((Button)sender).Text == cars[i].name)
                {
                    CarForm carForm = new CarForm(cars[i]);
                    carForm.ShowDialog();
                }
            }
        }

        private void ViewPanel_Resize(object sender, EventArgs e)
        {
            MainForm_Load(null, null);
        }

    }
}
