namespace Spravochnik
{
    partial class CompareForm
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
            this.EmaiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmaiButton
            // 
            this.EmaiButton.Location = new System.Drawing.Point(1011, 15);
            this.EmaiButton.Name = "EmaiButton";
            this.EmaiButton.Size = new System.Drawing.Size(202, 40);
            this.EmaiButton.TabIndex = 0;
            this.EmaiButton.Text = "Отправить на Email";
            this.EmaiButton.UseVisualStyleBackColor = true;
            this.EmaiButton.Click += new System.EventHandler(this.EmaiButton_Click);
            // 
            // CompareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1226, 693);
            this.Controls.Add(this.EmaiButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CompareForm";
            this.Text = "CompareForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EmaiButton;
    }
}