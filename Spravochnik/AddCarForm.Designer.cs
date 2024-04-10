namespace Spravochnik
{
    partial class AddCarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.KuzovComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.KppComboBox = new System.Windows.Forms.ComboBox();
            this.PowerTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SearchPictureButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.descriptionsTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Модель";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(38, 76);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(283, 30);
            this.NameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Добавление объекта в справочник";
            // 
            // KuzovComboBox
            // 
            this.KuzovComboBox.FormattingEnabled = true;
            this.KuzovComboBox.Items.AddRange(new object[] {
            "Седан",
            "Хэтчбек",
            "Универсал",
            "Лифтбэк",
            "Купе",
            "Кабриолет",
            "Родстер",
            "Стретч",
            "Тарга",
            "Внедорожник",
            "Кроссовер",
            "Пикап",
            "Фургон",
            "Минивэн"});
            this.KuzovComboBox.Location = new System.Drawing.Point(38, 152);
            this.KuzovComboBox.Name = "KuzovComboBox";
            this.KuzovComboBox.Size = new System.Drawing.Size(279, 33);
            this.KuzovComboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тип кузова";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Тип трансмиссии";
            // 
            // KppComboBox
            // 
            this.KppComboBox.FormattingEnabled = true;
            this.KppComboBox.Items.AddRange(new object[] {
            "АКПП",
            "МКПП"});
            this.KppComboBox.Location = new System.Drawing.Point(38, 237);
            this.KppComboBox.Name = "KppComboBox";
            this.KppComboBox.Size = new System.Drawing.Size(279, 33);
            this.KppComboBox.TabIndex = 5;
            // 
            // PowerTextBox
            // 
            this.PowerTextBox.Location = new System.Drawing.Point(38, 318);
            this.PowerTextBox.Name = "PowerTextBox";
            this.PowerTextBox.Size = new System.Drawing.Size(283, 30);
            this.PowerTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Мощность двигателя, л.с.";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(38, 397);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(283, 30);
            this.PriceTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Цена, руб.";
            // 
            // SaveButton
            // 
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaveButton.Location = new System.Drawing.Point(0, 495);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(1036, 41);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(358, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // SearchPictureButton
            // 
            this.SearchPictureButton.Location = new System.Drawing.Point(358, 318);
            this.SearchPictureButton.Name = "SearchPictureButton";
            this.SearchPictureButton.Size = new System.Drawing.Size(291, 41);
            this.SearchPictureButton.TabIndex = 13;
            this.SearchPictureButton.Text = "Выберите картинку";
            this.SearchPictureButton.UseVisualStyleBackColor = true;
            this.SearchPictureButton.Click += new System.EventHandler(this.SearchPictureButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // descriptionsTextBox
            // 
            this.descriptionsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionsTextBox.Location = new System.Drawing.Point(677, 76);
            this.descriptionsTextBox.Multiline = true;
            this.descriptionsTextBox.Name = "descriptionsTextBox";
            this.descriptionsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionsTextBox.Size = new System.Drawing.Size(339, 351);
            this.descriptionsTextBox.TabIndex = 14;
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 536);
            this.Controls.Add(this.descriptionsTextBox);
            this.Controls.Add(this.SearchPictureButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PowerTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.KppComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.KuzovComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddCarForm";
            this.Text = "AddCarForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox KuzovComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox KppComboBox;
        private System.Windows.Forms.TextBox PowerTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SearchPictureButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox descriptionsTextBox;
    }
}