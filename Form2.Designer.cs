namespace WindowsForms
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.linkLabelDiversos = new System.Windows.Forms.LinkLabel();
            this.linkLabelCalculadora = new System.Windows.Forms.LinkLabel();
            this.linkLabelCanal = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o seu nome";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // linkLabelDiversos
            // 
            this.linkLabelDiversos.AutoSize = true;
            this.linkLabelDiversos.Location = new System.Drawing.Point(13, 106);
            this.linkLabelDiversos.Name = "linkLabelDiversos";
            this.linkLabelDiversos.Size = new System.Drawing.Size(181, 16);
            this.linkLabelDiversos.TabIndex = 2;
            this.linkLabelDiversos.TabStop = true;
            this.linkLabelDiversos.Text = "GOOGLE-CANAL-YOUTUBE";
            this.linkLabelDiversos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDiversos_LinkClicked);
            // 
            // linkLabelCalculadora
            // 
            this.linkLabelCalculadora.AutoSize = true;
            this.linkLabelCalculadora.Location = new System.Drawing.Point(13, 155);
            this.linkLabelCalculadora.Name = "linkLabelCalculadora";
            this.linkLabelCalculadora.Size = new System.Drawing.Size(80, 16);
            this.linkLabelCalculadora.TabIndex = 3;
            this.linkLabelCalculadora.TabStop = true;
            this.linkLabelCalculadora.Text = "Calculadora";
            this.linkLabelCalculadora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCalculadora_LinkClicked);
            // 
            // linkLabelCanal
            // 
            this.linkLabelCanal.AutoSize = true;
            this.linkLabelCanal.Location = new System.Drawing.Point(12, 207);
            this.linkLabelCanal.Name = "linkLabelCanal";
            this.linkLabelCanal.Size = new System.Drawing.Size(42, 16);
            this.linkLabelCanal.TabIndex = 4;
            this.linkLabelCanal.TabStop = true;
            this.linkLabelCanal.Text = "Canal";
            this.linkLabelCanal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCanal_LinkClicked);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 333);
            this.Controls.Add(this.linkLabelCanal);
            this.Controls.Add(this.linkLabelCalculadora);
            this.Controls.Add(this.linkLabelDiversos);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel linkLabelDiversos;
        private System.Windows.Forms.LinkLabel linkLabelCalculadora;
        private System.Windows.Forms.LinkLabel linkLabelCanal;
    }
}