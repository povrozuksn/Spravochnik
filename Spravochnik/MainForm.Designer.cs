namespace Spravochnik
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.HelpButton = new System.Windows.Forms.Button();
            this.AuthPanel = new System.Windows.Forms.Panel();
            this.DelCarButton = new System.Windows.Forms.Button();
            this.AddCarButton = new System.Windows.Forms.Button();
            this.RegButton = new System.Windows.Forms.Button();
            this.HelloLabel = new System.Windows.Forms.Label();
            this.AuthButton = new System.Windows.Forms.Button();
            this.FiltrPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.findBTN = new System.Windows.Forms.Button();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.powerTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kuzovCLB = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kppCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.CompareButton = new System.Windows.Forms.Button();
            this.AuthPanel.SuspendLayout();
            this.FiltrPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HelpButton
            // 
            this.HelpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HelpButton.Location = new System.Drawing.Point(1140, 14);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(30, 30);
            this.HelpButton.TabIndex = 3;
            this.HelpButton.Text = "?";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // AuthPanel
            // 
            this.AuthPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AuthPanel.Controls.Add(this.CompareButton);
            this.AuthPanel.Controls.Add(this.DelCarButton);
            this.AuthPanel.Controls.Add(this.AddCarButton);
            this.AuthPanel.Controls.Add(this.RegButton);
            this.AuthPanel.Controls.Add(this.HelloLabel);
            this.AuthPanel.Controls.Add(this.AuthButton);
            this.AuthPanel.Controls.Add(this.HelpButton);
            this.AuthPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AuthPanel.Location = new System.Drawing.Point(0, 0);
            this.AuthPanel.Name = "AuthPanel";
            this.AuthPanel.Size = new System.Drawing.Size(1182, 56);
            this.AuthPanel.TabIndex = 4;
            // 
            // DelCarButton
            // 
            this.DelCarButton.Location = new System.Drawing.Point(734, 10);
            this.DelCarButton.Name = "DelCarButton";
            this.DelCarButton.Size = new System.Drawing.Size(195, 38);
            this.DelCarButton.TabIndex = 8;
            this.DelCarButton.Text = "Удалить машину";
            this.DelCarButton.UseVisualStyleBackColor = true;
            this.DelCarButton.Click += new System.EventHandler(this.DelCarButton_Click);
            // 
            // AddCarButton
            // 
            this.AddCarButton.Location = new System.Drawing.Point(533, 10);
            this.AddCarButton.Name = "AddCarButton";
            this.AddCarButton.Size = new System.Drawing.Size(195, 38);
            this.AddCarButton.TabIndex = 7;
            this.AddCarButton.Text = "Добавить машину";
            this.AddCarButton.UseVisualStyleBackColor = true;
            this.AddCarButton.Click += new System.EventHandler(this.AddCarButton_Click);
            // 
            // RegButton
            // 
            this.RegButton.Location = new System.Drawing.Point(980, 12);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(154, 34);
            this.RegButton.TabIndex = 6;
            this.RegButton.Text = "Регистрация";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Location = new System.Drawing.Point(145, 17);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(64, 25);
            this.HelloLabel.TabIndex = 5;
            this.HelloLabel.Text = "label6";
            // 
            // AuthButton
            // 
            this.AuthButton.Location = new System.Drawing.Point(12, 12);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(127, 35);
            this.AuthButton.TabIndex = 4;
            this.AuthButton.Text = "Войти";
            this.AuthButton.UseVisualStyleBackColor = true;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // FiltrPanel
            // 
            this.FiltrPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FiltrPanel.Controls.Add(this.button1);
            this.FiltrPanel.Controls.Add(this.findBTN);
            this.FiltrPanel.Controls.Add(this.priceTB);
            this.FiltrPanel.Controls.Add(this.label5);
            this.FiltrPanel.Controls.Add(this.powerTB);
            this.FiltrPanel.Controls.Add(this.label4);
            this.FiltrPanel.Controls.Add(this.kuzovCLB);
            this.FiltrPanel.Controls.Add(this.label3);
            this.FiltrPanel.Controls.Add(this.kppCB);
            this.FiltrPanel.Controls.Add(this.label2);
            this.FiltrPanel.Controls.Add(this.nameTB);
            this.FiltrPanel.Controls.Add(this.label1);
            this.FiltrPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FiltrPanel.Location = new System.Drawing.Point(0, 56);
            this.FiltrPanel.Name = "FiltrPanel";
            this.FiltrPanel.Size = new System.Drawing.Size(1182, 144);
            this.FiltrPanel.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Свернуть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // findBTN
            // 
            this.findBTN.Location = new System.Drawing.Point(1069, 47);
            this.findBTN.Name = "findBTN";
            this.findBTN.Size = new System.Drawing.Size(97, 64);
            this.findBTN.TabIndex = 10;
            this.findBTN.Text = "Найти";
            this.findBTN.UseVisualStyleBackColor = true;
            this.findBTN.Click += new System.EventHandler(this.findBTN_Click);
            // 
            // priceTB
            // 
            this.priceTB.Location = new System.Drawing.Point(775, 83);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(188, 30);
            this.priceTB.TabIndex = 9;
            this.priceTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.priceTB_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(571, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Стоимость, руб., от";
            // 
            // powerTB
            // 
            this.powerTB.Location = new System.Drawing.Point(851, 44);
            this.powerTB.Name = "powerTB";
            this.powerTB.Size = new System.Drawing.Size(188, 30);
            this.powerTB.TabIndex = 7;
            this.powerTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.powerTB_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(571, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Мощность двигателя, л.с., от";
            // 
            // kuzovCLB
            // 
            this.kuzovCLB.FormattingEnabled = true;
            this.kuzovCLB.Items.AddRange(new object[] {
            "Седан",
            "Хечбэк",
            "Универсал",
            "Фургон"});
            this.kuzovCLB.Location = new System.Drawing.Point(423, 34);
            this.kuzovCLB.Name = "kuzovCLB";
            this.kuzovCLB.Size = new System.Drawing.Size(142, 104);
            this.kuzovCLB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тип кузова";
            // 
            // kppCB
            // 
            this.kppCB.FormattingEnabled = true;
            this.kppCB.Items.AddRange(new object[] {
            "",
            "МКПП",
            "АКПП"});
            this.kppCB.Location = new System.Drawing.Point(186, 86);
            this.kppCB.Name = "kppCB";
            this.kppCB.Size = new System.Drawing.Size(177, 33);
            this.kppCB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тип трансмиссии";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(110, 45);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(188, 30);
            this.nameTB.TabIndex = 1;
            this.nameTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameTB_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // ViewPanel
            // 
            this.ViewPanel.AutoScroll = true;
            this.ViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewPanel.Location = new System.Drawing.Point(0, 200);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(1182, 374);
            this.ViewPanel.TabIndex = 6;
            this.ViewPanel.Resize += new System.EventHandler(this.ViewPanel_Resize);
            // 
            // CompareButton
            // 
            this.CompareButton.Location = new System.Drawing.Point(800, 12);
            this.CompareButton.Name = "CompareButton";
            this.CompareButton.Size = new System.Drawing.Size(174, 34);
            this.CompareButton.TabIndex = 9;
            this.CompareButton.Text = "К сравнению";
            this.CompareButton.UseVisualStyleBackColor = true;
            this.CompareButton.Click += new System.EventHandler(this.CompareButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1182, 574);
            this.Controls.Add(this.ViewPanel);
            this.Controls.Add(this.FiltrPanel);
            this.Controls.Add(this.AuthPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.AuthPanel.ResumeLayout(false);
            this.AuthPanel.PerformLayout();
            this.FiltrPanel.ResumeLayout(false);
            this.FiltrPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Panel AuthPanel;
        private System.Windows.Forms.Panel FiltrPanel;
        private System.Windows.Forms.Panel ViewPanel;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox kppCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox kuzovCLB;
        private System.Windows.Forms.Button findBTN;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox powerTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AuthButton;
        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.Button AddCarButton;
        private System.Windows.Forms.Button DelCarButton;
        private System.Windows.Forms.Button CompareButton;
    }
}

