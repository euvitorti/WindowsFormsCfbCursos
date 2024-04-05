namespace WindowsForms
{
    partial class Form6
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBoxInicialDate = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxFinalDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(41, 18);
            this.monthCalendar1.MaxSelectionCount = 30;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // textBoxInicialDate
            // 
            this.textBoxInicialDate.Location = new System.Drawing.Point(374, 18);
            this.textBoxInicialDate.Name = "textBoxInicialDate";
            this.textBoxInicialDate.Size = new System.Drawing.Size(170, 22);
            this.textBoxInicialDate.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Get Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxFinalDate
            // 
            this.textBoxFinalDate.Location = new System.Drawing.Point(374, 70);
            this.textBoxFinalDate.Name = "textBoxFinalDate";
            this.textBoxFinalDate.Size = new System.Drawing.Size(170, 22);
            this.textBoxFinalDate.TabIndex = 3;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 275);
            this.Controls.Add(this.textBoxFinalDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxInicialDate);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form6";
            this.Text = "Month Calendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox textBoxInicialDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxFinalDate;
    }
}