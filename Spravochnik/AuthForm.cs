﻿using System;
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
    public partial class AuthForm : Form
    {
        public static string name = "";
        public static string family = "";


        public AuthForm()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            string[] strs = File.ReadAllLines("users.txt");

            foreach (string str in strs)
            {
                string[] parts = str.Split(new string[] { ", " }, StringSplitOptions.None);

                if (LoginTextBox.Text == parts[2] && PasTextBox.Text == parts[3])
                {
                    name = parts[0];
                    family = parts[1];
                    Close();
                    return;
                }
            }
            MessageBox.Show("Введен неверный логин/пароль");            
        }
    }
}
