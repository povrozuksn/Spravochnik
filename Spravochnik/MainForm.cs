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
        static int array_Count = 7;
        Car[] cars = new Car[array_Count];
        public MainForm()
        {
            InitializeComponent();            
            Text = "Справочник по автомобилям";
            cars[0] = new Car("Lada Priora", "Седан", "МКПП", 120, 50000);
            cars[1] = new Car("Lada Granta", "Седан", "МКПП", 128, 70000);
            cars[2] = new Car("Lada Vesta", "Хечбэк", "МКПП", 138, 80000);
            cars[3] = new Car("Lada Xray", "Универсал", "АКПП", 158, 100000);
            cars[4] = new Car("UAZ Hunter", "Универсал", "МКПП", 168, 120000);
            cars[5] = new Car("UAZ 3909", "Вагонного типа", "МКПП", 168, 120000);
            cars[6] = new Car("UAZ Patriot", "Универсал", "АКПП", 168, 120000);



            int x = 30;
            int y = 30;
            for (int i=0; i< array_Count; i++)
            {
                cars[i].btn.Location = new Point(x, y+150);
                cars[i].btn.Size = new Size(200, 40);
                cars[i].btn.UseVisualStyleBackColor = true;
                cars[i].btn.Click += new EventHandler(CarButton_Click);
                ViewPanel.Controls.Add(cars[i].btn);

                cars[i].pb.Location = new Point(x, y);
                cars[i].pb.Size = new Size(200, 150);
                cars[i].pb.SizeMode = PictureBoxSizeMode.Zoom;
                ViewPanel.Controls.Add(cars[i].pb);

                x += 230;
                if(x>=ViewPanel.Width-200)
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
            for (int i = 0; i < array_Count; i++)
            {
                if(((Button)sender).Text == cars[i].name)
                {
                    CarForm carForm = new CarForm(cars[i]);
                    carForm.ShowDialog();
                }
            }
        }
    }
}
