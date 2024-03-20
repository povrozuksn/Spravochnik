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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            if(PasTextBox.Text == RePasTextBox.Text && NameTextBox.Text != "" 
                && FamyliTextBox.Text != "" && LoginTextBox.Text != "")
            {           
                File.AppendAllText("users.txt", Environment.NewLine + NameTextBox.Text + ", " +
                                            FamyliTextBox.Text + ", " +
                                            LoginTextBox.Text + ", " +
                                            PasTextBox.Text + ", " + "0");
                MessageBox.Show("Регистрация прошла успешно");
                Close();
            }
            else
            {
                MessageBox.Show("Введенные пароли не совпадают или не заполнены обязательные поля");
            }
        }
    }
}
