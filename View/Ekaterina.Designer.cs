using System.ComponentModel;

namespace LR3
{
    partial class Ekaterina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.table = new System.Windows.Forms.DataGridView();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.January = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.February = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.March = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.April = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.May = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.June = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.July = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.August = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.September = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.October = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.November = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.December = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.Year, this.January, this.February, this.March, this.April, this.May, this.June, this.July, this.August, this.September, this.October, this.November, this.December });
            this.table.Location = new System.Drawing.Point(11, 13);
            this.table.Name = "table";
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(772, 203);
            this.table.TabIndex = 0;
            // 
            // Year
            // 
            this.Year.HeaderText = "Год";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // January
            // 
            this.January.HeaderText = "Январь";
            this.January.Name = "January";
            this.January.ReadOnly = true;
            // 
            // February
            // 
            this.February.HeaderText = "Февраль";
            this.February.Name = "February";
            this.February.ReadOnly = true;
            // 
            // March
            // 
            this.March.HeaderText = "Март";
            this.March.Name = "March";
            this.March.ReadOnly = true;
            // 
            // April
            // 
            this.April.HeaderText = "Апрель";
            this.April.Name = "April";
            this.April.ReadOnly = true;
            // 
            // May
            // 
            this.May.HeaderText = "Май";
            this.May.Name = "May";
            this.May.ReadOnly = true;
            // 
            // June
            // 
            this.June.HeaderText = "Июнь";
            this.June.Name = "June";
            this.June.ReadOnly = true;
            // 
            // July
            // 
            this.July.HeaderText = "Июль";
            this.July.Name = "July";
            this.July.ReadOnly = true;
            // 
            // August
            // 
            this.August.HeaderText = "Август";
            this.August.Name = "August";
            this.August.ReadOnly = true;
            // 
            // September
            // 
            this.September.HeaderText = "Сентябрь";
            this.September.Name = "September";
            this.September.ReadOnly = true;
            // 
            // October
            // 
            this.October.HeaderText = "Октябрь";
            this.October.Name = "October";
            this.October.ReadOnly = true;
            // 
            // November
            // 
            this.November.HeaderText = "Ноябрь";
            this.November.Name = "November";
            this.November.ReadOnly = true;
            // 
            // December
            // 
            this.December.HeaderText = "Декабрь";
            this.December.Name = "December";
            this.December.ReadOnly = true;
            // 
            // Ekaterina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.table);
            this.Name = "Ekaterina";
            this.Text = "Ekaterina";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn January;
        private System.Windows.Forms.DataGridViewTextBoxColumn February;
        private System.Windows.Forms.DataGridViewTextBoxColumn March;
        private System.Windows.Forms.DataGridViewTextBoxColumn April;
        private System.Windows.Forms.DataGridViewTextBoxColumn May;
        private System.Windows.Forms.DataGridViewTextBoxColumn June;
        private System.Windows.Forms.DataGridViewTextBoxColumn July;
        private System.Windows.Forms.DataGridViewTextBoxColumn August;
        private System.Windows.Forms.DataGridViewTextBoxColumn September;
        private System.Windows.Forms.DataGridViewTextBoxColumn October;
        private System.Windows.Forms.DataGridViewTextBoxColumn November;
        private System.Windows.Forms.DataGridViewTextBoxColumn December;

        private System.Windows.Forms.DataGridView table;

        #endregion
    }
}