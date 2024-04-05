namespace WindowsForms
{
    partial class Form5
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
            this.maskedTextBoxPassWord = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxCep = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.checkBoxOnlyText = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // maskedTextBoxPassWord
            // 
            this.maskedTextBoxPassWord.Location = new System.Drawing.Point(24, 87);
            this.maskedTextBoxPassWord.Name = "maskedTextBoxPassWord";
            this.maskedTextBoxPassWord.PasswordChar = '*';
            this.maskedTextBoxPassWord.Size = new System.Drawing.Size(110, 22);
            this.maskedTextBoxPassWord.TabIndex = 1;
            this.maskedTextBoxPassWord.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(77, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            // 
            // maskedTextBoxCep
            // 
            this.maskedTextBoxCep.Location = new System.Drawing.Point(24, 129);
            this.maskedTextBoxCep.Mask = "00.000-999";
            this.maskedTextBoxCep.Name = "maskedTextBoxCep";
            this.maskedTextBoxCep.Size = new System.Drawing.Size(110, 22);
            this.maskedTextBoxCep.TabIndex = 3;
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(24, 169);
            this.maskedTextBoxCpf.Mask = "000.000.000-00";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(110, 22);
            this.maskedTextBoxCpf.TabIndex = 4;
            this.maskedTextBoxCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(24, 221);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(110, 23);
            this.buttonShow.TabIndex = 5;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // checkBoxOnlyText
            // 
            this.checkBoxOnlyText.AutoSize = true;
            this.checkBoxOnlyText.Location = new System.Drawing.Point(160, 223);
            this.checkBoxOnlyText.Name = "checkBoxOnlyText";
            this.checkBoxOnlyText.Size = new System.Drawing.Size(85, 20);
            this.checkBoxOnlyText.TabIndex = 6;
            this.checkBoxOnlyText.Text = "Only Text";
            this.checkBoxOnlyText.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.checkBoxOnlyText);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.maskedTextBoxCpf);
            this.Controls.Add(this.maskedTextBoxCep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBoxPassWord);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPassWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCep;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCpf;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.CheckBox checkBoxOnlyText;
    }
}