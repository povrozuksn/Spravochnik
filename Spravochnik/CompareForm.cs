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
    public partial class CompareForm : Form
    {
        public static Dictionary<Car, int> myCars_list = new Dictionary<Car, int>();

        public CompareForm()
        {
            InitializeComponent();
            ReDraw();
        }

        void ReDraw()
        {
            Controls.Clear();

            int x = 30;
            int y = 30;
            foreach (KeyValuePair<Car, int> my_car in myCars_list)
            {
                Car car = my_car.Key;

                #region Столбец 1
                Label lb_name = new Label();
                lb_name.Location = new Point(x, y);
                lb_name.Size = new Size(200, 20);
                lb_name.Text = car.name;
                Controls.Add(lb_name);

                PictureBox pb = new PictureBox();
                pb.Image = car.pb.Image;
                pb.Location = new Point(x, y + 30);
                pb.Size = new Size(200, 150);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                Controls.Add(pb);
                #endregion

                #region Столбец 2
                Label lb_kuzov = new Label();
                lb_kuzov.Location = new Point(x + 220, y + 30);
                lb_kuzov.Size = new Size(300, 20);
                lb_kuzov.Text = "Тип кузова: " + car.kuzov;
                Controls.Add(lb_kuzov);

                Label lb_kpp = new Label();
                lb_kpp.Location = new Point(x + 220, y + 60);
                lb_kpp.Size = new Size(300, 20);
                lb_kpp.Text = "Тип КПП: " + car.kpp;
                Controls.Add(lb_kpp);

                Label lb_power = new Label();
                lb_power.Location = new Point(x + 220, y + 90);
                lb_power.Size = new Size(300, 20);
                lb_power.Text = "Мощность двигателя: " + car.power + " л.с.";
                Controls.Add(lb_power);
                #endregion

                #region Столбец 3
                Label lb_price = new Label();
                lb_price.Location = new Point(x + 540, y + 30);
                lb_price.Size = new Size(150, 20);
                lb_price.Text = "Цена: " + car.price + " руб.";
                Controls.Add(lb_price);

                Label lb_count = new Label();
                lb_count.Location = new Point(x + 540, y + 60);
                lb_count.Size = new Size(70, 20);
                lb_count.Text = "Кол-во: ";
                Controls.Add(lb_count);

                NumericUpDown num_count = new NumericUpDown();
                num_count.Location = new Point(x + 620, y + 60);
                num_count.Size = new Size(50, 10);
                num_count.Value = my_car.Value;
                Controls.Add(num_count);

                #endregion

                #region Столбец 4
                Button btn_delete = new Button();
                btn_delete.Location = new Point(x + 740, y + 30);
                btn_delete.Size = new Size(100, 30);
                btn_delete.Text = "Удалить";
                btn_delete.Click += new EventHandler(CarDelete);
                Controls.Add(btn_delete);
                #endregion

                y += 200;
            }

        }

        void CarDelete(object sender, EventArgs e)
        {
            int i = 0;
            Button btn = (Button)sender;
            Dictionary<Car, int> myCars_list1 = new Dictionary<Car, int>();
            foreach (KeyValuePair<Car, int> my_car in myCars_list)
            {
                Car car = my_car.Key;
                if(btn.Location == new Point(770, 60+200*i))
                {

                }
                else
                {
                    myCars_list1[my_car.Key] = my_car.Value;
                }
                i++;
            }
            myCars_list = myCars_list1;
            ReDraw();
        }
    }
}
