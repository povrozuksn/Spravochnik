using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spravochnik
{
    public partial class DelCarForm : Form
    {
        public DelCarForm()
        {
            InitializeComponent();

            for(int i=0; i<MainForm.cars.Count; i++)
            {
                comboBox1.Items.Add(MainForm.cars[i].name);
            }
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите удалить " + comboBox1.Text + "?", "Удаление машины", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                File.Delete("cars.txt");
                for (int i = 0; i < MainForm.cars.Count; i++)
                {
                    if (comboBox1.Text == MainForm.cars[i].name)
                    {

                    }
                    else
                    {
                        File.AppendAllText("cars.txt", MainForm.cars[i].name + ", " +
                                                MainForm.cars[i].kuzov + ", " +
                                                MainForm.cars[i].kpp + ", " +
                                                MainForm.cars[i].power + ", " +
                                                MainForm.cars[i].price +
                                                Environment.NewLine);
                    }
                }
                MessageBox.Show("Удаление прошло успешно");
                Close();
            }
        }
    }
}
