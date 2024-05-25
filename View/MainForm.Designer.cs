namespace LR3
{
    partial class MainForm
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
            this.Ekaterina = new System.Windows.Forms.Button();
            this.Daria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ekaterina
            // 
            this.Ekaterina.Location = new System.Drawing.Point(40, 21);
            this.Ekaterina.Name = "Ekaterina";
            this.Ekaterina.Size = new System.Drawing.Size(148, 36);
            this.Ekaterina.TabIndex = 0;
            this.Ekaterina.Text = "Троицкая";
            this.Ekaterina.UseVisualStyleBackColor = true;
            this.Ekaterina.Click += new System.EventHandler(this.Ekaterina_Click);
            // 
            // Daria
            // 
            this.Daria.Location = new System.Drawing.Point(40, 63);
            this.Daria.Name = "Daria";
            this.Daria.Size = new System.Drawing.Size(148, 36);
            this.Daria.TabIndex = 1;
            this.Daria.Text = "Троицкая2";
            this.Daria.UseVisualStyleBackColor = true;
            this.Daria.Click += new System.EventHandler(this.Daria_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 131);
            this.Controls.Add(this.Daria);
            this.Controls.Add(this.Ekaterina);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button Ekaterina;
        private System.Windows.Forms.Button Daria;

        #endregion
    }
}