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

            try
            {
                pb.Load("../../Pictures/" + name + ".jpg");
            }
            catch (Exception) { }
        }
    }

    public partial class MainForm : Form
    {
        List<Car> cars = new List<Car>();

        public MainForm()
        {
            InitializeComponent();            
            Text = "Справочник по автомобилям";
            HelloLabel.Visible = false;
            AddCarButton.Visible = false;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cars.Clear();
            string[] strs = File.ReadAllLines("cars.txt");
            foreach (string str in strs)
            {
                string[] parts = str.Split(new string[] { ", " }, StringSplitOptions.None);
                Car car = new Car(parts[0], parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToInt32(parts[4]));
                cars.Add(car);
            }

            ViewPanel.Controls.Clear();
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

        private void findBTN_Click(object sender, EventArgs e)
        {
            int x = 30;
            int y = 30;
            for (int i = 0; i < cars.Count; i++)
            {
                cars[i].btn.Visible = true;
                cars[i].pb.Visible = true;

                if(nameTB.Text != "" && !cars[i].name.Contains(nameTB.Text))
                {
                    cars[i].btn.Visible = false;
                    cars[i].pb.Visible = false;
                }

                if(kppCB.Text != "" && kppCB.Text != cars[i].kpp)
                {
                    cars[i].btn.Visible = false;
                    cars[i].pb.Visible = false;
                }

                if (kuzovCLB.CheckedItems.Count > 0 && !kuzovCLB.CheckedItems.Contains(cars[i].kuzov))
                {
                    cars[i].btn.Visible = false;
                    cars[i].pb.Visible = false;
                }

                if (powerTB.Text != "" && Convert.ToInt32(powerTB.Text) > cars[i].power)
                {
                    cars[i].btn.Visible = false;
                    cars[i].pb.Visible = false;
                }

                if (priceTB.Text != "" && Convert.ToInt32(priceTB.Text) > cars[i].price)
                {
                    cars[i].btn.Visible = false;
                    cars[i].pb.Visible = false;
                }

                if (cars[i].pb.Visible)
                {
                    cars[i].btn.Location = new Point(x, y+150);
                    cars[i].pb.Location = new Point(x, y);

                    x += 230;
                    if (x >= ViewPanel.Width - 200)
                    {
                        y += 200;
                        x = 30;
                    }
                } 
            }
        }

        private void nameTB_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                findBTN_Click(null, null);
            }
        }

        private void powerTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                findBTN_Click(null, null);
            }

        }

        private void priceTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                findBTN_Click(null, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(FiltrPanel.Height > button1.Size.Height)
            {
                FiltrPanel.Height = button1.Size.Height;
                button1.Text = "Развернуть";
            }
            else
            {
                FiltrPanel.Height = 145;
                button1.Text = "Свернуть";
            }
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            if (AuthForm.name == "")
            {
                AuthForm authForm = new AuthForm();
                authForm.ShowDialog();
            }
            else
            {
                AuthForm.name = "";
            }

            if (AuthForm.name == "")
            {
                HelloLabel.Visible = false;
                HelloLabel.Text = "";
                AuthForm.name = "";
                AuthButton.Text = "Войти";
                RegButton.Visible = true;
                AuthForm.isAdmin = false;
                AddCarButton.Visible = AuthForm.isAdmin;
            }
            else
            {
                HelloLabel.Visible = true;
                HelloLabel.Text = "Вы авторизовались как " + AuthForm.name + " " + AuthForm.family;
                AuthButton.Text = "Выйти";
                RegButton.Visible = false;
                AddCarButton.Visible = AuthForm.isAdmin;
            }
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            RegForm reg = new RegForm();
            reg.ShowDialog();
        }

        private void AddCarButton_Click(object sender, EventArgs e)
        {
            AddCarForm addCar = new AddCarForm();
            addCar.ShowDialog();
            MainForm_Load(null, null);
        }
    }
}
