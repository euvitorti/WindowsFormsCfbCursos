namespace WindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonGetDate = new System.Windows.Forms.Button();
            this.textBoxFullDate = new System.Windows.Forms.TextBox();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.buttonSetDate = new System.Windows.Forms.Button();
            this.buttonOpenNewForm = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu3ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(297, 22);
            this.dateTimePicker.TabIndex = 0;
            // 
            // buttonGetDate
            // 
            this.buttonGetDate.Location = new System.Drawing.Point(218, 51);
            this.buttonGetDate.Name = "buttonGetDate";
            this.buttonGetDate.Size = new System.Drawing.Size(91, 45);
            this.buttonGetDate.TabIndex = 1;
            this.buttonGetDate.Text = "Get";
            this.buttonGetDate.UseVisualStyleBackColor = true;
            this.buttonGetDate.Click += new System.EventHandler(this.buttonGetDate_Click);
            // 
            // textBoxFullDate
            // 
            this.textBoxFullDate.Location = new System.Drawing.Point(12, 51);
            this.textBoxFullDate.Name = "textBoxFullDate";
            this.textBoxFullDate.Size = new System.Drawing.Size(200, 22);
            this.textBoxFullDate.TabIndex = 2;
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.Location = new System.Drawing.Point(12, 142);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(200, 22);
            this.textBoxMonth.TabIndex = 3;
            // 
            // textBoxDay
            // 
            this.textBoxDay.Location = new System.Drawing.Point(12, 94);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.Size = new System.Drawing.Size(200, 22);
            this.textBoxDay.TabIndex = 4;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(12, 188);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(200, 22);
            this.textBoxYear.TabIndex = 5;
            // 
            // buttonSetDate
            // 
            this.buttonSetDate.Location = new System.Drawing.Point(218, 165);
            this.buttonSetDate.Name = "buttonSetDate";
            this.buttonSetDate.Size = new System.Drawing.Size(91, 45);
            this.buttonSetDate.TabIndex = 6;
            this.buttonSetDate.Text = "Set";
            this.buttonSetDate.UseVisualStyleBackColor = true;
            this.buttonSetDate.Click += new System.EventHandler(this.buttonSetDate_Click);
            // 
            // buttonOpenNewForm
            // 
            this.buttonOpenNewForm.Location = new System.Drawing.Point(315, 51);
            this.buttonOpenNewForm.Name = "buttonOpenNewForm";
            this.buttonOpenNewForm.Size = new System.Drawing.Size(91, 45);
            this.buttonOpenNewForm.TabIndex = 7;
            this.buttonOpenNewForm.Text = "New Form";
            this.buttonOpenNewForm.UseVisualStyleBackColor = true;
            this.buttonOpenNewForm.Click += new System.EventHandler(this.buttonOpenNewForm_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(218, 108);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(273, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu3ToolStripMenuItem
            // 
            this.menu3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lToolStripMenuItem,
            this.menu3ToolStripMenuItem1,
            this.menu4ToolStripMenuItem,
            this.menu6ToolStripMenuItem});
            this.menu3ToolStripMenuItem.Name = "menu3ToolStripMenuItem";
            this.menu3ToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.menu3ToolStripMenuItem.Text = "Componentes";
            // 
            // lToolStripMenuItem
            // 
            this.lToolStripMenuItem.Name = "lToolStripMenuItem";
            this.lToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lToolStripMenuItem.Text = "ListView";
            this.lToolStripMenuItem.Click += new System.EventHandler(this.lToolStripMenuItem_Click);
            // 
            // menu3ToolStripMenuItem1
            // 
            this.menu3ToolStripMenuItem1.Name = "menu3ToolStripMenuItem1";
            this.menu3ToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.menu3ToolStripMenuItem1.Text = "Menu3";
            this.menu3ToolStripMenuItem1.Click += new System.EventHandler(this.menu3ToolStripMenuItem1_Click);
            // 
            // menu4ToolStripMenuItem
            // 
            this.menu4ToolStripMenuItem.Name = "menu4ToolStripMenuItem";
            this.menu4ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.menu4ToolStripMenuItem.Text = "Menu 5";
            this.menu4ToolStripMenuItem.Click += new System.EventHandler(this.menu4ToolStripMenuItem_Click);
            // 
            // menu6ToolStripMenuItem
            // 
            this.menu6ToolStripMenuItem.Name = "menu6ToolStripMenuItem";
            this.menu6ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.menu6ToolStripMenuItem.Text = "Menu 6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 228);
            this.Controls.Add(this.buttonOpenNewForm);
            this.Controls.Add(this.buttonSetDate);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxDay);
            this.Controls.Add(this.textBoxMonth);
            this.Controls.Add(this.textBoxFullDate);
            this.Controls.Add(this.buttonGetDate);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttonGetDate;
        private System.Windows.Forms.TextBox textBoxFullDate;
        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.TextBox textBoxDay;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Button buttonSetDate;
        private System.Windows.Forms.Button buttonOpenNewForm;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu3ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menu4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu6ToolStripMenuItem;
    }
}

