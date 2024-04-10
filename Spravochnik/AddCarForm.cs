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
    public partial class AddCarForm : Form
    {
        public AddCarForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int a;
            if(!Int32.TryParse(PowerTextBox.Text, out a))
            {
                MessageBox.Show("Значение поля 'Мощность двигателя' должно быть числом");
                return;
            }

            if (!Int32.TryParse(PriceTextBox.Text, out a))
            {
                MessageBox.Show("Значение поля 'Цена' должно быть числом");
                return;
            }

            if(NameTextBox.Text == "" || KuzovComboBox.Text == "" || KppComboBox.Text == "" ||
                PowerTextBox.Text == "" || PriceTextBox.Text == "")
            {
                MessageBox.Show("Все поля обязательны к заполнению");
                return;
            }

            File.AppendAllText("cars.txt",  Environment.NewLine + NameTextBox.Text + ", " +
                                            KuzovComboBox.Text + ", " +
                                            KppComboBox.Text + ", " +
                                            PowerTextBox.Text + ", " +
                                            PriceTextBox.Text);
            
            if(FileName != "")
            {
                File.Copy(FileName, "../../Pictures/" + NameTextBox.Text + ".jpg");
            }

            File.AppendAllText("../../Pictures/" + NameTextBox.Text + ".txt", descriptionsTextBox.Text);

            MessageBox.Show("Сохранено");
            Close();
        }

        string FileName = "";

        private void SearchPictureButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog1.FileName;
                pictureBox1.Load(FileName);
            }
        }
    }
}
