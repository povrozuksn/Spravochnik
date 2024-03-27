﻿using System;
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
            File.AppendAllText("cars.txt",  Environment.NewLine + NameTextBox.Text + ", " +
                                            KuzovComboBox.Text + ", " +
                                            KppComboBox.Text + ", " +
                                            PowerTextBox.Text + ", " +
                                            PriceTextBox.Text);
            MessageBox.Show("Сохранено");
            Close();
        }
    }
}
